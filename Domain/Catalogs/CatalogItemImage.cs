﻿using Domain.Attributes;

namespace Domain.Catalogs
{

    public class CatalogItemImage
    {
        public int Id { get; set; }
        public string Src { get; set; }
        public int CatalogItemId { get; set; }
        public CatalogItem CatalogItem { get; set; }


    }
}
