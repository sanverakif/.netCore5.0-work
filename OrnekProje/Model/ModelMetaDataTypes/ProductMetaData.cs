using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Model.ModelMetaDataTypes
{
    public class ProductMetaData
    {
        [Required(ErrorMessage = "lütfen ürün ismi giriniz")]
        [StringLength(100, ErrorMessage = "lütfen ürün ismini en fazla 100 karakter giriniz")]
        public string ProductName { get; set; }
        [EmailAddress(ErrorMessage = "doğru email giriniz")]
        public string Email { get; set; }
    }
}
