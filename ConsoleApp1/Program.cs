using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MessengerRegistration
{
    public class RegistrationForm : Form
    {
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtEmail;
        private Button btnRegister;
        private Button btnCancel;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Настройка окна формы
            this.Text = "Регистрация пользователя";
            this.Size = new System.Drawing.Size(300, 250);

            // Лейблы для ввода данных
            lblUsername = new Label() { Text = "Имя пользователя:", Location = new System.Drawing.Point(10, 20) };
            lblPassword = new Label() { Text = "Пароль:", Location = new System.Drawing.Point(10, 60) };
            lblConfirmPassword = new Label() { Text = "Подтвердите пароль:", Location = new System.Drawing.Point(10, 100) };
            lblEmail = new Label() { Text = "Email:", Location = new System.Drawing.Point(10, 140) };

            // Поля ввода
            txtUsername = new TextBox() { Location = new System.Drawing.Point(150, 20), Width = 120 };
            txtPassword = new TextBox() { Location = new System.Drawing.Point(150, 60), Width = 120, UseSystemPasswordChar = true };
            txtConfirmPassword = new TextBox() { Location = new System.Drawing.Point(150, 100), Width = 120, UseSystemPasswordChar = true };
            txtEmail = new TextBox() { Location = new System.Drawing.Point(150, 140), Width = 120 };

            // Кнопки
            btnRegister = new Button() { Text = "Зарегистрироваться", Location = new System.Drawing.Point(10, 180) };
            btnCancel = new Button() { Text = "Отмена", Location = new System.Drawing.Point(150, 180) };

            // Добавление обработчиков событий для кнопок
            btnRegister.Click += BtnRegister_Click;
            btnCancel.Click += BtnCancel_Click;

            // Добавление элементов управления на форму
            this.Controls.Add(lblUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(lblConfirmPassword);
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtUsername);
            this.Controls.Add(txtPassword);
            this.Controls.Add(txtConfirmPassword);
            this.Controls.Add(txtEmail);
            this.Controls.Add(btnRegister);
            this.Controls.Add(btnCancel);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Проверка правильности введенных данных
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Все поля обязательны для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Логика регистрации пользователя
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new RegistrationForm());
        }
    }
}