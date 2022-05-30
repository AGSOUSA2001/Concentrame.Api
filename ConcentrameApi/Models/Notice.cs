using System.ComponentModel.DataAnnotations;

namespace ConcentrameApi.Models
{
    public class Notice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string UrL { get; set; }
    }
}