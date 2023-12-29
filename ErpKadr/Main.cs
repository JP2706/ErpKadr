using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpKadr
{
    public partial class Main : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Path.Combine(Environment.CurrentDirectory, "Employees.xml"));
        public Main()
        {
            InitializeComponent();
            var employees = _fileHelper.DeserializeFromFile();
            dgvKadr.DataSource = employees;
            SetColumnHeader();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee("Dodaj Pracownika");
            addEditEmployee.ShowDialog();
            RefreshDgv();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvKadr.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz Pracownika do edycji!");
                return;
            }

            if (dgvKadr.SelectedRows[0].Cells[7].Value.ToString() != "")
            {
                MessageBox.Show("Nie można edytować pracownika, który został zwolniony!", "Uwaga!");
                return;
            }

            var addEditEmployee = new AddEditEmployee("Edytuj Pracownika", Convert.ToInt32(dgvKadr.SelectedRows[0].Cells[0].Value));
            addEditEmployee.ShowDialog();
            RefreshDgv();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvKadr.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz Pracownika do zwolnienia");
                return;
            }

            if (dgvKadr.SelectedRows[0].Cells[7].Value.ToString() != "")
            {
                MessageBox.Show("Ten praconik został już zwolniony!", "Uwaga!");
                return;
            }

            var addEditEmployess = new AddEditEmployee("Zwolnij", Convert.ToInt32(dgvKadr.SelectedRows[0].Cells[0].Value), true);
            addEditEmployess.ShowDialog();
            RefreshDgv();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {

            var employees = new List<Employee>();
            var employees2 = new List<Employee>();
            employees = _fileHelper.DeserializeFromFile();
            if(cbKadr.Text == "Wszyscy")
            {
                RefreshDgv();
            }
            else if (cbKadr.Text == "Zatrudnieni")
            {
                foreach (Employee employee in employees)
                {
                    if (!(employee.DateSlowDown != ""))
                        employees2.Add(employee);
                }
                dgvKadr.DataSource = employees2;
            }
            else
            {
                foreach (Employee employee in employees)
                {
                    if (employee.DateSlowDown != "")
                        employees2.Add(employee);
                }
                dgvKadr.DataSource= employees2;
            }
        }

        private void SetColumnHeader()
        {
            dgvKadr.Columns[0].HeaderText = "Numer";
            dgvKadr.Columns[1].HeaderText = "Imię";
            dgvKadr.Columns[2].HeaderText = "Nazwisko";
            dgvKadr.Columns[3].HeaderText = "Data Zatrudnienia";
            dgvKadr.Columns[4].HeaderText = "Wypłata";
            dgvKadr.Columns[5].HeaderText = "Numer Telefonu";
            dgvKadr.Columns[6].HeaderText = "Uwagi";
            dgvKadr.Columns[7].HeaderText = "Data Zwolnienia";

        }
        private void RefreshDgv()
        {
            var Data = _fileHelper.DeserializeFromFile();
            dgvKadr.DataSource = Data;
        }
    }
}
