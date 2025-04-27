using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDS.Models;

public class HeadersHD
{
    [Key]
    public int Id { get; set; }

    public string HeaderHDNo { get; set; }
    public string HeaderHDName { get; set; }

    // public string HeaderHId { get; set; } // Foreign key to Headers table
    // public HeadersH HeadersH { get; set; } // Navigation property

    [ForeignKey("HeadersHId")]
    public int HeadersHId { get; set; } // Foreign key to Headers table
    public HeadersH HeadersH { get; set; } // Navigation property


    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }

}

// id integer [primary key]
//   header_d_id varchar
//   header_d_name varchar(200)
//   header_h_id nvarchar(50)
//   created_date datetime
//   created_by nvarchar(50)
//   updated_date datetime
//   updated_by ncarchar(50)