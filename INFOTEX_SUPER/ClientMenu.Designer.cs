namespace INFOTEX_SUPER
{
    partial class ClientMenu
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
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(8, 8);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(176, 40);
            this.btnMakeOrder.TabIndex = 0;
            this.btnMakeOrder.Text = "Оформить заявку на ремонт компьютерной техники";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.Location = new System.Drawing.Point(8, 56);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(176, 40);
            this.btnMyOrders.TabIndex = 1;
            this.btnMyOrders.Text = "Мои заявки";
            this.btnMyOrders.UseVisualStyleBackColor = true;
            // 
            // ClientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.btnMyOrders);
            this.Controls.Add(this.btnMakeOrder);
            this.Name = "ClientMenu";
            this.Text = "ClientMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnMyOrders;
    }
}