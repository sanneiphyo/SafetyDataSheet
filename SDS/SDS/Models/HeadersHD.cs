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
