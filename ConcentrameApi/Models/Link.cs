using System.ComponentModel.DataAnnotations;

namespace ConcentrameApi.Models
{
    public class Link
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
