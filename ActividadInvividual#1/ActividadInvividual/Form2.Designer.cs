namespace ActividadInvividual
{
    partial class Form2
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
            DetallesVideojuegosLabel = new Label();
            groupBox1 = new GroupBox();
            ConfirmarInformacionButton = new Button();
            ConsolasVideoJuegoComboBox = new ComboBox();
            PrecioVideoJuegoTextBox = new TextBox();
            NombreVideoJuegoTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DetallesVideojuegosLabel
            // 
            DetallesVideojuegosLabel.AutoSize = true;
            DetallesVideojuegosLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetallesVideojuegosLabel.Location = new Point(82, 33);
            DetallesVideojuegosLabel.Name = "DetallesVideojuegosLabel";
            DetallesVideojuegosLabel.Size = new Size(171, 19);
            DetallesVideojuegosLabel.TabIndex = 0;
            DetallesVideojuegosLabel.Text = "Detalles del VideoJuego";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(ConfirmarInformacionButton);
            groupBox1.Controls.Add(ConsolasVideoJuegoComboBox);
            groupBox1.Controls.Add(PrecioVideoJuegoTextBox);
            groupBox1.Controls.Add(NombreVideoJuegoTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DetallesVideojuegosLabel);
            groupBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(35, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 412);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            // 
            // ConfirmarInformacionButton
            // 
            ConfirmarInformacionButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmarInformacionButton.Location = new Point(82, 274);
            ConfirmarInformacionButton.Name = "ConfirmarInformacionButton";
            ConfirmarInformacionButton.Size = new Size(145, 23);
            ConfirmarInformacionButton.TabIndex = 7;
            ConfirmarInformacionButton.Text = "Confirmar Informacíon";
            ConfirmarInformacionButton.UseVisualStyleBackColor = true;
            ConfirmarInformacionButton.Click += ConfirmarInformacionButton_Click;
            // 
            // ConsolasVideoJuegoComboBox
            // 
            ConsolasVideoJuegoComboBox.FormattingEnabled = true;
            ConsolasVideoJuegoComboBox.Location = new Point(84, 221);
            ConsolasVideoJuegoComboBox.Name = "ConsolasVideoJuegoComboBox";
            ConsolasVideoJuegoComboBox.Size = new Size(121, 30);
            ConsolasVideoJuegoComboBox.TabIndex = 6;
            // 
            // PrecioVideoJuegoTextBox
            // 
            PrecioVideoJuegoTextBox.Location = new Point(82, 156);
            PrecioVideoJuegoTextBox.Name = "PrecioVideoJuegoTextBox";
            PrecioVideoJuegoTextBox.Size = new Size(100, 29);
            PrecioVideoJuegoTextBox.TabIndex = 5;
            // 
            // NombreVideoJuegoTextBox
            // 
            NombreVideoJuegoTextBox.Location = new Point(84, 88);
            NombreVideoJuegoTextBox.Name = "NombreVideoJuegoTextBox";
            NombreVideoJuegoTextBox.Size = new Size(100, 29);
            NombreVideoJuegoTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 203);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Consola";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 138);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 70);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Juego";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(447, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label DetallesVideojuegosLabel;
        private GroupBox groupBox1;
        private Button ConfirmarInformacionButton;
        private ComboBox ConsolasVideoJuegoComboBox;
        private TextBox PrecioVideoJuegoTextBox;
        private TextBox NombreVideoJuegoTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}