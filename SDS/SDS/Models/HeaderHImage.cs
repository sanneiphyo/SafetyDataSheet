using System.ComponentModel.DataAnnotations;

namespace SDS.Models
{
    public class HeaderHImage
    {
        public int Id { get; set; }

        public int HeaderHId { get; set; }
        public HeadersH HeadersH { get; set; }

        public int HeadersDataId { get; set; }
        public HeadersData HeadersData { get; set; }


        public string ImagePath { get; set; }

        public string ImageName { get; set; }

        [Range(1, 5)]
        public int Order { get; set;  }
    }
}
