using Messeger.BLL.interfaceComand;
using Messeger.BLL.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messeger.BLL.FileAktiveClassProgramm;

public class ShowUserRegister
{
    public async Task Show()
    {

        Console.WriteLine("Введите имя:");
        string Name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(Name))
        {
            Console.WriteLine("Строка имени не может быть пустым или состоять только из пробелов.");
            return;
        }

        Console.WriteLine("Введите фамилию:");
        string MiddleName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(MiddleName))
        {
            Console.WriteLine("Строка Фамилии не может быть пустым или состоять только из пробелов.");
            return;
        }

        Console.WriteLine("Введите отчество:");
        string LastName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(LastName))
        {
            Console.WriteLine("Строка Отчества не может быть пустым или состоять только из пробелов.");
            return;
        }

        Console.WriteLine("Введите номер телефона:");
        if (!long.TryParse(Console.ReadLine(), out long PhoneNumber))
        {
            Console.WriteLine("Неверный формат номера телефона!");
            return;
        }

        Console.WriteLine("Введите почту:");
        string Mail = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(Mail))
        {
            Console.WriteLine("Строка почты не может быть пустой или состоять только из пробелов.");
            return;
        }

        Console.WriteLine("Введите пароль:");
        string Password = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(Password))
        {
            Console.WriteLine("Строка пароля не может быть пустым или состоять только из пробелов.");
            return;
        }


        IDataBaseSevise dataBase = new RegisterUserDB();
        await dataBase.RegisterUser(Name, MiddleName, LastName, PhoneNumber, Mail, Password);

        CommandDB command = new CommandDB(dataBase);
        var userData = command.ShowRegisterData(Name, MiddleName, LastName, PhoneNumber, Mail, Password);


        Console.WriteLine($"Пользователь {userData.Name} {userData.MiddleName} зарегистрирован.");

    }
}
