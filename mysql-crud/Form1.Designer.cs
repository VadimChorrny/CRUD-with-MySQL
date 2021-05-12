
namespace mysql_crud
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCreateFullName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCreatePrice = new System.Windows.Forms.TextBox();
            this.txtCreateDescribes = new System.Windows.Forms.TextBox();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.u_txtFullName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnApdate = new System.Windows.Forms.Button();
            this.u_txtPrice = new System.Windows.Forms.TextBox();
            this.IDTXT = new System.Windows.Forms.Label();
            this.u_txtDescribes = new System.Windows.Forms.TextBox();
            this.u_txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.c_btnOpenImage = new System.Windows.Forms.Button();
            this.u_btnOpenImage = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.c_btnOpenImage);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCreateFullName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtCreatePrice);
            this.groupBox1.Controls.Add(this.txtCreateDescribes);
            this.groupBox1.Controls.Add(this.txtCreateName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // txtCreateFullName
            // 
            this.txtCreateFullName.Location = new System.Drawing.Point(113, 115);
            this.txtCreateFullName.Name = "txtCreateFullName";
            this.txtCreateFullName.Size = new System.Drawing.Size(262, 22);
            this.txtCreateFullName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "FULLNAME:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(254, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCreatePrice
            // 
            this.txtCreatePrice.Location = new System.Drawing.Point(113, 85);
            this.txtCreatePrice.Name = "txtCreatePrice";
            this.txtCreatePrice.Size = new System.Drawing.Size(262, 22);
            this.txtCreatePrice.TabIndex = 7;
            // 
            // txtCreateDescribes
            // 
            this.txtCreateDescribes.Location = new System.Drawing.Point(113, 57);
            this.txtCreateDescribes.Name = "txtCreateDescribes";
            this.txtCreateDescribes.Size = new System.Drawing.Size(262, 22);
            this.txtCreateDescribes.TabIndex = 6;
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(113, 29);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(262, 22);
            this.txtCreateName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRICE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESCRIBES:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAME:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(803, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 428);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read/Viewing data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(467, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.u_btnOpenImage);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.u_txtFullName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnApdate);
            this.groupBox3.Controls.Add(this.u_txtPrice);
            this.groupBox3.Controls.Add(this.IDTXT);
            this.groupBox3.Controls.Add(this.u_txtDescribes);
            this.groupBox3.Controls.Add(this.u_txtName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(432, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 229);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update/Delete";
            // 
            // u_txtFullName
            // 
            this.u_txtFullName.Location = new System.Drawing.Point(97, 115);
            this.u_txtFullName.Name = "u_txtFullName";
            this.u_txtFullName.Size = new System.Drawing.Size(262, 22);
            this.u_txtFullName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "FULLNAME:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(238, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 31);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnApdate
            // 
            this.btnApdate.Location = new System.Drawing.Point(6, 192);
            this.btnApdate.Name = "btnApdate";
            this.btnApdate.Size = new System.Drawing.Size(121, 31);
            this.btnApdate.TabIndex = 9;
            this.btnApdate.Text = "Update";
            this.btnApdate.UseVisualStyleBackColor = true;
            this.btnApdate.Click += new System.EventHandler(this.btnApdate_Click);
            // 
            // u_txtPrice
            // 
            this.u_txtPrice.Location = new System.Drawing.Point(97, 88);
            this.u_txtPrice.Name = "u_txtPrice";
            this.u_txtPrice.Size = new System.Drawing.Size(262, 22);
            this.u_txtPrice.TabIndex = 10;
            // 
            // IDTXT
            // 
            this.IDTXT.AutoSize = true;
            this.IDTXT.Location = new System.Drawing.Point(133, 12);
            this.IDTXT.Name = "IDTXT";
            this.IDTXT.Size = new System.Drawing.Size(19, 17);
            this.IDTXT.TabIndex = 8;
            this.IDTXT.Text = "id";
            // 
            // u_txtDescribes
            // 
            this.u_txtDescribes.Location = new System.Drawing.Point(97, 60);
            this.u_txtDescribes.Name = "u_txtDescribes";
            this.u_txtDescribes.Size = new System.Drawing.Size(262, 22);
            this.u_txtDescribes.TabIndex = 9;
            // 
            // u_txtName
            // 
            this.u_txtName.Location = new System.Drawing.Point(97, 32);
            this.u_txtName.Name = "u_txtName";
            this.u_txtName.Size = new System.Drawing.Size(262, 22);
            this.u_txtName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "PRICE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "NAME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "DESCRIBES:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "IMAGE";
            // 
            // c_btnOpenImage
            // 
            this.c_btnOpenImage.Location = new System.Drawing.Point(113, 143);
            this.c_btnOpenImage.Name = "c_btnOpenImage";
            this.c_btnOpenImage.Size = new System.Drawing.Size(262, 32);
            this.c_btnOpenImage.TabIndex = 12;
            this.c_btnOpenImage.Text = "Choose image...";
            this.c_btnOpenImage.UseVisualStyleBackColor = true;
            this.c_btnOpenImage.Click += new System.EventHandler(this.c_btnOpenImage_Click);
            // 
            // u_btnOpenImage
            // 
            this.u_btnOpenImage.Location = new System.Drawing.Point(97, 147);
            this.u_btnOpenImage.Name = "u_btnOpenImage";
            this.u_btnOpenImage.Size = new System.Drawing.Size(262, 32);
            this.u_btnOpenImage.TabIndex = 14;
            this.u_btnOpenImage.Text = "Choose image...";
            this.u_btnOpenImage.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "IMAGE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 182);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label IDTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCreatePrice;
        private System.Windows.Forms.TextBox txtCreateDescribes;
        private System.Windows.Forms.TextBox txtCreateName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnApdate;
        private System.Windows.Forms.TextBox u_txtPrice;
        private System.Windows.Forms.TextBox u_txtDescribes;
        private System.Windows.Forms.TextBox u_txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        protected internal System.Windows.Forms.TextBox txtCreateFullName;
        protected internal System.Windows.Forms.TextBox u_txtFullName;
        private System.Windows.Forms.Button c_btnOpenImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button u_btnOpenImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

