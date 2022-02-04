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
using System.Data.Entity.Infrastructure;

namespace EmployeeManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EmployeeEntities db;
        UISource employeeUISource;

        Dictionary<string, TextBox> columnToTextBox;

        private void Form1_Load(object sender, EventArgs e)
        {
            columnToTextBox = new Dictionary<string, TextBox>()
            {
                ["Id"] = txtId,
                ["ФИО"] = txtFullName,
                ["Департамент"] = txtDepartment,
                ["Должность"] = txtPost,
                ["Категория"] = txtCategory
            };

            db = new EmployeeEntities();

            employeeUISource = new EmployeeUISource(db, employeeBindingSource);

            editPanel.Enabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;

            employeeUISource.RebuildDataSource();

            foreach (var pair in columnToTextBox)
            {
                pair.Value.DataBindings.Add("Text", employeeBindingSource, pair.Key);
            }
        }

        private void CancelChanges()
        {
            foreach (DbEntityEntry entry in db.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case System.Data.Entity.EntityState.Added:
                        entry.State = System.Data.Entity.EntityState.Detached;
                        employeeBindingSource.RemoveCurrent();
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        entry.State = System.Data.Entity.EntityState.Unchanged;
                        employeeBindingSource.CancelEdit();
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }

            employeeBindingSource.ResetBindings(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            editPanel.Enabled = true;
            txtId.Enabled = false;

            Employee person = new Employee()
            {
                Id = employeeBindingSource.Count + 1,
                Уволен = false
            };

            db.Employee.Add(person);
            employeeBindingSource.Add(person);
            employeeBindingSource.MoveLast();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            editPanel.Enabled = true;
            txtId.Enabled = false;

            txtFullName.Select();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                await db.SaveChangesAsync();
                MessageBox.Show(Localization.Saved, Localization.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);

                editPanel.Enabled = false;
                btnEdit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Localization.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            editPanel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;

            CancelChanges();
        }

        private void dataGridViewEmployee_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmployee.Columns[e.ColumnIndex].Name == "flag_fired")
            {
                var employee = employeeBindingSource.Current as Employee;
                employee.Уволен = !employee.Уволен;
                //db.SaveChanges();
            }
        }

        private void txtFind_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                return;
            }

            if (string.IsNullOrEmpty(txtFind.Text))
            {
                employeeUISource.RebuildDataSource();
            }
            else
            {
                employeeUISource.RebuildListFilter(txtFind.Text);
            }
        }

        private void dataGridViewEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Employee employee = employeeBindingSource.Current as Employee;

                if (MessageBox.Show(Localization.ConfirmDelete(employee.ФИО), Localization.Message, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Employee.Remove(employeeBindingSource.Current as Employee);
                    employeeBindingSource.RemoveCurrent();
                }
            }
        }

        private void btn_refreshTable_Click(object sender, EventArgs e)
        {
            CancelChanges();
            employeeUISource.RebuildDataSource();
            //employeeUISource.RebuildListFilter(txtFind.Text);
            //employeeBindingSource.ResetBindings(false);
        }
    }
}
