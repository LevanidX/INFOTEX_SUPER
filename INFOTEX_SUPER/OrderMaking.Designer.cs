namespace INFOTEX_SUPER
{
    partial class OrderMaking
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
            System.Windows.Forms.Label order_date_addLabel;
            System.Windows.Forms.Label order_device_typeLabel;
            System.Windows.Forms.Label order_device_nameLabel;
            System.Windows.Forms.Label order_problem_textLabel;
            System.Windows.Forms.Label order_status_numberLabel;
            System.Windows.Forms.Label order_client_numberLabel;
            this.oOO_INFOTEXDataSet = new INFOTEX_SUPER.OOO_INFOTEXDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new INFOTEX_SUPER.OOO_INFOTEXDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new INFOTEX_SUPER.OOO_INFOTEXDataSetTableAdapters.TableAdapterManager();
            this.order_date_addDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_device_nameTextBox = new System.Windows.Forms.TextBox();
            this.order_problem_textTextBox = new System.Windows.Forms.TextBox();
            this.order_status_numberTextBox = new System.Windows.Forms.TextBox();
            this.order_client_numberTextBox = new System.Windows.Forms.TextBox();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.order_device_typeTextBox = new System.Windows.Forms.ComboBox();
            this.devicetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.device_typesTableAdapter = new INFOTEX_SUPER.OOO_INFOTEXDataSetTableAdapters.device_typesTableAdapter();
            order_date_addLabel = new System.Windows.Forms.Label();
            order_device_typeLabel = new System.Windows.Forms.Label();
            order_device_nameLabel = new System.Windows.Forms.Label();
            order_problem_textLabel = new System.Windows.Forms.Label();
            order_status_numberLabel = new System.Windows.Forms.Label();
            order_client_numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oOO_INFOTEXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicetypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oOO_INFOTEXDataSet
            // 
            this.oOO_INFOTEXDataSet.DataSetName = "OOO_INFOTEXDataSet";
            this.oOO_INFOTEXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.oOO_INFOTEXDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.account_typesTableAdapter = null;
            this.tableAdapterManager.AccountsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.device_typesTableAdapter = this.device_typesTableAdapter;
            this.tableAdapterManager.mulfunction_typesTableAdapter = null;
            this.tableAdapterManager.order_mulfunctionsTableAdapter = null;
            this.tableAdapterManager.order_partsTableAdapter = null;
            this.tableAdapterManager.order_statusesTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = INFOTEX_SUPER.OOO_INFOTEXDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // order_date_addLabel
            // 
            order_date_addLabel.AutoSize = true;
            order_date_addLabel.Location = new System.Drawing.Point(520, 116);
            order_date_addLabel.Name = "order_date_addLabel";
            order_date_addLabel.Size = new System.Drawing.Size(79, 13);
            order_date_addLabel.TabIndex = 1;
            order_date_addLabel.Text = "order date add:";
            // 
            // order_date_addDateTimePicker
            // 
            this.order_date_addDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "order_date_add", true));
            this.order_date_addDateTimePicker.Location = new System.Drawing.Point(608, 112);
            this.order_date_addDateTimePicker.Name = "order_date_addDateTimePicker";
            this.order_date_addDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.order_date_addDateTimePicker.TabIndex = 2;
            // 
            // order_device_typeLabel
            // 
            order_device_typeLabel.AutoSize = true;
            order_device_typeLabel.Location = new System.Drawing.Point(8, 8);
            order_device_typeLabel.Name = "order_device_typeLabel";
            order_device_typeLabel.Size = new System.Drawing.Size(86, 13);
            order_device_typeLabel.TabIndex = 5;
            order_device_typeLabel.Text = "Тип устройства";
            // 
            // order_device_nameLabel
            // 
            order_device_nameLabel.AutoSize = true;
            order_device_nameLabel.Location = new System.Drawing.Point(8, 56);
            order_device_nameLabel.Name = "order_device_nameLabel";
            order_device_nameLabel.Size = new System.Drawing.Size(143, 13);
            order_device_nameLabel.TabIndex = 7;
            order_device_nameLabel.Text = "Наименование устройства";
            // 
            // order_device_nameTextBox
            // 
            this.order_device_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_device_name", true));
            this.order_device_nameTextBox.Location = new System.Drawing.Point(8, 72);
            this.order_device_nameTextBox.Name = "order_device_nameTextBox";
            this.order_device_nameTextBox.Size = new System.Drawing.Size(264, 20);
            this.order_device_nameTextBox.TabIndex = 8;
            // 
            // order_problem_textLabel
            // 
            order_problem_textLabel.AutoSize = true;
            order_problem_textLabel.Location = new System.Drawing.Point(8, 104);
            order_problem_textLabel.Name = "order_problem_textLabel";
            order_problem_textLabel.Size = new System.Drawing.Size(112, 13);
            order_problem_textLabel.TabIndex = 9;
            order_problem_textLabel.Text = "Описание проблемы";
            // 
            // order_problem_textTextBox
            // 
            this.order_problem_textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_problem_text", true));
            this.order_problem_textTextBox.Location = new System.Drawing.Point(8, 120);
            this.order_problem_textTextBox.Multiline = true;
            this.order_problem_textTextBox.Name = "order_problem_textTextBox";
            this.order_problem_textTextBox.Size = new System.Drawing.Size(264, 88);
            this.order_problem_textTextBox.TabIndex = 10;
            // 
            // order_status_numberLabel
            // 
            order_status_numberLabel.AutoSize = true;
            order_status_numberLabel.Location = new System.Drawing.Point(664, 203);
            order_status_numberLabel.Name = "order_status_numberLabel";
            order_status_numberLabel.Size = new System.Drawing.Size(103, 13);
            order_status_numberLabel.TabIndex = 11;
            order_status_numberLabel.Text = "order status number:";
            // 
            // order_status_numberTextBox
            // 
            this.order_status_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_status_number", true));
            this.order_status_numberTextBox.Location = new System.Drawing.Point(776, 200);
            this.order_status_numberTextBox.Name = "order_status_numberTextBox";
            this.order_status_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.order_status_numberTextBox.TabIndex = 12;
            // 
            // order_client_numberLabel
            // 
            order_client_numberLabel.AutoSize = true;
            order_client_numberLabel.Location = new System.Drawing.Point(640, 75);
            order_client_numberLabel.Name = "order_client_numberLabel";
            order_client_numberLabel.Size = new System.Drawing.Size(100, 13);
            order_client_numberLabel.TabIndex = 13;
            order_client_numberLabel.Text = "order client number:";
            // 
            // order_client_numberTextBox
            // 
            this.order_client_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_client_number", true));
            this.order_client_numberTextBox.Location = new System.Drawing.Point(752, 72);
            this.order_client_numberTextBox.Name = "order_client_numberTextBox";
            this.order_client_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.order_client_numberTextBox.TabIndex = 14;
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(8, 216);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(264, 40);
            this.btnMakeOrder.TabIndex = 15;
            this.btnMakeOrder.Text = "Оформить";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // order_device_typeTextBox
            // 
            this.order_device_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "order_device_type", true));
            this.order_device_typeTextBox.DataSource = this.devicetypesBindingSource;
            this.order_device_typeTextBox.DisplayMember = "device_type_name";
            this.order_device_typeTextBox.FormattingEnabled = true;
            this.order_device_typeTextBox.Location = new System.Drawing.Point(8, 24);
            this.order_device_typeTextBox.Name = "order_device_typeTextBox";
            this.order_device_typeTextBox.Size = new System.Drawing.Size(264, 21);
            this.order_device_typeTextBox.TabIndex = 16;
            this.order_device_typeTextBox.ValueMember = "device_type_id";
            // 
            // devicetypesBindingSource
            // 
            this.devicetypesBindingSource.DataMember = "device_types";
            this.devicetypesBindingSource.DataSource = this.oOO_INFOTEXDataSet;
            // 
            // device_typesTableAdapter
            // 
            this.device_typesTableAdapter.ClearBeforeFill = true;
            // 
            // OrderMaking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 268);
            this.Controls.Add(this.order_device_typeTextBox);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(order_client_numberLabel);
            this.Controls.Add(this.order_client_numberTextBox);
            this.Controls.Add(order_status_numberLabel);
            this.Controls.Add(this.order_status_numberTextBox);
            this.Controls.Add(order_problem_textLabel);
            this.Controls.Add(this.order_problem_textTextBox);
            this.Controls.Add(order_device_nameLabel);
            this.Controls.Add(this.order_device_nameTextBox);
            this.Controls.Add(order_device_typeLabel);
            this.Controls.Add(order_date_addLabel);
            this.Controls.Add(this.order_date_addDateTimePicker);
            this.Name = "OrderMaking";
            this.Text = "OrderMaking";
            this.Load += new System.EventHandler(this.OrderMaking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oOO_INFOTEXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicetypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OOO_INFOTEXDataSet oOO_INFOTEXDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private OOO_INFOTEXDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private OOO_INFOTEXDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker order_date_addDateTimePicker;
        private System.Windows.Forms.TextBox order_device_nameTextBox;
        private System.Windows.Forms.TextBox order_problem_textTextBox;
        private System.Windows.Forms.TextBox order_status_numberTextBox;
        private System.Windows.Forms.TextBox order_client_numberTextBox;
        private System.Windows.Forms.Button btnMakeOrder;
        private OOO_INFOTEXDataSetTableAdapters.device_typesTableAdapter device_typesTableAdapter;
        private System.Windows.Forms.ComboBox order_device_typeTextBox;
        private System.Windows.Forms.BindingSource devicetypesBindingSource;
    }
}