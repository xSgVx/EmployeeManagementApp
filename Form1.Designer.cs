
namespace EmployeeManagementApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageWorkers = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployee = new Zuby.ADGV.AdvancedDataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageFired = new System.Windows.Forms.TabPage();
            this.dataGridViewFired = new Zuby.ADGV.AdvancedDataGridView();
            this.Restore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.департаментDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.департаментDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.tabPageFired.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFired)).BeginInit();
            this.editPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageWorkers);
            this.tabControl.Controls.Add(this.tabPageFired);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(945, 774);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabPageWorkers
            // 
            this.tabPageWorkers.Controls.Add(this.dataGridViewEmployee);
            this.tabPageWorkers.Location = new System.Drawing.Point(4, 25);
            this.tabPageWorkers.Name = "tabPageWorkers";
            this.tabPageWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkers.Size = new System.Drawing.Size(937, 745);
            this.tabPageWorkers.TabIndex = 1;
            this.tabPageWorkers.Text = "Работники";
            this.tabPageWorkers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewEmployee.ColumnHeadersHeight = 25;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.департаментDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.Delete});
            this.dataGridViewEmployee.DataSource = this.employeeBindingSource;
            this.dataGridViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEmployee.FilterAndSortEnabled = true;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEmployee.MultiSelect = false;
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(931, 739);
            this.dataGridViewEmployee.TabIndex = 0;
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick_1);
            // 
            // Delete
            // 
            this.Delete.FillWeight = 45.17068F;
            this.Delete.HeaderText = "Удалить";
            this.Delete.MinimumWidth = 22;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tabPageFired
            // 
            this.tabPageFired.Controls.Add(this.dataGridViewFired);
            this.tabPageFired.Location = new System.Drawing.Point(4, 25);
            this.tabPageFired.Name = "tabPageFired";
            this.tabPageFired.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFired.Size = new System.Drawing.Size(937, 745);
            this.tabPageFired.TabIndex = 0;
            this.tabPageFired.Text = "Уволенные";
            this.tabPageFired.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFired
            // 
            this.dataGridViewFired.AllowUserToAddRows = false;
            this.dataGridViewFired.AutoGenerateColumns = false;
            this.dataGridViewFired.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFired.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewFired.ColumnHeadersHeight = 25;
            this.dataGridViewFired.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.фИОDataGridViewTextBoxColumn1,
            this.департаментDataGridViewTextBoxColumn1,
            this.должностьDataGridViewTextBoxColumn1,
            this.категорияDataGridViewTextBoxColumn1,
            this.Restore});
            this.dataGridViewFired.DataSource = this.firedBindingSource;
            this.dataGridViewFired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFired.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFired.FilterAndSortEnabled = true;
            this.dataGridViewFired.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFired.Name = "dataGridViewFired";
            this.dataGridViewFired.ReadOnly = true;
            this.dataGridViewFired.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewFired.RowHeadersWidth = 51;
            this.dataGridViewFired.RowTemplate.Height = 24;
            this.dataGridViewFired.Size = new System.Drawing.Size(931, 739);
            this.dataGridViewFired.TabIndex = 0;
            this.dataGridViewFired.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFired_CellContentClick);
            // 
            // Restore
            // 
            this.Restore.FillWeight = 39.14493F;
            this.Restore.HeaderText = "Восстановить";
            this.Restore.MinimumWidth = 22;
            this.Restore.Name = "Restore";
            this.Restore.ReadOnly = true;
            this.Restore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // editPanel
            // 
            this.editPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editPanel.ColumnCount = 1;
            this.editPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editPanel.Controls.Add(this.txtId, 0, 1);
            this.editPanel.Controls.Add(this.lblId, 0, 0);
            this.editPanel.Controls.Add(this.txtCategory, 0, 9);
            this.editPanel.Controls.Add(this.lblCategory, 0, 8);
            this.editPanel.Controls.Add(this.txtPost, 0, 7);
            this.editPanel.Controls.Add(this.lblPost, 0, 6);
            this.editPanel.Controls.Add(this.txtDepartment, 0, 5);
            this.editPanel.Controls.Add(this.lblDepartment, 0, 4);
            this.editPanel.Controls.Add(this.txtFullName, 0, 3);
            this.editPanel.Controls.Add(this.lblName, 0, 2);
            this.editPanel.Location = new System.Drawing.Point(967, 25);
            this.editPanel.MaximumSize = new System.Drawing.Size(654, 319);
            this.editPanel.MinimumSize = new System.Drawing.Size(654, 319);
            this.editPanel.Name = "editPanel";
            this.editPanel.RowCount = 10;
            this.editPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editPanel.Size = new System.Drawing.Size(654, 319);
            this.editPanel.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.Location = new System.Drawing.Point(3, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(648, 22);
            this.txtId.TabIndex = 0;
            this.txtId.Validating += new System.ComponentModel.CancelEventHandler(this.txtId_Validating);
            this.txtId.Validated += new System.EventHandler(this.txtId_Validated);
            // 
            // lblId
            // 
            this.lblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.MinimumSize = new System.Drawing.Size(705, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(705, 31);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCategory
            // 
            this.txtCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCategory.Location = new System.Drawing.Point(3, 282);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(648, 22);
            this.txtCategory.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Location = new System.Drawing.Point(3, 248);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(648, 31);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Категория";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPost
            // 
            this.txtPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPost.Location = new System.Drawing.Point(3, 220);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(648, 22);
            this.txtPost.TabIndex = 3;
            // 
            // lblPost
            // 
            this.lblPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost.Location = new System.Drawing.Point(3, 186);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(648, 31);
            this.lblPost.TabIndex = 6;
            this.lblPost.Text = "Должность";
            this.lblPost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDepartment.Location = new System.Drawing.Point(3, 158);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(648, 22);
            this.txtDepartment.TabIndex = 2;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartment.Location = new System.Drawing.Point(3, 124);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(648, 31);
            this.lblDepartment.TabIndex = 6;
            this.lblDepartment.Text = "Департамент";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFullName
            // 
            this.txtFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFullName.Location = new System.Drawing.Point(3, 96);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(648, 22);
            this.txtFullName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(648, 31);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "ФИО";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(967, 407);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(654, 74);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(654, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.33962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 74);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 68);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(166, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(157, 68);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(329, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 68);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(492, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 68);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.txtFind, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFind, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(967, 350);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(654, 56);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(654, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(654, 56);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // txtFind
            // 
            this.txtFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFind.Location = new System.Drawing.Point(101, 3);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(550, 22);
            this.txtFind.TabIndex = 9;
            this.txtFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFind_KeyPress_1);
            // 
            // lblFind
            // 
            this.lblFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFind.Location = new System.Drawing.Point(3, 0);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(92, 26);
            this.lblFind.TabIndex = 17;
            this.lblFind.Text = "Поиск:";
            this.lblFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 10F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.FillWeight = 45.17068F;
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // департаментDataGridViewTextBoxColumn
            // 
            this.департаментDataGridViewTextBoxColumn.DataPropertyName = "Департамент";
            this.департаментDataGridViewTextBoxColumn.FillWeight = 45.17068F;
            this.департаментDataGridViewTextBoxColumn.HeaderText = "Департамент";
            this.департаментDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.департаментDataGridViewTextBoxColumn.Name = "департаментDataGridViewTextBoxColumn";
            this.департаментDataGridViewTextBoxColumn.ReadOnly = true;
            this.департаментDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.FillWeight = 45.17068F;
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.должностьDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.FillWeight = 45.17068F;
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.ReadOnly = true;
            this.категорияDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(EmployeeManagementApp.Employee);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.FillWeight = 10F;
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.FillWeight = 39.14493F;
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // департаментDataGridViewTextBoxColumn1
            // 
            this.департаментDataGridViewTextBoxColumn1.DataPropertyName = "Департамент";
            this.департаментDataGridViewTextBoxColumn1.FillWeight = 39.14493F;
            this.департаментDataGridViewTextBoxColumn1.HeaderText = "Департамент";
            this.департаментDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.департаментDataGridViewTextBoxColumn1.Name = "департаментDataGridViewTextBoxColumn1";
            this.департаментDataGridViewTextBoxColumn1.ReadOnly = true;
            this.департаментDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // должностьDataGridViewTextBoxColumn1
            // 
            this.должностьDataGridViewTextBoxColumn1.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn1.FillWeight = 39.14493F;
            this.должностьDataGridViewTextBoxColumn1.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.должностьDataGridViewTextBoxColumn1.Name = "должностьDataGridViewTextBoxColumn1";
            this.должностьDataGridViewTextBoxColumn1.ReadOnly = true;
            this.должностьDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // категорияDataGridViewTextBoxColumn1
            // 
            this.категорияDataGridViewTextBoxColumn1.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn1.FillWeight = 39.14493F;
            this.категорияDataGridViewTextBoxColumn1.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.категорияDataGridViewTextBoxColumn1.Name = "категорияDataGridViewTextBoxColumn1";
            this.категорияDataGridViewTextBoxColumn1.ReadOnly = true;
            this.категорияDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // firedBindingSource
            // 
            this.firedBindingSource.DataSource = typeof(EmployeeManagementApp.Fired);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 776);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(1659, 823);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageWorkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.tabPageFired.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFired)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageWorkers;
        private System.Windows.Forms.TabPage tabPageFired;
        private System.Windows.Forms.TableLayoutPanel editPanel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.BindingSource firedBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Zuby.ADGV.AdvancedDataGridView dataGridViewEmployee;
        private Zuby.ADGV.AdvancedDataGridView dataGridViewFired;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn департаментDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Restore;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn департаментDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

