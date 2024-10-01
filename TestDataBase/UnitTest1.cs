using Moq;
using NUnit.Framework;
using System;
using System.IO;
using System.Threading.Tasks;
using Messeger.BLL.FileAktiveClassProgramm;
using Messeger.BLL.interfaceComand;

namespace TestDataBase;

[TestFixture]
public class RegisterUserDBTests
{
    
    [Test]
    public async Task RegisterUser_ShouldAddUserToDatabase()
    {
        ShowUserRegister show = new ShowUserRegister();

        var mockConsole = new Mock<IConsoleInput>();
        mockConsole.SetupSequence(x => x.ReadLine())
            .Returns(" ")   // ������ ��� �����
            .Returns("�������")
            .Returns("��������")
            .Returns("1234567890") // ���������� ����� ��������
            .Returns("email@mail.com")
            .Returns("password");
    }
}