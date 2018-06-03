using System.ComponentModel.DataAnnotations.Schema;
namespace Quiniela.Models
{
    [Table("K_USER")]
    public class UserDO : CommonDO
    {
        [Column("DS_LASTNAME")]
        public string LastName { get; set; }
        [Column("DS_NICKNAME")]
        public string NickName { get; set; }
        [Column("DS_EMAIL")]
        public string Email { get; set; }
        [Column("ID_LOCATION")]
        public string Location { get; set; }
        [Column("DS_PICTURE")]
        public string Picture { get; set; }
    }
}
