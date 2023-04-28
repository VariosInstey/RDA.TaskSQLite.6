using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDA.TaskSQLite._6.Model;
public class Role
{
    public int RoleID { get; set; }
    public string RoleName { get; set; }
    
    public virtual ICollection<User> Users { get; private set; } = new ObservableCollection<User>();
}
