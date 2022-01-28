using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace EmployeeManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EmployeeEntities db;
        ErrorProvider errorProvider = new ErrorProvider();

        private void Form1_Load(object sender, EventArgs e)
        {
            editPanel.Enabled = false;

            db = new EmployeeEntities();

            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;

            employeeBindingSource.DataSource = db.Employee.ToList();
            firedBindingSource.DataSource = db.Fired.ToList();

            txtId.DataBindings.Add("Text", employeeBindingSource, "Id");
            txtFullName.DataBindings.Add("Text", employeeBindingSource, "ФИО");
            txtDepartment.DataBindings.Add("Text", employeeBindingSource, "Департамент");
            txtPost.DataBindings.Add("Text", employeeBindingSource, "Должность");
            txtCategory.DataBindings.Add("Text", employeeBindingSource, "Категория");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            editPanel.Enabled = true;

            txtId.Select();
            //txtFullName.Select();
            //txtDepartment.Select();
            //txtPost.Select();
            //txtCategory.Select();

            Employee person = new Employee();
            db.Employee.Add(person);
            employeeBindingSource.Add(person);
            employeeBindingSource.MoveLast();

            // db.SaveChangesAsync();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            editPanel.Enabled = true;

            //txtId.Select();

            
            txtFullName.Select();
            //txtDepartment.Select();
            //txtPost.Select();
            //txtCategory.Select();

            // db.SaveChangesAsync();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                await db.SaveChangesAsync();
                MessageBox.Show("Сохранено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            editPanel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            employeeBindingSource.ResetBindings(false);
        }

        private void dataGridViewEmployee_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmployee.Columns[e.ColumnIndex].Name == "Delete")
            {
                var employee = employeeBindingSource.Current as Employee;
                Fired firedEmployee = new Fired()
                {
                    Id = employee.Id,
                    ФИО = employee.ФИО,
                    Департамент = employee.Департамент,
                    Должность = employee.Должность,
                    Категория = employee.Категория
                };

                if (MessageBox.Show($"Поместить пользователя {employee.ФИО} в группу уволенных?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Fired.Add(firedEmployee);
                    firedBindingSource.Add(firedEmployee);

                    db.Employee.Remove(employeeBindingSource.Current as Employee);
                    employeeBindingSource.RemoveCurrent();

                    //db.SaveChangesAsync();
                }
            }
        }

        private void dataGridViewFired_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFired.Columns[e.ColumnIndex].Name == "Restore")
            {
                var fired = firedBindingSource.Current as Fired;
                Employee recoveredEmployee = new Employee()
                {
                    Id = fired.Id,
                    ФИО = fired.ФИО,
                    Департамент = fired.Департамент,
                    Должность = fired.Должность,
                    Категория = fired.Категория
                };

                if (MessageBox.Show($"Восстановить пользователя {fired.ФИО} ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Employee.Add(recoveredEmployee);
                    employeeBindingSource.Add(recoveredEmployee);

                    db.Fired.Remove(firedBindingSource.Current as Fired);
                    firedBindingSource.RemoveCurrent();

                    //   db.SaveChangesAsync();
                }
            }
        }

        private void dataGridViewFired_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Fired fired = firedBindingSource.Current as Fired;

                if (MessageBox.Show($"Удалить пользователя {fired.ФИО} навсегда?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Fired.Remove(firedBindingSource.Current as Fired);
                    firedBindingSource.RemoveCurrent();

                    //  db.SaveChangesAsync();
                }
            }
        }

        private void txtFind_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //кнопка Enter
            {
                if (string.IsNullOrEmpty(txtFind.Text))
                {
                    if (tabControl.SelectedTab == tabPageWorkers)
                    {
                        employeeBindingSource.DataSource = db.Employee.ToList();
                    }

                    if (tabControl.SelectedTab == tabPageFired)
                    {
                        employeeBindingSource.DataSource = db.Fired.ToList();
                    }
                }
                else
                {
                    if (tabControl.SelectedTab == tabPageWorkers)
                    {
                        var query = from match in db.Employee.Where(x => x.Id.ToString().Contains(txtFind.Text) ||
                                                                         x.ФИО.Contains(txtFind.Text) ||
                                                                         x.Департамент.Contains(txtFind.Text) ||
                                                                         x.Должность.Contains(txtFind.Text) ||
                                                                         x.Категория.Contains(txtFind.Text))
                                    select match;

                        employeeBindingSource.DataSource = query.ToList();
                    }

                    if (tabControl.SelectedTab == tabPageFired)
                    {
                        var query = from match in db.Fired.Where(x => x.Id.ToString().Contains(txtFind.Text) ||
                                                                      x.ФИО.Contains(txtFind.Text) ||
                                                                      x.Департамент.Contains(txtFind.Text) ||
                                                                      x.Должность.Contains(txtFind.Text) ||
                                                                      x.Категория.Contains(txtFind.Text))
                                    select match;

                        firedBindingSource.DataSource = query.ToList();
                    }
                }
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            txtId.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            txtDepartment.DataBindings.Clear();
            txtPost.DataBindings.Clear();
            txtCategory.DataBindings.Clear();

            if (tabControl.SelectedTab == tabPageWorkers)
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;

                txtId.DataBindings.Add("Text", employeeBindingSource, "Id");
                txtFullName.DataBindings.Add("Text", employeeBindingSource, "ФИО");
                txtDepartment.DataBindings.Add("Text", employeeBindingSource, "Департамент");
                txtPost.DataBindings.Add("Text", employeeBindingSource, "Должность");
                txtCategory.DataBindings.Add("Text", employeeBindingSource, "Категория");
            }

            if (tabControl.SelectedTab == tabPageFired)
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;

                txtId.DataBindings.Add("Text", firedBindingSource, "Id");
                txtFullName.DataBindings.Add("Text", firedBindingSource, "ФИО");
                txtDepartment.DataBindings.Add("Text", firedBindingSource, "Департамент");
                txtPost.DataBindings.Add("Text", firedBindingSource, "Должность");
                txtCategory.DataBindings.Add("Text", firedBindingSource, "Категория");
            }
        }


        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!ValidId(txtId.Text, out errorMsg))
            {
                e.Cancel = true;
               // txtId.Select(0, txtId.Text.Length);

                txtId.BackColor = Color.Red;
                MessageBox.Show(errorMsg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtId_Validated(object sender, EventArgs e)
        {
            txtId.BackColor = Color.Green;
        }

        private bool ValidId(string id, out string errorMassage)
        {
            if (id.Length == 0)
            {
                errorMassage = "Пустой id, введите значение";
                return false;
            }

            if(!Int32.TryParse(id, out int result))
            {
                errorMassage = "Нераспознанный символ, введите число";
                return false;
            }

            var query = (from match in db.Employee
                         where match.Id.ToString().Contains(txtId.Text)
                         select match).ToList().FirstOrDefault();

            if (query != null)
            {
                errorMassage = "Id встречается в таблице Работники, введите другое значение";
                return false;
            }

            var query2 = (from match in db.Fired
                          where match.Id.ToString().Contains(txtId.Text)
                          select match).ToList().FirstOrDefault();

            if (query2 != null)
            {
                errorMassage = "Id встречается в таблице Уволенные, введите другое значение";
                return false;
            }

            errorMassage = "";
            return true;
        }


    }
}
