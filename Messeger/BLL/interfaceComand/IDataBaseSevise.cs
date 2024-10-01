using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messeger.BLL.interfaceComand;

public interface IDataBaseSevise
{
    Task RegisterUser(string Name, string MiddleName, string LastName, long PhoneNumber, string Mail, string Password);
}
public interface IConsoleInput
{
    string ReadLine();
}

