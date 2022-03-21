using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RazorPagesArileKris.Models
{
    public class Sheet
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Temperature { get; set; }
        public string Sex { get; set; } = string.Empty;
        
        public string Address { get; set; } = string.Empty;

    }
}
