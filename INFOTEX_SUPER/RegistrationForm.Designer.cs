namespace INFOTEX_SUPER
{
    partial class RegistrationForm
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
            System.Windows.Forms.Label account_type_numberLabel;
            System.Windows.Forms.Label account_phone_numberLabel;
            System.Windows.Forms.Label account_fullnameLabel;
            System.Windows.Forms.Label account_passwordLabel;
            System.Windows.Forms.Label account_loginLabel;
            this.account_type_numberTextBox = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.account_phone_numberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.account_fullnameTextBox = new System.Windows.Forms.TextBox();
            this.account_passwordTextBox = new System.Windows.Forms.TextBox();
            this.account_loginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oOO_INFOTEXDataSet = new INFOTEX_SUPER.OOO_INFOTEXDataSet();
            this.accountsTableAdapter = new INFOTEX_SUPER.OOO_INFOTEXDataSetTableAdapters.AccountsTableAdapter();
            this.tableAdapterManager = new INFOTEX_SUPER.OOO_INFOTEXDataSetTableAdapters.TableAdapterManager();
            account_type_numberLabel = new System.Windows.Forms.Label();
            account_phone_numberLabel = new System.Windows.Forms.Label();
            account_fullnameLabel = new System.Windows.Forms.Label();
            account_passwordLabel = new System.Windows.Forms.Label();
            account_loginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOO_INFOTEXDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // account_type_numberLabel
            // 
            account_type_numberLabel.AutoSize = true;
            account_type_numberLabel.Location = new System.Drawing.Point(464, 123);
            account_type_numberLabel.Name = "account_type_numberLabel";
            account_type_numberLabel.Size = new System.Drawing.Size(110, 13);
            account_type_numberLabel.TabIndex = 37;
            account_type_numberLabel.Text = "account type number:";
            // 
            // account_type_numberTextBox
            // 
            this.account_type_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "account_type_number", true));
            this.account_type_numberTextBox.Location = new System.Drawing.Point(584, 120);
            this.account_type_numberTextBox.Name = "account_type_numberTextBox";
            this.account_type_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.account_type_numberTextBox.TabIndex = 39;
            this.account_type_numberTextBox.Text = "1";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(16, 248);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(272, 40);
            this.btnRegister.TabIndex = 38;
            this.btnRegister.Text = "Зарегистрироватся";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // account_phone_numberTextBox
            // 
            this.account_phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "account_phone_number", true));
            this.account_phone_numberTextBox.Location = new System.Drawing.Point(16, 216);
            this.account_phone_numberTextBox.Mask = "+7 (000) 000-00-00";
            this.account_phone_numberTextBox.Name = "account_phone_numberTextBox";
            this.account_phone_numberTextBox.Size = new System.Drawing.Size(272, 20);
            this.account_phone_numberTextBox.TabIndex = 36;
            // 
            // account_phone_numberLabel
            // 
            account_phone_numberLabel.AutoSize = true;
            account_phone_numberLabel.Location = new System.Drawing.Point(16, 200);
            account_phone_numberLabel.Name = "account_phone_numberLabel";
            account_phone_numberLabel.Size = new System.Drawing.Size(136, 13);
            account_phone_numberLabel.TabIndex = 35;
            account_phone_numberLabel.Text = "Введите номер телефона";
            // 
            // account_fullnameLabel
            // 
            account_fullnameLabel.AutoSize = true;
            account_fullnameLabel.Location = new System.Drawing.Point(16, 152);
            account_fullnameLabel.Name = "account_fullnameLabel";
            account_fullnameLabel.Size = new System.Drawing.Size(79, 13);
            account_fullnameLabel.TabIndex = 33;
            account_fullnameLabel.Text = "Введите ФИО";
            // 
            // account_fullnameTextBox
            // 
            this.account_fullnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "account_fullname", true));
            this.account_fullnameTextBox.Location = new System.Drawing.Point(16, 168);
            this.account_fullnameTextBox.Name = "account_fullnameTextBox";
            this.account_fullnameTextBox.Size = new System.Drawing.Size(272, 20);
            this.account_fullnameTextBox.TabIndex = 34;
            // 
            // account_passwordLabel
            // 
            account_passwordLabel.AutoSize = true;
            account_passwordLabel.Location = new System.Drawing.Point(16, 104);
            account_passwordLabel.Name = "account_passwordLabel";
            account_passwordLabel.Size = new System.Drawing.Size(108, 13);
            account_passwordLabel.TabIndex = 30;
            account_passwordLabel.Text = "Придумайте пароль";
            // 
            // account_passwordTextBox
            // 
            this.account_passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "account_password", true));
            this.account_passwordTextBox.Location = new System.Drawing.Point(16, 120);
            this.account_passwordTextBox.Name = "account_passwordTextBox";
            this.account_passwordTextBox.Size = new System.Drawing.Size(272, 20);
            this.account_passwordTextBox.TabIndex = 32;
            // 
            // account_loginLabel
            // 
            account_loginLabel.AutoSize = true;
            account_loginLabel.Location = new System.Drawing.Point(16, 56);
            account_loginLabel.Name = "account_loginLabel";
            account_loginLabel.Size = new System.Drawing.Size(101, 13);
            account_loginLabel.TabIndex = 29;
            account_loginLabel.Text = "Придумайте логин";
            // 
            // account_loginTextBox
            // 
            this.account_loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "account_login", true));
            this.account_loginTextBox.Location = new System.Drawing.Point(16, 72);
            this.account_loginTextBox.Name = "account_loginTextBox";
            this.account_loginTextBox.Size = new System.Drawing.Size(272, 20);
            this.account_loginTextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 40);
            this.label1.TabIndex = 28;
            this.label1.Text = "Здарова, падаван";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.oOO_INFOTEXDataSet;
            // 
            // oOO_INFOTEXDataSet
            // 
            this.oOO_INFOTEXDataSet.DataSetName = "OOO_INFOTEXDataSet";
            this.oOO_INFOTEXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.account_typesTableAdapter = null;
            this.tableAdapterManager.AccountsTableAdapter = this.accountsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.device_typesTableAdapter = null;
            this.tableAdapterManager.mulfunction_typesTableAdapter = null;
            this.tableAdapterManager.order_mulfunctionsTableAdapter = null;
            this.tableAdapterManager.order_partsTableAdapter = null;
            this.tableAdapterManager.order_statusesTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = INFOTEX_SUPER.OOO_INFOTEXDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 297);
            this.Controls.Add(account_type_numberLabel);
            this.Controls.Add(this.account_type_numberTextBox);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.account_phone_numberTextBox);
            this.Controls.Add(account_phone_numberLabel);
            this.Controls.Add(account_fullnameLabel);
            this.Controls.Add(this.account_fullnameTextBox);
            this.Controls.Add(account_passwordLabel);
            this.Controls.Add(this.account_passwordTextBox);
            this.Controls.Add(account_loginLabel);
            this.Controls.Add(this.account_loginTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOO_INFOTEXDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox account_type_numberTextBox;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.MaskedTextBox account_phone_numberTextBox;
        private System.Windows.Forms.TextBox account_fullnameTextBox;
        private System.Windows.Forms.TextBox account_passwordTextBox;
        private System.Windows.Forms.TextBox account_loginTextBox;
        private System.Windows.Forms.Label label1;
        private OOO_INFOTEXDataSet oOO_INFOTEXDataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private OOO_INFOTEXDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private OOO_INFOTEXDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}