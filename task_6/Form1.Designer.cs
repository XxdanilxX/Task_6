namespace task_6
{
    partial class frmMass
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
            label2 = new Label();
            label3 = new Label();
            dgvMass = new DataGridView();
            txtn = new TextBox();
            txtm = new TextBox();
            txtRez = new TextBox();
            cmdStart = new Button();
            cmdExit = new Button();
            cmdClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 0;
            label1.Text = "Количество строк n=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 164);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(248, 28);
            label2.TabIndex = 1;
            label2.Text = "Количество столбцов m=";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 269);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 2;
            label3.Text = "Результат:";
            // 
            // dgvMass
            // 
            dgvMass.AllowUserToOrderColumns = true;
            dgvMass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMass.Location = new Point(488, 91);
            dgvMass.Margin = new Padding(4);
            dgvMass.Name = "dgvMass";
            dgvMass.RowHeadersWidth = 51;
            dgvMass.RowTemplate.Height = 29;
            dgvMass.Size = new Size(575, 391);
            dgvMass.TabIndex = 3;
            // 
            // txtn
            // 
            txtn.Location = new Point(16, 91);
            txtn.Margin = new Padding(4);
            txtn.Name = "txtn";
            txtn.Size = new Size(217, 34);
            txtn.TabIndex = 4;
            // 
            // txtm
            // 
            txtm.Location = new Point(16, 196);
            txtm.Margin = new Padding(4);
            txtm.Name = "txtm";
            txtm.Size = new Size(217, 34);
            txtm.TabIndex = 5;
            // 
            // txtRez
            // 
            txtRez.Location = new Point(16, 301);
            txtRez.Margin = new Padding(4);
            txtRez.Multiline = true;
            txtRez.Name = "txtRez";
            txtRez.Size = new Size(436, 179);
            txtRez.TabIndex = 6;
            // 
            // cmdStart
            // 
            cmdStart.Location = new Point(16, 533);
            cmdStart.Margin = new Padding(4);
            cmdStart.Name = "cmdStart";
            cmdStart.Size = new Size(177, 59);
            cmdStart.TabIndex = 7;
            cmdStart.Text = "Вычислить";
            cmdStart.UseVisualStyleBackColor = true;
            cmdStart.Click += button1_Click;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(874, 533);
            cmdExit.Margin = new Padding(4);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(189, 59);
            cmdExit.TabIndex = 8;
            cmdExit.Text = "Завершить работу";
            cmdExit.UseVisualStyleBackColor = true;
            cmdExit.Click += button2_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(442, 533);
            cmdClear.Margin = new Padding(4);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(188, 59);
            cmdClear.TabIndex = 9;
            cmdClear.Text = "Очистка полей";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += button3_Click;
            // 
            // frmMass
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(cmdClear);
            Controls.Add(cmdExit);
            Controls.Add(cmdStart);
            Controls.Add(txtRez);
            Controls.Add(txtm);
            Controls.Add(txtn);
            Controls.Add(dgvMass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmMass";
            Text = "Двумерные массивы";
            ((System.ComponentModel.ISupportInitialize)dgvMass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvMass;
        private TextBox txtn;
        private TextBox txtm;
        private TextBox txtRez;
        private Button cmdStart;
        private Button cmdExit;
        private Button cmdClear;
    }
}