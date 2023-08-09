namespace ClientServer
{
    partial class Home
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            btn_connect = new Button();
            btn_send_message = new Button();
            status = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(134, 22);
            label1.Name = "label1";
            label1.Size = new Size(168, 26);
            label1.TabIndex = 0;
            label1.Text = "ClientServer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 105);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite o IP ->";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 102);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ex. 127.0.0.1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 161);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ex. 8088";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 164);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 3;
            label3.Text = "Digite a porta ->";
            // 
            // btn_connect
            // 
            btn_connect.BackColor = Color.ForestGreen;
            btn_connect.Location = new Point(77, 284);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(75, 23);
            btn_connect.TabIndex = 5;
            btn_connect.Text = "Conectar";
            btn_connect.UseVisualStyleBackColor = false;
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_send_message
            // 
            btn_send_message.BackColor = Color.MidnightBlue;
            btn_send_message.Location = new Point(238, 284);
            btn_send_message.Name = "btn_send_message";
            btn_send_message.Size = new Size(126, 23);
            btn_send_message.TabIndex = 6;
            btn_send_message.Text = "Enviar mensagem";
            btn_send_message.UseVisualStyleBackColor = false;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(157, 380);
            status.Name = "status";
            status.Size = new Size(133, 15);
            status.TabIndex = 7;
            status.Text = "Status -> Desconectado";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(174, 430);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(435, 474);
            Controls.Add(button1);
            Controls.Add(status);
            Controls.Add(btn_send_message);
            Controls.Add(btn_connect);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button btn_connect;
        private Button btn_send_message;
        private Label status;
        private Button button1;
    }
}