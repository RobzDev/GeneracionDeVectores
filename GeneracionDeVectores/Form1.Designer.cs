namespace GeneracionDeVectores
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
            txtTamanio = new TextBox();
            btnGenerar = new Button();
            txtValor = new TextBox();
            btnAgregar = new Button();
            listBoxVector = new ListBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtTamanio
            // 
            txtTamanio.Location = new Point(12, 12);
            txtTamanio.Name = "txtTamanio";
            txtTamanio.PlaceholderText = "Vector Size";
            txtTamanio.Size = new Size(156, 23);
            txtTamanio.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(174, 12);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(98, 23);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generate Vector";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(12, 50);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Add a Value";
            txtValor.Size = new Size(156, 23);
            txtValor.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(174, 50);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Add Value";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // listBoxVector
            // 
            listBoxVector.FormattingEnabled = true;
            listBoxVector.ItemHeight = 15;
            listBoxVector.Location = new Point(12, 90);
            listBoxVector.Name = "listBoxVector";
            listBoxVector.Size = new Size(260, 154);
            listBoxVector.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(93, 250);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Vector";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 383);
            Controls.Add(btnDelete);
            Controls.Add(listBoxVector);
            Controls.Add(btnAgregar);
            Controls.Add(txtValor);
            Controls.Add(btnGenerar);
            Controls.Add(txtTamanio);
            Name = "Form1";
            Text = "Vector Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listBoxVector;
        private Button btnDelete;
    }
}

