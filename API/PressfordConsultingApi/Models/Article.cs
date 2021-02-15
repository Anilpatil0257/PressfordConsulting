using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PressfordConsultingApi.Models
{
    [Table(name:"Article")]
    public class Article
    {
        [Key]
        public int articleId { get; set; }
        [Required]
        [StringLength(255)]
        public string articleName { get; set; }
        public int? likes { get; set; }
        public string articleBody { get; set; }
        public string articleType { get; set; }
        public DateTime? articleDate { get; set; }
    }
}
