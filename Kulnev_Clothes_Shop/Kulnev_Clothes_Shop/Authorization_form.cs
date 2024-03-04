using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kulnev_Clothes_Shop
{
    public partial class Authorization_form : Form
    {
        public Authorization_form()
        {
            InitializeComponent();
        }

        int errors = 0;
        string answer;
        bool blockentry = true;
        private void Authorization_form_Load(object sender, EventArgs e)
        {
            txtBoxCapcha.Visible = false;
            picBoxCapcha.Visible = false;
            btnCapcha.Visible = false;
            timer_for_blocking.Tick += new EventHandler(timer_for_blocking_Tick);
            timer_for_blocking.Interval = 10000;
        }

        private void timer_for_blocking_Tick(object sender, EventArgs e)
        {
            btnEnter.Enabled = true;
            timer_for_blocking.Stop();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (blockentry == true)
            {
                string login, password;
                login = txtboxLogin.Text;
                password = txtboxPassword.Text;
                SqlConnection con = new SqlConnection(Programm_class.connection);
                con.Open();
                SqlCommand logrequest = new SqlCommand();

                logrequest.CommandType = CommandType.StoredProcedure;
                logrequest.CommandText = "checkpassword";
                logrequest.Parameters.AddWithValue("@login", login);
                logrequest.Parameters.AddWithValue("@password", password);
                logrequest.Connection = con;
                SqlDataReader sqlDataReader = logrequest.ExecuteReader();
                sqlDataReader.Read();
                if (sqlDataReader.HasRows)
                {
                   // Programm_class.user_id = (int)sqlDataReader.GetDouble(0);
                    Programm_class.role = (int)sqlDataReader.GetInt32(7);

                    this.Hide();
                    MainForm form = new MainForm();
                    form.Show();

                    errors = 0;
                }
                else
                {
                    errors++;
                    MessageBox.Show("Ошибка. Неправильно введён логин или пароль");
                    blockentry = false;
                    txtBoxCapcha.Visible = true;
                    picBoxCapcha.Visible = true;
                    btnCapcha.Visible = true;

                    picBoxCapcha.SizeMode = PictureBoxSizeMode.StretchImage;
                    fillcapcha();

                    if (errors > 1)
                    {
                        btnEnter.Enabled = false;
                        timer_for_blocking.Start();
                    }

                }
                con.Close();
            }
        }
        private void fillcapcha()//заполнение капчи
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            switch (value)
            {
                case 0:
                    answer = "6ne3";
                    break;
                case 1:
                    answer = "e5hb";
                    break;
                case 2:
                    answer = "xdhyn";
                    break;
            }
            picBoxCapcha.Image = imageListcapcha.Images[value];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }
    }
}
