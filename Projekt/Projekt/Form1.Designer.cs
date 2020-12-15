namespace Projekt
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Betegseg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vezeteknevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keresztnevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csoportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyerekekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyerekekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Betöltés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vezeteknevDataGridViewTextBoxColumn,
            this.keresztnevDataGridViewTextBoxColumn,
            this.korDataGridViewTextBoxColumn,
            this.csoportDataGridViewTextBoxColumn,
            this.Betegseg});
            this.dataGridView1.DataSource = this.gyerekekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 155);
            this.dataGridView1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Betegseg
            // 
            this.Betegseg.DataPropertyName = "Betegseg";
            this.Betegseg.HeaderText = "Betegseg";
            this.Betegseg.Name = "Betegseg";
            // 
            // vezeteknevDataGridViewTextBoxColumn
            // 
            this.vezeteknevDataGridViewTextBoxColumn.DataPropertyName = "Vezeteknev";
            this.vezeteknevDataGridViewTextBoxColumn.HeaderText = "Vezeteknev";
            this.vezeteknevDataGridViewTextBoxColumn.Name = "vezeteknevDataGridViewTextBoxColumn";
            // 
            // keresztnevDataGridViewTextBoxColumn
            // 
            this.keresztnevDataGridViewTextBoxColumn.DataPropertyName = "Keresztnev";
            this.keresztnevDataGridViewTextBoxColumn.HeaderText = "Keresztnev";
            this.keresztnevDataGridViewTextBoxColumn.Name = "keresztnevDataGridViewTextBoxColumn";
            // 
            // korDataGridViewTextBoxColumn
            // 
            this.korDataGridViewTextBoxColumn.DataPropertyName = "Kor";
            this.korDataGridViewTextBoxColumn.HeaderText = "Kor";
            this.korDataGridViewTextBoxColumn.Name = "korDataGridViewTextBoxColumn";
            // 
            // csoportDataGridViewTextBoxColumn
            // 
            this.csoportDataGridViewTextBoxColumn.DataPropertyName = "Csoport";
            this.csoportDataGridViewTextBoxColumn.HeaderText = "Csoport";
            this.csoportDataGridViewTextBoxColumn.Name = "csoportDataGridViewTextBoxColumn";
            // 
            // gyerekekBindingSource
            // 
            this.gyerekekBindingSource.DataSource = typeof(Projekt.Gyerekek);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(564, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyerekekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn betegségDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource gyerekekBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn vezeteknevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keresztnevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn csoportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Betegseg;
        private System.Windows.Forms.Button button4;
    }
}

