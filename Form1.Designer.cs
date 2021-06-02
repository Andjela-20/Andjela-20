
namespace projekat1
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_gore = new System.Windows.Forms.Button();
            this.btn_levo = new System.Windows.Forms.Button();
            this.btn_desno = new System.Windows.Forms.Button();
            this.btn_dole = new System.Windows.Forms.Button();
            this.btn_pokret = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_object = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 650);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "START";
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_gore
            // 
            this.btn_gore.Location = new System.Drawing.Point(1237, 531);
            this.btn_gore.Name = "btn_gore";
            this.btn_gore.Size = new System.Drawing.Size(75, 64);
            this.btn_gore.TabIndex = 1;
            this.btn_gore.Text = "GORE";
            this.btn_gore.UseVisualStyleBackColor = true;
            this.btn_gore.Click += new System.EventHandler(this.btn_gore_Click);
            // 
            // btn_levo
            // 
            this.btn_levo.Location = new System.Drawing.Point(1188, 601);
            this.btn_levo.Name = "btn_levo";
            this.btn_levo.Size = new System.Drawing.Size(71, 64);
            this.btn_levo.TabIndex = 2;
            this.btn_levo.Text = "LEVO";
            this.btn_levo.UseVisualStyleBackColor = true;
            this.btn_levo.Click += new System.EventHandler(this.btn_levo_Click);
            // 
            // btn_desno
            // 
            this.btn_desno.Location = new System.Drawing.Point(1283, 601);
            this.btn_desno.Name = "btn_desno";
            this.btn_desno.Size = new System.Drawing.Size(70, 64);
            this.btn_desno.TabIndex = 3;
            this.btn_desno.Text = "DESNO";
            this.btn_desno.UseVisualStyleBackColor = true;
            this.btn_desno.Click += new System.EventHandler(this.btn_desno_Click);
            // 
            // btn_dole
            // 
            this.btn_dole.Location = new System.Drawing.Point(1237, 671);
            this.btn_dole.Name = "btn_dole";
            this.btn_dole.Size = new System.Drawing.Size(75, 64);
            this.btn_dole.TabIndex = 4;
            this.btn_dole.Text = "DOLE";
            this.btn_dole.UseVisualStyleBackColor = true;
            this.btn_dole.Click += new System.EventHandler(this.btn_dole_Click);
            // 
            // btn_pokret
            // 
            this.btn_pokret.Location = new System.Drawing.Point(1221, 422);
            this.btn_pokret.Name = "btn_pokret";
            this.btn_pokret.Size = new System.Drawing.Size(106, 90);
            this.btn_pokret.TabIndex = 5;
            this.btn_pokret.Text = "KRENI\r\nSTANI";
            this.btn_pokret.UseVisualStyleBackColor = true;
            this.btn_pokret.Click += new System.EventHandler(this.btn_pokret_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1090, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "FINISH";
            // 
            // btn_object
            // 
            this.btn_object.Image = global::projekat1.Properties.Resources._102692302_black_balloon_vector_icon_balloon_with_shadow;
            this.btn_object.Location = new System.Drawing.Point(165, 666);
            this.btn_object.Name = "btn_object";
            this.btn_object.Size = new System.Drawing.Size(63, 69);
            this.btn_object.TabIndex = 8;
            this.btn_object.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1475, 1055);
            this.Controls.Add(this.btn_object);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pokret);
            this.Controls.Add(this.btn_dole);
            this.Controls.Add(this.btn_desno);
            this.Controls.Add(this.btn_levo);
            this.Controls.Add(this.btn_gore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_gore;
        private System.Windows.Forms.Button btn_levo;
        private System.Windows.Forms.Button btn_desno;
        private System.Windows.Forms.Button btn_dole;
        private System.Windows.Forms.Button btn_pokret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_object;
    }
}

