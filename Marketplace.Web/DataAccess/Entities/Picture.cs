﻿namespace Marketplace.Web.DataAccess.Entities
{
    public class Picture : BaseEntity
    {
        public string File { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
    }
}
