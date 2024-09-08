namespace visualizador_imagem
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            mostrarimagem = new Button();
            limpartela = new Button();
            cordefundo = new Button();
            fechar = new Button();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 399);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 408);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Stretch";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(mostrarimagem);
            flowLayoutPanel1.Controls.Add(limpartela);
            flowLayoutPanel1.Controls.Add(cordefundo);
            flowLayoutPanel1.Controls.Add(fechar);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(123, 408);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(674, 39);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // mostrarimagem
            // 
            mostrarimagem.AutoSize = true;
            mostrarimagem.Location = new Point(570, 3);
            mostrarimagem.Name = "mostrarimagem";
            mostrarimagem.Size = new Size(101, 25);
            mostrarimagem.TabIndex = 0;
            mostrarimagem.Text = "mostrar a figura";
            mostrarimagem.UseVisualStyleBackColor = true;
            mostrarimagem.Click += mostrarimagem_Click;
            // 
            // limpartela
            // 
            limpartela.AutoSize = true;
            limpartela.Location = new Point(447, 3);
            limpartela.Name = "limpartela";
            limpartela.Size = new Size(117, 25);
            limpartela.TabIndex = 1;
            limpartela.Text = "Limpar a impagem";
            limpartela.UseVisualStyleBackColor = true;
            limpartela.Click += limpartela_Click;
            // 
            // cordefundo
            // 
            cordefundo.AutoSize = true;
            cordefundo.Location = new Point(331, 3);
            cordefundo.Name = "cordefundo";
            cordefundo.Size = new Size(110, 25);
            cordefundo.TabIndex = 2;
            cordefundo.Text = "Definir cor da tela";
            cordefundo.UseVisualStyleBackColor = true;
            cordefundo.Click += cordefundo_Click;
            // 
            // fechar
            // 
            fechar.AutoSize = true;
            fechar.Location = new Point(250, 3);
            fechar.Name = "fechar";
            fechar.Size = new Size(75, 25);
            fechar.TabIndex = 3;
            fechar.Text = "fechar";
            fechar.UseVisualStyleBackColor = true;
            fechar.Click += fechar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.Title = "Selecionar um arquvo de imagem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Visusalizador de imagens";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button mostrarimagem;
        private Button limpartela;
        private Button cordefundo;
        private Button fechar;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
    }
}
