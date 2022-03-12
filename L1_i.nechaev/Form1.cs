using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1_i.nechaev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nechaev_t1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.nechaev_t1BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.iVT_2022DataSet);
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iVT_2022DataSet._i_nechaev_t1' table. You can move, or remove it, as needed.
            this.i_nechaev_t1TableAdapter.Fill(this.iVT_2022DataSet._i_nechaev_t1);

        }

        private void i_nechaev_t1DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            String error = e.Exception.GetType().ToString();

            switch (error)
            {
                case "System.Data.NoNullAllowedException":
                    MessageBox.Show("Пустое значение имени");
                    break;
                case "System.FormatException":
                    MessageBox.Show("Слишком большое число в price или значение не целое");
                    break;
                default:
                    MessageBox.Show(e.Exception.GetType().ToString() + "\n" + e.Exception.Message);
                    break;
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int rowIndex = i_nechaev_t1DataGridView.CurrentCell.RowIndex;
            i_nechaev_t1DataGridView.Rows.RemoveAt(rowIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.i_nechaev_t1DataGridView.SelectedRows)
            {
                i_nechaev_t1DataGridView.Rows.RemoveAt(item.Index);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.i_nechaev_t1DataGridView.SelectedRows)
                {
                    i_nechaev_t1DataGridView.Rows.RemoveAt(item.Index);
                }
            } catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

          private void i_nechaev_t1DataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = i_nechaev_t1DataGridView.Rows[e.RowIndex];  // текущая строка
            DataGridViewCell nameCell = row.Cells[i_nechaev_t1DataGridView.Columns["name"].Index];  // ячейка name в текущей строке
            if (nameCell.Value == null || nameCell.Value.ToString().Length == 0)  // значение в ячейке name пусто
            {
                nameCell.ErrorText = "Заполните имя";  // метка в ячейке name
                i_nechaev_t1DataGridView.Rows[nameCell.RowIndex].ErrorText = "Заполните имя";  // метка в ошибочной строке
                e.Cancel = true;  // запрет ухода из строки
            }
            else

            {

                nameCell.ErrorText = "";  // метка в ячейке name
                i_nechaev_t1DataGridView.Rows[nameCell.RowIndex].ErrorText = "";  // метка в ошибочной строке

                e.Cancel = false;

              }
        }

        private void i_nechaev_t1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
