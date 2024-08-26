namespace ActividadInvividual
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
            ListaVideoJuegos = new ListBox();
            GroupBox1 = new GroupBox();
            ComprarVideoJuegoButton = new Button();
            GroupBox3 = new GroupBox();
            EliminarVideoJuegoButton = new Button();
            GroupBox2 = new GroupBox();
            AñadirVideojuegoTextBox = new TextBox();
            AñadirVideoJuegoButton = new Button();
            LimpiarVideoJuegoButton = new Button();
            groupBox4 = new GroupBox();
            AñadirDetallesButton = new Button();
            GroupBox1.SuspendLayout();
            GroupBox3.SuspendLayout();
            GroupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // ListaVideoJuegos
            // 
            ListaVideoJuegos.BackColor = Color.DarkGray;
            ListaVideoJuegos.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ListaVideoJuegos.FormattingEnabled = true;
            ListaVideoJuegos.ItemHeight = 19;
            ListaVideoJuegos.Items.AddRange(new object[] { "Horizon Zero Dawn", "Battlefield 1", "Grand Theft Auto V", "For Honor", "Call Of Duty: Modern Warfare" });
            ListaVideoJuegos.Location = new Point(16, 31);
            ListaVideoJuegos.Name = "ListaVideoJuegos";
            ListaVideoJuegos.Size = new Size(226, 270);
            ListaVideoJuegos.TabIndex = 0;
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.MediumSlateBlue;
            GroupBox1.Controls.Add(ComprarVideoJuegoButton);
            GroupBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox1.Location = new Point(248, 31);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(163, 69);
            GroupBox1.TabIndex = 2;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Comprar Videojuegos";
            // 
            // ComprarVideoJuegoButton
            // 
            ComprarVideoJuegoButton.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComprarVideoJuegoButton.Location = new Point(38, 21);
            ComprarVideoJuegoButton.Name = "ComprarVideoJuegoButton";
            ComprarVideoJuegoButton.Size = new Size(88, 34);
            ComprarVideoJuegoButton.TabIndex = 0;
            ComprarVideoJuegoButton.Text = "Comprar";
            ComprarVideoJuegoButton.UseVisualStyleBackColor = true;
            ComprarVideoJuegoButton.Click += ComprarVideoJuegoButton_Click;
            // 
            // GroupBox3
            // 
            GroupBox3.BackColor = Color.MediumSlateBlue;
            GroupBox3.Controls.Add(EliminarVideoJuegoButton);
            GroupBox3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox3.Location = new Point(248, 208);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(163, 93);
            GroupBox3.TabIndex = 3;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Eliminar VideoJuegos";
            // 
            // EliminarVideoJuegoButton
            // 
            EliminarVideoJuegoButton.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EliminarVideoJuegoButton.Location = new Point(38, 35);
            EliminarVideoJuegoButton.Name = "EliminarVideoJuegoButton";
            EliminarVideoJuegoButton.Size = new Size(88, 33);
            EliminarVideoJuegoButton.TabIndex = 0;
            EliminarVideoJuegoButton.Text = "Eliminar";
            EliminarVideoJuegoButton.UseVisualStyleBackColor = true;
            EliminarVideoJuegoButton.Click += EliminarVideoJuegoButton_Click;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(AñadirVideojuegoTextBox);
            GroupBox2.Controls.Add(AñadirVideoJuegoButton);
            GroupBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox2.Location = new Point(248, 106);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(163, 100);
            GroupBox2.TabIndex = 4;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Añadir Videojuegos";
            // 
            // AñadirVideojuegoTextBox
            // 
            AñadirVideojuegoTextBox.Location = new Point(28, 29);
            AñadirVideojuegoTextBox.Name = "AñadirVideojuegoTextBox";
            AñadirVideojuegoTextBox.Size = new Size(107, 22);
            AñadirVideojuegoTextBox.TabIndex = 2;
            // 
            // AñadirVideoJuegoButton
            // 
            AñadirVideoJuegoButton.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AñadirVideoJuegoButton.Location = new Point(38, 57);
            AñadirVideoJuegoButton.Name = "AñadirVideoJuegoButton";
            AñadirVideoJuegoButton.Size = new Size(88, 23);
            AñadirVideoJuegoButton.TabIndex = 1;
            AñadirVideoJuegoButton.Text = "Añadir";
            AñadirVideoJuegoButton.UseVisualStyleBackColor = true;
            AñadirVideoJuegoButton.Click += AñadirVideoJuegoButton_Click;
            // 
            // LimpiarVideoJuegoButton
            // 
            LimpiarVideoJuegoButton.BackColor = Color.Transparent;
            LimpiarVideoJuegoButton.Location = new Point(16, 305);
            LimpiarVideoJuegoButton.Name = "LimpiarVideoJuegoButton";
            LimpiarVideoJuegoButton.Size = new Size(110, 33);
            LimpiarVideoJuegoButton.TabIndex = 6;
            LimpiarVideoJuegoButton.Text = "Limpiar Tablero";
            LimpiarVideoJuegoButton.UseVisualStyleBackColor = false;
            LimpiarVideoJuegoButton.Click += LimpiarVideoJuegoButton_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.MediumSlateBlue;
            groupBox4.Controls.Add(AñadirDetallesButton);
            groupBox4.Controls.Add(ListaVideoJuegos);
            groupBox4.Controls.Add(LimpiarVideoJuegoButton);
            groupBox4.Controls.Add(GroupBox1);
            groupBox4.Controls.Add(GroupBox3);
            groupBox4.Controls.Add(GroupBox2);
            groupBox4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(435, 358);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tienda de VideoJuegos";
            // 
            // AñadirDetallesButton
            // 
            AñadirDetallesButton.Location = new Point(132, 305);
            AñadirDetallesButton.Name = "AñadirDetallesButton";
            AñadirDetallesButton.Size = new Size(176, 33);
            AñadirDetallesButton.TabIndex = 8;
            AñadirDetallesButton.Text = "Añadir Detalles";
            AñadirDetallesButton.UseVisualStyleBackColor = true;
            AñadirDetallesButton.Click += AñadirDetallesButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(932, 450);
            Controls.Add(groupBox4);
            Name = "Form1";
            Text = "Form1";
            GroupBox1.ResumeLayout(false);
            GroupBox3.ResumeLayout(false);
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListaVideoJuegos;
        private GroupBox GroupBox1;
        private Button ComprarVideoJuegoButton;
        private GroupBox GroupBox3;
        private Button EliminarVideoJuegoButton;
        private GroupBox GroupBox2;
        private TextBox AñadirVideojuegoTextBox;
        private Button AñadirVideoJuegoButton;
        private Button LimpiarVideoJuegoButton;
        private GroupBox groupBox4;
        private Button AñadirDetallesButton;
    }
}
