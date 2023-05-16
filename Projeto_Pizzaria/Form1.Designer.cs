namespace Projeto_Pizzaria
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
            lblSabores = new Label();
            cboSabor = new ComboBox();
            grpBorda = new GroupBox();
            rdbSemBorda = new RadioButton();
            rdbComBorda = new RadioButton();
            grpIngredientes = new GroupBox();
            chkCebola = new CheckBox();
            chkAzeitona = new CheckBox();
            btnImprimir = new Button();
            btnLimpar = new Button();
            grpBorda.SuspendLayout();
            grpIngredientes.SuspendLayout();
            SuspendLayout();
            // 
            // lblSabores
            // 
            lblSabores.AutoSize = true;
            lblSabores.Location = new Point(12, 33);
            lblSabores.Name = "lblSabores";
            lblSabores.Size = new Size(98, 15);
            lblSabores.TabIndex = 0;
            lblSabores.Text = "Sabores da Pizzas";
            // 
            // cboSabor
            // 
            cboSabor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSabor.FormattingEnabled = true;
            cboSabor.Location = new Point(126, 33);
            cboSabor.Name = "cboSabor";
            cboSabor.Size = new Size(153, 23);
            cboSabor.Sorted = true;
            cboSabor.TabIndex = 1;
            // 
            // grpBorda
            // 
            grpBorda.Controls.Add(rdbSemBorda);
            grpBorda.Controls.Add(rdbComBorda);
            grpBorda.Location = new Point(191, 78);
            grpBorda.Name = "grpBorda";
            grpBorda.Size = new Size(156, 100);
            grpBorda.TabIndex = 2;
            grpBorda.TabStop = false;
            grpBorda.Text = "Borda";
            // 
            // rdbSemBorda
            // 
            rdbSemBorda.AutoSize = true;
            rdbSemBorda.Location = new Point(6, 21);
            rdbSemBorda.Name = "rdbSemBorda";
            rdbSemBorda.Size = new Size(82, 19);
            rdbSemBorda.TabIndex = 7;
            rdbSemBorda.TabStop = true;
            rdbSemBorda.Text = "Sem Borda";
            rdbSemBorda.UseVisualStyleBackColor = true;
            // 
            // rdbComBorda
            // 
            rdbComBorda.AutoSize = true;
            rdbComBorda.Location = new Point(6, 55);
            rdbComBorda.Name = "rdbComBorda";
            rdbComBorda.Size = new Size(85, 19);
            rdbComBorda.TabIndex = 8;
            rdbComBorda.TabStop = true;
            rdbComBorda.Text = "Com Borda";
            rdbComBorda.UseVisualStyleBackColor = true;
            // 
            // grpIngredientes
            // 
            grpIngredientes.Controls.Add(chkCebola);
            grpIngredientes.Controls.Add(chkAzeitona);
            grpIngredientes.Location = new Point(12, 78);
            grpIngredientes.Name = "grpIngredientes";
            grpIngredientes.Size = new Size(162, 100);
            grpIngredientes.TabIndex = 0;
            grpIngredientes.TabStop = false;
            grpIngredientes.Text = "Ingredientes Adicionais";
            // 
            // chkCebola
            // 
            chkCebola.AutoSize = true;
            chkCebola.Location = new Point(6, 22);
            chkCebola.Name = "chkCebola";
            chkCebola.Size = new Size(63, 19);
            chkCebola.TabIndex = 5;
            chkCebola.Text = "Cebola";
            chkCebola.UseVisualStyleBackColor = true;
            // 
            // chkAzeitona
            // 
            chkAzeitona.AutoSize = true;
            chkAzeitona.Location = new Point(6, 56);
            chkAzeitona.Name = "chkAzeitona";
            chkAzeitona.Size = new Size(72, 19);
            chkAzeitona.TabIndex = 6;
            chkAzeitona.Text = "Azeitona";
            chkAzeitona.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(189, 184);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(158, 23);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir Pedido";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(52, 184);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar Pedido";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 288);
            Controls.Add(btnLimpar);
            Controls.Add(btnImprimir);
            Controls.Add(grpBorda);
            Controls.Add(grpIngredientes);
            Controls.Add(cboSabor);
            Controls.Add(lblSabores);
            Name = "Form1";
            Text = "Pizzaria";
            Load += Form1_Load;
            grpBorda.ResumeLayout(false);
            grpBorda.PerformLayout();
            grpIngredientes.ResumeLayout(false);
            grpIngredientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSabores;
        private ComboBox cboSabor;
        private GroupBox grpBorda;
        private RadioButton rdbSemBorda;
        private RadioButton rdbComBorda;
        private GroupBox grpIngredientes;
        private CheckBox chkCebola;
        private CheckBox chkAzeitona;
        private Button btnImprimir;
        private Button btnLimpar;
    }
}