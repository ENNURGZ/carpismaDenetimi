using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections.Generic;

namespace ndp_2
{

    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void verigetir_cizdir_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            pictureBox1.Refresh();

            //Çizim için genelleyici sınıf listelerini çağırma
            List<nesneler<int>> nsn = new List<nesneler<int>>();

            nokta2boyutlu<int> n2d = new nokta2boyutlu<int>();
            nokta3boyutlu<int> n3d = new nokta3boyutlu<int>();
            dikdörtgen<int> d1 = new dikdörtgen<int>();
            dikdörtgen2<int> d2 = new dikdörtgen2<int>();
            çember<int> ç1 = new çember<int>();
            çember2<int> ç2 = new çember2<int>();
            kure<int> k1 = new kure<int>();
            kure2<int> k2 = new kure2<int>();
            prizma<int> p1 = new prizma<int>();
            prizma2<int> p2 = new prizma2<int>();
            silindir<int> s1 = new silindir<int>();
            silindir2<int> s2 = new silindir2<int>();
            yuzey<int> y = new yuzey<int>();

            //Çİzim İşlemleri

            //nokta-dörtgen
            if (radioButton_noktadrtgn.Checked)
            {
                xxkoordinatdegeri = n2d.xkoordegeri;
                yykoordinatdegeri = n2d.ykoordegeri;

                xkoordinat.Text = n2d.xkoordegeri.ToString();
                Ykoordinat.Text = n2d.ykoordegeri.ToString();

                xxkoordinatdegeri2 = d2.xkoordegeri2;
                yykoordinatdegeri2 = d2.ykoordegeri2;
                ggenislikdegeri2 = d2.genislikdegeri2;
                yyukseklikdegeri2 = d2.yukseklikdegeri2;

                xkoordinat2.Text = d2.xkoordegeri2.ToString();
                Ykoordinat2.Text = d2.ykoordegeri2.ToString();
                genişlik2.Text = d2.genislikdegeri2.ToString();
                yükseklik2.Text = d2.yukseklikdegeri2.ToString();

                n2d.nokta2boyutlu_çiz(pictureBox1);
                d2.dikdörtgen2_çiz(pictureBox1);

            }
            //nokta-çember
            if (radioButton_noktacember.Checked)
            {
                xxkoordinatdegeri = n2d.xkoordegeri;
                yykoordinatdegeri = n2d.ykoordegeri;

                xkoordinat.Text = n2d.xkoordegeri.ToString();
                Ykoordinat.Text = n2d.ykoordegeri.ToString();

                xxkoordinatdegeri2 = ç2.xkoordegeri2;
                yykoordinatdegeri2 = ç2.ykoordegeri2;
                yyaricapdegeri2 = ç2.yaricapdegeri2;

                xkoordinat2.Text = ç2.xkoordegeri2.ToString();
                Ykoordinat2.Text = ç2.ykoordegeri2.ToString();
                çap2.Text = ç2.yaricapdegeri2.ToString();

                n2d.nokta2boyutlu_çiz(pictureBox1);
                ç2.çember2_çiz(pictureBox1);

            }
            //dikdörtgen-dikdörtgen
            if (radioButton_dkdrtgndkdrtgn.Checked)
            {
                xxkoordinatdegeri = d1.xkoordegeri;
                yykoordinatdegeri = d1.ykoordegeri;
                ggenislikdegeri = d1.genislikdegeri;
                yyukseklikdegeri = d1.yukseklikdegeri;

                xkoordinat.Text = d1.xkoordegeri.ToString();
                Ykoordinat.Text = d1.ykoordegeri.ToString();
                genişlik.Text = d1.genislikdegeri.ToString();
                yükseklik.Text = d1.yukseklikdegeri.ToString();

                xxkoordinatdegeri2 = d2.xkoordegeri2;
                yykoordinatdegeri2 = d2.ykoordegeri2;
                ggenislikdegeri2 = d2.genislikdegeri2;
                yyukseklikdegeri2 = d2.yukseklikdegeri2;

                xkoordinat2.Text = d2.xkoordegeri2.ToString();
                Ykoordinat2.Text = d2.ykoordegeri2.ToString();
                genişlik2.Text = d2.genislikdegeri2.ToString();
                yükseklik2.Text = d2.yukseklikdegeri2.ToString();

                d1.dikdörtgen_çiz(pictureBox1);
                d2.dikdörtgen2_çiz(pictureBox1);
            }
            //dikdörtgen-çember
            if (radioButton_dkdrtgncember.Checked)
            {
                xxkoordinatdegeri = d1.xkoordegeri;
                yykoordinatdegeri = d1.ykoordegeri;
                ggenislikdegeri = d1.genislikdegeri;
                yyukseklikdegeri = d1.yukseklikdegeri;

                xkoordinat.Text = d1.xkoordegeri.ToString();
                Ykoordinat.Text = d1.ykoordegeri.ToString();
                genişlik.Text = d1.genislikdegeri.ToString();
                yükseklik.Text = d1.yukseklikdegeri.ToString();

                xxkoordinatdegeri2 = ç2.xkoordegeri2;
                yykoordinatdegeri2 = ç2.ykoordegeri2;
                yyaricapdegeri2 = ç2.yaricapdegeri2;

                xkoordinat2.Text = ç2.xkoordegeri2.ToString();
                Ykoordinat2.Text = ç2.ykoordegeri2.ToString();
                çap2.Text = ç2.yaricapdegeri2.ToString();

                d1.dikdörtgen_çiz(pictureBox1);
                ç2.çember2_çiz(pictureBox1);
            }
            //çember-çember
            if (radioButton_cembercember.Checked)
            {
                xxkoordinatdegeri = ç1.xkoordegeri;
                yykoordinatdegeri = ç1.ykoordegeri;
                yyaricapdegeri = ç1.yaricapdegeri;

                xkoordinat.Text = ç1.xkoordegeri.ToString();
                Ykoordinat.Text = ç1.ykoordegeri.ToString();
                çap.Text = ç1.yaricapdegeri.ToString();

                xxkoordinatdegeri2 = ç2.xkoordegeri2;
                yykoordinatdegeri2 = ç2.ykoordegeri2;
                yyaricapdegeri2 = ç2.yaricapdegeri2;

                xkoordinat2.Text = ç2.xkoordegeri2.ToString();
                Ykoordinat2.Text = ç2.ykoordegeri2.ToString();
                çap2.Text = ç2.yaricapdegeri2.ToString();

                ç1.çember_çiz(pictureBox1);
                ç2.çember2_çiz(pictureBox1);
            }
            //nokta-küre
            if (radioButton_noktakure.Checked)
            {
                xxkoordinatdegeri = n3d.xkoordegeri;
                yykoordinatdegeri = n3d.ykoordegeri;
                zzkoordinatdegeri = n3d.zkoordegeri;

                xkoordinat.Text = n3d.xkoordegeri.ToString();
                Ykoordinat.Text = n3d.ykoordegeri.ToString();
                zkoordinat.Text = n3d.zkoordegeri.ToString();

                xxkoordinatdegeri2 = k2.xkoordegeri2;
                yykoordinatdegeri2 = k2.ykoordegeri2;
                zzkoordinatdegeri2 = k2.zkoordegeri2;
                yyaricapdegeri2 = k2.yaricapdegeri2;

                xkoordinat2.Text = k2.xkoordegeri2.ToString();
                Ykoordinat2.Text = k2.ykoordegeri2.ToString();
                zkoordinat2.Text = k2.zkoordegeri2.ToString();
                çap2.Text = k2.yaricapdegeri2.ToString();

                n3d.nokta3boyutlu_çiz(pictureBox1);
                k2.kure2_çiz(pictureBox1);


            }
            //nokta-dikdörtgenprizma
            if (radioButton_noktadkdrtgnprizma.Checked)
            {
                xxkoordinatdegeri = n3d.xkoordegeri;
                yykoordinatdegeri = n3d.ykoordegeri;
                zzkoordinatdegeri = n3d.zkoordegeri;

                xkoordinat.Text = n3d.xkoordegeri.ToString();
                Ykoordinat.Text = n3d.ykoordegeri.ToString();
                zkoordinat.Text = n3d.zkoordegeri.ToString();

                xkoordinat2.Text = p2.xkoordegeri2.ToString();
                Ykoordinat2.Text = p2.ykoordegeri2.ToString();
                zkoordinat2.Text = p2.zkoordegeri2.ToString();
                genişlik2.Text = p2.genislikdegeri2.ToString();
                yükseklik2.Text = p2.yukseklikdegeri2.ToString();
                derin2.Text = p2.derinlikdegeri2.ToString();

                n3d.nokta3boyutlu_çiz(pictureBox1);
                p2.prizma2_çiz(pictureBox1);
            }
            //nokta-silindir
            if (radioButton_noktasilindir.Checked)
            {
                xxkoordinatdegeri = n3d.xkoordegeri;
                yykoordinatdegeri = n3d.ykoordegeri;
                zzkoordinatdegeri = n3d.zkoordegeri;

                xkoordinat.Text = n3d.xkoordegeri.ToString();
                Ykoordinat.Text = n3d.ykoordegeri.ToString();
                zkoordinat.Text = n3d.zkoordegeri.ToString();

                xxkoordinatdegeri2 = s2.xkoordegeri2;
                yykoordinatdegeri2 = s2.ykoordegeri2;
                zzkoordinatdegeri2 = s2.zkoordegeri2;
                yyaricapdegeri2 = s2.yaricapdegeri2;
                yyukseklikdegeri2 = s2.yukseklikdegeri2;

                xkoordinat2.Text = s2.xkoordegeri2.ToString();
                Ykoordinat2.Text = s2.ykoordegeri2.ToString();
                zkoordinat2.Text = s2.zkoordegeri2.ToString();
                çap2.Text = ç2.yaricapdegeri2.ToString();
                yükseklik2.Text = s2.yukseklikdegeri2.ToString();

                n3d.nokta3boyutlu_çiz(pictureBox1);
                s2.silindir2_çiz(pictureBox1);
            }
            //silindir-silindir
            if (radioButton_silindirsilindir.Checked)
            {
                xxkoordinatdegeri = s1.xkoordegeri;
                yykoordinatdegeri = s1.ykoordegeri;
                zzkoordinatdegeri = s1.zkoordegeri;
                yyaricapdegeri = s1.yaricapdegeri;
                yyukseklikdegeri = s1.yukseklikdegeri;

                xkoordinat.Text = s1.xkoordegeri.ToString();
                Ykoordinat.Text = s1.ykoordegeri.ToString();
                zkoordinat.Text = s1.zkoordegeri.ToString();
                çap.Text = s1.yaricapdegeri.ToString();
                yükseklik.Text = s1.yukseklikdegeri.ToString();

                xxkoordinatdegeri2 = s2.xkoordegeri2;
                yykoordinatdegeri2 = s2.ykoordegeri2;
                zzkoordinatdegeri2 = s2.zkoordegeri2;
                yyaricapdegeri2 = s2.yaricapdegeri2;
                yyukseklikdegeri2 = s2.yukseklikdegeri2;

                xkoordinat2.Text = s2.xkoordegeri2.ToString();
                Ykoordinat2.Text = s2.ykoordegeri2.ToString();
                zkoordinat2.Text = s2.zkoordegeri2.ToString();
                çap2.Text = s2.yaricapdegeri2.ToString();
                yükseklik2.Text = s2.yukseklikdegeri2.ToString();

                s1.silindir_çiz(pictureBox1);
                s2.silindir2_çiz(pictureBox1);
            }
            //küre-küre
            if (radioButton_kurekure.Checked)
            {
                xxkoordinatdegeri = k1.xkoordegeri;
                yykoordinatdegeri = k1.ykoordegeri;
                zzkoordinatdegeri = k1.zkoordegeri;
                yyaricapdegeri = k1.yaricapdegeri;

                xkoordinat.Text = k1.xkoordegeri.ToString();
                Ykoordinat.Text = k1.ykoordegeri.ToString();
                zkoordinat.Text = k1.zkoordegeri.ToString();
                çap.Text = k1.yaricapdegeri.ToString();

                xxkoordinatdegeri2 = k2.xkoordegeri2;
                yykoordinatdegeri2 = k2.ykoordegeri2;
                zzkoordinatdegeri2 = k2.zkoordegeri2;
                yyaricapdegeri2 = k2.yaricapdegeri2;

                xkoordinat2.Text = k2.xkoordegeri2.ToString();
                Ykoordinat2.Text = k2.ykoordegeri2.ToString();
                zkoordinat2.Text = k2.zkoordegeri2.ToString();
                çap2.Text = k2.yaricapdegeri2.ToString();

                k1.kure_çiz(pictureBox1);
                k2.kure2_çiz(pictureBox1);

            }
            //küre-silindir
            if (radioButton_kuresilindir.Checked)
            {
                xxkoordinatdegeri = k1.xkoordegeri;
                yykoordinatdegeri = k1.ykoordegeri;
                zzkoordinatdegeri = k1.zkoordegeri;
                yyaricapdegeri = k1.yaricapdegeri;

                xkoordinat.Text = k1.xkoordegeri.ToString();
                Ykoordinat.Text = k1.ykoordegeri.ToString();
                zkoordinat.Text = k1.zkoordegeri.ToString();
                çap.Text = k1.yaricapdegeri.ToString();

                xxkoordinatdegeri2 = s2.xkoordegeri2;
                yykoordinatdegeri2 = s2.ykoordegeri2;
                zzkoordinatdegeri2 = s2.zkoordegeri2;
                yyaricapdegeri2 = s2.yaricapdegeri2;
                yyukseklikdegeri2 = s2.yukseklikdegeri2;

                xkoordinat2.Text = s2.xkoordegeri2.ToString();
                Ykoordinat2.Text = s2.ykoordegeri2.ToString();
                zkoordinat2.Text = s2.zkoordegeri2.ToString();
                çap2.Text = s2.yaricapdegeri2.ToString();
                yükseklik2.Text = s2.yukseklikdegeri2.ToString();

                k1.kure_çiz(pictureBox1);
                s2.silindir2_çiz(pictureBox1);

            }
            //yüzey-küre
            if (radioButton_yuzeykure.Checked)
            {
                xxkoordinatdegeri = y.xkoordegeri;
                yykoordinatdegeri = y.ykoordegeri;
                zzkoordinatdegeri = y.zkoordegeri;
                ggenislikdegeri = y.genislikdegeri;
                yyukseklikdegeri = y.yukseklikdegeri;
                dderinlikdegeri = y.derinlikdegeri;

                xkoordinat.Text = y.xkoordegeri.ToString();
                Ykoordinat.Text = y.ykoordegeri.ToString();
                zkoordinat.Text = y.zkoordegeri.ToString();
                genişlik.Text = y.genislikdegeri.ToString();
                yükseklik.Text = y.yukseklikdegeri.ToString();
                derin.Text = y.derinlikdegeri.ToString();

                xxkoordinatdegeri2 = k2.xkoordegeri2;
                yykoordinatdegeri2 = k2.ykoordegeri2;
                zzkoordinatdegeri2 = k2.zkoordegeri2;
                yyaricapdegeri2 = k2.yaricapdegeri2;

                xkoordinat2.Text = k2.xkoordegeri2.ToString();
                Ykoordinat2.Text = k2.ykoordegeri2.ToString();
                zkoordinat2.Text = k2.zkoordegeri2.ToString();
                çap2.Text = k2.yaricapdegeri2.ToString();

                y.yuzey_çiz(pictureBox1);
                k2.kure2_çiz(pictureBox1);
            }
            //yüzey-dikdörtgenprizma
            if (radioButton_yuzeydkdrtgnprizma.Checked)
            {
                xxkoordinatdegeri = y.xkoordegeri;
                yykoordinatdegeri = y.ykoordegeri;
                zzkoordinatdegeri = y.zkoordegeri;
                ggenislikdegeri = y.genislikdegeri;
                yyukseklikdegeri = y.yukseklikdegeri;
                dderinlikdegeri = y.derinlikdegeri;

                xkoordinat.Text = y.xkoordegeri.ToString();
                Ykoordinat.Text = y.ykoordegeri.ToString();
                zkoordinat.Text = y.zkoordegeri.ToString();
                genişlik.Text = y.genislikdegeri.ToString();
                yükseklik.Text = y.yukseklikdegeri.ToString();
                derin.Text = y.derinlikdegeri.ToString();

                xxkoordinatdegeri2 = p2.xkoordegeri2;
                yykoordinatdegeri2 = p2.ykoordegeri2;
                zzkoordinatdegeri2 = p2.zkoordegeri2;
                ggenislikdegeri2 = p2.genislikdegeri2;
                yyukseklikdegeri2 = p2.yukseklikdegeri2;
                dderinlikdegeri2 = p2.derinlikdegeri2;

                xkoordinat2.Text = p2.xkoordegeri2.ToString();
                Ykoordinat2.Text = p2.ykoordegeri2.ToString();
                zkoordinat2.Text = p2.zkoordegeri2.ToString();
                genişlik2.Text = p2.genislikdegeri2.ToString();
                yükseklik2.Text = p2.yukseklikdegeri2.ToString();
                derin2.Text = p2.derinlikdegeri2.ToString();

                y.yuzey_çiz(pictureBox1);
                p2.prizma2_çiz(pictureBox1);
            }
            //yüzey-silindir
            if (radioButton_yuzeysilindir.Checked)
            {
                xxkoordinatdegeri = y.xkoordegeri;
                yykoordinatdegeri = y.ykoordegeri;
                zzkoordinatdegeri = y.zkoordegeri;
                ggenislikdegeri = y.genislikdegeri;
                yyukseklikdegeri = y.yukseklikdegeri;
                dderinlikdegeri = y.derinlikdegeri;

                xkoordinat.Text = y.xkoordegeri.ToString();
                Ykoordinat.Text = y.ykoordegeri.ToString();
                zkoordinat.Text = y.zkoordegeri.ToString();
                genişlik.Text = y.genislikdegeri.ToString();
                yükseklik.Text = y.yukseklikdegeri.ToString();
                derin.Text = y.derinlikdegeri.ToString();

                xxkoordinatdegeri2 = s2.xkoordegeri2;
                yykoordinatdegeri2 = s2.ykoordegeri2;
                zzkoordinatdegeri2 = s2.zkoordegeri2;
                yyaricapdegeri2 = s2.yaricapdegeri2;
                yyukseklikdegeri2 = s2.yukseklikdegeri2;

                xkoordinat2.Text = s2.xkoordegeri2.ToString();
                Ykoordinat2.Text = s2.ykoordegeri2.ToString();
                zkoordinat2.Text = s2.zkoordegeri2.ToString();
                çap2.Text = s2.yaricapdegeri2.ToString();
                yükseklik2.Text = s2.yukseklikdegeri2.ToString();

                y.yuzey_çiz(pictureBox1);
                s2.silindir2_çiz(pictureBox1);
            }
            //küre-dikdörtgenprizma
            if (radioButton_kuredkdrtgnprizma.Checked)
            {
                xxkoordinatdegeri = k1.xkoordegeri;
                yykoordinatdegeri = k1.ykoordegeri;
                zzkoordinatdegeri = k1.zkoordegeri;
                yyaricapdegeri = k1.yaricapdegeri;

                xkoordinat.Text = k1.xkoordegeri.ToString();
                Ykoordinat.Text = k1.ykoordegeri.ToString();
                zkoordinat.Text = k1.zkoordegeri.ToString();
                çap.Text = k1.yaricapdegeri.ToString();

                xxkoordinatdegeri2 = p2.xkoordegeri2;
                yykoordinatdegeri2 = p2.ykoordegeri2;
                zzkoordinatdegeri2 = p2.zkoordegeri2;
                ggenislikdegeri2 = p2.genislikdegeri2;
                yyukseklikdegeri2 = p2.yukseklikdegeri2;
                dderinlikdegeri2 = p2.derinlikdegeri2;

                xkoordinat2.Text = p2.xkoordegeri2.ToString();
                Ykoordinat2.Text = p2.ykoordegeri2.ToString();
                zkoordinat2.Text = p2.zkoordegeri2.ToString();
                genişlik2.Text = p2.genislikdegeri2.ToString();
                yükseklik2.Text = p2.yukseklikdegeri2.ToString();
                derin2.Text = p2.derinlikdegeri2.ToString();

                k1.kure_çiz(pictureBox1);
                p2.prizma2_çiz(pictureBox1);
            }
            //dikdörtgenprizma-dikdörtgenprizma
            if (radioButton_dkdrtgnprizmadkdrtgnprizma.Checked)
            {
                xxkoordinatdegeri = p1.xkoordegeri;
                yykoordinatdegeri = p1.ykoordegeri;
                zzkoordinatdegeri = p1.zkoordegeri;
                ggenislikdegeri = p1.genislikdegeri;
                yyukseklikdegeri = p1.yukseklikdegeri;
                dderinlikdegeri = p1.derinlikdegeri;

                xkoordinat.Text = p1.xkoordegeri.ToString();
                Ykoordinat.Text = p1.ykoordegeri.ToString();
                zkoordinat.Text = p1.zkoordegeri.ToString();
                genişlik.Text = p1.genislikdegeri.ToString();
                yükseklik.Text = p1.yukseklikdegeri.ToString();
                derin.Text = p1.derinlikdegeri.ToString();

                xxkoordinatdegeri2 = p2.xkoordegeri2;
                yykoordinatdegeri2 = p2.ykoordegeri2;
                zzkoordinatdegeri2 = p2.zkoordegeri2;
                ggenislikdegeri2 = p2.genislikdegeri2;
                yyukseklikdegeri2 = p2.yukseklikdegeri2;
                dderinlikdegeri2 = p2.derinlikdegeri2;

                xkoordinat2.Text = p2.xkoordegeri2.ToString();
                Ykoordinat2.Text = p2.ykoordegeri2.ToString();
                zkoordinat2.Text = p2.zkoordegeri2.ToString();
                genişlik2.Text = p2.genislikdegeri2.ToString();
                yükseklik2.Text = p2.yukseklikdegeri2.ToString();
                derin2.Text = p2.derinlikdegeri2.ToString();

                p1.prizma_çiz(pictureBox1);
                p2.prizma2_çiz(pictureBox1);
            }
        }
        //sınıf listelerinden çağıran değerler için değişkenler
        public int xxkoordinatdegeri;
        public int yykoordinatdegeri;
        public int zzkoordinatdegeri;
        public int ggenislikdegeri;
        public int yyukseklikdegeri;
        public int dderinlikdegeri;
        public int yyaricapdegeri;
        public int xxkoordinatdegeri2;
        public int yykoordinatdegeri2;
        public int zzkoordinatdegeri2;
        public int ggenislikdegeri2;
        public int yyukseklikdegeri2;
        public int dderinlikdegeri2;
        public int yyaricapdegeri2;
        public bool i1;
        public bool i2;
        public bool i3;

        //çarpışma Denetimi işlemleri
        private void carpisma_Click(object sender, EventArgs e)
        {
            if(radioButton_noktadrtgn.Checked)
            {
                int dikdortgeninxmerkezi = xxkoordinatdegeri2 + ggenislikdegeri2 / 2;
                int dikdortgeninymerkezi = yykoordinatdegeri2 + yyukseklikdegeri2 / 2;
                int xuzaklik=Math.Abs(dikdortgeninxmerkezi-xxkoordinatdegeri);
                int yuzaklik = Math.Abs(dikdortgeninymerkezi - yykoordinatdegeri);
                i1 = xuzaklik <= ggenislikdegeri2 / 2;
                i2 = yuzaklik <= yyukseklikdegeri2 / 2;
                if (i1 && i2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }

            }
            if (radioButton_noktacember.Checked)
            {
                i1 = Math.Pow(xxkoordinatdegeri - xxkoordinatdegeri2, 2) + Math.Pow(yykoordinatdegeri - yykoordinatdegeri2, 2) == Math.Pow(yyaricapdegeri2, 2);
                if (i1)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_dkdrtgndkdrtgn.Checked)
            {
                i1 = xxkoordinatdegeri <= xxkoordinatdegeri2 + ggenislikdegeri2 && xxkoordinatdegeri + ggenislikdegeri >= xxkoordinatdegeri2 && yykoordinatdegeri <= yykoordinatdegeri2 + yyukseklikdegeri2 && yykoordinatdegeri + yyukseklikdegeri >= yykoordinatdegeri2;
                i2= xxkoordinatdegeri2 <= xxkoordinatdegeri + ggenislikdegeri && xxkoordinatdegeri2 + ggenislikdegeri2 >= xxkoordinatdegeri && yykoordinatdegeri2 <= yykoordinatdegeri + yyukseklikdegeri && yykoordinatdegeri2 + yyukseklikdegeri2 >= yykoordinatdegeri;
                if (i1||i2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_dkdrtgncember.Checked)
            {
                i1 = xxkoordinatdegeri2 + yyaricapdegeri2 >= xxkoordinatdegeri && xxkoordinatdegeri2 - yyaricapdegeri2 <= xxkoordinatdegeri+ggenislikdegeri;
                i2 = yykoordinatdegeri2 + yyaricapdegeri2 >= yykoordinatdegeri && yykoordinatdegeri2 - yyaricapdegeri2 <= yykoordinatdegeri+yyukseklikdegeri;
                if (i1&&i2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_cembercember.Checked)
            {
                double cemberlerinmerkezleri = Math.Sqrt(Math.Pow(xxkoordinatdegeri - xxkoordinatdegeri2, 2) + Math.Pow(yykoordinatdegeri - yykoordinatdegeri2, 2));
                int yaricaplarıtoplami = yyaricapdegeri + yyaricapdegeri2;
                if (cemberlerinmerkezleri<=yaricaplarıtoplami)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_noktakure.Checked)
            {
                double uzakliklari= Math.Sqrt(Math.Pow(xxkoordinatdegeri - xxkoordinatdegeri2, 2) + Math.Pow(yykoordinatdegeri - yykoordinatdegeri2, 2)+Math.Pow(zzkoordinatdegeri-zzkoordinatdegeri2,2));
                if (uzakliklari<=yyaricapdegeri2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_noktadkdrtgnprizma.Checked)
            {
                i1 = xxkoordinatdegeri >= xxkoordinatdegeri2 && xxkoordinatdegeri <= xxkoordinatdegeri2 + dderinlikdegeri2 + yyukseklikdegeri2;
                i2 = yykoordinatdegeri >= yykoordinatdegeri2 && yykoordinatdegeri <= yykoordinatdegeri2 + yyukseklikdegeri2 + dderinlikdegeri2;

                if (i1&&i2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_noktasilindir.Checked)
            {
                int xkooruzaklik = Math.Abs(xxkoordinatdegeri-xxkoordinatdegeri2);
                int ykooruzaklik = Math.Abs(yykoordinatdegeri-yykoordinatdegeri2);
                int zkooruzaklik = Math.Abs(zzkoordinatdegeri-zzkoordinatdegeri2);
                i1 = xkooruzaklik <= yyaricapdegeri2;
                i2 = ykooruzaklik <= yyukseklikdegeri2;
                i3 = zkooruzaklik <= yyaricapdegeri2;
                if (i1 && i2&&i3)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }

            }
            if (radioButton_silindirsilindir.Checked)
            {
                double ilkuzaklik;
                ilkuzaklik = Math.Sqrt(Math.Pow(xxkoordinatdegeri - xxkoordinatdegeri2, 2) + Math.Pow(zzkoordinatdegeri - zzkoordinatdegeri2, 2));
                double ikinciuzaklik;
                ikinciuzaklik = Math.Abs(yykoordinatdegeri - yykoordinatdegeri2);
                i1 = ilkuzaklik <= yyaricapdegeri + yyaricapdegeri2;
                i2 = ikinciuzaklik <= yyukseklikdegeri / 2 + yyukseklikdegeri2 / 2;
                if (i1 && i2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_kurekure.Checked)
            {
                double uzaklik = Math.Sqrt(Math.Pow(xxkoordinatdegeri - xxkoordinatdegeri2, 2) + Math.Pow(yykoordinatdegeri - yykoordinatdegeri2, 2) + Math.Pow(zzkoordinatdegeri - zzkoordinatdegeri2, 2));
                if (uzaklik<=yyaricapdegeri+yyaricapdegeri2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_kuresilindir.Checked)
            {
                double ilkuzaklik;
                ilkuzaklik = Math.Sqrt(Math.Pow(xxkoordinatdegeri - xxkoordinatdegeri2, 2) + Math.Pow(zzkoordinatdegeri - zzkoordinatdegeri2, 2));
                double ikinciuzaklik;
                ikinciuzaklik = Math.Abs(yykoordinatdegeri - yykoordinatdegeri2);
                i1 = ilkuzaklik <= yyaricapdegeri + yyaricapdegeri2;
                i2 = ikinciuzaklik <= yyukseklikdegeri / 2 + yyaricapdegeri;
                if (i1 && i2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_yuzeykure.Checked)
            {
                i1 = xxkoordinatdegeri - yyaricapdegeri2 <= xxkoordinatdegeri2 && xxkoordinatdegeri + ggenislikdegeri + dderinlikdegeri + yyaricapdegeri2 >= xxkoordinatdegeri2;
                i2 = yykoordinatdegeri - yyaricapdegeri2 - dderinlikdegeri <= yykoordinatdegeri2 && yykoordinatdegeri + yyaricapdegeri2 >= yyaricapdegeri2;
                if (i1 && i2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_yuzeydkdrtgnprizma.Checked)
            {
                i1 = xxkoordinatdegeri - ggenislikdegeri2 <= xxkoordinatdegeri2 && xxkoordinatdegeri + ggenislikdegeri + dderinlikdegeri >= xxkoordinatdegeri2;
                i2 = yykoordinatdegeri2 + yyukseklikdegeri2 >= yykoordinatdegeri - dderinlikdegeri && yykoordinatdegeri2 <= yykoordinatdegeri;
                if (i1 && i2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_yuzeysilindir.Checked)
            {
                i1 = xxkoordinatdegeri - yyaricapdegeri2 <= xxkoordinatdegeri2 && xxkoordinatdegeri + ggenislikdegeri + dderinlikdegeri + yyaricapdegeri2 >= xxkoordinatdegeri2;
                i2 = yykoordinatdegeri - yyukseklikdegeri2 / 2 - dderinlikdegeri <= yykoordinatdegeri2 && yykoordinatdegeri + yyukseklikdegeri2 / 2 >= yykoordinatdegeri2; ;
                if (i1 && i2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_kuredkdrtgnprizma.Checked)
            {
                i1 = xxkoordinatdegeri2 - yyaricapdegeri <= xxkoordinatdegeri && xxkoordinatdegeri2 + dderinlikdegeri2 + ggenislikdegeri2 >= xxkoordinatdegeri;
                i2 = yykoordinatdegeri + yyaricapdegeri >= yykoordinatdegeri2 && yykoordinatdegeri - yyaricapdegeri <= yykoordinatdegeri2 + yyukseklikdegeri2 + dderinlikdegeri2;
                if (i1 && i2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }
            if (radioButton_dkdrtgnprizmadkdrtgnprizma.Checked)
            {
                i1 = xxkoordinatdegeri <= xxkoordinatdegeri2 + ggenislikdegeri2 && xxkoordinatdegeri + ggenislikdegeri >= xxkoordinatdegeri2 && yykoordinatdegeri <= yykoordinatdegeri2 + yyukseklikdegeri2 && yykoordinatdegeri + yyukseklikdegeri >= yykoordinatdegeri2 && xxkoordinatdegeri + dderinlikdegeri <= xxkoordinatdegeri2 + ggenislikdegeri2 + dderinlikdegeri2 && xxkoordinatdegeri + dderinlikdegeri + ggenislikdegeri >= xxkoordinatdegeri2 + dderinlikdegeri2 && yykoordinatdegeri + dderinlikdegeri <= yykoordinatdegeri2 + dderinlikdegeri2 + yyukseklikdegeri2 && yykoordinatdegeri + dderinlikdegeri + yyukseklikdegeri >= yykoordinatdegeri2 + dderinlikdegeri2;
                i2 = xxkoordinatdegeri2 <= xxkoordinatdegeri + ggenislikdegeri && xxkoordinatdegeri2 + ggenislikdegeri2 >= xxkoordinatdegeri + dderinlikdegeri && yykoordinatdegeri2 + dderinlikdegeri2 <= yykoordinatdegeri + dderinlikdegeri + yyukseklikdegeri && yykoordinatdegeri2 + dderinlikdegeri2 + yyukseklikdegeri2 >= yykoordinatdegeri + dderinlikdegeri;
                if (i1||i2)
                {
                    MessageBox.Show("Çarpışma Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Çarpışma Gerçekleşmedi.");
                }
            }







        }

        

        //Nokta-Dörtgen
        private void radioButton_noktadrtgn_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "xkoordinat2", "Ykoordinat2", "yükseklik2", "genişlik2", });
            label3.Text = "Nokta Verileri";
            label4.Text = "Dörtgen Verileri";

        }
        //Nokta-Çember
        private void radioButton_noktacember_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "xkoordinat2", "Ykoordinat2", "çap2" });
            label3.Text = "Nokta Verileri";
            label4.Text = "Çember Verileri";


        }
        //Dikdörtgen-Dikdörtgen
        private void radioButton_dkdrtgndkdrtgn_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "yükseklik", "genişlik", "xkoordinat2", "Ykoordinat2", "yükseklik2", "genişlik2" });
            label3.Text = "Dikdörtgen Verileri";
            label4.Text = "Dikdörtgen Verileri";


        }
        //Dikdötgen-Çember
        private void radioButton_dkdrtgncember_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "genişlik", "yükseklik", "xkoordinat2", "Ykoordinat2", "çap2" });
            label3.Text = "Dikdörtgen Verileri";
            label4.Text = "Çember Verileri";


        }
        //Çember-Çember
        private void radioButton_cembercember_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "çap", "xkoordinat2", "Ykoordinat2", "çap2" });
            label3.Text = "Çember Verileri";
            label4.Text = "Çember Verileri";

        }
        //Nokta-Küre
        private void radioButton_noktakure_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "zkoordinat", "xkoordinat2", "ykoordiYkoordinat2nat2", "çap2" });
            label3.Text = "Nokta Verileri";
            label4.Text = "Küre Verileri";


        }
        //Nokta-Dikdörtgen Prizma
        private void radioButton_noktadkdrtgnprizma_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "zkoordinat", "xkoordinat2", "Ykoordinat2", "yükseklik2", "genişlik2", "derin2" });
            label3.Text = "Nokta Verileri";
            label4.Text = "DikdörtgenPrizma Verileri";

        }
        //Nokta-Silindir
        private void radioButton_noktasilindir_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "zkoordinat", "xkoordinat2", "Ykoordinat2", "yükseklik2", "çap2" });
            label3.Text = "Nokta Verileri";
            label4.Text = "Silindir Verileri";

        }
        //Silindir-Silindir
        private void radioButton_silindirsilindir_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "zkoordinat", "yükseklik", "çap", "xkoordinat2", "Ykoordinat2", "zkoordinat2", "yükseklik2", "çap2" });
            label3.Text = "Silindir Verileri";
            label4.Text = "Silindir Verileri";

        }
        //Küre-Küre
        private void radioButton_kurekure_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "zkoordinat", "çap", "xkoordinat2", "Ykoordinat2", "zkoordinat2", "çap2" });
            label3.Text = "Küre Verileri";
            label4.Text = "Küre Verileri";

        }
        //Küre-Silindir
        private void radioButton_kuresilindir_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "zkoordinat", "çap", "xkoordinat2", "Ykoordinat2", "zkoordinat2", "çap2", "yükseklik2" });
            label3.Text = "Küre Verileri";
            label4.Text = "Silindir Verileri";


        }
        //Yüzey-Küre
        private void radioButton_yuzeykure_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "zkoordinat", "yükseklik", "genişlik", "derin", "xkoordinat2", "Ykoordinat2", "zkoordinat2", "çap2" });
            label3.Text = "Yüzey Verileri";
            label4.Text = "Küre Verileri";


        }
        //Yüzey-DikdörtgenPrizma
        private void radioButton_yuzeydkdrtgnprizma_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "zkoordinat", "yükseklik", "genişlik", "derin", "xkoordinat2", "Ykoordinat2", "zkoordinat2", "genişlik2", "yükseklik2", "derin2" });
            label3.Text = "Yüzey Verileri";
            label4.Text = "DikdörtgenPrizma Verileri";
        }
        //Yüzey-Silindir
        private void radioButton_yuzeysilindir_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "zkoordinat", "yükseklik", "genişlik", "derin", "xkoordinat2", "Ykoordinat2", "zkoordinat2", "çap2", "yükseklik2" });
            label3.Text = "Yüzey Verileri";
            label4.Text = "Silindir Verileri";
        }
        //Küre-DikdörtgenPrizma
        private void radioButton_kuredkdrtgnprizma_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "zkoordinat", "çap", "xkoordinat2", "Ykoordinat2", "zkoordinat2", "yükseklik2", "genişlik2", "derin2" });
            label3.Text = "Küre Verileri";
            label4.Text = "DikdörtgenPrizma Verileri";
        }
        //DikdörtgenPrizma-DikdörtgenPrizma
        private void radioButton_dkdrtgnprizmadkdrtgnprizma_CheckedChanged(object sender, EventArgs e)
        {
            GizleHaricGoster(new string[] { "xkoordinat", "Ykoordinat", "zkoordinat", "yükseklik", "genişlik", "derin", "xkoordinat2", "Ykoordinat2", "zkoordinat2", "yükseklik2", "genişlik2", "derin2" });
            label3.Text = "DikdörtgenPrizma Verileri";
            label4.Text = "DikdörtgenPrizma Verileri";
        }


        // Gerekli kontrolleri göster, diğerlerini gizle
        private void GizleHaricGoster(string[] gosterilecekler)
        {
            Dictionary<string, string> kontrolEslesmeleri = new Dictionary<string, string>
    {
        {"xkoordinat", "Xkoordinati"},
        {"Ykoordinat", "Ykoordinati"},
        {"zkoordinat", "Zkoordinati"},
        {"yükseklik", "Yukseklik"},
        {"genişlik", "Genislik"},
        {"çap", "Cap"},
        {"derin", "Derinlik"},
        {"xkoordinat2", "Xkoordinati2"},
        {"Ykoordinat2", "Ykoordinati2"},
        {"zkoordinat2", "Zkoordinati2"},
        {"yükseklik2", "Yukseklik2"},
        {"genişlik2", "Genislik2"},
        {"çap2", "Cap2"},
        {"derin2", "Derinlik2"},
    };

            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    bool goster = gosterilecekler.Contains(textBox.Name);
                    textBox.Visible = goster;
                    textBox.Enabled = goster;

                    if (kontrolEslesmeleri.TryGetValue(textBox.Name, out string? labelName))
                    {
                        var label = Controls.Find(labelName, true).FirstOrDefault() as Control;
                        if (label != null)
                        {
                            label.Visible = goster;
                            label.Enabled = goster;
                        }
                    }
                }
            }
        }

    }

    public class nesneler<nesne>
    {
        //1.nesnelerin değerleri
        public int xkoordegeri;
        public int ykoordegeri;
        public int zkoordegeri;
        public int genislikdegeri;
        public int yukseklikdegeri;
        public int derinlikdegeri;
        public int yaricapdegeri;

        //2.nesnlerin değerleri
        public int xkoordegeri2;
        public int ykoordegeri2;
        public int zkoordegeri2;
        public int genislikdegeri2;
        public int yukseklikdegeri2;
        public int derinlikdegeri2;
        public int yaricapdegeri2;
    }

    class nokta2boyutlu<nesne> : nesneler<nesne> //2 boyutlu nokta için oluşturulmuş sınıf 
    {
        public nokta2boyutlu()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());

            xkoordegeri = r.Next(50, 500);
            ykoordegeri = r.Next(50, 500);



        }
        public void nokta2boyutlu_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.Black);
            g.DrawEllipse(kalem, xkoordegeri, ykoordegeri, 1, 1);
            Pen koordinat = new Pen(Color.FromArgb(18, Color.AliceBlue));
            g.DrawLine(koordinat, 1, 1, 1, 750);
            g.DrawLine(koordinat, 1, 750, 689, 750);
        }
    }

    class nokta3boyutlu<nesne> : nesneler<nesne>
    {
        public nokta3boyutlu()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());

            xkoordegeri = r.Next(50, 500);
            ykoordegeri = r.Next(50, 500);
            zkoordegeri = r.Next(5, 15);


        }
        public void nokta3boyutlu_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.Black);
            g.DrawEllipse(kalem, xkoordegeri, ykoordegeri, 1, 1);
            Pen koordinat = new Pen(Color.FromArgb(18, Color.AliceBlue));
            g.DrawLine(koordinat, 1, 1, 1, 750);
            g.DrawLine(koordinat, 1, 750, 689, 750);
        }
    }

    class dikdörtgen<nesne> : nesneler<nesne>
    {
        public dikdörtgen()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());

            xkoordegeri = r.Next(50, 500);
            ykoordegeri = r.Next(50, 500);
            genislikdegeri = r.Next(20, 300);
            yukseklikdegeri = r.Next(20, 300);



        }
        public void dikdörtgen_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            SolidBrush fırça = new SolidBrush(Color.FromArgb(50, Color.DarkBlue));
            g.FillRectangle(fırça, xkoordegeri, ykoordegeri, genislikdegeri, yukseklikdegeri);
            Pen koordinat = new Pen(Color.FromArgb(18, Color.AliceBlue));
            g.DrawLine(koordinat, 1, 1, 1, 750);
            g.DrawLine(koordinat, 1, 750, 689, 750);
        }
    }

    class dikdörtgen2<nesne> : nesneler<nesne>
    {
        public dikdörtgen2()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());

            xkoordegeri2 = r.Next(50, 500);
            ykoordegeri2 = r.Next(50, 500);
            genislikdegeri2 = r.Next(20, 300);
            yukseklikdegeri2 = r.Next(20, 300);



        }
        public void dikdörtgen2_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            SolidBrush fırça = new SolidBrush(Color.FromArgb(50, Color.DarkBlue));
            g.FillRectangle(fırça, xkoordegeri2, ykoordegeri2, genislikdegeri2, yukseklikdegeri2);
            Pen koordinat = new Pen(Color.FromArgb(18, Color.AliceBlue));
            g.DrawLine(koordinat, 1, 1, 1, 750);
            g.DrawLine(koordinat, 1, 750, 689, 750);
        }
    }

    class çember<nesne> : nesneler<nesne>
    {
        public çember()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            xkoordegeri = r.Next(50, 500);
            ykoordegeri = r.Next(50, 500);
            yaricapdegeri = r.Next(50, 100);



        }
        public void çember_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.Red);
            g.DrawEllipse(kalem, xkoordegeri - yaricapdegeri, ykoordegeri - yaricapdegeri, 2 * yaricapdegeri, 2 * yaricapdegeri);
        }

    }
    class çember2<nesne> : nesneler<nesne>
    {
        public çember2()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            xkoordegeri2 = r.Next(50, 500);
            ykoordegeri2 = r.Next(50, 500);
            yaricapdegeri2 = r.Next(50, 100);



        }
        public void çember2_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.Red);
            g.DrawEllipse(kalem, xkoordegeri2 - yaricapdegeri2, ykoordegeri2 - yaricapdegeri2, 2 * yaricapdegeri2, 2 * yaricapdegeri2);
        }

    }

    class kure<nesne> : nesneler<nesne>
    {
        public kure()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            xkoordegeri = r.Next(50, 500);
            ykoordegeri = r.Next(50, 500);
            zkoordegeri = r.Next(5, 15);
            yaricapdegeri = r.Next(50, 100);



        }
        public void kure_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.FromArgb(128, Color.Purple));
            SolidBrush fırça = new SolidBrush(Color.FromArgb(128, Color.Purple));
            g.FillEllipse(fırça, xkoordegeri - yaricapdegeri, ykoordegeri - yaricapdegeri, 2 * yaricapdegeri, 2 * yaricapdegeri);
            g.DrawEllipse(kalem, xkoordegeri - yaricapdegeri, ykoordegeri - yaricapdegeri / 3, 2 * yaricapdegeri, yaricapdegeri / 2);
        }

    }

    class kure2<nesne> : nesneler<nesne>
    {
        public kure2()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            xkoordegeri2 = r.Next(50, 500);
            ykoordegeri2 = r.Next(50, 500);
            zkoordegeri2 = r.Next(5, 15);
            yaricapdegeri2 = r.Next(50, 100);



        }
        public void kure2_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.FromArgb(128, Color.Purple));
            SolidBrush fırça = new SolidBrush(Color.FromArgb(128, Color.Purple));
            g.FillEllipse(fırça, xkoordegeri2 - yaricapdegeri2, ykoordegeri2 - yaricapdegeri2, 2 * yaricapdegeri2, 2 * yaricapdegeri2);
            g.DrawEllipse(kalem, xkoordegeri2 - yaricapdegeri2, ykoordegeri2 - yaricapdegeri2 / 3, 2 * yaricapdegeri2, yaricapdegeri2 / 2);
        }

    }

    class prizma<nesne> : nesneler<nesne>
    {
        public prizma()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            xkoordegeri = r.Next(50, 500);
            ykoordegeri = r.Next(50, 500);
            zkoordegeri = r.Next(5, 15);
            yukseklikdegeri = r.Next(20, 100);
            genislikdegeri = r.Next(20, 100);
            derinlikdegeri = r.Next(20, 100);



        }
        public void prizma_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.FromArgb(128, Color.Red));
            g.DrawRectangle(kalem, xkoordegeri, ykoordegeri, genislikdegeri, yukseklikdegeri);
            g.DrawRectangle(kalem, xkoordegeri + derinlikdegeri, ykoordegeri + derinlikdegeri, genislikdegeri, yukseklikdegeri);

            g.DrawLine(kalem, xkoordegeri, ykoordegeri, xkoordegeri + derinlikdegeri, ykoordegeri + derinlikdegeri);
            g.DrawLine(kalem, xkoordegeri + genislikdegeri, ykoordegeri, xkoordegeri + genislikdegeri + derinlikdegeri, ykoordegeri + derinlikdegeri);
            g.DrawLine(kalem, xkoordegeri, ykoordegeri + yukseklikdegeri, xkoordegeri + derinlikdegeri, ykoordegeri + yukseklikdegeri + derinlikdegeri);
            g.DrawLine(kalem, xkoordegeri + genislikdegeri, ykoordegeri + yukseklikdegeri, xkoordegeri + genislikdegeri + derinlikdegeri, ykoordegeri + yukseklikdegeri + derinlikdegeri);

        }

    }

    class prizma2<nesne> : nesneler<nesne>
    {
        public prizma2()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            xkoordegeri2 = r.Next(50, 500);
            ykoordegeri2 = r.Next(50, 500);
            zkoordegeri2 = r.Next(5, 15);
            yukseklikdegeri2 = r.Next(20, 100);
            genislikdegeri2 = r.Next(20, 100);
            derinlikdegeri2 = r.Next(20, 100);



        }
        public void prizma2_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.FromArgb(128, Color.Red));
            g.DrawRectangle(kalem, xkoordegeri2, ykoordegeri2, genislikdegeri2, yukseklikdegeri2);
            g.DrawRectangle(kalem, xkoordegeri2 + derinlikdegeri2, ykoordegeri2 + derinlikdegeri2, genislikdegeri2, yukseklikdegeri2);

            g.DrawLine(kalem, xkoordegeri2, ykoordegeri2, xkoordegeri2 + derinlikdegeri2, ykoordegeri2 + derinlikdegeri2);
            g.DrawLine(kalem, xkoordegeri2 + genislikdegeri2, ykoordegeri2, xkoordegeri2 + genislikdegeri2 + derinlikdegeri2, ykoordegeri2 + derinlikdegeri2);
            g.DrawLine(kalem, xkoordegeri2, ykoordegeri2 + yukseklikdegeri2, xkoordegeri2 + derinlikdegeri2, ykoordegeri2 + yukseklikdegeri2 + derinlikdegeri2);
            g.DrawLine(kalem, xkoordegeri2 + genislikdegeri2, ykoordegeri2 + yukseklikdegeri2, xkoordegeri2 + genislikdegeri2 + derinlikdegeri2, ykoordegeri2 + yukseklikdegeri2 + derinlikdegeri2);

        }

    }

    class silindir<nesne> : nesneler<nesne>
    {
        public silindir()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            xkoordegeri = r.Next(50, 500);
            ykoordegeri = r.Next(50, 500);
            zkoordegeri = r.Next(5, 15);
            yaricapdegeri = r.Next(50, 75);
            yukseklikdegeri = r.Next(20, 200);




        }
        public void silindir_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.FromArgb(128, Color.Orange));

            g.DrawEllipse(kalem, xkoordegeri - yaricapdegeri, ykoordegeri + yukseklikdegeri / 2, yaricapdegeri * 2, yaricapdegeri / 2);
            g.DrawEllipse(kalem, xkoordegeri - yaricapdegeri, ykoordegeri - yukseklikdegeri / 2, yaricapdegeri * 2, yaricapdegeri / 2);
            g.DrawLine(kalem, xkoordegeri - yaricapdegeri, ykoordegeri - yukseklikdegeri / 2 + yaricapdegeri / 4, xkoordegeri - yaricapdegeri, ykoordegeri + yukseklikdegeri / 2 + yaricapdegeri / 4);
            g.DrawLine(kalem, xkoordegeri + yaricapdegeri, ykoordegeri - yukseklikdegeri / 2 + yaricapdegeri / 4, xkoordegeri + yaricapdegeri, ykoordegeri + yukseklikdegeri / 2 + yaricapdegeri / 4);

        }
    }

    class silindir2<nesne> : nesneler<nesne>
    {
        public silindir2()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            xkoordegeri2 = r.Next(50, 500);
            ykoordegeri2 = r.Next(50, 500);
            zkoordegeri2 = r.Next(5, 15);
            yaricapdegeri2 = r.Next(50, 75);
            yukseklikdegeri2 = r.Next(20, 200);




        }
        public void silindir2_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.FromArgb(128, Color.Orange));

            g.DrawEllipse(kalem, xkoordegeri2 - yaricapdegeri2, ykoordegeri2 + yukseklikdegeri2 / 2, yaricapdegeri2 * 2, yaricapdegeri2 / 2);
            g.DrawEllipse(kalem, xkoordegeri2 - yaricapdegeri2, ykoordegeri2 - yukseklikdegeri2 / 2, yaricapdegeri2 * 2, yaricapdegeri2 / 2);
            g.DrawLine(kalem, xkoordegeri2 - yaricapdegeri2, ykoordegeri2 - yukseklikdegeri2 / 2 + yaricapdegeri2 / 4, xkoordegeri2 - yaricapdegeri2, ykoordegeri2 + yukseklikdegeri2 / 2 + yaricapdegeri2 / 4);
            g.DrawLine(kalem, xkoordegeri2 + yaricapdegeri2, ykoordegeri2 - yukseklikdegeri2 / 2 + yaricapdegeri2 / 4, xkoordegeri2 + yaricapdegeri2, ykoordegeri2 + yukseklikdegeri2 / 2 + yaricapdegeri2 / 4);

        }
    }

    class yuzey<nesne> : nesneler<nesne>
    {
        public yuzey()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            xkoordegeri = r.Next(50, 500);
            ykoordegeri = r.Next(50, 500);
            zkoordegeri = r.Next(5, 15);
            genislikdegeri = r.Next(150, 250);
            yukseklikdegeri = 1;
            derinlikdegeri = r.Next(20, 60);




        }
        public void yuzey_çiz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.FromArgb(128, Color.Black));
            g.DrawRectangle(kalem, xkoordegeri, ykoordegeri, genislikdegeri, yukseklikdegeri);

            g.DrawLine(kalem, xkoordegeri, ykoordegeri, xkoordegeri + derinlikdegeri, ykoordegeri - derinlikdegeri);
            g.DrawLine(kalem, xkoordegeri + genislikdegeri, ykoordegeri, xkoordegeri + genislikdegeri + derinlikdegeri, ykoordegeri - derinlikdegeri);
            g.DrawLine(kalem, xkoordegeri + derinlikdegeri, ykoordegeri - derinlikdegeri, xkoordegeri + genislikdegeri + derinlikdegeri, ykoordegeri - derinlikdegeri);

            g.DrawLine(kalem, xkoordegeri + genislikdegeri / 3, ykoordegeri, xkoordegeri + derinlikdegeri + yukseklikdegeri / 3, ykoordegeri - derinlikdegeri);
            g.DrawLine(kalem, xkoordegeri + 2 * genislikdegeri / 3, ykoordegeri, xkoordegeri + derinlikdegeri + 2 * genislikdegeri / 3, ykoordegeri - derinlikdegeri);
            g.DrawLine(kalem, xkoordegeri + derinlikdegeri / 2, ykoordegeri - derinlikdegeri / 2, xkoordegeri + genislikdegeri + derinlikdegeri / 2, ykoordegeri - derinlikdegeri / 2);




        }
    }


}








