namespace LoginForm
{
    partial class adminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new LoginForm.DatabaseDataSet();
            this.employeeTableAdapter = new LoginForm.DatabaseDataSetTableAdapters.employeeTableAdapter();
            this.dtJoinDate = new System.Windows.Forms.DateTimePicker();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignUserLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlViewEmployees = new System.Windows.Forms.Panel();
            this.lblSearchLN = new System.Windows.Forms.Label();
            this.lblSearchFN = new System.Windows.Forms.Label();
            this.txtSearchLN = new System.Windows.Forms.TextBox();
            this.txtSearchFN = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAssignEmployee = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboEmpId = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new LoginForm.DatabaseDataSet1();
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new LoginForm.DatabaseDataSet1TableAdapters.departmentTableAdapter();
            this.roleTableAdapter = new LoginForm.DatabaseDataSet1TableAdapters.roleTableAdapter();
            this.pnlAssignLogin = new System.Windows.Forms.Panel();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.comboEmployeeId = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmpId1 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.pnlEmployee.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlViewEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pnlAssignEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.pnlAssignLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(220, 77);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 23);
            this.txtFirstName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(220, 117);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(212, 23);
            this.txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Join Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date of Birth";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(580, 130);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(591, 82);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 29);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.joinDateDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 148);
            this.dataGridView1.TabIndex = 12;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "employeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee Id";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // joinDateDataGridViewTextBoxColumn
            // 
            this.joinDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.joinDateDataGridViewTextBoxColumn.DataPropertyName = "joinDate";
            this.joinDateDataGridViewTextBoxColumn.HeaderText = "Join Date";
            this.joinDateDataGridViewTextBoxColumn.Name = "joinDateDataGridViewTextBoxColumn";
            this.joinDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // dtJoinDate
            // 
            this.dtJoinDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtJoinDate.Location = new System.Drawing.Point(220, 153);
            this.dtJoinDate.Name = "dtJoinDate";
            this.dtJoinDate.Size = new System.Drawing.Size(212, 23);
            this.dtJoinDate.TabIndex = 4;
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDateOfBirth.Location = new System.Drawing.Point(220, 192);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(212, 23);
            this.dtDateOfBirth.TabIndex = 5;
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.dtDateOfBirth);
            this.pnlEmployee.Controls.Add(this.txtEmployeeId);
            this.pnlEmployee.Controls.Add(this.txtFirstName);
            this.pnlEmployee.Controls.Add(this.dtJoinDate);
            this.pnlEmployee.Controls.Add(this.txtLastName);
            this.pnlEmployee.Controls.Add(this.lblEmployeeId);
            this.pnlEmployee.Controls.Add(this.dataGridView1);
            this.pnlEmployee.Controls.Add(this.label1);
            this.pnlEmployee.Controls.Add(this.btnClear);
            this.pnlEmployee.Controls.Add(this.label2);
            this.pnlEmployee.Controls.Add(this.label3);
            this.pnlEmployee.Controls.Add(this.label4);
            this.pnlEmployee.Controls.Add(this.btnAdd);
            this.pnlEmployee.Controls.Add(this.btnDelete);
            this.pnlEmployee.Controls.Add(this.btnUpdate);
            this.pnlEmployee.Location = new System.Drawing.Point(0, 27);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(802, 422);
            this.pnlEmployee.TabIndex = 14;
            this.pnlEmployee.Visible = false;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(220, 35);
            this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(212, 23);
            this.txtEmployeeId.TabIndex = 2;
            this.txtEmployeeId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmployeeId_KeyDown);
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(108, 39);
            this.lblEmployeeId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(73, 15);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(580, 130);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 46);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(580, 130);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 46);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeDataToolStripMenuItem,
            this.checkBookingsToolStripMenuItem,
            this.addStructureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeDataToolStripMenuItem
            // 
            this.employeeDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.updateEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem,
            this.viewEmployeesToolStripMenuItem,
            this.assignEmployeeToolStripMenuItem,
            this.assignUserLoginToolStripMenuItem});
            this.employeeDataToolStripMenuItem.Name = "employeeDataToolStripMenuItem";
            this.employeeDataToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.employeeDataToolStripMenuItem.Text = "Employee Data";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.AddEmployeeToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.UpdateEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.DeleteEmployeeToolStripMenuItem_Click);
            // 
            // viewEmployeesToolStripMenuItem
            // 
            this.viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.viewEmployeesToolStripMenuItem.Text = "View Employees";
            this.viewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.ViewEmployeesToolStripMenuItem_Click);
            // 
            // assignEmployeeToolStripMenuItem
            // 
            this.assignEmployeeToolStripMenuItem.Name = "assignEmployeeToolStripMenuItem";
            this.assignEmployeeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.assignEmployeeToolStripMenuItem.Text = "Assign Employee";
            this.assignEmployeeToolStripMenuItem.Click += new System.EventHandler(this.AssignEmployeeToolStripMenuItem_Click);
            // 
            // assignUserLoginToolStripMenuItem
            // 
            this.assignUserLoginToolStripMenuItem.Name = "assignUserLoginToolStripMenuItem";
            this.assignUserLoginToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.assignUserLoginToolStripMenuItem.Text = "Assign User Login";
            this.assignUserLoginToolStripMenuItem.Click += new System.EventHandler(this.AssignUserLoginToolStripMenuItem_Click);
            // 
            // checkBookingsToolStripMenuItem
            // 
            this.checkBookingsToolStripMenuItem.Name = "checkBookingsToolStripMenuItem";
            this.checkBookingsToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.checkBookingsToolStripMenuItem.Text = "Check Bookings";
            this.checkBookingsToolStripMenuItem.Click += new System.EventHandler(this.CheckBookingsToolStripMenuItem_Click);
            // 
            // addStructureToolStripMenuItem
            // 
            this.addStructureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepartmentToolStripMenuItem});
            this.addStructureToolStripMenuItem.Name = "addStructureToolStripMenuItem";
            this.addStructureToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.addStructureToolStripMenuItem.Text = "Add Structure";
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addDepartmentToolStripMenuItem.Text = "Add Department";
            // 
            // pnlViewEmployees
            // 
            this.pnlViewEmployees.Controls.Add(this.lblSearchLN);
            this.pnlViewEmployees.Controls.Add(this.lblSearchFN);
            this.pnlViewEmployees.Controls.Add(this.txtSearchLN);
            this.pnlViewEmployees.Controls.Add(this.txtSearchFN);
            this.pnlViewEmployees.Controls.Add(this.dataGridView2);
            this.pnlViewEmployees.Location = new System.Drawing.Point(4, 28);
            this.pnlViewEmployees.Name = "pnlViewEmployees";
            this.pnlViewEmployees.Size = new System.Drawing.Size(796, 420);
            this.pnlViewEmployees.TabIndex = 13;
            this.pnlViewEmployees.Visible = false;
            // 
            // lblSearchLN
            // 
            this.lblSearchLN.AutoSize = true;
            this.lblSearchLN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchLN.Location = new System.Drawing.Point(409, 35);
            this.lblSearchLN.Name = "lblSearchLN";
            this.lblSearchLN.Size = new System.Drawing.Size(120, 15);
            this.lblSearchLN.TabIndex = 2;
            this.lblSearchLN.Text = "Search by Last Name:";
            // 
            // lblSearchFN
            // 
            this.lblSearchFN.AutoSize = true;
            this.lblSearchFN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFN.Location = new System.Drawing.Point(44, 35);
            this.lblSearchFN.Name = "lblSearchFN";
            this.lblSearchFN.Size = new System.Drawing.Size(121, 15);
            this.lblSearchFN.TabIndex = 2;
            this.lblSearchFN.Text = "Search by First Name:";
            // 
            // txtSearchLN
            // 
            this.txtSearchLN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLN.Location = new System.Drawing.Point(542, 32);
            this.txtSearchLN.Name = "txtSearchLN";
            this.txtSearchLN.Size = new System.Drawing.Size(168, 23);
            this.txtSearchLN.TabIndex = 1;
            this.txtSearchLN.TextChanged += new System.EventHandler(this.TxtSearchLN_TextChanged);
            // 
            // txtSearchFN
            // 
            this.txtSearchFN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFN.Location = new System.Drawing.Point(177, 32);
            this.txtSearchFN.Name = "txtSearchFN";
            this.txtSearchFN.Size = new System.Drawing.Size(168, 23);
            this.txtSearchFN.TabIndex = 1;
            this.txtSearchFN.TextChanged += new System.EventHandler(this.TxtSearchFN_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.joinDateDataGridViewTextBoxColumn1,
            this.dateOfBirthDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.employeeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(24, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(744, 311);
            this.dataGridView2.TabIndex = 0;
            // 
            // employeeIdDataGridViewTextBoxColumn1
            // 
            this.employeeIdDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeIdDataGridViewTextBoxColumn1.DataPropertyName = "employeeId";
            this.employeeIdDataGridViewTextBoxColumn1.HeaderText = "Employee Id";
            this.employeeIdDataGridViewTextBoxColumn1.Name = "employeeIdDataGridViewTextBoxColumn1";
            this.employeeIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // joinDateDataGridViewTextBoxColumn1
            // 
            this.joinDateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.joinDateDataGridViewTextBoxColumn1.DataPropertyName = "joinDate";
            this.joinDateDataGridViewTextBoxColumn1.HeaderText = "Join Date";
            this.joinDateDataGridViewTextBoxColumn1.Name = "joinDateDataGridViewTextBoxColumn1";
            this.joinDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn1
            // 
            this.dateOfBirthDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOfBirthDataGridViewTextBoxColumn1.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn1.HeaderText = "Date Of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn1.Name = "dateOfBirthDataGridViewTextBoxColumn1";
            this.dateOfBirthDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pnlAssignEmployee
            // 
            this.pnlAssignEmployee.Controls.Add(this.btnSubmit);
            this.pnlAssignEmployee.Controls.Add(this.dataGridView3);
            this.pnlAssignEmployee.Controls.Add(this.comboEmpId);
            this.pnlAssignEmployee.Controls.Add(this.lblRole);
            this.pnlAssignEmployee.Controls.Add(this.lblEmpId);
            this.pnlAssignEmployee.Controls.Add(this.lblDepartment);
            this.pnlAssignEmployee.Controls.Add(this.comboRole);
            this.pnlAssignEmployee.Controls.Add(this.comboDepartment);
            this.pnlAssignEmployee.Location = new System.Drawing.Point(0, 26);
            this.pnlAssignEmployee.Name = "pnlAssignEmployee";
            this.pnlAssignEmployee.Size = new System.Drawing.Size(799, 420);
            this.pnlAssignEmployee.TabIndex = 13;
            this.pnlAssignEmployee.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(132, 284);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn2,
            this.firstNameDataGridViewTextBoxColumn2,
            this.lastNameDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.employeeBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(352, 84);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(436, 150);
            this.dataGridView3.TabIndex = 4;
            // 
            // employeeIdDataGridViewTextBoxColumn2
            // 
            this.employeeIdDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeIdDataGridViewTextBoxColumn2.DataPropertyName = "employeeId";
            this.employeeIdDataGridViewTextBoxColumn2.HeaderText = "Employee Id";
            this.employeeIdDataGridViewTextBoxColumn2.Name = "employeeIdDataGridViewTextBoxColumn2";
            this.employeeIdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn2
            // 
            this.firstNameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn2.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn2.Name = "firstNameDataGridViewTextBoxColumn2";
            this.firstNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn2
            // 
            this.lastNameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn2.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn2.Name = "lastNameDataGridViewTextBoxColumn2";
            this.lastNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // comboEmpId
            // 
            this.comboEmpId.DataSource = this.employeeBindingSource;
            this.comboEmpId.DisplayMember = "employeeId";
            this.comboEmpId.FormattingEnabled = true;
            this.comboEmpId.Location = new System.Drawing.Point(178, 84);
            this.comboEmpId.Name = "comboEmpId";
            this.comboEmpId.Size = new System.Drawing.Size(121, 21);
            this.comboEmpId.TabIndex = 3;
            this.comboEmpId.ValueMember = "employeeId";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(109, 203);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(30, 15);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.Location = new System.Drawing.Point(69, 86);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(73, 15);
            this.lblEmpId.TabIndex = 2;
            this.lblEmpId.Text = "Employee ID";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(69, 144);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(70, 15);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            // 
            // comboRole
            // 
            this.comboRole.DataSource = this.roleBindingSource;
            this.comboRole.DisplayMember = "roleName";
            this.comboRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Location = new System.Drawing.Point(178, 203);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(121, 23);
            this.comboRole.TabIndex = 1;
            this.comboRole.ValueMember = "roleId";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "role";
            this.roleBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboDepartment
            // 
            this.comboDepartment.DataSource = this.departmentBindingSource;
            this.comboDepartment.DisplayMember = "departmentName";
            this.comboDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.Location = new System.Drawing.Point(178, 141);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(121, 23);
            this.comboDepartment.TabIndex = 0;
            this.comboDepartment.ValueMember = "departmentId";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.databaseDataSet1;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // pnlAssignLogin
            // 
            this.pnlAssignLogin.Controls.Add(this.panel1);
            this.pnlAssignLogin.Controls.Add(this.radioUser);
            this.pnlAssignLogin.Controls.Add(this.radioAdmin);
            this.pnlAssignLogin.Controls.Add(this.comboEmployeeId);
            this.pnlAssignLogin.Controls.Add(this.lblPassword);
            this.pnlAssignLogin.Controls.Add(this.lblEmpId1);
            this.pnlAssignLogin.Controls.Add(this.lblLastName);
            this.pnlAssignLogin.Controls.Add(this.lblFirstName);
            this.pnlAssignLogin.Controls.Add(this.lblEmail);
            this.pnlAssignLogin.Controls.Add(this.txtPassword);
            this.pnlAssignLogin.Controls.Add(this.txtEmail);
            this.pnlAssignLogin.Controls.Add(this.btnCreate);
            this.pnlAssignLogin.Location = new System.Drawing.Point(-1, 26);
            this.pnlAssignLogin.Name = "pnlAssignLogin";
            this.pnlAssignLogin.Size = new System.Drawing.Size(799, 422);
            this.pnlAssignLogin.TabIndex = 17;
            this.pnlAssignLogin.Visible = false;
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUser.Location = new System.Drawing.Point(468, 288);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(48, 19);
            this.radioUser.TabIndex = 6;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "User";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdmin.Location = new System.Drawing.Point(313, 287);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(61, 19);
            this.radioAdmin.TabIndex = 6;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // comboEmployeeId
            // 
            this.comboEmployeeId.DataSource = this.employeeBindingSource;
            this.comboEmployeeId.DisplayMember = "employeeId";
            this.comboEmployeeId.FormattingEnabled = true;
            this.comboEmployeeId.Location = new System.Drawing.Point(331, 89);
            this.comboEmployeeId.Name = "comboEmployeeId";
            this.comboEmployeeId.Size = new System.Drawing.Size(121, 21);
            this.comboEmployeeId.TabIndex = 5;
            this.comboEmployeeId.ValueMember = "employeeId";
            this.comboEmployeeId.SelectedIndexChanged += new System.EventHandler(this.ComboEmployeeId_SelectedIndexChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(221, 211);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblEmpId1
            // 
            this.lblEmpId1.AutoSize = true;
            this.lblEmpId1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId1.Location = new System.Drawing.Point(205, 91);
            this.lblEmpId1.Name = "lblEmpId1";
            this.lblEmpId1.Size = new System.Drawing.Size(73, 15);
            this.lblEmpId1.TabIndex = 2;
            this.lblEmpId1.Text = "Employee ID";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(614, 91);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(524, 91);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(242, 154);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(331, 206);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(331, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(377, 330);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 423);
            this.panel1.TabIndex = 7;
            // 
            // adminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlAssignLogin);
            this.Controls.Add(this.pnlAssignEmployee);
            this.Controls.Add(this.pnlEmployee);
            this.Controls.Add(this.pnlViewEmployees);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMenu_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlViewEmployees.ResumeLayout(false);
            this.pnlViewEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pnlAssignEmployee.ResumeLayout(false);
            this.pnlAssignEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.pnlAssignLogin.ResumeLayout(false);
            this.pnlAssignLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DatabaseDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtJoinDate;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem addStructureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.ToolStripMenuItem assignEmployeeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlViewEmployees;
        private System.Windows.Forms.TextBox txtSearchFN;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel pnlAssignEmployee;
        private System.Windows.Forms.ComboBox comboDepartment;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DatabaseDataSet1TableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private DatabaseDataSet1TableAdapters.roleTableAdapter roleTableAdapter;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox comboEmpId;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSearchLN;
        private System.Windows.Forms.Label lblSearchFN;
        private System.Windows.Forms.TextBox txtSearchLN;
        private System.Windows.Forms.ToolStripMenuItem assignUserLoginToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAssignLogin;
        private System.Windows.Forms.ComboBox comboEmployeeId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmpId1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.Panel panel1;
    }
}