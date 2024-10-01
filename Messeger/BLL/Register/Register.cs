using Messeger.BLL.interfaceComand;
using Messeger.DAL.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messeger.BLL.Register;

public class RegisterUserDB : IDataBaseSevise
{
    public async Task RegisterUser(string Name, string MiddleName, string LastName, long PhoneNumber, string Mail, string Password)
    {
        using (DataBaseCreateRegister dataBaseCreateRegister = new DataBaseCreateRegister())
        {
            await dataBaseCreateRegister.DataBaseTableType.AddAsync(new DataBaseTableType(Name, MiddleName, LastName, PhoneNumber, Mail, Password));
            await dataBaseCreateRegister.SaveChangesAsync();
        }
    }
}

public class CommandDB
{
    private readonly IDataBaseSevise _CommandDataB;

    public CommandDB(IDataBaseSevise _CommandDataB)
    {
        this._CommandDataB = _CommandDataB;
    }

    public (string Name, string MiddleName, string LastName, long PhoneNumber, string Mail, string Password) ShowRegisterData(string Name, string MiddleName, string LastName, long PhoneNumber, string Mail, string Password)
    {
        return (Name, MiddleName, LastName, PhoneNumber, Mail, Password);
    }
}