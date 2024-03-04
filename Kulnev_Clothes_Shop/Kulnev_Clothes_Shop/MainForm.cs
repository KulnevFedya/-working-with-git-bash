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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Programm_class.crtbtn == false)//скрытие кнопки корзины
            {
                btnCart.Visible = false;
            }
            else
            {
                btnCart.Visible = true;
            }
            if (Programm_class.role != 1)
            {
                btnAdmin.Visible = false;
            }

            SqlConnection con = new SqlConnection(Programm_class.connection);
            DataSet dataset = new DataSet();

            SqlCommand profiletext = new SqlCommand();
            profiletext.CommandText = $"Select * FROM Clothes_catalog";//заполнение таблицы продуктами
            profiletext.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
            adapter.Fill(dataset);

            dataGridViewProduct.DataSource = dataset.Tables[0];

            if (dataGridViewProduct.DataSource != null)//скрываю ненужные столбцы
            {
                dataGridViewProduct.Columns[0].Visible = false;
                dataGridViewProduct.Columns[8].Visible = false;
            }

            con.Close();

            //здесь меняется шапка таблицы
            dataGridViewProduct.Columns[1].HeaderText = "Название товара";
            dataGridViewProduct.Columns[2].HeaderText = "Цена";
            dataGridViewProduct.Columns[3].HeaderText = "Производитель";
            dataGridViewProduct.Columns[4].HeaderText = "Категория";
            dataGridViewProduct.Columns[5].HeaderText = "Скидка";
            dataGridViewProduct.Columns[6].HeaderText = "Количество на складе";
            dataGridViewProduct.Columns[7].HeaderText = "Описание";
        
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Programm_class.connection);
            DataSet dataset = new DataSet();

            SqlCommand profiletext = new SqlCommand();
            profiletext.CommandText = $"Select * FROM Clothes_catalog where [ProductName] like '%{txtBoxSearch.Text}%'";
            profiletext.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
            adapter.Fill(dataset);

            dataGridViewProduct.DataSource = dataset.Tables[0];

            if (dataGridViewProduct.DataSource != null)
                dataGridViewProduct.Columns[0].Visible = false;

            con.Close();
        }
        int selected_product = 0;
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                if (e.RowIndex != null & e.RowIndex != -1)//при выборе элемента появлется информация о товаре и меняется картинка
                {

                    DataGridViewRow productdata = dataGridViewProduct.Rows[e.RowIndex];
                    string product_name = "";
                    product_name = productdata.Cells[8].Value.ToString();//получаем имя продукта из таблицы

                    lblDescription.Text = "Описание товара: " + productdata.Cells[7].Value.ToString();
                    lblProvider.Text = "Производитель товара: " + productdata.Cells[3].Value.ToString();
                    lblcost.Text = "Цена: " + productdata.Cells[2].Value.ToString();
                    lblDiscount.Text = "Скидка: " + productdata.Cells[5].Value.ToString() + "%";//вывод скидки

                String imagename = Programm_class.folder + productdata.Cells[8].Value.ToString() + ".JPG";//вывод картинки
                pictureBoxProduct.Image = Image.FromFile(imagename);
                  
                }
           }
            catch (Exception ex)
           {
               MessageBox.Show("Ошибка вывода картинки");
           }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization_form form = new Authorization_form();
            form.Show();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catText = comboBoxCategory.SelectedItem.ToString();
            if (catText == "все категории")
            {
                SqlConnection con = new SqlConnection(Programm_class.connection);
                DataSet dataset = new DataSet();

                SqlCommand profiletext = new SqlCommand();
                profiletext.CommandText = $"Select * FROM Clothes_catalog";
                profiletext.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
                adapter.Fill(dataset);

                dataGridViewProduct.DataSource = dataset.Tables[0];
                con.Close();

            }
            else if (catText == "Обувь")
            {
                SqlConnection con = new SqlConnection(Programm_class.connection);
                DataSet dataset = new DataSet();

                SqlCommand profiletext = new SqlCommand();
                profiletext.CommandText = "Select * FROM Clothes_catalog where [ProductCategory] like '%Обувь%'";
                profiletext.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
                adapter.Fill(dataset);

                dataGridViewProduct.DataSource = dataset.Tables[0];

                con.Close();

            }
            else if (catText == "Одежда")
            {
                SqlConnection con = new SqlConnection(Programm_class.connection);
                DataSet dataset = new DataSet();

                SqlCommand profiletext = new SqlCommand();
                profiletext.CommandText = "Select * FROM Clothes_catalog where [ProductCategory] like '%Одежда%'";
                profiletext.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
                adapter.Fill(dataset);

                dataGridViewProduct.DataSource = dataset.Tables[0];

                con.Close();

            }
        }

        private void dataGridViewProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentRow = e.RowIndex;
                int currentColumn = e.ColumnIndex;

                if (currentRow >= 0)
                {
                    dataGridViewProduct.Rows[currentRow].Selected = true;
                    Point point = dataGridViewProduct.PointToClient(Cursor.Position);
                    contextMenuStrip1.Show(dataGridViewProduct, point);//вывод контекстного меню
                }
            }
        }

        private void добавитьВКорзинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Programm_class.crtbtn = true;
            btnCart.Visible = true;//кнопка перехода в корзину становится доступной

            /*string name = dataGridViewProduct.CurrentRow.Cells[1].Value.ToString();
            int cost = (int)dataGridViewProduct.CurrentRow.Cells[3].Value;
            int discount = (int)dataGridViewProduct.CurrentRow.Cells[5].Value;
            string article = dataGridViewProduct.CurrentRow.Cells[8].Value.ToString();
            int amount = 1;

            Order_cart cart = new Order_cart();

            cart.AddProduct(new Product { name = name, cost = cost, discount = discount, article = article, amount = amount });
            */
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart form = new Cart();
            form.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Form form = new Admin_Form();
            form.Show();
        }
    }
}
