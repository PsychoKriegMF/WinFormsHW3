namespace WinFormsHW3
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
            lstSource = new ListBox();
            lstDest = new ListBox();
            btnAddDest = new Button();
            btnAddDestAll = new Button();
            btnAddSource = new Button();
            btnAddSourceAll = new Button();
            btnClearDestAll = new Button();
            pbSource = new ProgressBar();
            pbDest = new ProgressBar();
            checkDell = new CheckBox();
            btnForm2 = new Button();
            SuspendLayout();
            // 
            // lstSource
            // 
            lstSource.FormattingEnabled = true;
            lstSource.ItemHeight = 15;
            lstSource.Items.AddRange(new object[] { "физика", "химия", "литература", "математика", "биология" });
            lstSource.Location = new Point(51, 27);
            lstSource.Name = "lstSource";
            lstSource.Size = new Size(130, 364);
            lstSource.TabIndex = 0;
            // 
            // lstDest
            // 
            lstDest.FormattingEnabled = true;
            lstDest.ItemHeight = 15;
            lstDest.Location = new Point(358, 27);
            lstDest.Name = "lstDest";
            lstDest.Size = new Size(130, 364);
            lstDest.TabIndex = 1;
            // 
            // btnAddDest
            // 
            btnAddDest.Location = new Point(234, 40);
            btnAddDest.Name = "btnAddDest";
            btnAddDest.Size = new Size(75, 23);
            btnAddDest.TabIndex = 2;
            btnAddDest.Text = "->";
            btnAddDest.UseVisualStyleBackColor = true;
            btnAddDest.Click += btnAddDest_Click;
            // 
            // btnAddDestAll
            // 
            btnAddDestAll.Location = new Point(234, 81);
            btnAddDestAll.Name = "btnAddDestAll";
            btnAddDestAll.Size = new Size(75, 23);
            btnAddDestAll.TabIndex = 3;
            btnAddDestAll.Text = "->>";
            btnAddDestAll.UseVisualStyleBackColor = true;
            btnAddDestAll.Click += btnAddDestAll_Click;
            // 
            // btnAddSource
            // 
            btnAddSource.Location = new Point(234, 158);
            btnAddSource.Name = "btnAddSource";
            btnAddSource.Size = new Size(75, 23);
            btnAddSource.TabIndex = 4;
            btnAddSource.Text = "<-";
            btnAddSource.UseVisualStyleBackColor = true;
            btnAddSource.Click += btnAddSource_Click;
            // 
            // btnAddSourceAll
            // 
            btnAddSourceAll.Location = new Point(234, 200);
            btnAddSourceAll.Name = "btnAddSourceAll";
            btnAddSourceAll.Size = new Size(75, 23);
            btnAddSourceAll.TabIndex = 5;
            btnAddSourceAll.Text = "<<-";
            btnAddSourceAll.UseVisualStyleBackColor = true;
            btnAddSourceAll.Click += btnAddSourceAll_Click;
            // 
            // btnClearDestAll
            // 
            btnClearDestAll.Location = new Point(234, 346);
            btnClearDestAll.Name = "btnClearDestAll";
            btnClearDestAll.Size = new Size(75, 23);
            btnClearDestAll.TabIndex = 6;
            btnClearDestAll.Text = "Clear";
            btnClearDestAll.UseVisualStyleBackColor = true;
            btnClearDestAll.Click += btnClearDestAll_Click;
            // 
            // pbSource
            // 
            pbSource.Location = new Point(52, 402);
            pbSource.Name = "pbSource";
            pbSource.Size = new Size(129, 23);
            pbSource.TabIndex = 7;
            // 
            // pbDest
            // 
            pbDest.Location = new Point(358, 402);
            pbDest.Name = "pbDest";
            pbDest.Size = new Size(130, 23);
            pbDest.TabIndex = 8;
            // 
            // checkDell
            // 
            checkDell.AutoSize = true;
            checkDell.Location = new Point(523, 27);
            checkDell.Name = "checkDell";
            checkDell.Size = new Size(145, 19);
            checkDell.TabIndex = 9;
            checkDell.Text = "Удалять из источника";
            checkDell.UseVisualStyleBackColor = true;
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(523, 90);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(222, 23);
            btnForm2.TabIndex = 10;
            btnForm2.Text = "Вторая часть ДЗ";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForm2);
            Controls.Add(checkDell);
            Controls.Add(pbDest);
            Controls.Add(pbSource);
            Controls.Add(btnClearDestAll);
            Controls.Add(btnAddSourceAll);
            Controls.Add(btnAddSource);
            Controls.Add(btnAddDestAll);
            Controls.Add(btnAddDest);
            Controls.Add(lstDest);
            Controls.Add(lstSource);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSource;
        private ListBox lstDest;
        private Button btnAddDest;
        private Button btnAddDestAll;
        private Button btnAddSource;
        private Button btnAddSourceAll;
        private Button btnClearDestAll;
        private ProgressBar pbSource;
        private ProgressBar pbDest;
        private CheckBox checkDell;
        private Button btnForm2;
    }
}
