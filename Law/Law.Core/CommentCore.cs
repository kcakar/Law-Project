﻿using Law.DataAccess;
using Law.Models;
using Law.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Law.Core
{
    public class CommentCore: CoreBase
    {
        public static List<Comment> GetCommentByArticleId(string id)
        {
            return Tester.TestComments.Where(x => x.ArticleId == id).ToList();
        }


        public static Comment AddComment(string body, string articleId, string username)
        {
            try
            {
                
                Comment comment = new Comment
                {
                    ID = Guid.NewGuid().ToString(),
                    ArticleId = articleId,
                    Body = body,
                    Username = username,
                    //CreationTime = DateTime.Now.Date
                };

                _context.Comments.Add(comment);
                _context.SaveChanges();
               //_context.Comments.Add(comment);


                Tester.TestComments.Add(comment);
                return comment;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
