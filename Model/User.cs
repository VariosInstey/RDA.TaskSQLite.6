
using System.ComponentModel.DataAnnotations;

namespace RDA.TaskSQLite._6.Model;
public class User
{
    [Key]
    public int UserID { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public int RoleID { get; set; }
    public virtual Role Role { get; set; }
}
