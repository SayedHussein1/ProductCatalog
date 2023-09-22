using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Model
{
    public class TopicModel : BaseModel, ILocalizedModel<TopicLocalizedModel>
    {
        public TopicModel()
        {
            Locales = new List<TopicLocalizedModel>();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TopicId { get; set; }


        public IList<TopicLocalizedModel> Locales { get; set; }
    }
    public partial class TopicLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
       
    }
}
