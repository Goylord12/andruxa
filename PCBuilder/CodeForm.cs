using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PCBuilder
{
    public partial class CodeForm : Form
    {
        private string _codeFromRegistration;
        private TextBox[] codeBoxes;
        private int currentCodeBoxIndex = 0;
        private const int MaxCodeLength = 1; // Максимальная длина кода в каждом текстовом поле
        string log, pass, eMail = "";

        public string CodeFromRegistration
        {
            get { return _codeFromRegistration; }
            set { _codeFromRegistration = value; }
        }

        Timer timer;
        int secondsLeft = 30;

        public CodeForm(string code, string login, string password, string email)
        {
            log = login;
            pass = password;
            eMail = email;
            InitializeComponent();
            InitializeCodeTextBoxes();
            CodeFromRegistration = code; // Установка кода регистрации

            // Создание и запуск таймера
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Добавляем обработчик события FormClosing
            this.FormClosing += CodeForm_FormClosing;
        }
        private void CodeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Проверяем причину закрытия формы
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Отменяем закрытие формы
                this.Hide(); // Прячем текущую форму вместо закрытия
            }
        }

        private void InitializeCodeTextBoxes()
        {
            codeBoxes = new TextBox[] { codeBox1, codeBox2, codeBox3, codeBox4, codeBox5, codeBox6 };

            foreach (var textBox in codeBoxes)
            {
                textBox.KeyPress += CodeBox_KeyPress;
                textBox.MaxLength = MaxCodeLength; // Ограничение максимальной длины текста
                textBox.KeyDown += CodeBox_KeyDown; // Добавить обработчик для нажатия клавиш
                textBox.TextChanged += CodeBox_TextChanged; // Подписка на событие изменения текста
            }
        }
        private void CodeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                TextBox currentTextBox = (TextBox)sender;
                currentTextBox.Clear(); // Очистить текстовое поле при нажатии кнопки Backspace
            }
        }

        private void CodeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;

            // Проверяем, является ли символ буквой английского алфавита или цифрой
            if (!char.IsLetterOrDigit(e.KeyChar) || !IsEnglishLetterOrDigit(e.KeyChar))
            {
                // Если символ не является буквой английского алфавита или цифрой, игнорируем его
                e.Handled = true;
                return;
            }

            // Преобразовываем символ в верхний регистр
            e.KeyChar = char.ToUpper(e.KeyChar);

            // Устанавливаем курсор в конец текста
            currentTextBox.SelectionStart = currentTextBox.Text.Length;
            currentTextBox.SelectionLength = 0;
        }

        private bool IsEnglishLetterOrDigit(char c)
        {
            // Проверяем, является ли символ буквой английского алфавита или цифрой
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
        }


        private void CodeBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;

            // Перемещение курсора на следующее поле при вводе одного символа,
            // если текущее поле не находится в конце и не достигло максимальной длины
            if (currentTextBox.TextLength == MaxCodeLength)
            {
                MoveToNextCodeBox(currentTextBox);
            }
        }

        private void MoveToNextCodeBox(TextBox currentTextBox)
        {
            int currentIndex = Array.IndexOf(codeBoxes, currentTextBox);

            if (currentIndex < codeBoxes.Length - 1)
            {
                codeBoxes[currentIndex + 1].Focus();
            }
            else
            {
                ValidateEnteredCode();
            }
        }

        private void ValidateEnteredCode()
        {
            string enteredCode = string.Concat(codeBoxes.Select(tb => tb.Text));

            if (enteredCode == CodeFromRegistration)
            {
                MessageBox.Show("Код верный.");
                // Действия при верном коде
            }
            else
            {
                MessageBox.Show("Неверный код.");

                // Очистка всех текстовых полей
                foreach (var textBox in codeBoxes)
                {
                    textBox.Clear();
                }
                codeBoxes[0].Focus();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsLeft--;
            TimerLabel.Text = secondsLeft.ToString();

            if (secondsLeft == 0)
            {
                timer.Stop();
                RepeatcodeLabel.Visible = true;
            }
        }

        private void RepeatcodeLabel_Click(object sender, EventArgs e)
        {
            secondsLeft = 30;
            timer.Start();
        }

        private void CodeForm_Load(object sender, EventArgs e)
        {
            foreach (var textBox in codeBoxes)
            {
                textBox.MouseClick += TextBox_MouseClick;
            }
        }

        private void TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Установите фокус на текстовом поле, чтобы начать редактирование текста
            TextBox textBox = (TextBox)sender;
            textBox.ReadOnly = false;
            textBox.Focus();
            textBox.SelectAll(); // Выделить весь текст при клике
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string enteredCode = string.Concat(codeBoxes.Select(tb => tb.Text));

            if (enteredCode == CodeFromRegistration)
            {
                DB db = new DB();
                SqlConnection connection = db.getConnection();
                // Закрываем текущую форму с кодом

                using (connection)
                {
                    
                    connection.Open();
                    try
                    {
                        // Вставляем данные в таблицу userTable
                        string insertUserQuery = @"
                        INSERT INTO Users (Login, Password, Email)
                        OUTPUT INSERTED.UserID
                        VALUES (@login, @password, @name);";

                        int userId;
                        using (SqlCommand insertUserCommand = new SqlCommand(insertUserQuery, connection))
                        {
                            insertUserCommand.Parameters.AddWithValue("@login", log);
                            insertUserCommand.Parameters.AddWithValue("@password", pass); // Здесь должно быть хеширование пароля
                            insertUserCommand.Parameters.AddWithValue("@name", eMail);

                            // Получаем ID нового пользователя
                            userId = (int)insertUserCommand.ExecuteScalar();
                        }

                      
                        this.Close();
                        AuthorizationForm form = new AuthorizationForm();
                        form.Show();
                        
                    }
                    // Подтверждаем транзакцию

                    catch (Exception)
                    {
                        // В случае ошибки откатываем транзакцию
                     
                        MessageBox.Show("что-то не робит");
                    }
                }
                MessageBox.Show("Регистрация завершена!");

         
               
             

            }
            else
            {
                MessageBox.Show("Неверный код.");

                // Очистка всех текстовых полей
                foreach (var textBox in codeBoxes)
                {
                    textBox.Clear();
                }
                codeBoxes[0].Focus();
            }
        }
    }
}
