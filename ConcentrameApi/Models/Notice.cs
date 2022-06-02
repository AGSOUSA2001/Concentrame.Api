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
        public string Url { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Paragraph1 { get; set; }
        [Required]
        public string Paragraph2 { get; set; }
        [Required]
        public string Paragraph3 { get; set; }
    }
}