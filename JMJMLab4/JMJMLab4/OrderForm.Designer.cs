namespace JMJMLab4
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReadOrders = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grand Total:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrandTotal.Location = new System.Drawing.Point(510, 165);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(162, 36);
            this.lblGrandTotal.TabIndex = 2;
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(266, 22);
            this.txtName.TabIndex = 3;
            // 
            // lstOrders
            // 
            this.lstOrders.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 16;
            this.lstOrders.Location = new System.Drawing.Point(21, 75);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(369, 260);
            this.lstOrders.TabIndex = 4;
            this.lstOrders.TabStop = false;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(21, 369);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(121, 55);
            this.btnAddOrder.TabIndex = 5;
            this.btnAddOrder.Text = "&Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(194, 369);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 55);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnReadOrders
            // 
            this.btnReadOrders.Location = new System.Drawing.Point(367, 369);
            this.btnReadOrders.Name = "btnReadOrders";
            this.btnReadOrders.Size = new System.Drawing.Size(121, 55);
            this.btnReadOrders.TabIndex = 7;
            this.btnReadOrders.Text = "&Read Orders";
            this.btnReadOrders.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(540, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 55);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // cbo
            // 
            this.cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(414, 75);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(258, 24);
            this.cbo.TabIndex = 9;
            this.cbo.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadOrders);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders by Jonah Martin & Jon McNamee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReadOrders;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbo;
    }
}

