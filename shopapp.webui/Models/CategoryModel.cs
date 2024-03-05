using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Name zorunlu bir alan.")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Kategori ismi 5-10 karakter arasında olmalı.")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Url zorunlu bir alan.")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Url ismi 5-10 karakter arasında olmalı.")]

        public string Url { get; set; }

        public List<Product> Products { get; set; }


    }
}
