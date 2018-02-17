using Law.Models;
using Law.Test;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Law.Core
{
    public class CommentCore
    {
        public static List<Comment> GetCommentByArticleId(string id)
        {
            return Tester.TestComments.Where(x => x.ArticleId == id).ToList();
        }


        public static Comment AddComment(string body,string username,string articleId)
        {
            try
            {
                Comment comment = new Comment
                {
                    ArticleId = articleId,
                    Body = body,
                    Username = username,
                    CreationTime = DateTime.Now
                };
                Tester.TestComments.Add(comment);
                return comment;
            }
            catch
            {
                return null;
            }
        }
    }
}
