using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ErpKadr
{
    public partial class AddEditEmployee : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Path.Combine(Environment.CurrentDirectory, "Employees.xml"));
        private int _employeeId;
        private bool _enabledDataSlowDow;
        private List<Employee> _employees;
        private Employee _employee;
        public AddEditEmployee(string nameForm, int employeeId = 0, bool enabledDataSlowDow = false)
        {
            InitializeComponent();
            Text = nameForm;
            _employeeId = employeeId;
            _enabledDataSlowDow = enabledDataSlowDow;
            GetEmployeeData();
            EnabledDataSlowDow(_enabledDataSlowDow);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_enabledDataSlowDow)
            {
                if (MessageBox.Show("Czy napewno chcesz zolnić pracowanika?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                else if (dtpDTE.Value >= dtpDSD.Value)
                {
                    MessageBox.Show("Data zwolnienia niepoprawna!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            _employees = _fileHelper.DeserializeFromFile();

            //if (!ValidationTextBoxDecimal(tbPycheck))
            //    return;

            //if (!ValidationTextBoxInt(tbEN))
            //    return;
            if (_employeeId != 0)
                _employees.RemoveAll(x => x.Id == _employeeId);
            else
                AssignNewIdEmpolyees(_employees);

            if (string.IsNullOrEmpty(tbEN.Text))
                tbEN.Text = "Nie podano";

            if (!_enabledDataSlowDow)
                AddNewEmployeeToList(_employees);
            else
                AddNewEmployeeToListWithDataSlowNow(_employees);

            _fileHelper.SerializeToFile(_employees);
            Close();
        }

        private void btnNoConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AssignNewIdEmpolyees(List<Employee> _employees)
        {
            var employeesWithHighestId = _employees.OrderByDescending(x => x.Id).FirstOrDefault();
            if (employeesWithHighestId == null)
                _employeeId = 1;
            else
                _employeeId = employeesWithHighestId.Id + 1;
        }

        private void AddNewEmployeeToList(List<Employee> _employees)
        {

            Employee employee = new Employee
            {
                Id = _employeeId,
                Name = tbName.Text,
                Surname = tbSurname.Text,
                DateToEmploy = dtpDTE.Value.Date,
                Paycheck = nudPycheck.Value,
                EmployeeNumer = tbEN.Text,
                Comments = rtbComments.Text,
            };

            _employees.Add(employee);
        }

        private void AddNewEmployeeToListWithDataSlowNow(List<Employee> _employees)
        {
            Employee employee = new Employee
            {
                Id = _employeeId,
                Name = tbName.Text,
                Surname = tbSurname.Text,
                DateToEmploy = dtpDTE.Value.Date,
                Paycheck = nudPycheck.Value,
                EmployeeNumer = tbEN.Text,
                Comments = rtbComments.Text,
                DateSlowDown = dtpDSD.Value.Date,
            };

            _employees.Add(employee);
        }

        private void FillTextBox()
        {
            tbId.Text = _employee.Id.ToString();
            tbName.Text = _employee.Name;
            tbSurname.Text = _employee.Surname;
            dtpDTE.Value = _employee.DateToEmploy;
            nudPycheck.Value = _employee.Paycheck;
            tbEN.Text = _employee.EmployeeNumer.ToString();
            rtbComments.Text = _employee.Comments;
        }

        private void EnabledDataSlowDow(bool _enabledDataSlowDow)
        {
            if (_enabledDataSlowDow == true)
            {
                tbId.Enabled = false;
                tbName.Enabled = false;
                tbSurname.Enabled = false;
                dtpDTE.Enabled = false;
                nudPycheck.Enabled = false;
                tbEN.Enabled = false;
                rtbComments.Enabled = false;
                dtpDSD.Enabled = true;
            }
        }

        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                var employees = _fileHelper.DeserializeFromFile();
                _employee = employees.FirstOrDefault(x => x.Id == _employeeId);
                if (_employee == null)
                    throw new Exception("Brak pracownika o podanym id");
                FillTextBox();
            }
        }

        //private bool ValidationTextBoxDecimal(System.Windows.Forms.TextBox textBox)
        //{
        //    if (textBox.Text == string.Empty || !decimal.TryParse(textBox.Text, out decimal numeric))
        //    {
        //        MessageBox.Show($"Wartość pola {textBox.Tag} jest pusta lub niepoprawna", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    return true;

        //}

        private bool ValidationTextBoxInt(System.Windows.Forms.TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out int numeric) && !string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show($"Wartość pola {textBox.Tag} jest niepoprawna", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        private void tbEN_Leave(object sender, EventArgs e)
        {
            if (!ValidationTextBoxInt(tbEN))
            {
                tbEN.Select();
            }

        }
    }
}
