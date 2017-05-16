﻿namespace BillOfMaterial.InfoObjects
{
    public class BillOfMaterialPositionInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string AdditionalInformations { get; set; }

        public int? ParentId { get; set; }

        public bool IsArticle { get; set; }
    }
}
