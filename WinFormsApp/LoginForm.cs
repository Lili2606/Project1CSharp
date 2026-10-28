using WinFormsApp;
namespace WinFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "files",
                "configs",
                "logins.txt"
            );

            if (!File.Exists(filePath))
            {
                MessageBox.Show("فایل اطلاعات ورود پیدا نشد");
                return;
            }

            string[] logins = File.ReadAllLines(filePath);

            string userName = textBox1.Text.Trim().ToLower();
            string passWord = textBox2.Text;

            bool successfulLogin = false;

            for (int i = 0; i < logins.Length; i++)
            {
                string[] login = logins[i].Split(',');

                if (login.Length < 2)
                {
                    continue;
                }

                string savedUserName = login[0].Trim().ToLower();
                string savedPassword = login[1];

                if (userName == savedUserName &&
                    passWord == savedPassword)
                {
                    successfulLogin = true;
                    break;
                }
            }

            if (successfulLogin)
            {
                LayoutForm layoutForm = new LayoutForm();
                layoutForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}

