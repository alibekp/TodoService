using System.ComponentModel.DataAnnotations;

namespace TodoApiDTO.DAL
{
    public class TodoItem
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Secret { get; set; }
    }
}