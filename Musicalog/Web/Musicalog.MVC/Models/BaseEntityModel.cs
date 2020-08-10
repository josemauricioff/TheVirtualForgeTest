using System.ComponentModel.DataAnnotations;

namespace Musicalog.MVC.Models
{
    public class BaseEntityModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
