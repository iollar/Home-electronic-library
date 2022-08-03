using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LibraryDB
{
    public partial class AddandDelete : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Library.mdb");
        public string id, obj;
        public string[] way = { "0", "0" };

        public AddandDelete(string s, string[] w)
        {
            obj = s;
            way = w;
            InitializeComponent();
            switch (obj)
            {
                case "Closet":
                    panel1.Visible = false;
                    Size = MinimumSize;
                    break;
                case "Shelf":
                    panel1.Visible = false;
                    Size = MinimumSize;
                    break;
                case "Book":
                    panel1.Visible = true;
                    cbCondition.SelectedIndex = 0;
                    Size = MaximumSize;
                    break;
                default:
                    break;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) { this.Close(); }

        public void Add()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Поле \"Название\" обязательно для заполнения!");
            }
            else
            {
                string query;

                switch (obj)
                {
                    case "Closet":
                        query = $"INSERT INTO {obj} (name) VALUES ('{txtName.Text}')";
                        break;
                    case "Shelf":
                        query = $"INSERT INTO {obj} (name, closet) VALUES ('{txtName.Text}','{way[0]}')";
                        break;
                    case "Book":
                        if (txtAuthor.Text == "") txtAuthor.Text = "---";
                        if (txtYear.Text == "") txtYear.Text = "0";
                        query = $"INSERT INTO {obj} (name,author,public_date,shelf,condition) VALUES ('{txtName.Text}','{txtAuthor.Text}','{txtYear.Text}','{way[1]}','{cbCondition.Text}')";
                        break;
                    default:
                        query = "";
                        break;
                }

                con.Open();
                OleDbCommand dbCommand = new OleDbCommand(query, con);
                dbCommand.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e) { Add(); }

        private void btnYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }
    }
}
