﻿namespace Onlib.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int BookId { get; set; }
        public BookModel BookModel { get; set; }
    }
}