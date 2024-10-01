using Messeger.Log_in_to_your_account;
using Messeger.BLL.FileAktiveClassProgramm;

namespace Messeger;

internal class Program
{

    static async Task Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в новый месседжер пожалуйста зарегистрируйтесь или войдите в аккаунт" +
            "для регистрации нажмите 1, а для входа 2");
        
        if (!byte.TryParse(Console.ReadLine(), out byte value ))
        {
            Console.WriteLine("Вы ввели неизвестные значения попробуйте ещё раз");
            return;
        }
        else
        {
            switch (value)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Регистрация");
                        ShowUserRegister showUserRegister = new ShowUserRegister();
                        showUserRegister.Show();
                        break;
                    }
                    case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Введите ваш номер телефона");

                        if (!long.TryParse(Console.ReadLine(), out long PhoneNumber))
                        {
                            Console.WriteLine("Строка осталась пустая пустая");
                            return;
                        }

                        Console.WriteLine("Введите ваш пароль");

                        string Password = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(Password))
                        {
                            Console.WriteLine("Строка осталась пустая пустая");
                            return;
                        }
                        Logintoyouraccount LogInAccaunt = new Logintoyouraccount();

                        await LogInAccaunt.UserSearch(PhoneNumber, Password);
                        break;
                    }
            }
        }

    }
}
