using Messeger.DAL.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messeger.Log_in_to_your_account
{
    public class Logintoyouraccount
    {
        public async Task UserSearch(long PhoneNumber, string Password)
        {
            using (DataBaseCreateRegister dataBaseCreateRegister = new DataBaseCreateRegister())
            {
                var person = dataBaseCreateRegister.DataBaseTableType.FirstOrDefault(x => x.PhoneNumber == PhoneNumber && x.Password == Password);

                if (person != null)
                {
                    Console.WriteLine($"Вы уcпешно вошли в аккаунт! Здравствуйте {person.Name}"); 
                }
                else
                {
                    Console.WriteLine("Пользователь не найден. Проверьте номер телефона или пароль."); 
                }
            }
        } 
    }
}
