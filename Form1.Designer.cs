﻿namespace Clasificador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Parametro_1 = new System.Windows.Forms.TextBox();
            this.Parametro_2 = new System.Windows.Forms.TextBox();
            this.Graficador1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Graficador2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Finalizar = new System.Windows.Forms.Button();
            this.ProbabilidadesFinales = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Conclusion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Parametro_3 = new System.Windows.Forms.TextBox();
            this.Graficador3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graficador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graficador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graficador3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el primer parametro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el segundo parametro: ";
            // 
            // Parametro_1
            // 
            this.Parametro_1.Location = new System.Drawing.Point(168, 77);
            this.Parametro_1.Name = "Parametro_1";
            this.Parametro_1.Size = new System.Drawing.Size(100, 20);
            this.Parametro_1.TabIndex = 2;
            // 
            // Parametro_2
            // 
            this.Parametro_2.Location = new System.Drawing.Point(168, 103);
            this.Parametro_2.Name = "Parametro_2";
            this.Parametro_2.Size = new System.Drawing.Size(100, 20);
            this.Parametro_2.TabIndex = 3;
            // 
            // Graficador1
            // 
            this.Graficador1.BackColor = System.Drawing.Color.LightSalmon;
            chartArea1.Name = "ChartArea1";
            this.Graficador1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graficador1.Legends.Add(legend1);
            this.Graficador1.Location = new System.Drawing.Point(481, 10);
            this.Graficador1.Name = "Graficador1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Graficador1.Series.Add(series1);
            this.Graficador1.Size = new System.Drawing.Size(429, 170);
            this.Graficador1.TabIndex = 4;
            this.Graficador1.Text = "chart1";
            // 
            // Graficador2
            // 
            this.Graficador2.BackColor = System.Drawing.Color.LightSalmon;
            chartArea2.Name = "ChartArea1";
            this.Graficador2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Graficador2.Legends.Add(legend2);
            this.Graficador2.Location = new System.Drawing.Point(481, 186);
            this.Graficador2.Name = "Graficador2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Graficador2.Series.Add(series2);
            this.Graficador2.Size = new System.Drawing.Size(429, 170);
            this.Graficador2.TabIndex = 5;
            this.Graficador2.Text = "chart1";
            // 
            // Finalizar
            // 
            this.Finalizar.Location = new System.Drawing.Point(113, 470);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(75, 23);
            this.Finalizar.TabIndex = 8;
            this.Finalizar.Text = "Finalizar";
            this.Finalizar.UseVisualStyleBackColor = true;
            this.Finalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // ProbabilidadesFinales
            // 
            this.ProbabilidadesFinales.FormattingEnabled = true;
            this.ProbabilidadesFinales.Location = new System.Drawing.Point(53, 242);
            this.ProbabilidadesFinales.Name = "ProbabilidadesFinales";
            this.ProbabilidadesFinales.Size = new System.Drawing.Size(245, 95);
            this.ProbabilidadesFinales.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Probabilidades:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Es mas probable que el objeto sea:";
            // 
            // Conclusion
            // 
            this.Conclusion.AutoSize = true;
            this.Conclusion.Location = new System.Drawing.Point(220, 362);
            this.Conclusion.Name = "Conclusion";
            this.Conclusion.Size = new System.Drawing.Size(0, 13);
            this.Conclusion.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ingresa el tercer parámetro:";
            // 
            // Parametro_3
            // 
            this.Parametro_3.Location = new System.Drawing.Point(168, 129);
            this.Parametro_3.Name = "Parametro_3";
            this.Parametro_3.Size = new System.Drawing.Size(100, 20);
            this.Parametro_3.TabIndex = 14;
            // 
            // Graficador3
            // 
            this.Graficador3.BackColor = System.Drawing.Color.LightSalmon;
            chartArea3.Name = "ChartArea1";
            this.Graficador3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Graficador3.Legends.Add(legend3);
            this.Graficador3.Location = new System.Drawing.Point(481, 362);
            this.Graficador3.Name = "Graficador3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Graficador3.Series.Add(series3);
            this.Graficador3.Size = new System.Drawing.Size(429, 170);
            this.Graficador3.TabIndex = 15;
            this.Graficador3.Text = "chart1";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "ClasificarObjeto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "otros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Iniciar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(933, 538);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Graficador3);
            this.Controls.Add(this.Parametro_3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Conclusion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProbabilidadesFinales);
            this.Controls.Add(this.Finalizar);
            this.Controls.Add(this.Graficador2);
            this.Controls.Add(this.Graficador1);
            this.Controls.Add(this.Parametro_2);
            this.Controls.Add(this.Parametro_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Form1";
            this.Text = "¿Que objeto es?";
            ((System.ComponentModel.ISupportInitialize)(this.Graficador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graficador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graficador3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Parametro_1;
        private System.Windows.Forms.TextBox Parametro_2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graficador1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graficador2;
        private System.Windows.Forms.Button Finalizar;
        private System.Windows.Forms.ListBox ProbabilidadesFinales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Conclusion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Parametro_3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graficador3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

