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
        private FileHelper<List<Employee>> fileHelper = new FileHelper<List<Employee>>(Path.Combine(Environment.CurrentDirectory, "Employees.xml"));
        private int employeeId;
        private bool enabledDataSlowDow;
        private List<Employee> employees;
        private Employee employee;
        public AddEditEmployee(string nameForm, int _employeeId = 0, bool _enabledDataSlowDow = false)
        {
            InitializeComponent();
            Text = nameForm;
            employeeId = _employeeId;
            enabledDataSlowDow = _enabledDataSlowDow;
            GetEmployeeData();
            EnabledDataSlowDow(_enabledDataSlowDow);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (enabledDataSlowDow == true)
                if (MessageBox.Show("Czy napewno chcesz zolnić pracowanika?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            employees = fileHelper.DeserializeFromFile();

            if (!ValidationTextBoxDecimal(tbPycheck))
                return;

            if (!ValidationTextBoxInt(tbEN))
                return;
            if (employeeId != 0)
                employees.RemoveAll(x => x.Id == employeeId);
            else
                AssignNewIdEmpolyees(employees);

            if (enabledDataSlowDow == false)
                AddNewEmployeeToList(employees);
            else
                AddNewEmployeeToListWithDataSlowNow(employees);

            fileHelper.SerializeToFile(employees);
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
                employeeId = 1;
            else
                employeeId = employeesWithHighestId.Id + 1;
        }

        private void AddNewEmployeeToList(List<Employee> _employees)
        {
         
            Employee employee = new Employee
            {
                Id = employeeId,
                Name = tbName.Text,
                Surname = tbSurname.Text,
                DateToEmploy = dtpDTE.Value.ToShortDateString(),
                Paycheck = decimal.Parse(tbPycheck.Text),
                EmployeeNumer = int.Parse(tbEN.Text),
                Comments = rtbComments.Text,
                DateSlowDown = ""
            };

            employees.Add(employee);
        }

        private void AddNewEmployeeToListWithDataSlowNow(List<Employee> _employees)
        {
            Employee employee = new Employee
            {
                Id = employeeId,
                Name = tbName.Text,
                Surname = tbSurname.Text,
                DateToEmploy = dtpDTE.Value.ToShortDateString(),
                Paycheck = decimal.Parse(tbPycheck.Text),
                EmployeeNumer = int.Parse(tbEN.Text),
                Comments = rtbComments.Text,
                DateSlowDown = dtpDSD.Value.ToShortDateString(),
            };

            employees.Add(employee);
        }

        private void FillTextBox()
        {
            tbId.Text = employee.Id.ToString();
            tbName.Text = employee.Name;
            tbSurname.Text = employee.Surname;
            dtpDTE.Value = DateTime.Parse(employee.DateToEmploy);
            tbPycheck.Text = employee.Paycheck.ToString();
            tbEN.Text = employee.EmployeeNumer.ToString();
            rtbComments.Text = employee.Comments;
        }

        private void EnabledDataSlowDow(bool _enabledDataSlowDow)
        {
            if (_enabledDataSlowDow == true)
            {
                tbId.Enabled = false;
                tbName.Enabled = false;
                tbSurname.Enabled = false;
                dtpDTE.Enabled = false;
                tbPycheck.Enabled = false;
                tbEN.Enabled = false;
                rtbComments.Enabled = false;
                dtpDSD.Enabled = true;
            }
        }

        private void GetEmployeeData()
        {
            if (employeeId != 0)
            {
                var employees = fileHelper.DeserializeFromFile();
                employee = employees.FirstOrDefault(x => x.Id == employeeId);
                if (employee == null)
                    throw new Exception("Brak pracownika o podanym id");
                FillTextBox();
            }
        }

        private bool ValidationTextBoxDecimal(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == string.Empty || !decimal.TryParse(textBox.Text, out decimal numeric))
            {
                MessageBox.Show($"Wartość pola {textBox.Tag} jest pusta lub niepoprawna", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
            
        }

        private bool ValidationTextBoxInt(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == string.Empty || !int.TryParse(textBox.Text, out int numeric))
            {
                MessageBox.Show($"Wartość pola {textBox.Tag} jest pusta lub niepoprawna", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
    }
}
