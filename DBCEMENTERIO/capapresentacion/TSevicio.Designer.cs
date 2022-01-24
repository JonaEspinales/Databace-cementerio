
namespace capapresentacion
{
    partial class TSevicio
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.IDSERVICIOPAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCUENTAPAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IDSERVICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORSERVICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOSERVICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtorigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDCUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSERVICIOPAGO,
            this.IDCUENTAPAGO,
            this.IMPORTE});
            this.dataGridView3.Location = new System.Drawing.Point(747, 255);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(329, 178);
            this.dataGridView3.TabIndex = 27;
            // 
            // IDSERVICIOPAGO
            // 
            this.IDSERVICIOPAGO.HeaderText = "IDSERVICIOPAGO";
            this.IDSERVICIOPAGO.Name = "IDSERVICIOPAGO";
            // 
            // IDCUENTAPAGO
            // 
            this.IDCUENTAPAGO.HeaderText = "IDCUENTAPAGO";
            this.IDCUENTAPAGO.Name = "IDCUENTAPAGO";
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSERVICIO,
            this.IDPAGO,
            this.VALORSERVICIO,
            this.TIPOSERVICIO});
            this.dataGridView2.Location = new System.Drawing.Point(283, 255);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(440, 178);
            this.dataGridView2.TabIndex = 26;
            // 
            // IDSERVICIO
            // 
            this.IDSERVICIO.HeaderText = "IDSERVICIO";
            this.IDSERVICIO.Name = "IDSERVICIO";
            // 
            // IDPAGO
            // 
            this.IDPAGO.HeaderText = "IDPAGO";
            this.IDPAGO.Name = "IDPAGO";
            // 
            // VALORSERVICIO
            // 
            this.VALORSERVICIO.HeaderText = "VALORSERVICIO";
            this.VALORSERVICIO.Name = "VALORSERVICIO";
            // 
            // TIPOSERVICIO
            // 
            this.TIPOSERVICIO.HeaderText = "TIPOSERVICIO";
            this.TIPOSERVICIO.Name = "TIPOSERVICIO";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(848, 199);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 30);
            this.button5.TabIndex = 25;
            this.button5.Text = "TRANSFERIR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(434, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 30);
            this.button4.TabIndex = 24;
            this.button4.Text = "SERVICIO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 30);
            this.button3.TabIndex = 23;
            this.button3.Text = "TRANFERIR(NO)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "CONSULTAR SALDO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "TRANSFERIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(164, 148);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(104, 20);
            this.txtvalor.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "VALOR TRANSFERIR";
            // 
            // txtdestino
            // 
            this.txtdestino.Location = new System.Drawing.Point(164, 88);
            this.txtdestino.Name = "txtdestino";
            this.txtdestino.Size = new System.Drawing.Size(195, 20);
            this.txtdestino.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID PAGO";
            // 
            // txtorigen
            // 
            this.txtorigen.Location = new System.Drawing.Point(164, 23);
            this.txtorigen.Name = "txtorigen";
            this.txtorigen.Size = new System.Drawing.Size(195, 20);
            this.txtorigen.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID SERVICIO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCUENTA,
            this.VALOR});
            this.dataGridView1.Location = new System.Drawing.Point(21, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 178);
            this.dataGridView1.TabIndex = 14;
            // 
            // IDCUENTA
            // 
            this.IDCUENTA.HeaderText = "IDCUENTA";
            this.IDCUENTA.Name = "IDCUENTA";
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(865, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 42);
            this.button6.TabIndex = 43;
            this.button6.Text = "REGRESAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TSevicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtorigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TSevicio";
            this.Text = "TSevicio";
            this.Load += new System.EventHandler(this.TSevicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSERVICIOPAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCUENTAPAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSERVICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORSERVICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOSERVICIO;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtorigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.Button button6;
    }
}