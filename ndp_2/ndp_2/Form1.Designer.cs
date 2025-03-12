namespace ndp_2
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
            label1 = new Label();
            radioButton_noktadrtgn = new RadioButton();
            radioButton_noktacember = new RadioButton();
            radioButton_dkdrtgndkdrtgn = new RadioButton();
            radioButton_dkdrtgncember = new RadioButton();
            radioButton_cembercember = new RadioButton();
            radioButton_noktakure = new RadioButton();
            radioButton_noktadkdrtgnprizma = new RadioButton();
            radioButton_noktasilindir = new RadioButton();
            radioButton_silindirsilindir = new RadioButton();
            radioButton_kurekure = new RadioButton();
            radioButton_kuresilindir = new RadioButton();
            radioButton_yuzeykure = new RadioButton();
            radioButton_yuzeydkdrtgnprizma = new RadioButton();
            radioButton_yuzeysilindir = new RadioButton();
            radioButton_kuredkdrtgnprizma = new RadioButton();
            radioButton_dkdrtgnprizmadkdrtgnprizma = new RadioButton();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            Xkoordinati = new Label();
            Xkoordinati2 = new Label();
            Ykoordinati = new Label();
            Ykoordinati2 = new Label();
            Zkoordinati = new Label();
            Zkoordinati2 = new Label();
            Yukseklik = new Label();
            Yukseklik2 = new Label();
            Genislik = new Label();
            Genislik2 = new Label();
            cap = new Label();
            cap2 = new Label();
            xkoordinat = new TextBox();
            çap2 = new TextBox();
            çap = new TextBox();
            genişlik2 = new TextBox();
            genişlik = new TextBox();
            yükseklik2 = new TextBox();
            yükseklik = new TextBox();
            zkoordinat2 = new TextBox();
            zkoordinat = new TextBox();
            Ykoordinat2 = new TextBox();
            xkoordinat2 = new TextBox();
            Ykoordinat = new TextBox();
            verigetir_cizdir = new Button();
            carpisma = new Button();
            label4 = new Label();
            derinlik = new Label();
            derinlik2 = new Label();
            derin = new TextBox();
            derin2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 22);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(342, 52);
            label1.TabIndex = 0;
            label1.Text = "Çarpışma denetimi yapmak istediğiniz nesneleri seçiniz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton_noktadrtgn
            // 
            radioButton_noktadrtgn.BackColor = SystemColors.ActiveCaption;
            radioButton_noktadrtgn.Location = new Point(28, 88);
            radioButton_noktadrtgn.Name = "radioButton_noktadrtgn";
            radioButton_noktadrtgn.Size = new Size(315, 25);
            radioButton_noktadrtgn.TabIndex = 1;
            radioButton_noktadrtgn.TabStop = true;
            radioButton_noktadrtgn.Text = "Nokta-Dörtgen\r\n";
            radioButton_noktadrtgn.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_noktadrtgn.UseVisualStyleBackColor = false;
            radioButton_noktadrtgn.CheckedChanged += radioButton_noktadrtgn_CheckedChanged;
            // 
            // radioButton_noktacember
            // 
            radioButton_noktacember.BackColor = SystemColors.ActiveCaption;
            radioButton_noktacember.Location = new Point(28, 129);
            radioButton_noktacember.Name = "radioButton_noktacember";
            radioButton_noktacember.Size = new Size(315, 25);
            radioButton_noktacember.TabIndex = 2;
            radioButton_noktacember.TabStop = true;
            radioButton_noktacember.Text = "Nokta-Çember";
            radioButton_noktacember.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_noktacember.UseVisualStyleBackColor = false;
            radioButton_noktacember.CheckedChanged += radioButton_noktacember_CheckedChanged;
            // 
            // radioButton_dkdrtgndkdrtgn
            // 
            radioButton_dkdrtgndkdrtgn.BackColor = SystemColors.ActiveCaption;
            radioButton_dkdrtgndkdrtgn.Location = new Point(28, 170);
            radioButton_dkdrtgndkdrtgn.Name = "radioButton_dkdrtgndkdrtgn";
            radioButton_dkdrtgndkdrtgn.Size = new Size(315, 25);
            radioButton_dkdrtgndkdrtgn.TabIndex = 3;
            radioButton_dkdrtgndkdrtgn.TabStop = true;
            radioButton_dkdrtgndkdrtgn.Text = "Dikdörtgen-Dikdörtgen";
            radioButton_dkdrtgndkdrtgn.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_dkdrtgndkdrtgn.UseVisualStyleBackColor = false;
            radioButton_dkdrtgndkdrtgn.CheckedChanged += radioButton_dkdrtgndkdrtgn_CheckedChanged;
            // 
            // radioButton_dkdrtgncember
            // 
            radioButton_dkdrtgncember.BackColor = SystemColors.ActiveCaption;
            radioButton_dkdrtgncember.Location = new Point(28, 211);
            radioButton_dkdrtgncember.Name = "radioButton_dkdrtgncember";
            radioButton_dkdrtgncember.Size = new Size(315, 25);
            radioButton_dkdrtgncember.TabIndex = 4;
            radioButton_dkdrtgncember.TabStop = true;
            radioButton_dkdrtgncember.Text = "Dikdörtgen-Çember";
            radioButton_dkdrtgncember.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_dkdrtgncember.UseVisualStyleBackColor = false;
            radioButton_dkdrtgncember.CheckedChanged += radioButton_dkdrtgncember_CheckedChanged;
            // 
            // radioButton_cembercember
            // 
            radioButton_cembercember.BackColor = SystemColors.ActiveCaption;
            radioButton_cembercember.Location = new Point(28, 252);
            radioButton_cembercember.Name = "radioButton_cembercember";
            radioButton_cembercember.Size = new Size(315, 25);
            radioButton_cembercember.TabIndex = 5;
            radioButton_cembercember.TabStop = true;
            radioButton_cembercember.Text = "Çember-Çember";
            radioButton_cembercember.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_cembercember.UseVisualStyleBackColor = false;
            radioButton_cembercember.CheckedChanged += radioButton_cembercember_CheckedChanged;
            // 
            // radioButton_noktakure
            // 
            radioButton_noktakure.BackColor = SystemColors.ActiveCaption;
            radioButton_noktakure.Location = new Point(28, 290);
            radioButton_noktakure.Name = "radioButton_noktakure";
            radioButton_noktakure.Size = new Size(315, 25);
            radioButton_noktakure.TabIndex = 6;
            radioButton_noktakure.TabStop = true;
            radioButton_noktakure.Text = "Nokta-Küre";
            radioButton_noktakure.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_noktakure.UseVisualStyleBackColor = false;
            radioButton_noktakure.CheckedChanged += radioButton_noktakure_CheckedChanged;
            // 
            // radioButton_noktadkdrtgnprizma
            // 
            radioButton_noktadkdrtgnprizma.BackColor = SystemColors.ActiveCaption;
            radioButton_noktadkdrtgnprizma.Location = new Point(28, 330);
            radioButton_noktadkdrtgnprizma.Name = "radioButton_noktadkdrtgnprizma";
            radioButton_noktadkdrtgnprizma.Size = new Size(315, 25);
            radioButton_noktadkdrtgnprizma.TabIndex = 7;
            radioButton_noktadkdrtgnprizma.TabStop = true;
            radioButton_noktadkdrtgnprizma.Text = "Nokta-Dikdörtgen Prizma";
            radioButton_noktadkdrtgnprizma.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_noktadkdrtgnprizma.UseVisualStyleBackColor = false;
            radioButton_noktadkdrtgnprizma.CheckedChanged += radioButton_noktadkdrtgnprizma_CheckedChanged;
            // 
            // radioButton_noktasilindir
            // 
            radioButton_noktasilindir.BackColor = SystemColors.ActiveCaption;
            radioButton_noktasilindir.Location = new Point(28, 370);
            radioButton_noktasilindir.Name = "radioButton_noktasilindir";
            radioButton_noktasilindir.Size = new Size(315, 25);
            radioButton_noktasilindir.TabIndex = 8;
            radioButton_noktasilindir.TabStop = true;
            radioButton_noktasilindir.Text = "Nokta-Silindir";
            radioButton_noktasilindir.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_noktasilindir.UseVisualStyleBackColor = false;
            radioButton_noktasilindir.CheckedChanged += radioButton_noktasilindir_CheckedChanged;
            // 
            // radioButton_silindirsilindir
            // 
            radioButton_silindirsilindir.BackColor = SystemColors.ActiveCaption;
            radioButton_silindirsilindir.Location = new Point(28, 410);
            radioButton_silindirsilindir.Name = "radioButton_silindirsilindir";
            radioButton_silindirsilindir.Size = new Size(315, 25);
            radioButton_silindirsilindir.TabIndex = 9;
            radioButton_silindirsilindir.TabStop = true;
            radioButton_silindirsilindir.Text = "Silindir-Silindir";
            radioButton_silindirsilindir.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_silindirsilindir.UseVisualStyleBackColor = false;
            radioButton_silindirsilindir.CheckedChanged += radioButton_silindirsilindir_CheckedChanged;
            // 
            // radioButton_kurekure
            // 
            radioButton_kurekure.BackColor = SystemColors.ActiveCaption;
            radioButton_kurekure.Location = new Point(28, 450);
            radioButton_kurekure.Name = "radioButton_kurekure";
            radioButton_kurekure.Size = new Size(315, 25);
            radioButton_kurekure.TabIndex = 10;
            radioButton_kurekure.TabStop = true;
            radioButton_kurekure.Text = "Küre-Küre";
            radioButton_kurekure.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_kurekure.UseVisualStyleBackColor = false;
            radioButton_kurekure.CheckedChanged += radioButton_kurekure_CheckedChanged;
            // 
            // radioButton_kuresilindir
            // 
            radioButton_kuresilindir.BackColor = SystemColors.ActiveCaption;
            radioButton_kuresilindir.Location = new Point(28, 490);
            radioButton_kuresilindir.Name = "radioButton_kuresilindir";
            radioButton_kuresilindir.Size = new Size(315, 25);
            radioButton_kuresilindir.TabIndex = 11;
            radioButton_kuresilindir.TabStop = true;
            radioButton_kuresilindir.Text = "Küre-Silindir";
            radioButton_kuresilindir.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_kuresilindir.UseVisualStyleBackColor = false;
            radioButton_kuresilindir.CheckedChanged += radioButton_kuresilindir_CheckedChanged;
            // 
            // radioButton_yuzeykure
            // 
            radioButton_yuzeykure.BackColor = SystemColors.ActiveCaption;
            radioButton_yuzeykure.Location = new Point(28, 530);
            radioButton_yuzeykure.Name = "radioButton_yuzeykure";
            radioButton_yuzeykure.Size = new Size(315, 25);
            radioButton_yuzeykure.TabIndex = 12;
            radioButton_yuzeykure.TabStop = true;
            radioButton_yuzeykure.Text = "Yüzey-Küre";
            radioButton_yuzeykure.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_yuzeykure.UseVisualStyleBackColor = false;
            radioButton_yuzeykure.CheckedChanged += radioButton_yuzeykure_CheckedChanged;
            // 
            // radioButton_yuzeydkdrtgnprizma
            // 
            radioButton_yuzeydkdrtgnprizma.BackColor = SystemColors.ActiveCaption;
            radioButton_yuzeydkdrtgnprizma.Location = new Point(28, 573);
            radioButton_yuzeydkdrtgnprizma.Name = "radioButton_yuzeydkdrtgnprizma";
            radioButton_yuzeydkdrtgnprizma.Size = new Size(315, 25);
            radioButton_yuzeydkdrtgnprizma.TabIndex = 13;
            radioButton_yuzeydkdrtgnprizma.TabStop = true;
            radioButton_yuzeydkdrtgnprizma.Text = "Yüzey-Dikdörtgen Prizma";
            radioButton_yuzeydkdrtgnprizma.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_yuzeydkdrtgnprizma.UseVisualStyleBackColor = false;
            radioButton_yuzeydkdrtgnprizma.CheckedChanged += radioButton_yuzeydkdrtgnprizma_CheckedChanged;
            // 
            // radioButton_yuzeysilindir
            // 
            radioButton_yuzeysilindir.BackColor = SystemColors.ActiveCaption;
            radioButton_yuzeysilindir.Location = new Point(28, 616);
            radioButton_yuzeysilindir.Name = "radioButton_yuzeysilindir";
            radioButton_yuzeysilindir.Size = new Size(315, 25);
            radioButton_yuzeysilindir.TabIndex = 14;
            radioButton_yuzeysilindir.TabStop = true;
            radioButton_yuzeysilindir.Text = "Yüzey-Silindir";
            radioButton_yuzeysilindir.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_yuzeysilindir.UseVisualStyleBackColor = false;
            radioButton_yuzeysilindir.CheckedChanged += radioButton_yuzeysilindir_CheckedChanged;
            // 
            // radioButton_kuredkdrtgnprizma
            // 
            radioButton_kuredkdrtgnprizma.BackColor = SystemColors.ActiveCaption;
            radioButton_kuredkdrtgnprizma.Location = new Point(28, 656);
            radioButton_kuredkdrtgnprizma.Name = "radioButton_kuredkdrtgnprizma";
            radioButton_kuredkdrtgnprizma.Size = new Size(315, 25);
            radioButton_kuredkdrtgnprizma.TabIndex = 15;
            radioButton_kuredkdrtgnprizma.TabStop = true;
            radioButton_kuredkdrtgnprizma.Text = "Küre-Dikdörtgen Prizma";
            radioButton_kuredkdrtgnprizma.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_kuredkdrtgnprizma.UseVisualStyleBackColor = false;
            radioButton_kuredkdrtgnprizma.CheckedChanged += radioButton_kuredkdrtgnprizma_CheckedChanged;
            // 
            // radioButton_dkdrtgnprizmadkdrtgnprizma
            // 
            radioButton_dkdrtgnprizmadkdrtgnprizma.BackColor = SystemColors.ActiveCaption;
            radioButton_dkdrtgnprizmadkdrtgnprizma.Location = new Point(28, 700);
            radioButton_dkdrtgnprizmadkdrtgnprizma.Name = "radioButton_dkdrtgnprizmadkdrtgnprizma";
            radioButton_dkdrtgnprizmadkdrtgnprizma.Size = new Size(315, 25);
            radioButton_dkdrtgnprizmadkdrtgnprizma.TabIndex = 16;
            radioButton_dkdrtgnprizmadkdrtgnprizma.TabStop = true;
            radioButton_dkdrtgnprizmadkdrtgnprizma.Text = "Dikdörtgen Prizma-Dikdörtgen Prizma";
            radioButton_dkdrtgnprizmadkdrtgnprizma.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_dkdrtgnprizmadkdrtgnprizma.UseVisualStyleBackColor = false;
            radioButton_dkdrtgnprizmadkdrtgnprizma.CheckedChanged += radioButton_dkdrtgnprizmadkdrtgnprizma_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(366, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(729, 757);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1130, 12);
            label2.Name = "label2";
            label2.Size = new Size(308, 31);
            label2.TabIndex = 18;
            label2.Text = "Çarpışma Verileri";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1115, 69);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 19;
            label3.Text = "label3";
            // 
            // Xkoordinati
            // 
            Xkoordinati.AutoSize = true;
            Xkoordinati.Location = new Point(1130, 109);
            Xkoordinati.Name = "Xkoordinati";
            Xkoordinati.Size = new Size(90, 20);
            Xkoordinati.TabIndex = 21;
            Xkoordinati.Text = "X koordinatı";
            // 
            // Xkoordinati2
            // 
            Xkoordinati2.AutoSize = true;
            Xkoordinati2.Location = new Point(1329, 109);
            Xkoordinati2.Name = "Xkoordinati2";
            Xkoordinati2.Size = new Size(90, 20);
            Xkoordinati2.TabIndex = 22;
            Xkoordinati2.Text = "X koordinatı";
            // 
            // Ykoordinati
            // 
            Ykoordinati.AutoSize = true;
            Ykoordinati.Location = new Point(1130, 170);
            Ykoordinati.Name = "Ykoordinati";
            Ykoordinati.Size = new Size(89, 20);
            Ykoordinati.TabIndex = 23;
            Ykoordinati.Text = "Y koordinatı";
            // 
            // Ykoordinati2
            // 
            Ykoordinati2.AutoSize = true;
            Ykoordinati2.Location = new Point(1332, 170);
            Ykoordinati2.Name = "Ykoordinati2";
            Ykoordinati2.Size = new Size(89, 20);
            Ykoordinati2.TabIndex = 24;
            Ykoordinati2.Text = "Y koordinatı";
            // 
            // Zkoordinati
            // 
            Zkoordinati.AutoSize = true;
            Zkoordinati.Location = new Point(1132, 233);
            Zkoordinati.Name = "Zkoordinati";
            Zkoordinati.Size = new Size(90, 20);
            Zkoordinati.TabIndex = 25;
            Zkoordinati.Text = "Z koordinatı";
            // 
            // Zkoordinati2
            // 
            Zkoordinati2.AutoSize = true;
            Zkoordinati2.Location = new Point(1329, 233);
            Zkoordinati2.Name = "Zkoordinati2";
            Zkoordinati2.Size = new Size(90, 20);
            Zkoordinati2.TabIndex = 26;
            Zkoordinati2.Text = "Z koordinatı";
            // 
            // Yukseklik
            // 
            Yukseklik.AutoSize = true;
            Yukseklik.Location = new Point(1147, 295);
            Yukseklik.Name = "Yukseklik";
            Yukseklik.Size = new Size(68, 20);
            Yukseklik.TabIndex = 27;
            Yukseklik.Text = "Yükseklik";
            // 
            // Yukseklik2
            // 
            Yukseklik2.AutoSize = true;
            Yukseklik2.Location = new Point(1339, 295);
            Yukseklik2.Name = "Yukseklik2";
            Yukseklik2.Size = new Size(68, 20);
            Yukseklik2.TabIndex = 28;
            Yukseklik2.Text = "Yükseklik";
            // 
            // Genislik
            // 
            Genislik.AutoSize = true;
            Genislik.Location = new Point(1147, 359);
            Genislik.Name = "Genislik";
            Genislik.Size = new Size(60, 20);
            Genislik.TabIndex = 29;
            Genislik.Text = "Genişlik";
            // 
            // Genislik2
            // 
            Genislik2.AutoSize = true;
            Genislik2.Location = new Point(1339, 359);
            Genislik2.Name = "Genislik2";
            Genislik2.Size = new Size(60, 20);
            Genislik2.TabIndex = 30;
            Genislik2.Text = "Genişlik";
            // 
            // cap
            // 
            cap.AutoSize = true;
            cap.Location = new Point(1156, 428);
            cap.Name = "cap";
            cap.Size = new Size(35, 20);
            cap.TabIndex = 31;
            cap.Text = "Çap";
            // 
            // cap2
            // 
            cap2.AutoSize = true;
            cap2.Location = new Point(1349, 428);
            cap2.Name = "cap2";
            cap2.Size = new Size(35, 20);
            cap2.TabIndex = 32;
            cap2.Text = "Çap";
            // 
            // xkoordinat
            // 
            xkoordinat.Location = new Point(1115, 132);
            xkoordinat.Name = "xkoordinat";
            xkoordinat.Size = new Size(125, 27);
            xkoordinat.TabIndex = 35;
            // 
            // çap2
            // 
            çap2.Location = new Point(1313, 451);
            çap2.Name = "çap2";
            çap2.Size = new Size(125, 27);
            çap2.TabIndex = 36;
            // 
            // çap
            // 
            çap.Location = new Point(1115, 451);
            çap.Name = "çap";
            çap.Size = new Size(125, 27);
            çap.TabIndex = 37;
            // 
            // genişlik2
            // 
            genişlik2.Location = new Point(1313, 385);
            genişlik2.Name = "genişlik2";
            genişlik2.Size = new Size(125, 27);
            genişlik2.TabIndex = 38;
            // 
            // genişlik
            // 
            genişlik.Location = new Point(1115, 385);
            genişlik.Name = "genişlik";
            genişlik.Size = new Size(125, 27);
            genişlik.TabIndex = 39;
            // 
            // yükseklik2
            // 
            yükseklik2.Location = new Point(1313, 318);
            yükseklik2.Name = "yükseklik2";
            yükseklik2.Size = new Size(125, 27);
            yükseklik2.TabIndex = 40;
            // 
            // yükseklik
            // 
            yükseklik.Location = new Point(1115, 318);
            yükseklik.Name = "yükseklik";
            yükseklik.Size = new Size(125, 27);
            yükseklik.TabIndex = 41;
            // 
            // zkoordinat2
            // 
            zkoordinat2.Location = new Point(1313, 256);
            zkoordinat2.Name = "zkoordinat2";
            zkoordinat2.Size = new Size(125, 27);
            zkoordinat2.TabIndex = 42;
            // 
            // zkoordinat
            // 
            zkoordinat.Location = new Point(1115, 256);
            zkoordinat.Name = "zkoordinat";
            zkoordinat.Size = new Size(125, 27);
            zkoordinat.TabIndex = 43;
            // 
            // Ykoordinat2
            // 
            Ykoordinat2.Location = new Point(1313, 193);
            Ykoordinat2.Name = "Ykoordinat2";
            Ykoordinat2.Size = new Size(125, 27);
            Ykoordinat2.TabIndex = 44;
            // 
            // xkoordinat2
            // 
            xkoordinat2.Location = new Point(1313, 132);
            xkoordinat2.Name = "xkoordinat2";
            xkoordinat2.Size = new Size(125, 27);
            xkoordinat2.TabIndex = 45;
            // 
            // Ykoordinat
            // 
            Ykoordinat.Location = new Point(1115, 193);
            Ykoordinat.Name = "Ykoordinat";
            Ykoordinat.Size = new Size(125, 27);
            Ykoordinat.TabIndex = 46;
            // 
            // verigetir_cizdir
            // 
            verigetir_cizdir.BackColor = SystemColors.ActiveCaption;
            verigetir_cizdir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            verigetir_cizdir.Location = new Point(1147, 595);
            verigetir_cizdir.Name = "verigetir_cizdir";
            verigetir_cizdir.Size = new Size(237, 46);
            verigetir_cizdir.TabIndex = 47;
            verigetir_cizdir.Text = "Veri Getir ve Çizdir";
            verigetir_cizdir.UseVisualStyleBackColor = false;
            verigetir_cizdir.Click += verigetir_cizdir_Click;
            // 
            // carpisma
            // 
            carpisma.BackColor = SystemColors.ActiveCaption;
            carpisma.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            carpisma.Location = new Point(1115, 679);
            carpisma.Name = "carpisma";
            carpisma.Size = new Size(306, 65);
            carpisma.TabIndex = 48;
            carpisma.Text = "Çarpışma verileri için tıklayın!";
            carpisma.UseVisualStyleBackColor = false;
            carpisma.Click += carpisma_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1299, 69);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 49;
            label4.Text = "label4";
            // 
            // derinlik
            // 
            derinlik.AutoSize = true;
            derinlik.Location = new Point(1147, 495);
            derinlik.Name = "derinlik";
            derinlik.Size = new Size(60, 20);
            derinlik.TabIndex = 50;
            derinlik.Text = "Derinlik";
            // 
            // derinlik2
            // 
            derinlik2.AutoSize = true;
            derinlik2.Location = new Point(1339, 495);
            derinlik2.Name = "derinlik2";
            derinlik2.Size = new Size(60, 20);
            derinlik2.TabIndex = 51;
            derinlik2.Text = "Derinlik";
            // 
            // derin
            // 
            derin.Location = new Point(1115, 528);
            derin.Name = "derin";
            derin.Size = new Size(125, 27);
            derin.TabIndex = 52;
            // 
            // derin2
            // 
            derin2.Location = new Point(1313, 528);
            derin2.Name = "derin2";
            derin2.Size = new Size(125, 27);
            derin2.TabIndex = 53;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 781);
            Controls.Add(derin2);
            Controls.Add(derin);
            Controls.Add(derinlik2);
            Controls.Add(derinlik);
            Controls.Add(label4);
            Controls.Add(carpisma);
            Controls.Add(verigetir_cizdir);
            Controls.Add(Ykoordinat);
            Controls.Add(xkoordinat2);
            Controls.Add(Ykoordinat2);
            Controls.Add(zkoordinat);
            Controls.Add(zkoordinat2);
            Controls.Add(yükseklik);
            Controls.Add(yükseklik2);
            Controls.Add(genişlik);
            Controls.Add(genişlik2);
            Controls.Add(çap);
            Controls.Add(çap2);
            Controls.Add(xkoordinat);
            Controls.Add(cap2);
            Controls.Add(cap);
            Controls.Add(Genislik2);
            Controls.Add(Genislik);
            Controls.Add(Yukseklik2);
            Controls.Add(Yukseklik);
            Controls.Add(Zkoordinati2);
            Controls.Add(Zkoordinati);
            Controls.Add(Ykoordinati2);
            Controls.Add(Ykoordinati);
            Controls.Add(Xkoordinati2);
            Controls.Add(Xkoordinati);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(radioButton_dkdrtgnprizmadkdrtgnprizma);
            Controls.Add(radioButton_kuredkdrtgnprizma);
            Controls.Add(radioButton_yuzeysilindir);
            Controls.Add(radioButton_yuzeydkdrtgnprizma);
            Controls.Add(radioButton_yuzeykure);
            Controls.Add(radioButton_kuresilindir);
            Controls.Add(radioButton_kurekure);
            Controls.Add(radioButton_silindirsilindir);
            Controls.Add(radioButton_noktasilindir);
            Controls.Add(radioButton_noktadkdrtgnprizma);
            Controls.Add(radioButton_noktakure);
            Controls.Add(radioButton_cembercember);
            Controls.Add(radioButton_dkdrtgncember);
            Controls.Add(radioButton_dkdrtgndkdrtgn);
            Controls.Add(radioButton_noktacember);
            Controls.Add(radioButton_noktadrtgn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton_noktadrtgn;
        private RadioButton radioButton_noktacember;
        private RadioButton radioButton_dkdrtgndkdrtgn;
        private RadioButton radioButton_dkdrtgncember;
        private RadioButton radioButton_cembercember;
        private RadioButton radioButton_noktakure;
        private RadioButton radioButton_noktadkdrtgnprizma;
        private RadioButton radioButton_noktasilindir;
        private RadioButton radioButton_silindirsilindir;
        private RadioButton radioButton_kurekure;
        private RadioButton radioButton_kuresilindir;
        private RadioButton radioButton_yuzeykure;
        private RadioButton radioButton_yuzeydkdrtgnprizma;
        private RadioButton radioButton_yuzeysilindir;
        private RadioButton radioButton_kuredkdrtgnprizma;
        private RadioButton radioButton_dkdrtgnprizmadkdrtgnprizma;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label Xkoordinati;
        private Label Xkoordinati2;
        private Label Ykoordinati;
        private Label Ykoordinati2;
        private Label Zkoordinati;
        private Label Zkoordinati2;
        private Label Yukseklik;
        private Label Yukseklik2;
        private Label Genislik;
        private Label Genislik2;
        private Label cap;
        private Label cap2;
        private TextBox xkoordinat;
        private TextBox çap2;
        private TextBox çap;
        private TextBox genişlik2;
        private TextBox genişlik;
        private TextBox yükseklik2;
        private TextBox yükseklik;
        private TextBox zkoordinat2;
        private TextBox zkoordinat;
        private TextBox Ykoordinat2;
        private TextBox xkoordinat2;
        private TextBox Ykoordinat;
        private Button verigetir_cizdir;
        private Button carpisma;
        private Label label4;
        private Label derinlik;
        private Label derinlik2;
        private TextBox derin;
        private TextBox derin2;
    }
}