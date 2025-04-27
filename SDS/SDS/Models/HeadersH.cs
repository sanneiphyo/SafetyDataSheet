using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDS.Models;

public class HeadersH
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string HeaderHNo { get; set; }
    public string HeaderHName { get; set; }

    [ForeignKey("HeaderId")]
    public int HeaderId { get; set; } // Foreign key to Headers table
    public Headers Headers { get; set; } // Navigation property

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }

}

// id integer [primary key]
//   header_h_id varchar
//   header_h_name varchar(200)
//   header_id nvarchar(50)
//   created_date datetime
//   created_by nvarchar(50)
//   updated_date datetime
//   updated_by ncarchar(50
