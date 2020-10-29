using System;
using System.Collections.Concurrent;
using System.Runtime;

namespace ArticleApi.Entity
{
    public class ArticleEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Permalink { get; set; }
        public string File1 { get; set; }
        public string File2 { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}