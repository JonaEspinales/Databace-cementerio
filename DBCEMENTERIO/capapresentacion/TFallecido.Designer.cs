
namespace capapresentacion
{
    partial class TFallecido
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
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.IDPANTEONN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFALLECIDOOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDADTRASLADADOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IDFALLECIDOO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPANTEON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSONAENVIADAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtper = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtorigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDFALLECIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSONAEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(772, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 30);
            this.button5.TabIndex = 41;
            this.button5.Text = "TIPOCONSTRUCCION";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPANTEONN,
            this.IDFALLECIDOOS,
            this.CANTIDADTRASLADADOS});
            this.dataGridView3.Location = new System.Drawing.Point(666, 252);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(342, 178);
            this.dataGridView3.TabIndex = 40;
            // 
            // IDPANTEONN
            // 
            this.IDPANTEONN.HeaderText = "IDPANTEONN";
            this.IDPANTEONN.Name = "IDPANTEONN";
            // 
            // IDFALLECIDOOS
            // 
            this.IDFALLECIDOOS.HeaderText = "IDFALLECIDOOS";
            this.IDFALLECIDOOS.Name = "IDFALLECIDOOS";
            // 
            // CANTIDADTRASLADADOS
            // 
            this.CANTIDADTRASLADADOS.HeaderText = "CANTIDADTRASLADADOS";
            this.CANTIDADTRASLADADOS.Name = "CANTIDADTRASLADADOS";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 30);
            this.button4.TabIndex = 39;
            this.button4.Text = "PANTEON";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFALLECIDOO,
            this.IDPANTEON,
            this.PERSONAENVIADAS});
            this.dataGridView2.Location = new System.Drawing.Point(292, 252);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 178);
            this.dataGridView2.TabIndex = 38;
            // 
            // IDFALLECIDOO
            // 
            this.IDFALLECIDOO.HeaderText = "IDFALLECIDOO";
            this.IDFALLECIDOO.Name = "IDFALLECIDOO";
            // 
            // IDPANTEON
            // 
            this.IDPANTEON.HeaderText = "IDPANTEON";
            this.IDPANTEON.Name = "IDPANTEON";
            // 
            // PERSONAENVIADAS
            // 
            this.PERSONAENVIADAS.HeaderText = "PERSONAENVIADAS";
            this.PERSONAENVIADAS.Name = "PERSONAENVIADAS";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 30);
            this.button3.TabIndex = 37;
            this.button3.Text = "TRANFERIR(NO)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 30);
            this.button2.TabIndex = 36;
            this.button2.Text = "CONSULTAR FALLECIDO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 35;
            this.button1.Text = "TRANSFERIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtper
            // 
            this.txtper.Location = new System.Drawing.Point(176, 145);
            this.txtper.Name = "txtper";
            this.txtper.Size = new System.Drawing.Size(104, 20);
            this.txtper.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "PERSONA ENTERRAR";
            // 
            // txtdestino
            // 
            this.txtdestino.Location = new System.Drawing.Point(176, 78);
            this.txtdestino.Name = "txtdestino";
            this.txtdestino.Size = new System.Drawing.Size(195, 20);
            this.txtdestino.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "CUENTA DESTINO";
            // 
            // txtorigen
            // 
            this.txtorigen.Location = new System.Drawing.Point(176, 20);
            this.txtorigen.Name = "txtorigen";
            this.txtorigen.Size = new System.Drawing.Size(195, 20);
            this.txtorigen.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "CUENTA ORIGEN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFALLECIDO,
            this.PERSONAEN});
            this.dataGridView1.Location = new System.Drawing.Point(33, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(236, 178);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDFALLECIDO
            // 
            this.IDFALLECIDO.HeaderText = "IDFALLECIDO";
            this.IDFALLECIDO.Name = "IDFALLECIDO";
            // 
            // PERSONAEN
            // 
            this.PERSONAEN.HeaderText = "PERSONAEN";
            this.PERSONAEN.Name = "PERSONAEN";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(844, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 42);
            this.button6.TabIndex = 42;
            this.button6.Text = "REGRESAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TFallecido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtorigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TFallecido";
            this.Text = "TFallecido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPANTEONN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFALLECIDOOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDADTRASLADADOS;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFALLECIDOO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPANTEON;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSONAENVIADAS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtorigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFALLECIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSONAEN;
        private System.Windows.Forms.Button button6;
    }
}