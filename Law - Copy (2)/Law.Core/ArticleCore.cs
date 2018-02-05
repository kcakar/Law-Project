using Law.Models;
using Law.Test;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Law.Core
{
    public static class ArticleCore
    {
        public static List<Article> GetMostRecentArticles(int amount)
        {
            return Tester.TestArticles.OrderByDescending(x => x.CreationDate).Take(amount).ToList();
        }

        public static List<Article> GetMostPopularArticles(int amount)
        {
            return Tester.TestArticles.OrderByDescending(x => x.ViewCount).Take(amount).ToList();
        }

        public static Article GetArticleByArticleId(string id)
        {
            return Tester.TestArticles.FirstOrDefault(x => x.ID == id);
        }

        public static List<Article> GetArticleByContributorId(string id, int amount, int skip)
        {
            return Tester.TestArticles.Where(x => x.ContributorID == id).Skip(skip).Take(amount).ToList();
        }

        public static PaginatedList<Article> GetFilteredArticles(string keyword, string practice, string contributor, string country, string city, string page = "1")
        {
            var qry = Tester.TestArticles.OrderByDescending(x=>x.CreationDate).AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                qry = qry.Where(x => x.Title.ToLower().Contains(keyword.ToLower()) || x.Tags.ToLower().Contains(keyword.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(contributor))
            {
                qry = qry.Where(x => x.ContributorID == contributor);
            }

            if (!string.IsNullOrWhiteSpace(country))
            {
                qry = qry.Where(x => x.CountryID == country);
            }

            if (!string.IsNullOrWhiteSpace(city))
            {
                qry = qry.Where(x => x.CityID == city);
            }

            if (!string.IsNullOrWhiteSpace(practice))
            {
                qry = qry.Where(x => x.PracticeAreaID == practice);
            }

            if (!int.TryParse(page, out int pageNumber))
            {
                pageNumber = 1;
            }

            return PaginatedList<Article>.Create(qry, pageNumber, Common.PageSize);
        }

        public static void AddEditArticle(ArticleAddEditModel model)
        {
            Contributor contributor = ContributorCore.GetContributorsById(model.contributorID);

            Article article = new Article
            {
                Title = model.title,
                ContributorID = model.contributorID,
                AffiliateID = contributor.AffiliateID,
                CityID = contributor.CityID,
                CountryID = contributor.CountryID,
                CreationDate = DateTime.Now,
                ID = model.ID
            };

            if (model.paragraphs.Count > 0)
            {
                string content = model.paragraphs.First().content;
                if (content == null)
                {
                    content = "";
                }
                if (content.Length > 100)
                {
                    article.BodyPreview = content.Substring(0, 100);
                }
                else
                {
                    article.BodyPreview = content;
                }
            }
            else
            {
                article.BodyPreview = "";
            }
            article.LanguageID = "Turkish";
            article.PracticeAreaID = model.practiceAreaID;
            article.Tags = model.tags;

            foreach (ArticleParagraphRow row in model.paragraphs)
            {
                if(string.IsNullOrEmpty(row.ID))
                {
                    row.ID = Guid.NewGuid().ToString();
                }
                ArticlePiece piece = new ArticlePiece
                {
                    ArticleId = article.ID,
                    ID = row.ID
                };
                piece.ImagePosition = piece.SetImagePosition(row.imagePosition);
                if (row.imageURL == null)
                {
                    row.imageURL = "";
                }
                piece.ImageUrl = row.imageURL.Replace("~", "");
                piece.Paragraph = row.content;
                piece.Title = row.title;

                if (!Tester.TestArticlePieces.Exists(x => x.ID == piece.ID))
                {
                    Tester.TestArticlePieces.Add(piece);
                }
                else
                {
                    //dbde update normalde
                   Tester.TestArticlePieces.RemoveAll(x => x.ID == piece.ID);
                   Tester.TestArticlePieces.Add(piece);
                }
            }

            //ID mevcutsa güncelle, yoksa ekle
            if (!Tester.TestArticles.Exists(x => x.ID != article.ID))
            {
                Tester.TestArticles.Add(article);
            }
            else
            {
                //dbde update normalde
                Tester.TestArticles.RemoveAll(x => x.ID == model.ID);
                Tester.TestArticles.Add(article);

            }
        }

        public static List<ArticlePiece> GetArticlePiecesByArticleId(string id)
        {
            return Tester.TestArticlePieces.Where(x => x.ArticleId == id).ToList();
        }

        public static void RemoveArticlePiece(string id)
        {
            Tester.TestArticlePieces.RemoveAll(x => x.ID == id);
        }

    }
}
