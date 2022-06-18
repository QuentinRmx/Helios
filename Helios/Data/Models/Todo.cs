using SQLite;

namespace Helios.Data.Models
{
    [Table("todo")]
    public class Todo : Model
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; }

    }
}
