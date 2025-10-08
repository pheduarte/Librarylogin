namespace Assessment1
{
    partial class StudentDashboard
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
            this.lableTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lableBookSearch = new System.Windows.Forms.Label();
            this.btnExplorer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lableTitle
            // 
            this.lableTitle.AutoSize = true;
            this.lableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTitle.Location = new System.Drawing.Point(12, 19);
            this.lableTitle.Name = "lableTitle";
            this.lableTitle.Size = new System.Drawing.Size(207, 46);
            this.lableTitle.TabIndex = 0;
            this.lableTitle.Text = "Welcome!";
            this.lableTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 50);
            this.label1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 600);
            this.panel1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(462, 175);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 31);
            this.textBox1.TabIndex = 4;
            // 
            // lableBookSearch
            // 
            this.lableBookSearch.AutoSize = true;
            this.lableBookSearch.Location = new System.Drawing.Point(15, 142);
            this.lableBookSearch.Name = "lableBookSearch";
            this.lableBookSearch.Size = new System.Drawing.Size(380, 50);
            this.lableBookSearch.TabIndex = 5;
            this.lableBookSearch.Text = "Type a book name";
            this.lableBookSearch.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnExplorer
            // 
            this.btnExplorer.Location = new System.Drawing.Point(1045, 172);
            this.btnExplorer.Name = "btnExplorer";
            this.btnExplorer.Size = new System.Drawing.Size(283, 45);
            this.btnExplorer.TabIndex = 6;
            this.btnExplorer.Text = "Explorer Books";
            this.btnExplorer.UseVisualStyleBackColor = true;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 879);
            this.Controls.Add(this.btnExplorer);
            this.Controls.Add(this.lableBookSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lableTitle);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lableBookSearch;
        private System.Windows.Forms.Button btnExplorer;
    }
}