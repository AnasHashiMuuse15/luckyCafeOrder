namespace LuckyCafeOrder
{
    partial class LuckyCafeOrder
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQUANTITY = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.rbTea = new System.Windows.Forms.RadioButton();
            this.rbCoffee = new System.Windows.Forms.RadioButton();
            this.rbJuice = new System.Windows.Forms.RadioButton();
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblLucky = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gpDrinkType = new System.Windows.Forms.GroupBox();
            this.gpCustomer = new System.Windows.Forms.GroupBox();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.gpDrinkType.SuspendLayout();
            this.gpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 53);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LuckyCafeOrder";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(52, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Customer Name:";
            // 
            // lblQUANTITY
            // 
            this.lblQUANTITY.AutoSize = true;
            this.lblQUANTITY.Location = new System.Drawing.Point(19, 382);
            this.lblQUANTITY.Name = "lblQUANTITY";
            this.lblQUANTITY.Size = new System.Drawing.Size(72, 20);
            this.lblQUANTITY.TabIndex = 2;
            this.lblQUANTITY.Text = "Quantity:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(401, 26);
            this.txtName.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(113, 382);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(79, 26);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // rbTea
            // 
            this.rbTea.AutoSize = true;
            this.rbTea.Location = new System.Drawing.Point(39, 39);
            this.rbTea.Name = "rbTea";
            this.rbTea.Size = new System.Drawing.Size(89, 24);
            this.rbTea.TabIndex = 5;
            this.rbTea.TabStop = true;
            this.rbTea.Text = "tea (1$)";
            this.rbTea.UseVisualStyleBackColor = true;
            // 
            // rbCoffee
            // 
            this.rbCoffee.AutoSize = true;
            this.rbCoffee.Location = new System.Drawing.Point(39, 81);
            this.rbCoffee.Name = "rbCoffee";
            this.rbCoffee.Size = new System.Drawing.Size(98, 24);
            this.rbCoffee.TabIndex = 6;
            this.rbCoffee.TabStop = true;
            this.rbCoffee.Text = "coffe(2$)";
            this.rbCoffee.UseVisualStyleBackColor = true;
            // 
            // rbJuice
            // 
            this.rbJuice.AutoSize = true;
            this.rbJuice.Location = new System.Drawing.Point(39, 125);
            this.rbJuice.Name = "rbJuice";
            this.rbJuice.Size = new System.Drawing.Size(94, 24);
            this.rbJuice.TabIndex = 7;
            this.rbJuice.TabStop = true;
            this.rbJuice.Text = "juice(3$)";
            this.rbJuice.UseVisualStyleBackColor = true;
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(235, 384);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.Size = new System.Drawing.Size(208, 24);
            this.chkStudent.TabIndex = 8;
            this.chkStudent.Text = "studentMember(10%off)";
            this.chkStudent.UseVisualStyleBackColor = true;
            this.chkStudent.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(65, 619);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(131, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total Price: $0.00";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblLucky
            // 
            this.lblLucky.AutoSize = true;
            this.lblLucky.Location = new System.Drawing.Point(65, 650);
            this.lblLucky.Name = "lblLucky";
            this.lblLucky.Size = new System.Drawing.Size(134, 20);
            this.lblLucky.TabIndex = 11;
            this.lblLucky.Text = "No prize this time.";
            this.lblLucky.Click += new System.EventHandler(this.lblLucky_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(81, 535);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(193, 58);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "calculate order";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(321, 533);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 60);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(564, 535);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(193, 58);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "load from file";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(796, 535);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(193, 58);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gpDrinkType
            // 
            this.gpDrinkType.Controls.Add(this.rbTea);
            this.gpDrinkType.Controls.Add(this.rbCoffee);
            this.gpDrinkType.Controls.Add(this.rbJuice);
            this.gpDrinkType.Location = new System.Drawing.Point(23, 167);
            this.gpDrinkType.Name = "gpDrinkType";
            this.gpDrinkType.Size = new System.Drawing.Size(401, 173);
            this.gpDrinkType.TabIndex = 16;
            this.gpDrinkType.TabStop = false;
            this.gpDrinkType.Text = "Drink Type";
            // 
            // gpCustomer
            // 
            this.gpCustomer.Controls.Add(this.gpDrinkType);
            this.gpCustomer.Controls.Add(this.txtName);
            this.gpCustomer.Controls.Add(this.lblName);
            this.gpCustomer.Controls.Add(this.lblQUANTITY);
            this.gpCustomer.Controls.Add(this.txtQuantity);
            this.gpCustomer.Controls.Add(this.chkStudent);
            this.gpCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpCustomer.Location = new System.Drawing.Point(19, 45);
            this.gpCustomer.Name = "gpCustomer";
            this.gpCustomer.Size = new System.Drawing.Size(470, 435);
            this.gpCustomer.TabIndex = 17;
            this.gpCustomer.TabStop = false;
            this.gpCustomer.Text = "Customer information";
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 20;
            this.lstOrders.Location = new System.Drawing.Point(549, 76);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(440, 404);
            this.lstOrders.TabIndex = 18;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // LuckyCafeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 711);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.gpCustomer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblLucky);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTitle);
            this.Name = "LuckyCafeOrder";
            this.Text = "LuckyCafeOrder";
            this.Load += new System.EventHandler(this.LuckyCafeOrder_Load);
            this.gpDrinkType.ResumeLayout(false);
            this.gpDrinkType.PerformLayout();
            this.gpCustomer.ResumeLayout(false);
            this.gpCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQUANTITY;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.RadioButton rbTea;
        private System.Windows.Forms.RadioButton rbCoffee;
        private System.Windows.Forms.RadioButton rbJuice;
        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblLucky;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gpDrinkType;
        private System.Windows.Forms.GroupBox gpCustomer;
        private System.Windows.Forms.ListBox lstOrders;
    }
}

