namespace ficha_electronica
{
    partial class Reporte_ttos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_ttos));
            this.evaluacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fElectronicaDataSet = new ficha_electronica.FElectronicaDataSet();
            this.label = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.evaluacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tratamienntoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluacionTableAdapter = new ficha_electronica.FElectronicaDataSetTableAdapters.EvaluacionTableAdapter();
            this.chart_TtosVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_S_xTtos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Ttos = new System.Windows.Forms.Label();
            this.label_Ses = new System.Windows.Forms.Label();
            this.label_Pcte = new System.Windows.Forms.Label();
            this.label_Eva = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label_ = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fElectronicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamienntoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_TtosVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_S_xTtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // evaluacionBindingSource1
            // 
            this.evaluacionBindingSource1.DataMember = "Evaluacion";
            this.evaluacionBindingSource1.DataSource = this.fElectronicaDataSet;
            // 
            // fElectronicaDataSet
            // 
            this.fElectronicaDataSet.DataSetName = "FElectronicaDataSet";
            this.fElectronicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(27, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(246, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Informe de Tratamientos";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Turquoise;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(764, 29);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // evaluacionBindingSource
            // 
            this.evaluacionBindingSource.DataMember = "Evaluacion";
            // 
            // evaluacionTableAdapter
            // 
            this.evaluacionTableAdapter.ClearBeforeFill = true;
            // 
            // chart_TtosVendidos
            // 
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart_TtosVendidos.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chart_TtosVendidos.Legends.Add(legend1);
            this.chart_TtosVendidos.Location = new System.Drawing.Point(13, 239);
            this.chart_TtosVendidos.Name = "chart_TtosVendidos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_TtosVendidos.Series.Add(series1);
            this.chart_TtosVendidos.Size = new System.Drawing.Size(380, 242);
            this.chart_TtosVendidos.TabIndex = 4;
            this.chart_TtosVendidos.Text = "chart1";
            // 
            // chart_S_xTtos
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_S_xTtos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_S_xTtos.Legends.Add(legend2);
            this.chart_S_xTtos.Location = new System.Drawing.Point(408, 239);
            this.chart_S_xTtos.Name = "chart_S_xTtos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_S_xTtos.Series.Add(series2);
            this.chart_S_xTtos.Size = new System.Drawing.Size(368, 242);
            this.chart_S_xTtos.TabIndex = 5;
            this.chart_S_xTtos.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 85);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_Ttos);
            this.panel1.Controls.Add(this.label_Ses);
            this.panel1.Controls.Add(this.label_Pcte);
            this.panel1.Controls.Add(this.label_Eva);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.label_);
            this.panel1.Controls.Add(this.label_n);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chart_TtosVendidos);
            this.panel1.Controls.Add(this.chart_S_xTtos);
            this.panel1.Location = new System.Drawing.Point(32, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 493);
            this.panel1.TabIndex = 10;
            // 
            // label_Ttos
            // 
            this.label_Ttos.AutoSize = true;
            this.label_Ttos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ttos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Ttos.Location = new System.Drawing.Point(682, 146);
            this.label_Ttos.Name = "label_Ttos";
            this.label_Ttos.Size = new System.Drawing.Size(52, 18);
            this.label_Ttos.TabIndex = 24;
            this.label_Ttos.Text = "label2";
            this.label_Ttos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Ses
            // 
            this.label_Ses.AutoSize = true;
            this.label_Ses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Ses.Location = new System.Drawing.Point(481, 146);
            this.label_Ses.Name = "label_Ses";
            this.label_Ses.Size = new System.Drawing.Size(52, 18);
            this.label_Ses.TabIndex = 23;
            this.label_Ses.Text = "label2";
            this.label_Ses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Pcte
            // 
            this.label_Pcte.AutoSize = true;
            this.label_Pcte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pcte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Pcte.Location = new System.Drawing.Point(272, 143);
            this.label_Pcte.Name = "label_Pcte";
            this.label_Pcte.Size = new System.Drawing.Size(52, 18);
            this.label_Pcte.TabIndex = 22;
            this.label_Pcte.Text = "label2";
            this.label_Pcte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Eva
            // 
            this.label_Eva.AutoSize = true;
            this.label_Eva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Eva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Eva.Location = new System.Drawing.Point(64, 143);
            this.label_Eva.Name = "label_Eva";
            this.label_Eva.Size = new System.Drawing.Size(52, 18);
            this.label_Eva.TabIndex = 21;
            this.label_Eva.Text = "label2";
            this.label_Eva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(467, 46);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(675, 46);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(651, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Q Tratamientos";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(260, 46);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(64, 64);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_.Location = new System.Drawing.Point(464, 116);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(81, 17);
            this.label_.TabIndex = 16;
            this.label_.Text = "Q Sesiones";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_n.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_n.Location = new System.Drawing.Point(248, 116);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(85, 17);
            this.label_n.TabIndex = 15;
            this.label_n.Text = "Q Pacientes";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(216, 94);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(156, 85);
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(620, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 85);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(422, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 85);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Q Evaluaciones";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(57, 46);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(75, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tratamientos Vendidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(460, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sesiones Por Tratamientos";
            // 
            // Reporte_ttos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_ttos";
            this.Text = "Reporte_ttos";
            this.Load += new System.EventHandler(this.Reporte_ttos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fElectronicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamienntoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_TtosVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_S_xTtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource tratamienntoBindingSource;
        private System.Windows.Forms.BindingSource evaluacionBindingSource;
        private FElectronicaDataSet fElectronicaDataSet;
        private System.Windows.Forms.BindingSource evaluacionBindingSource1;
        private FElectronicaDataSetTableAdapters.EvaluacionTableAdapter evaluacionTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_TtosVendidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_S_xTtos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Eva;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label_Pcte;
        private System.Windows.Forms.Label label_Ttos;
        private System.Windows.Forms.Label label_Ses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}