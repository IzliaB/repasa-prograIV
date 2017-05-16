namespace Repaso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cbxsexo = new System.Windows.Forms.ComboBox();
            this.dtpfecha_nac = new System.Windows.Forms.DateTimePicker();
            this.btnguardar = new System.Windows.Forms.Button();
            this.control11 = new Repaso.Control1();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(108, 66);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(202, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // cbxsexo
            // 
            this.cbxsexo.FormattingEnabled = true;
            this.cbxsexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbxsexo.Location = new System.Drawing.Point(108, 101);
            this.cbxsexo.Name = "cbxsexo";
            this.cbxsexo.Size = new System.Drawing.Size(201, 21);
            this.cbxsexo.TabIndex = 6;
            // 
            // dtpfecha_nac
            // 
            this.dtpfecha_nac.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dtpfecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha_nac.Location = new System.Drawing.Point(165, 134);
            this.dtpfecha_nac.Name = "dtpfecha_nac";
            this.dtpfecha_nac.Size = new System.Drawing.Size(156, 20);
            this.dtpfecha_nac.TabIndex = 7;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(40, 195);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(155, 40);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // control11
            // 
            this.control11.ForeColor = System.Drawing.Color.Red;
            this.control11.Location = new System.Drawing.Point(108, 36);
            this.control11.Name = "control11";
            this.control11.Size = new System.Drawing.Size(202, 20);
            this.control11.TabIndex = 4;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(219, 195);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(155, 39);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 288);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dtpfecha_nac);
            this.Controls.Add(this.cbxsexo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.control11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Control1 control11;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cbxsexo;
        private System.Windows.Forms.DateTimePicker dtpfecha_nac;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnbuscar;
    }
}

