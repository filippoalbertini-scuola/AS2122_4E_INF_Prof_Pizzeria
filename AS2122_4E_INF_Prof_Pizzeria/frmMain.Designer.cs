namespace AS2122_4E_INF_Prof_Pizzeria
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoPizza = new System.Windows.Forms.ComboBox();
            this.txtQuantita = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMargherita = new System.Windows.Forms.Label();
            this.lblVerdura = new System.Windows.Forms.Label();
            this.lbl4Stagioni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo di pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantità";
            // 
            // cmbTipoPizza
            // 
            this.cmbTipoPizza.FormattingEnabled = true;
            this.cmbTipoPizza.Items.AddRange(new object[] {
            "MARGHERITA",
            "VERDURE",
            "4 STAGIONI"});
            this.cmbTipoPizza.Location = new System.Drawing.Point(152, 48);
            this.cmbTipoPizza.Name = "cmbTipoPizza";
            this.cmbTipoPizza.Size = new System.Drawing.Size(169, 28);
            this.cmbTipoPizza.TabIndex = 1;
            // 
            // txtQuantita
            // 
            this.txtQuantita.Location = new System.Drawing.Point(155, 121);
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(68, 27);
            this.txtQuantita.TabIndex = 2;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(338, 48);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(94, 29);
            this.btnAggiungi.TabIndex = 3;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Riepilogo :";
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 20;
            this.lstVisualizza.Location = new System.Drawing.Point(569, 74);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(195, 144);
            this.lstVisualizza.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Totale pizze margherita :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Totale pizze verdura :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Totale pizze 4 stagioni :";
            // 
            // lblMargherita
            // 
            this.lblMargherita.AutoSize = true;
            this.lblMargherita.Location = new System.Drawing.Point(669, 271);
            this.lblMargherita.Name = "lblMargherita";
            this.lblMargherita.Size = new System.Drawing.Size(17, 20);
            this.lblMargherita.TabIndex = 5;
            this.lblMargherita.Text = "0";
            // 
            // lblVerdura
            // 
            this.lblVerdura.AutoSize = true;
            this.lblVerdura.Location = new System.Drawing.Point(669, 315);
            this.lblVerdura.Name = "lblVerdura";
            this.lblVerdura.Size = new System.Drawing.Size(17, 20);
            this.lblVerdura.TabIndex = 5;
            this.lblVerdura.Text = "0";
            // 
            // lbl4Stagioni
            // 
            this.lbl4Stagioni.AutoSize = true;
            this.lbl4Stagioni.Location = new System.Drawing.Point(669, 356);
            this.lbl4Stagioni.Name = "lbl4Stagioni";
            this.lbl4Stagioni.Size = new System.Drawing.Size(17, 20);
            this.lbl4Stagioni.TabIndex = 5;
            this.lbl4Stagioni.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl4Stagioni);
            this.Controls.Add(this.lblVerdura);
            this.Controls.Add(this.lblMargherita);
            this.Controls.Add(this.lstVisualizza);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtQuantita);
            this.Controls.Add(this.cmbTipoPizza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Prof;Lab. 2.2 4E; 09/03/2022; Gestione pizzeria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbTipoPizza;
        private TextBox txtQuantita;
        private Button btnAggiungi;
        private Label label3;
        private ListBox lstVisualizza;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblMargherita;
        private Label lblVerdura;
        private Label lbl4Stagioni;
    }
}