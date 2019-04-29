namespace ArndtEmpMan
{
    partial class frmEmpMan
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
        public void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWorker = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.pnlSharedInfo = new System.Windows.Forms.Panel();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlManager = new System.Windows.Forms.Panel();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.pnlWorker = new System.Windows.Forms.Panel();
            this.txtHourlyPay = new System.Windows.Forms.TextBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblHourlyPay = new System.Windows.Forms.Label();
            this.pnlJobTitle = new System.Windows.Forms.Panel();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.pnlClient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSharedInfo.SuspendLayout();
            this.pnlManager.SuspendLayout();
            this.pnlWorker.SuspendLayout();
            this.pnlJobTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(135, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(552, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the data entry form for PREET INCORPORATED TM";
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.txtType);
            this.pnlClient.Controls.Add(this.lblClient);
            this.pnlClient.Controls.Add(this.lblType);
            this.pnlClient.Enabled = false;
            this.pnlClient.Location = new System.Drawing.Point(48, 201);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(221, 153);
            this.pnlClient.TabIndex = 1;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(72, 89);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 1;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(88, 57);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(45, 18);
            this.lblClient.TabIndex = 5;
            this.lblClient.Text = "Client";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(32, 92);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(35, 74);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(40, 13);
            this.lblBonus.TabIndex = 1;
            this.lblBonus.Text = "Bonus:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(117, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "To create a new client, managet or regular worker, press the corresponding button" +
    " below";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWorker);
            this.panel1.Controls.Add(this.btnManager);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Location = new System.Drawing.Point(193, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 41);
            this.panel1.TabIndex = 3;
            // 
            // btnWorker
            // 
            this.btnWorker.Location = new System.Drawing.Point(278, 3);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(122, 34);
            this.btnWorker.TabIndex = 4;
            this.btnWorker.Text = "Create Worker";
            this.btnWorker.UseVisualStyleBackColor = true;
            this.btnWorker.Click += new System.EventHandler(this.btnWorker_Click);
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(143, 3);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(122, 34);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "Create Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(4, 3);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(122, 34);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Create Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // pnlSharedInfo
            // 
            this.pnlSharedInfo.Controls.Add(this.txtBirthDate);
            this.pnlSharedInfo.Controls.Add(this.txtName);
            this.pnlSharedInfo.Controls.Add(this.txtID);
            this.pnlSharedInfo.Controls.Add(this.lblName);
            this.pnlSharedInfo.Controls.Add(this.lblBirthDate);
            this.pnlSharedInfo.Controls.Add(this.lblID);
            this.pnlSharedInfo.Enabled = false;
            this.pnlSharedInfo.Location = new System.Drawing.Point(105, 120);
            this.pnlSharedInfo.Name = "pnlSharedInfo";
            this.pnlSharedInfo.Size = new System.Drawing.Size(593, 61);
            this.pnlSharedInfo.TabIndex = 4;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(470, 20);
            this.txtBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(122, 20);
            this.txtBirthDate.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(240, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(39, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(196, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(409, 22);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(57, 13);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // pnlManager
            // 
            this.pnlManager.Controls.Add(this.txtBonus);
            this.pnlManager.Controls.Add(this.lblBonus);
            this.pnlManager.Controls.Add(this.txtSalary);
            this.pnlManager.Controls.Add(this.lblManager);
            this.pnlManager.Controls.Add(this.lblSalary);
            this.pnlManager.Enabled = false;
            this.pnlManager.Location = new System.Drawing.Point(291, 245);
            this.pnlManager.Name = "pnlManager";
            this.pnlManager.Size = new System.Drawing.Size(221, 108);
            this.pnlManager.TabIndex = 5;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(76, 71);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBonus.TabIndex = 6;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(76, 45);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 1;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.Location = new System.Drawing.Point(76, 12);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(66, 18);
            this.lblManager.TabIndex = 5;
            this.lblManager.Text = "Manager";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(36, 48);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(39, 13);
            this.lblSalary.TabIndex = 0;
            this.lblSalary.Text = "Salary:";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(148, 11);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(50, 13);
            this.lblJobTitle.TabIndex = 1;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // pnlWorker
            // 
            this.pnlWorker.Controls.Add(this.txtHourlyPay);
            this.pnlWorker.Controls.Add(this.lblWorker);
            this.pnlWorker.Controls.Add(this.lblHourlyPay);
            this.pnlWorker.Enabled = false;
            this.pnlWorker.Location = new System.Drawing.Point(536, 245);
            this.pnlWorker.Name = "pnlWorker";
            this.pnlWorker.Size = new System.Drawing.Size(221, 108);
            this.pnlWorker.TabIndex = 6;
            // 
            // txtHourlyPay
            // 
            this.txtHourlyPay.Location = new System.Drawing.Point(84, 45);
            this.txtHourlyPay.Name = "txtHourlyPay";
            this.txtHourlyPay.Size = new System.Drawing.Size(100, 20);
            this.txtHourlyPay.TabIndex = 1;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.Location = new System.Drawing.Point(84, 12);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(58, 18);
            this.lblWorker.TabIndex = 5;
            this.lblWorker.Text = "Worker";
            // 
            // lblHourlyPay
            // 
            this.lblHourlyPay.AutoSize = true;
            this.lblHourlyPay.Location = new System.Drawing.Point(17, 48);
            this.lblHourlyPay.Name = "lblHourlyPay";
            this.lblHourlyPay.Size = new System.Drawing.Size(61, 13);
            this.lblHourlyPay.TabIndex = 0;
            this.lblHourlyPay.Text = "Hourly Pay:";
            // 
            // pnlJobTitle
            // 
            this.pnlJobTitle.Controls.Add(this.txtJobTitle);
            this.pnlJobTitle.Controls.Add(this.lblJobTitle);
            this.pnlJobTitle.Enabled = false;
            this.pnlJobTitle.Location = new System.Drawing.Point(291, 201);
            this.pnlJobTitle.Name = "pnlJobTitle";
            this.pnlJobTitle.Size = new System.Drawing.Size(466, 38);
            this.pnlJobTitle.TabIndex = 1;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(205, 8);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(100, 20);
            this.txtJobTitle.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(36, 375);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(698, 375);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 54);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "CLOSE AND SAVE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(203, 375);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(84, 36);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Find/Display";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(530, 375);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 36);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(681, 63);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 36);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear all text boxes";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLookUp
            // 
            this.btnLookUp.Location = new System.Drawing.Point(48, 76);
            this.btnLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(96, 34);
            this.btnLookUp.TabIndex = 13;
            this.btnLookUp.Text = "Look up person by ID";
            this.btnLookUp.UseVisualStyleBackColor = true;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // frmEmpMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlJobTitle);
            this.Controls.Add(this.pnlWorker);
            this.Controls.Add(this.pnlManager);
            this.Controls.Add(this.pnlSharedInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmEmpMan";
            this.Text = "Employee Manager System";
            this.Load += new System.EventHandler(this.frmEmpMan_Load);
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlSharedInfo.ResumeLayout(false);
            this.pnlSharedInfo.PerformLayout();
            this.pnlManager.ResumeLayout(false);
            this.pnlManager.PerformLayout();
            this.pnlWorker.ResumeLayout(false);
            this.pnlWorker.PerformLayout();
            this.pnlJobTitle.ResumeLayout(false);
            this.pnlJobTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.Panel pnlClient;
        public System.Windows.Forms.Label lblBonus;
        public System.Windows.Forms.Label lblType;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnWorker;
        public System.Windows.Forms.Button btnManager;
        public System.Windows.Forms.Button btnClient;
        public System.Windows.Forms.Panel pnlSharedInfo;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblBirthDate;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblClient;
        public System.Windows.Forms.TextBox txtType;
        public System.Windows.Forms.Panel pnlManager;
        public System.Windows.Forms.Label lblJobTitle;
        public System.Windows.Forms.TextBox txtSalary;
        public System.Windows.Forms.Label lblManager;
        public System.Windows.Forms.Label lblSalary;
        public System.Windows.Forms.Panel pnlWorker;
        public System.Windows.Forms.TextBox txtHourlyPay;
        public System.Windows.Forms.Label lblWorker;
        public System.Windows.Forms.Label lblHourlyPay;
        public System.Windows.Forms.Panel pnlJobTitle;
        public System.Windows.Forms.TextBox txtJobTitle;
        public System.Windows.Forms.TextBox txtBonus;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnLookUp;
        public System.Windows.Forms.TextBox txtBirthDate;
    }
}

