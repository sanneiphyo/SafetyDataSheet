// using System;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

// namespace SDS.Models;

// public class HeadersData
// {
//     [Key]
//     public int Id { get; set; }
//     public string Content { get; set; } // Data content

//     [ForeignKey("HeadersHId")]
//     public int HeadersHId { get; set; } // Foreign key to HeadersH table
//     public HeadersH HeadersH { get; set; } // Navigation property to HeadersH

//     [ForeignKey("HeadersHDId")]
//     public int HeadersHDId { get; set; } // Foreign key to HeadersHD table
//     public HeadersHD HeadersHD { get; set; } // Navigation property to HeadersD

//     [ForeignKey("ProductId")]
//     public int ProductId { get; set; } // Foreign key to Product table
//     public Product Product { get; set; } // Navigation property to Product


//     public DateTime CreatedAt { get; set; }
//     public DateTime? UpdatedAt { get; set; }
//     public DateTime? DeletedAt { get; set; }
//     public bool IsDeleted { get; set; }
// }

