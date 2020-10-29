using System;

namespace ArticleApi.Dto.EntityDto
{
    public class ArticleDto
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