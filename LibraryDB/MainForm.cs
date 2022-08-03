using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LibraryDB
{
    public partial class MainForm : Form
    {
        OleDbConnection bdConnection = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Library.mdb");
        string obj = "Closet";
        string[] way = { "0", "0" };

        public MainForm(){ InitializeComponent(); }

        private void MainForm_Load(object sender, EventArgs e) { RefreshData(); }

        private void RefreshData()
        {
            string query;
            switch (obj)
            {
                case "Closet":
                    query = "SELECT id AS id, name AS Название FROM Closet";
                    break;
                case "Shelf":
                    query = "SELECT id AS id, name AS Название FROM Shelf WHERE closet = " + way[0];
                    break;
                case "Book":
                    query = $"SELECT id AS id, name AS Название, author AS Автор, public_date AS [Год издания], condition AS Состояние FROM {obj} WHERE shelf = {way[1]}";
                    break;
                default:
                    query = "";
                    break;
            }
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(query, bdConnection);
            DataTable data = new DataTable();
            bdConnection.Open();
            oleDbDataAdapter.Fill(data);
            bdConnection.Close();
            dGV.DataSource = data;
        }

        private void Delete()
        {
            try
            {
                if (dGV.CurrentCell.ColumnIndex < 0)
                    MessageBox.Show("Сначала выберите элемент, который хотите удалить!");
                else
                {
                    DialogResult dr = MessageBox.Show("Вы действительно хотите удалить этот элемент?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        string query = $"DELETE FROM {obj} WHERE id = {dGV[0, dGV.CurrentCell.RowIndex].Value}";

                        OleDbCommand command = new OleDbCommand(query, bdConnection);
                        bdConnection.Open();
                        command.ExecuteNonQuery();
                        bdConnection.Close();

                        int i = dGV.CurrentCell.RowIndex;
                        RefreshData();

                        if (i < dGV.RowCount)
                            dGV.CurrentCell = dGV[0, i];
                        else if (i - 1 >= 0)
                            dGV.CurrentCell = dGV[0, i - 1];
                    }
                }
            }
            catch(System.NullReferenceException) { MessageBox.Show("Невозможно удалить несуществующий элемент!"); }
        }

        private void Open()
        {
            try
            {
                if (dGV.CurrentCell.ColumnIndex < 0)
                    MessageBox.Show("Сначала выберите элемент, который хотите открыть!");
                else
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));

                    switch (obj)
                    {
                        case "Closet":
                            obj = "Shelf";
                            way[0] = dGV[0, dGV.CurrentCell.RowIndex].Value.ToString();
                            btnReturn.Visible = true;
                            btnCreate.Image = (Image)resources.GetObject("btnOpen.Image");
                            btnDelete.Image = (Image)resources.GetObject("btnOpen.Image");
                            btnOpen.Image = (Image)resources.GetObject("btnReturn.Image");
                            btnReturn.Image = (Image)resources.GetObject("btnCreate.Image");
                            break;
                        case "Shelf":
                            obj = "Book";
                            way[1] = dGV[0, dGV.CurrentCell.RowIndex].Value.ToString();
                            btnOpen.Visible = false;
                            btnCreate.Image = (Image)resources.GetObject("btnReturn.Image");
                            btnDelete.Image = (Image)resources.GetObject("btnReturn.Image");
                            btnReturn.Image = (Image)resources.GetObject("btnOpen.Image");
                            break;
                    }
                    RefreshData();
                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Невозможно открыть несуществующий элемент!"); }
        }

        private void Return()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));

            switch (obj)
            {
                case "Book":
                    obj = "Shelf";
                    btnOpen.Visible = true;
                    btnCreate.Image = (Image)resources.GetObject("btnOpen.Image");
                    btnDelete.Image = (Image)resources.GetObject("btnOpen.Image");
                    btnOpen.Image = (Image)resources.GetObject("btnReturn.Image");
                    btnReturn.Image = (Image)resources.GetObject("btnCreate.Image");
                    break;
                case "Shelf":
                    obj = "Closet";
                    btnReturn.Visible = false;
                    btnCreate.Image = (Image)resources.GetObject("btnCreate.Image");
                    btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
                    btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
                    break;
            }

            RefreshData();

            switch (obj)
            {
                case "Shelf":
                    dGV.CurrentCell = dGV[0, FindRowByID(way[1])];
                    way[1] = "0";
                    break;
                case "Closet":
                    dGV.CurrentCell = dGV[0, FindRowByID(way[0])];
                    way[0] = "0";
                    break;
            }

        }

        private string ShowWay()
        {
            string s = "";

            if (way[0] != "0")
            {
                bdConnection.Open();
                OleDbCommand command = new OleDbCommand($"SELECT name FROM Closet WHERE id = {way[0]}", bdConnection);
                s = $"путь: {command.ExecuteScalar()}";
                if (way[1] != "0")
                {
                    command = new OleDbCommand($"SELECT name FROM Closet WHERE id = {way[1]}", bdConnection);
                    s += $" > {command.ExecuteScalar()}";
                }
                bdConnection.Close();
            }

            return s;
        }

        private int FindRowByID(string d)
        {
            for (int i = 0; i < dGV.RowCount; i++)
                if (dGV[0, i].Value.ToString() == d)
                    return i;
            return 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddandDelete addAnEntry = new AddandDelete(obj, way);
            addAnEntry.Text = "Новая запись";
            addAnEntry.ShowDialog();
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e) { Delete(); }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Open();
            txtWay.Text = ShowWay();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Return();
            txtWay.Text = ShowWay();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
            MessageBox.Show("Синхронизация успешно завершена!");
        }

        private void btnClose_Click(object sender, EventArgs e) { Close(); }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e){bdConnection.Close();}
    }
}
