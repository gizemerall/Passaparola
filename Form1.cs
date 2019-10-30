using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlıs = 0;

      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Cevapla";
            soruno++;
            this.Text = soruno.ToString();

            if(soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin GüneyKısmındaki Kıyı Bölgesi?";
                button1.BackColor = Color.Pink;

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü marmara ilimiz?";
                button2.BackColor = Color.Pink;

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Pink;

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzu ile ünlü ilimiz?";
                button4.BackColor = Color.Pink;

            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                button5.BackColor = Color.Pink;

            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Pink;

            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                button7.BackColor = Color.Pink;

            }
            if (soruno == 8)
            {
                richTextBox1.Text = "öğrencilerin kotu not getirince bakıştıgı nesne?";
                button8.BackColor = Color.Pink;

            }
            if (soruno == 9)
            {
                richTextBox1.Text = "gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Pink;

            }
            if (soruno == 10)
            {
                richTextBox1.Text = "mersinin diğer ismi?";
                button10.BackColor = Color.Pink;

            }
            if (soruno == 11)
            {
                richTextBox1.Text = "askeri bir topluluk?";
                button11.BackColor = Color.Pink;

            }
            if (soruno == 12)
            {
                richTextBox1.Text = "malatyanın meshur meyvesi?";
                button12.BackColor = Color.Pink;

            }
            if (soruno == 13)
            {
                richTextBox1.Text = "her yıl bahar aylarında duzenlenen meshur cıcek festivali?";
                button13.BackColor = Color.Pink;

            }
            if (soruno == 14)
            {
                richTextBox1.Text = "yılın 3.ayı?";
                button14.BackColor = Color.Pink;

            }
            if (soruno == 15)
            {
                richTextBox1.Text = "üflemeli müzik aleti?";
                button15.BackColor = Color.Pink;

            }
            if (soruno == 16)
            {
                richTextBox1.Text = "halk şairi?";
                button16.BackColor = Color.Pink;

            }
            if (soruno == 17)
            { 
            
                richTextBox1.Text = "cocukların cok sevmediği sebzelerle yapılan yemek?";
                button17.BackColor = Color.Pink;
            }


            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                button18.BackColor = Color.Pink;

            }
            if (soruno == 19)
            {
                richTextBox1.Text = "ingilizcese yılan?";
                button19.BackColor = Color.Pink;

            }

            if (soruno == 20)
            {
                richTextBox1.Text = "türkiyenin mega starı?";
                button20.BackColor = Color.Pink;

            }
            if (soruno == 21)
            {
                richTextBox1.Text = "ümit kelimesinin eş anlamlısı?";
                button21.BackColor = Color.Pink;

            }
            if (soruno == 22)
            {
                richTextBox1.Text = "kahvaltısı ile ünlü ilimiz?";
                button22.BackColor = Color.Pink;

            }
            if (soruno == 23)
            {
                richTextBox1.Text = "şimşek kelimesiin eş amlamlısı?";
                button23.BackColor = Color.Pink;

            }
            if (soruno == 24)
            {
                richTextBox1.Text = "ege bölgesinin en çok ağacı bulunan yağıda yapılan bir kahvaltı besini?";
                button24.BackColor = Color.Pink;

            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red ;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;
             
                }
            }
        }

    }
}
