namespace RondellCalc_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_StartCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_OuterDiameter = new System.Windows.Forms.TextBox();
            this.txt_StoneLengthA = new System.Windows.Forms.TextBox();
            this.txt_StoneLengthB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ConcretePackWeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ConcreteWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ConcretePackCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ConcreteVolumen = new System.Windows.Forms.TextBox();
            this.txt_StoneCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SegmentAngle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MinOuterDiameter = new System.Windows.Forms.TextBox();
            this.txt_MaxOuterDiameter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pic_Sketch = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sketch)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_StartCalc
            // 
            this.btn_StartCalc.Location = new System.Drawing.Point(12, 221);
            this.btn_StartCalc.Name = "btn_StartCalc";
            this.btn_StartCalc.Size = new System.Drawing.Size(317, 31);
            this.btn_StartCalc.TabIndex = 0;
            this.btn_StartCalc.Text = "Berechnung starten";
            this.btn_StartCalc.UseVisualStyleBackColor = true;
            this.btn_StartCalc.Click += new System.EventHandler(this.btn_StartCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kantenlänge B [cm]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kantenlänge A [cm]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Außendurchmesser [m]";
            // 
            // txt_OuterDiameter
            // 
            this.txt_OuterDiameter.Location = new System.Drawing.Point(193, 26);
            this.txt_OuterDiameter.Name = "txt_OuterDiameter";
            this.txt_OuterDiameter.Size = new System.Drawing.Size(100, 20);
            this.txt_OuterDiameter.TabIndex = 5;
            this.txt_OuterDiameter.Text = "4,88";
            // 
            // txt_StoneLengthA
            // 
            this.txt_StoneLengthA.Location = new System.Drawing.Point(193, 52);
            this.txt_StoneLengthA.Name = "txt_StoneLengthA";
            this.txt_StoneLengthA.Size = new System.Drawing.Size(100, 20);
            this.txt_StoneLengthA.TabIndex = 6;
            this.txt_StoneLengthA.Text = "40";
            // 
            // txt_StoneLengthB
            // 
            this.txt_StoneLengthB.Location = new System.Drawing.Point(193, 78);
            this.txt_StoneLengthB.Name = "txt_StoneLengthB";
            this.txt_StoneLengthB.Size = new System.Drawing.Size(100, 20);
            this.txt_StoneLengthB.TabIndex = 7;
            this.txt_StoneLengthB.Text = "40";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ConcretePackWeight);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_ConcreteWidth);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_StoneLengthB);
            this.groupBox1.Controls.Add(this.txt_StoneLengthA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_OuterDiameter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 176);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ausgangsdaten";
            // 
            // txt_ConcretePackWeight
            // 
            this.txt_ConcretePackWeight.Location = new System.Drawing.Point(193, 138);
            this.txt_ConcretePackWeight.Name = "txt_ConcretePackWeight";
            this.txt_ConcretePackWeight.Size = new System.Drawing.Size(100, 20);
            this.txt_ConcretePackWeight.TabIndex = 11;
            this.txt_ConcretePackWeight.Text = "40";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Betonsackinhalt [kg]";
            // 
            // txt_ConcreteWidth
            // 
            this.txt_ConcreteWidth.Location = new System.Drawing.Point(193, 112);
            this.txt_ConcreteWidth.Name = "txt_ConcreteWidth";
            this.txt_ConcreteWidth.Size = new System.Drawing.Size(100, 20);
            this.txt_ConcreteWidth.TabIndex = 9;
            this.txt_ConcreteWidth.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Höhe Pflasterbett [cm]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_ConcretePackCount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_ConcreteVolumen);
            this.groupBox2.Controls.Add(this.txt_StoneCount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_SegmentAngle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_MinOuterDiameter);
            this.groupBox2.Controls.Add(this.txt_MaxOuterDiameter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 197);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ergebnis";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Anzahl Betonsäche";
            // 
            // txt_ConcretePackCount
            // 
            this.txt_ConcretePackCount.Enabled = false;
            this.txt_ConcretePackCount.Location = new System.Drawing.Point(193, 165);
            this.txt_ConcretePackCount.Name = "txt_ConcretePackCount";
            this.txt_ConcretePackCount.Size = new System.Drawing.Size(100, 20);
            this.txt_ConcretePackCount.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Volumen Bett [m³]";
            // 
            // txt_ConcreteVolumen
            // 
            this.txt_ConcreteVolumen.Enabled = false;
            this.txt_ConcreteVolumen.Location = new System.Drawing.Point(193, 139);
            this.txt_ConcreteVolumen.Name = "txt_ConcreteVolumen";
            this.txt_ConcreteVolumen.Size = new System.Drawing.Size(100, 20);
            this.txt_ConcreteVolumen.TabIndex = 15;
            // 
            // txt_StoneCount
            // 
            this.txt_StoneCount.Enabled = false;
            this.txt_StoneCount.Location = new System.Drawing.Point(193, 29);
            this.txt_StoneCount.Name = "txt_StoneCount";
            this.txt_StoneCount.Size = new System.Drawing.Size(100, 20);
            this.txt_StoneCount.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Anzahl der Steine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Segmentwinkel [°]";
            // 
            // txt_SegmentAngle
            // 
            this.txt_SegmentAngle.Enabled = false;
            this.txt_SegmentAngle.Location = new System.Drawing.Point(193, 107);
            this.txt_SegmentAngle.Name = "txt_SegmentAngle";
            this.txt_SegmentAngle.Size = new System.Drawing.Size(100, 20);
            this.txt_SegmentAngle.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kleinster Außendurchmesser [m]";
            // 
            // txt_MinOuterDiameter
            // 
            this.txt_MinOuterDiameter.Enabled = false;
            this.txt_MinOuterDiameter.Location = new System.Drawing.Point(193, 81);
            this.txt_MinOuterDiameter.Name = "txt_MinOuterDiameter";
            this.txt_MinOuterDiameter.Size = new System.Drawing.Size(100, 20);
            this.txt_MinOuterDiameter.TabIndex = 9;
            // 
            // txt_MaxOuterDiameter
            // 
            this.txt_MaxOuterDiameter.Enabled = false;
            this.txt_MaxOuterDiameter.Location = new System.Drawing.Point(193, 55);
            this.txt_MaxOuterDiameter.Name = "txt_MaxOuterDiameter";
            this.txt_MaxOuterDiameter.Size = new System.Drawing.Size(100, 20);
            this.txt_MaxOuterDiameter.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Außendurchmesser [m]";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pic_Sketch);
            this.groupBox3.Location = new System.Drawing.Point(350, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 457);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skizze";
            // 
            // pic_Sketch
            // 
            this.pic_Sketch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Sketch.Location = new System.Drawing.Point(19, 26);
            this.pic_Sketch.Name = "pic_Sketch";
            this.pic_Sketch.Size = new System.Drawing.Size(400, 400);
            this.pic_Sketch.TabIndex = 0;
            this.pic_Sketch.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_StartCalc);
            this.Name = "Form1";
            this.Text = "RondellCalc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sketch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_StartCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_OuterDiameter;
        private System.Windows.Forms.TextBox txt_StoneLengthA;
        private System.Windows.Forms.TextBox txt_StoneLengthB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_StoneCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SegmentAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MinOuterDiameter;
        private System.Windows.Forms.TextBox txt_MaxOuterDiameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ConcreteWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ConcreteVolumen;
        private System.Windows.Forms.TextBox txt_ConcretePackWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ConcretePackCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pic_Sketch;
    }
}

