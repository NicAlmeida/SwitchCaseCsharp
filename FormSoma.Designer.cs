namespace ProjetoEstruturaCondicionalSwitchCase
{
    partial class FormSoma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSoma));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOperacao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            resources.ApplyResources(this.btnCalcular, "btnCalcular");
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtV1
            // 
            resources.ApplyResources(this.txtV1, "txtV1");
            this.txtV1.Name = "txtV1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtV2
            // 
            resources.ApplyResources(this.txtV2, "txtV2");
            this.txtV2.Name = "txtV2";
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.Name = "txtTotal";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cbOperacao
            // 
            resources.ApplyResources(this.cbOperacao, "cbOperacao");
            this.cbOperacao.FormattingEnabled = true;
            this.cbOperacao.Items.AddRange(new object[] {
            resources.GetString("cbOperacao.Items"),
            resources.GetString("cbOperacao.Items1"),
            resources.GetString("cbOperacao.Items2"),
            resources.GetString("cbOperacao.Items3")});
            this.cbOperacao.Name = "cbOperacao";
            // 
            // FormSoma
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOperacao);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.label1);
            this.Name = "FormSoma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOperacao;
    }
}