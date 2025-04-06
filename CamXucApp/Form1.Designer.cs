namespace CamXucApp
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            lblPositive = new Label();
            lblNagative = new Label();
            txtReview = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 31);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập review của khách hàng:";
            // 
            // button1
            // 
            button1.Location = new Point(45, 118);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 2;
            button1.Text = "Xem kết quả";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 159);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Kết quả:";
            // 
            // lblPositive
            // 
            lblPositive.AutoSize = true;
            lblPositive.Location = new Point(149, 190);
            lblPositive.Name = "lblPositive";
            lblPositive.Size = new Size(261, 20);
            lblPositive.TabIndex = 4;
            lblPositive.Text = "                                                               ";
            lblPositive.Click += lblPositive_Click;
            // 
            // lblNagative
            // 
            lblNagative.AutoSize = true;
            lblNagative.Location = new Point(149, 224);
            lblNagative.Name = "lblNagative";
            lblNagative.Size = new Size(221, 20);
            lblNagative.TabIndex = 5;
            lblNagative.Text = "                                                     ";
            lblNagative.Click += lblNagative_Click;
            // 
            // txtReview
            // 
            txtReview.Location = new Point(45, 69);
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(365, 27);
            txtReview.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 344);
            Controls.Add(txtReview);
            Controls.Add(lblNagative);
            Controls.Add(lblPositive);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label lblPositive;
        private Label lblNagative;
        private TextBox txtReview;
    }
}
