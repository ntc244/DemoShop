﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }
        [MaxLength(50)]
        public string Name { set; get; }
        [MaxLength(50)]
        public string Type { set; get; }
        public virtual IEnumerable<PostTag> PostTags { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}
