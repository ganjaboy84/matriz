namespace matriz
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
            this.txtTable = new System.Windows.Forms.TextBox();
            this.cmdLlenar = new System.Windows.Forms.Button();
            this.cmdLlenarxCol = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.cmdLlenarInv = new System.Windows.Forms.Button();
            this.cmdMDP = new System.Windows.Forms.Button();
            this.cmdMDS = new System.Windows.Forms.Button();
            this.ADS = new System.Windows.Forms.Button();
            this.cmdADP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GDS = new System.Windows.Forms.Button();
            this.GDP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(37, 156);
            this.txtTable.Multiline = true;
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(240, 195);
            this.txtTable.TabIndex = 0;
            // 
            // cmdLlenar
            // 
            this.cmdLlenar.Location = new System.Drawing.Point(37, 22);
            this.cmdLlenar.Name = "cmdLlenar";
            this.cmdLlenar.Size = new System.Drawing.Size(75, 23);
            this.cmdLlenar.TabIndex = 1;
            this.cmdLlenar.Text = "Llenar";
            this.cmdLlenar.UseVisualStyleBackColor = true;
            this.cmdLlenar.Click += new System.EventHandler(this.cmdLlenar_Click);
            // 
            // cmdLlenarxCol
            // 
            this.cmdLlenarxCol.Location = new System.Drawing.Point(129, 22);
            this.cmdLlenarxCol.Name = "cmdLlenarxCol";
            this.cmdLlenarxCol.Size = new System.Drawing.Size(75, 23);
            this.cmdLlenarxCol.TabIndex = 2;
            this.cmdLlenarxCol.Text = "Llenar x Col";
            this.cmdLlenarxCol.UseVisualStyleBackColor = true;
            this.cmdLlenarxCol.Click += new System.EventHandler(this.cmdLlenarxCol_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(225, 22);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar.TabIndex = 3;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // cmdLlenarInv
            // 
            this.cmdLlenarInv.Location = new System.Drawing.Point(37, 70);
            this.cmdLlenarInv.Name = "cmdLlenarInv";
            this.cmdLlenarInv.Size = new System.Drawing.Size(75, 23);
            this.cmdLlenarInv.TabIndex = 4;
            this.cmdLlenarInv.Text = "Llenar Inv";
            this.cmdLlenarInv.UseVisualStyleBackColor = true;
            this.cmdLlenarInv.Click += new System.EventHandler(this.cmdLlenarInv_Click);
            // 
            // cmdMDP
            // 
            this.cmdMDP.Location = new System.Drawing.Point(129, 72);
            this.cmdMDP.Name = "cmdMDP";
            this.cmdMDP.Size = new System.Drawing.Size(75, 23);
            this.cmdMDP.TabIndex = 5;
            this.cmdMDP.Text = "MDP";
            this.cmdMDP.UseVisualStyleBackColor = true;
            this.cmdMDP.Click += new System.EventHandler(this.cmdMDP_Click);
            // 
            // cmdMDS
            // 
            this.cmdMDS.Location = new System.Drawing.Point(225, 72);
            this.cmdMDS.Name = "cmdMDS";
            this.cmdMDS.Size = new System.Drawing.Size(75, 23);
            this.cmdMDS.TabIndex = 6;
            this.cmdMDS.Text = "MDS";
            this.cmdMDS.UseVisualStyleBackColor = true;
            this.cmdMDS.Click += new System.EventHandler(this.cmdMDS_Click);
            // 
            // ADS
            // 
            this.ADS.Location = new System.Drawing.Point(181, 99);
            this.ADS.Name = "ADS";
            this.ADS.Size = new System.Drawing.Size(75, 23);
            this.ADS.TabIndex = 8;
            this.ADS.Text = "ADS";
            this.ADS.UseVisualStyleBackColor = true;
            // 
            // cmdADP
            // 
            this.cmdADP.Location = new System.Drawing.Point(78, 99);
            this.cmdADP.Name = "cmdADP";
            this.cmdADP.Size = new System.Drawing.Size(75, 23);
            this.cmdADP.TabIndex = 7;
            this.cmdADP.Text = "ADP";
            this.cmdADP.UseVisualStyleBackColor = true;
            this.cmdADP.Click += new System.EventHandler(this.cmdADP_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GDS
            // 
            this.GDS.Location = new System.Drawing.Point(181, 128);
            this.GDS.Name = "GDS";
            this.GDS.Size = new System.Drawing.Size(75, 23);
            this.GDS.TabIndex = 11;
            this.GDS.Text = "GDS";
            this.GDS.UseVisualStyleBackColor = true;
            this.GDS.Click += new System.EventHandler(this.GDS_Click);
            // 
            // GDP
            // 
            this.GDP.Location = new System.Drawing.Point(78, 128);
            this.GDP.Name = "GDP";
            this.GDP.Size = new System.Drawing.Size(75, 23);
            this.GDP.TabIndex = 10;
            this.GDP.Text = "GDP";
            this.GDP.UseVisualStyleBackColor = true;
            this.GDP.Click += new System.EventHandler(this.GDP_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(497, 432);
            this.Controls.Add(this.GDS);
            this.Controls.Add(this.GDP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ADS);
            this.Controls.Add(this.cmdADP);
            this.Controls.Add(this.cmdMDS);
            this.Controls.Add(this.cmdMDP);
            this.Controls.Add(this.cmdLlenarInv);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.cmdLlenarxCol);
            this.Controls.Add(this.cmdLlenar);
            this.Controls.Add(this.txtTable);
            this.Name = "Form1";
            this.Text = "Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Button cmdLlenar;
        private System.Windows.Forms.Button cmdLlenarxCol;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Button cmdLlenarInv;
        private System.Windows.Forms.Button cmdMDP;
        private System.Windows.Forms.Button cmdMDS;
        private System.Windows.Forms.Button ADS;
        private System.Windows.Forms.Button cmdADP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GDS;
        private System.Windows.Forms.Button GDP;
    }
}

