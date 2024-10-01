using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messeger.DAL.DataBase;

public class DataBaseTableType
{
    public Guid Id { get; private set; } = new Guid();
    public string Name { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public long PhoneNumber { get; set; }
    public string Mail { get; set; }
    public string Password { get; set; }

    public DataBaseTableType(string Name, string MiddleName, string LastName, long PhoneNumber, string Mail, string Password)
    {
        this.Name = Name;
        this.MiddleName = MiddleName;
        this.LastName = LastName;
        this.PhoneNumber = PhoneNumber;
        this.Mail = Mail;
        this.Password = Password;
    }
}
