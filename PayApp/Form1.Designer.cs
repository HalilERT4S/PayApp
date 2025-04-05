namespace PayApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblPaymentMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            btnMakePayment = new Button();
            lblPaymentStatus = new Label();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPaymentMethod.Location = new Point(41, 180);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(130, 20);
            lblPaymentMethod.TabIndex = 0;
            lblPaymentMethod.Text = "Payment Method";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Please select your payment method" });
            cmbPaymentMethod.Location = new Point(191, 172);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(306, 28);
            cmbPaymentMethod.TabIndex = 1;
            cmbPaymentMethod.Tag = "";
            cmbPaymentMethod.SelectedIndexChanged += cmbPaymentMethod_SelectedIndexChanged;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAmount.Location = new Point(41, 240);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(67, 20);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(191, 233);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Please enter the payment amount.";
            txtAmount.Size = new Size(306, 27);
            txtAmount.TabIndex = 3;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // btnMakePayment
            // 
            btnMakePayment.FlatAppearance.BorderSize = 2;
            btnMakePayment.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnMakePayment.Location = new Point(353, 315);
            btnMakePayment.Name = "btnMakePayment";
            btnMakePayment.Size = new Size(144, 41);
            btnMakePayment.TabIndex = 4;
            btnMakePayment.Text = "Make Payment";
            btnMakePayment.UseVisualStyleBackColor = true;
            btnMakePayment.Click += btnMakePayment_Click;
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.BackColor = Color.Transparent;
            lblPaymentStatus.Font = new Font("Segoe UI", 12F);
            lblPaymentStatus.ForeColor = Color.Green;
            lblPaymentStatus.Location = new Point(161, 412);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(0, 28);
            lblPaymentStatus.TabIndex = 5;
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = (Image)resources.GetObject("pbLogo.BackgroundImage");
            pbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogo.Location = new Point(551, 180);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(463, 162);
            pbLogo.TabIndex = 6;
            pbLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1040, 555);
            Controls.Add(pbLogo);
            Controls.Add(lblPaymentStatus);
            Controls.Add(btnMakePayment);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(lblPaymentMethod);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPaymentMethod;
        private ComboBox cmbPaymentMethod;
        private Label lblAmount;
        private TextBox txtAmount;
        private Button btnMakePayment;
        private Label lblPaymentStatus;
        private PictureBox pbLogo;
    }
}
