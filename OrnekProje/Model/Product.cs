using Microsoft.AspNetCore.Mvc;
using OrnekProje.Model.ModelMetaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Model
{
    [ModelMetadataType(typeof(ProductMetaData))]
    public class Product
    {
        //public virtual string Akif() { return "uieuie"; }
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
    }
}
