namespace Guitarhero3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Kliker = new System.Windows.Forms.Button();
            this.Progres = new System.Windows.Forms.ProgressBar();
            this.czasrucha = new System.Windows.Forms.Timer(this.components);
            this.wynik = new System.Windows.Forms.Label();
            this.Kliker2 = new System.Windows.Forms.Button();
            this.Kwadrat2 = new System.Windows.Forms.PictureBox();
            this.Kwadrat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Kwadrat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kwadrat)).BeginInit();
            this.SuspendLayout();
            // 
            // Kliker
            // 
            this.Kliker.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.Kliker, "Kliker");
            this.Kliker.Name = "Kliker";
            this.Kliker.UseVisualStyleBackColor = false;
            this.Kliker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.Kliker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Kliker_KeyUp);
            // 
            // Progres
            // 
            resources.ApplyResources(this.Progres, "Progres");
            this.Progres.Name = "Progres";
            this.Progres.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // czasrucha
            // 
            this.czasrucha.Enabled = true;
            this.czasrucha.Interval = 20;
            this.czasrucha.Tick += new System.EventHandler(this.czasruchu);
            // 
            // wynik
            // 
            resources.ApplyResources(this.wynik, "wynik");
            this.wynik.BackColor = System.Drawing.Color.White;
            this.wynik.Name = "wynik";
            this.wynik.Click += new System.EventHandler(this.wynik_Click);
            // 
            // Kliker2
            // 
            this.Kliker2.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.Kliker2, "Kliker2");
            this.Kliker2.Name = "Kliker2";
            this.Kliker2.UseVisualStyleBackColor = false;
            // 
            // Kwadrat2
            // 
            this.Kwadrat2.BackColor = System.Drawing.Color.Transparent;
            this.Kwadrat2.Image = global::Guitarhero3.Properties.Resources.niebieskikrazek4;
            resources.ApplyResources(this.Kwadrat2, "Kwadrat2");
            this.Kwadrat2.InitialImage = global::Guitarhero3.Properties.Resources.niebieskikrazek4;
            this.Kwadrat2.Name = "Kwadrat2";
            this.Kwadrat2.TabStop = false;
            this.Kwadrat2.Click += new System.EventHandler(this.Kwadrat2_Click);
            // 
            // Kwadrat
            // 
            this.Kwadrat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Kwadrat.BackColor = System.Drawing.Color.White;
            this.Kwadrat.Image = global::Guitarhero3.Properties.Resources.krazek3;
            resources.ApplyResources(this.Kwadrat, "Kwadrat");
            this.Kwadrat.Name = "Kwadrat";
            this.Kwadrat.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Kwadrat2);
            this.Controls.Add(this.Kliker2);
            this.Controls.Add(this.Kwadrat);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.Progres);
            this.Controls.Add(this.Kliker);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kwadrat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kwadrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kliker;
        private System.Windows.Forms.ProgressBar Progres;
        private System.Windows.Forms.Timer czasrucha;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.PictureBox Kwadrat;
        private System.Windows.Forms.Button Kliker2;
        private System.Windows.Forms.PictureBox Kwadrat2;
    }
}

