using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressfordConsultingApi.Dtos
{
    public class ArticleDto
    {
        public int articleId { get; set; }
        public string articleName { get; set; }
        public int? likes { get; set; }
        public string articleBody { get; set; }
        public string articleType { get; set; }
        public DateTime? articleDate { get; set; }
    }
}
