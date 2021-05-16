
namespace mysql_crud
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picJoin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.picSend = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(161)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.picJoin);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 84);
            this.panel1.TabIndex = 0;
            // 
            // picJoin
            // 
            this.picJoin.Image = global::mysql_crud.Properties.Resources.joinbtn;
            this.picJoin.Location = new System.Drawing.Point(600, 31);
            this.picJoin.Name = "picJoin";
            this.picJoin.Size = new System.Drawing.Size(68, 32);
            this.picJoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picJoin.TabIndex = 7;
            this.picJoin.TabStop = false;
            this.picJoin.Click += new System.EventHandler(this.picJoin_Click);
            // 
            // picClose
            // 
            this.picClose.Image = global::mysql_crud.Properties.Resources.exit;
            this.picClose.Location = new System.Drawing.Point(686, 31);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(67, 32);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 6;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbUserName.Location = new System.Drawing.Point(184, 29);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(267, 36);
            this.tbUserName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter name:";
            // 
            // tbChat
            // 
            this.tbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbChat.Location = new System.Drawing.Point(12, 118);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(776, 291);
            this.tbChat.TabIndex = 1;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 415);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(659, 62);
            this.tbMessage.TabIndex = 3;
            // 
            // picSend
            // 
            this.picSend.Image = global::mysql_crud.Properties.Resources.paper_plane;
            this.picSend.Location = new System.Drawing.Point(677, 415);
            this.picSend.Name = "picSend";
            this.picSend.Size = new System.Drawing.Size(111, 62);
            this.picSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSend.TabIndex = 4;
            this.picSend.TabStop = false;
            this.picSend.Click += new System.EventHandler(this.picSend_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.picSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbChat);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.Text = "Chat with user";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.PictureBox picSend;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picJoin;
    }
}