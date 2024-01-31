namespace CALCULATOR
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
            button1 = new Button();
            button10 = new Button();
            textBox1 = new TextBox();
            button13 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button14 = new Button();
            button11 = new Button();
            button12 = new Button();
            button17 = new Button();
            button15 = new Button();
            error = new Label();
            button18 = new Button();
            button16 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(8, 241);
            button1.Name = "button1";
            button1.Size = new Size(92, 55);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += digit_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button10.Location = new Point(446, 12);
            button10.Name = "button10";
            button10.Size = new Size(126, 48);
            button10.TabIndex = 10;
            button10.Text = "CLEAR";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Clear_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(8, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(432, 99);
            textBox1.TabIndex = 11;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button13.Location = new Point(446, 119);
            button13.Name = "button13";
            button13.Size = new Size(128, 55);
            button13.TabIndex = 14;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Action_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(106, 302);
            button2.Name = "button2";
            button2.Size = new Size(92, 55);
            button2.TabIndex = 16;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = true;
            button2.Click += digit_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(106, 241);
            button3.Name = "button3";
            button3.Size = new Size(92, 55);
            button3.TabIndex = 17;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += digit_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(204, 241);
            button4.Name = "button4";
            button4.Size = new Size(92, 55);
            button4.TabIndex = 18;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += digit_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.Location = new Point(204, 180);
            button5.Name = "button5";
            button5.Size = new Size(92, 55);
            button5.TabIndex = 21;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = true;
            button5.Click += digit_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.Location = new Point(106, 180);
            button6.Name = "button6";
            button6.Size = new Size(92, 55);
            button6.TabIndex = 20;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += digit_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(8, 180);
            button7.Name = "button7";
            button7.Size = new Size(92, 55);
            button7.TabIndex = 19;
            button7.Text = "4";
            button7.UseVisualStyleBackColor = true;
            button7.Click += digit_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button8.Location = new Point(204, 119);
            button8.Name = "button8";
            button8.Size = new Size(92, 55);
            button8.TabIndex = 24;
            button8.Text = "9";
            button8.UseVisualStyleBackColor = true;
            button8.Click += digit_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(106, 119);
            button9.Name = "button9";
            button9.Size = new Size(92, 55);
            button9.TabIndex = 23;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += digit_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button14.Location = new Point(8, 119);
            button14.Name = "button14";
            button14.Size = new Size(92, 55);
            button14.TabIndex = 22;
            button14.Text = "7";
            button14.UseVisualStyleBackColor = true;
            button14.Click += digit_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button11.Location = new Point(312, 180);
            button11.Name = "button11";
            button11.Size = new Size(128, 55);
            button11.TabIndex = 25;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Action_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button12.Location = new Point(446, 182);
            button12.Name = "button12";
            button12.Size = new Size(128, 55);
            button12.TabIndex = 26;
            button12.Text = "+";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Action_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button17.Location = new Point(204, 302);
            button17.Name = "button17";
            button17.Size = new Size(92, 55);
            button17.TabIndex = 29;
            button17.Text = ",";
            button17.UseVisualStyleBackColor = true;
            button17.Click += point_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button15.Location = new Point(312, 304);
            button15.Name = "button15";
            button15.Size = new Size(262, 53);
            button15.TabIndex = 30;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = true;
            button15.Click += sum_Click;
            // 
            // error
            // 
            error.AutoSize = true;
            error.BackColor = SystemColors.Control;
            error.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            error.ForeColor = Color.Red;
            error.Location = new Point(12, 80);
            error.Name = "error";
            error.Size = new Size(0, 17);
            error.TabIndex = 31;
            // 
            // button18
            // 
            button18.Font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button18.Location = new Point(448, 63);
            button18.Name = "button18";
            button18.Size = new Size(126, 48);
            button18.TabIndex = 32;
            button18.Text = "DEL";
            button18.UseVisualStyleBackColor = true;
            button18.Click += DEL_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button16.Location = new Point(312, 243);
            button16.Name = "button16";
            button16.Size = new Size(128, 55);
            button16.TabIndex = 28;
            button16.Text = "+/-";
            button16.UseVisualStyleBackColor = true;
            button16.Click += change_p;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button19.Location = new Point(312, 119);
            button19.Name = "button19";
            button19.Size = new Size(128, 55);
            button19.TabIndex = 33;
            button19.Text = "/";
            button19.UseVisualStyleBackColor = true;
            button19.Click += Action_Click;
            // 
            // button20
            // 
            button20.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button20.Location = new Point(8, 302);
            button20.Name = "button20";
            button20.Size = new Size(92, 55);
            button20.TabIndex = 34;
            button20.Text = "00";
            button20.UseVisualStyleBackColor = true;
            button20.Click += digit_Click;
            // 
            // button21
            // 
            button21.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button21.Location = new Point(446, 243);
            button21.Name = "button21";
            button21.Size = new Size(128, 55);
            button21.TabIndex = 35;
            button21.Text = "%";
            button21.UseVisualStyleBackColor = true;
            button21.Click += Action_Click;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(584, 381);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(error);
            Controls.Add(button15);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button14);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button13);
            Controls.Add(textBox1);
            Controls.Add(button10);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button10;
        private TextBox textBox1;
        private Button button13;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button14;
        private Button button11;
        private Button button12;
        private Button button17;
        private Button button15;
        private Label error;
        private Button button18;
        private Button button16;
        private Button button19;
        private Button button20;
        private Button button21;
    }
}
