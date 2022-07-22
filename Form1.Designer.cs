
namespace Project_tp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerUnImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogrammeSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lhistogrammeNormaliséToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lhistogrammeCumuléToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lhistogrammeCumuléNormaliséToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesTraitementsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rendreLimageGriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesTraitementsÀBaseDhistogrammeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.laTranslationDhistogrammeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.linversionDhistogrammeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lexpansionDeDynamiqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.egalisationDeLhistogrammeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficherToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.lesTraitementsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficherToolStripMenuItem
            // 
            this.ficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerUnImageToolStripMenuItem});
            this.ficherToolStripMenuItem.Name = "ficherToolStripMenuItem";
            this.ficherToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.ficherToolStripMenuItem.Text = "Ficher";
            // 
            // importerUnImageToolStripMenuItem
            // 
            this.importerUnImageToolStripMenuItem.Name = "importerUnImageToolStripMenuItem";
            this.importerUnImageToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.importerUnImageToolStripMenuItem.Text = "Importer un image";
            this.importerUnImageToolStripMenuItem.Click += new System.EventHandler(this.importerUnImageToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogrammeSimpleToolStripMenuItem,
            this.lhistogrammeNormaliséToolStripMenuItem,
            this.lhistogrammeCumuléToolStripMenuItem,
            this.lhistogrammeCumuléNormaliséToolStripMenuItem});
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.modificationToolStripMenuItem.Text = "Modification d\'Histogramme";
            // 
            // histogrammeSimpleToolStripMenuItem
            // 
            this.histogrammeSimpleToolStripMenuItem.Name = "histogrammeSimpleToolStripMenuItem";
            this.histogrammeSimpleToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.histogrammeSimpleToolStripMenuItem.Text = "Histogramme simple";
            this.histogrammeSimpleToolStripMenuItem.Click += new System.EventHandler(this.histogrammeSimpleToolStripMenuItem_Click);
            // 
            // lhistogrammeNormaliséToolStripMenuItem
            // 
            this.lhistogrammeNormaliséToolStripMenuItem.Name = "lhistogrammeNormaliséToolStripMenuItem";
            this.lhistogrammeNormaliséToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.lhistogrammeNormaliséToolStripMenuItem.Text = "L\'histogramme normalisé";
            this.lhistogrammeNormaliséToolStripMenuItem.Click += new System.EventHandler(this.lhistogrammeNormaliséToolStripMenuItem_Click);
            // 
            // lhistogrammeCumuléToolStripMenuItem
            // 
            this.lhistogrammeCumuléToolStripMenuItem.Name = "lhistogrammeCumuléToolStripMenuItem";
            this.lhistogrammeCumuléToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.lhistogrammeCumuléToolStripMenuItem.Text = "L\'histogramme cumulé";
            this.lhistogrammeCumuléToolStripMenuItem.Click += new System.EventHandler(this.lhistogrammeCumuléToolStripMenuItem_Click);
            // 
            // lhistogrammeCumuléNormaliséToolStripMenuItem
            // 
            this.lhistogrammeCumuléNormaliséToolStripMenuItem.Name = "lhistogrammeCumuléNormaliséToolStripMenuItem";
            this.lhistogrammeCumuléNormaliséToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.lhistogrammeCumuléNormaliséToolStripMenuItem.Text = "L\'histogramme cumulé normalisé";
            this.lhistogrammeCumuléNormaliséToolStripMenuItem.Click += new System.EventHandler(this.lhistogrammeCumuléNormaliséToolStripMenuItem_Click);
            // 
            // lesTraitementsToolStripMenuItem1
            // 
            this.lesTraitementsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rendreLimageGriseToolStripMenuItem,
            this.lesTraitementsÀBaseDhistogrammeToolStripMenuItem1});
            this.lesTraitementsToolStripMenuItem1.Name = "lesTraitementsToolStripMenuItem1";
            this.lesTraitementsToolStripMenuItem1.Size = new System.Drawing.Size(121, 24);
            this.lesTraitementsToolStripMenuItem1.Text = "Les traitements";
            // 
            // rendreLimageGriseToolStripMenuItem
            // 
            this.rendreLimageGriseToolStripMenuItem.Name = "rendreLimageGriseToolStripMenuItem";
            this.rendreLimageGriseToolStripMenuItem.Size = new System.Drawing.Size(329, 24);
            this.rendreLimageGriseToolStripMenuItem.Text = "rendre l\'image grise";
            this.rendreLimageGriseToolStripMenuItem.Click += new System.EventHandler(this.rendreLimageGriseToolStripMenuItem_Click);
            // 
            // lesTraitementsÀBaseDhistogrammeToolStripMenuItem1
            // 
            this.lesTraitementsÀBaseDhistogrammeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laTranslationDhistogrammeToolStripMenuItem1,
            this.linversionDhistogrammeToolStripMenuItem1,
            this.lexpansionDeDynamiqueToolStripMenuItem1,
            this.egalisationDeLhistogrammeToolStripMenuItem1});
            this.lesTraitementsÀBaseDhistogrammeToolStripMenuItem1.Name = "lesTraitementsÀBaseDhistogrammeToolStripMenuItem1";
            this.lesTraitementsÀBaseDhistogrammeToolStripMenuItem1.Size = new System.Drawing.Size(329, 24);
            this.lesTraitementsÀBaseDhistogrammeToolStripMenuItem1.Text = "Les traitements à base d\'histogramme";
            // 
            // laTranslationDhistogrammeToolStripMenuItem1
            // 
            this.laTranslationDhistogrammeToolStripMenuItem1.Name = "laTranslationDhistogrammeToolStripMenuItem1";
            this.laTranslationDhistogrammeToolStripMenuItem1.Size = new System.Drawing.Size(271, 24);
            this.laTranslationDhistogrammeToolStripMenuItem1.Text = "La translation d\'histogramme";
            this.laTranslationDhistogrammeToolStripMenuItem1.Click += new System.EventHandler(this.laTranslationDhistogrammeToolStripMenuItem1_Click);
            // 
            // linversionDhistogrammeToolStripMenuItem1
            // 
            this.linversionDhistogrammeToolStripMenuItem1.Name = "linversionDhistogrammeToolStripMenuItem1";
            this.linversionDhistogrammeToolStripMenuItem1.Size = new System.Drawing.Size(271, 24);
            this.linversionDhistogrammeToolStripMenuItem1.Text = "L\'inversion d\'histogramme";
            this.linversionDhistogrammeToolStripMenuItem1.Click += new System.EventHandler(this.linversionDhistogrammeToolStripMenuItem1_Click);
            // 
            // lexpansionDeDynamiqueToolStripMenuItem1
            // 
            this.lexpansionDeDynamiqueToolStripMenuItem1.Name = "lexpansionDeDynamiqueToolStripMenuItem1";
            this.lexpansionDeDynamiqueToolStripMenuItem1.Size = new System.Drawing.Size(271, 24);
            this.lexpansionDeDynamiqueToolStripMenuItem1.Text = "L\'expansion de dynamique";
            this.lexpansionDeDynamiqueToolStripMenuItem1.Click += new System.EventHandler(this.lexpansionDeDynamiqueToolStripMenuItem1_Click);
            // 
            // egalisationDeLhistogrammeToolStripMenuItem1
            // 
            this.egalisationDeLhistogrammeToolStripMenuItem1.Name = "egalisationDeLhistogrammeToolStripMenuItem1";
            this.egalisationDeLhistogrammeToolStripMenuItem1.Size = new System.Drawing.Size(271, 24);
            this.egalisationDeLhistogrammeToolStripMenuItem1.Text = "Egalisation de l\'histogramme";
            this.egalisationDeLhistogrammeToolStripMenuItem1.Click += new System.EventHandler(this.egalisationDeLhistogrammeToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1004, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image originale:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1001, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dernier traitement:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(130, 387);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1111, 250);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Histogramme:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1133, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(510, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(450, 250);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Image en gris";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerUnImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem lesTraitementsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lesTraitementsÀBaseDhistogrammeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem laTranslationDhistogrammeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem linversionDhistogrammeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lexpansionDeDynamiqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem egalisationDeLhistogrammeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rendreLimageGriseToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogrammeSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lhistogrammeNormaliséToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lhistogrammeCumuléToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lhistogrammeCumuléNormaliséToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
    }
}

