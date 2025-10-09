namespace Ejercicio1_1_
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            tbImporte = new TextBox();
            btnConfirmar = new Button();
            btnActualizar = new Button();
            lsbVer = new ListBox();
            button1 = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Importe";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(81, 48);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 3;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(81, 83);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(100, 23);
            tbDNI.TabIndex = 4;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(81, 112);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(100, 23);
            tbImporte.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(258, 51);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(89, 50);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(258, 112);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(89, 50);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lsbVer
            // 
            lsbVer.FormattingEnabled = true;
            lsbVer.ItemHeight = 15;
            lsbVer.Location = new Point(12, 169);
            lsbVer.Name = "lsbVer";
            lsbVer.Size = new Size(261, 109);
            lsbVer.TabIndex = 8;
            lsbVer.SelectedIndexChanged += lsbVer_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(296, 194);
            button1.Name = "button1";
            button1.Size = new Size(89, 27);
            button1.TabIndex = 9;
            button1.Text = "Importar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(296, 236);
            button2.Name = "button2";
            button2.Size = new Size(89, 27);
            button2.TabIndex = 10;
            button2.Text = "Exportar";
            button2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 310);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lsbVer);
            Controls.Add(btnActualizar);
            Controls.Add(btnConfirmar);
            Controls.Add(tbImporte);
            Controls.Add(tbDNI);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNombre;
        private TextBox tbDNI;
        private TextBox tbImporte;
        private Button btnConfirmar;
        private Button btnActualizar;
        private ListBox lsbVer;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
