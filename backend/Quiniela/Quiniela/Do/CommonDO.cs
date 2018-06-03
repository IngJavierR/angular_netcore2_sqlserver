using System.ComponentModel.DataAnnotations.Schema;
namespace Quiniela.Models
{
    public class CommonDO
    {
        public long ID { get; set; }
        [Column("DS_NAME")]
        public string Name { get; set; }

    }
}
