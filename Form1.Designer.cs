namespace EtiquetaSame
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
            txtMatricula = new TextBox();
            dataGridViewEtiqueta = new DataGridView();
            button1 = new Button();
            btnBuscarDados = new Button();
            label2 = new Label();
            listImpressoras = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEtiqueta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 0;
            label1.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(167, 21);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(363, 23);
            txtMatricula.TabIndex = 1;
            // 
            // dataGridViewEtiqueta
            // 
            dataGridViewEtiqueta.AllowUserToAddRows = false;
            dataGridViewEtiqueta.AllowUserToDeleteRows = false;
            dataGridViewEtiqueta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEtiqueta.Location = new Point(23, 64);
            dataGridViewEtiqueta.Name = "dataGridViewEtiqueta";
            dataGridViewEtiqueta.ReadOnly = true;
            dataGridViewEtiqueta.RowTemplate.Height = 25;
            dataGridViewEtiqueta.Size = new Size(749, 302);
            dataGridViewEtiqueta.TabIndex = 2;
            dataGridViewEtiqueta.CellClick += dataGridViewEtiqueta_CellClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 438);
            button1.Name = "button1";
            button1.Size = new Size(749, 38);
            button1.TabIndex = 3;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnBuscarDados
            // 
            btnBuscarDados.BackColor = SystemColors.Highlight;
            btnBuscarDados.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarDados.ForeColor = Color.White;
            btnBuscarDados.Location = new Point(600, 12);
            btnBuscarDados.Name = "btnBuscarDados";
            btnBuscarDados.Size = new Size(172, 38);
            btnBuscarDados.TabIndex = 4;
            btnBuscarDados.Text = "Buscar";
            btnBuscarDados.UseVisualStyleBackColor = false;
            btnBuscarDados.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Code Pro", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 389);
            label2.Name = "label2";
            label2.Size = new Size(120, 24);
            label2.TabIndex = 5;
            label2.Text = "Impressora";
            // 
            // listImpressoras
            // 
            listImpressoras.FormattingEnabled = true;
            listImpressoras.Location = new Point(179, 390);
            listImpressoras.Name = "listImpressoras";
            listImpressoras.Size = new Size(593, 23);
            listImpressoras.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(listImpressoras);
            Controls.Add(label2);
            Controls.Add(btnBuscarDados);
            Controls.Add(button1);
            Controls.Add(dataGridViewEtiqueta);
            Controls.Add(txtMatricula);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etiqueta Same";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEtiqueta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMatricula;
        private DataGridView dataGridViewEtiqueta;
        private Button button1;
        private Button btnBuscarDados;
        private Label label2;
        private ComboBox listImpressoras;
    }
}