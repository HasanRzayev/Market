using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tapsiriq______4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Product
        {
            public Product(string name, double money, int count)
            {
                this.name = name;
                this.money = money;
                this.count = count;
            }
            public Product()
            {

            }
            public string name { get; set; }
            public double money { get; set; }
            public int count { get; set; }
            public override string ToString() => $"{name:10}-------{money}------{count}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label_kola.Text != "Bitdi")
            {
                double number = double.Parse(label_kola.Text);
                number -= 1;
                if (number <= 0) label_kola.Text = "Bitdi";
                else label_kola.Text = number.ToString();
            }
            else
            {
                return;
            }
           
          
         
            int option=0;
            
            Product lazim=new Product(button_kola.Text, double.Parse(label_kolaqiymet.Text), 1);
            for (int i = 0; i < SEBET.Items.Count; i++)
            {
                if ((SEBET.Items[i] as Product).name == lazim.name)
                {

                    Product a = SEBET.Items[i] as Product;
                    a.count += 1;

                    SEBET.Items.RemoveAt(i);
                    SEBET.Items.Insert(i,a);

                    option += 1;
                }
            }
                
            
            if (option == 0)
            {
                SEBET.Items.Add(lazim);
            }

            label_odenilmeli.Text = (double.Parse(label_odenilmeli.Text) + double.Parse(label_kolaqiymet.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_money.Text = (double.Parse(textBox_money.Text)+0.10).ToString();
        }

        private void button_20_Click(object sender, EventArgs e)
        {
            textBox_money.Text = (double.Parse(textBox_money.Text) + 0.20).ToString();

        }

        private void button_50_Click(object sender, EventArgs e)
        {
            textBox_money.Text = (double.Parse(textBox_money.Text) + 0.50).ToString();

        }

        private void button1azn_Click(object sender, EventArgs e)
        {
            textBox_money.Text = (double.Parse(textBox_money.Text) + 1).ToString();

        }

        private void button5azn_Click(object sender, EventArgs e)
        {
            textBox_money.Text = (double.Parse(textBox_money.Text) + 5).ToString();

        }

        private void button10azn_Click(object sender, EventArgs e)
        {
            textBox_money.Text = (double.Parse(textBox_money.Text) + 10).ToString();

        }

        private void button20azn_Click(object sender, EventArgs e)
        {
            textBox_money.Text = (double.Parse(textBox_money.Text) + 20).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelpepsi.Text != "Bitdi")
            {
                double number = double.Parse(labelpepsi.Text);
                number -= 1;
   
                if (number <= 0) labelpepsi.Text = "Bitdi";
                else labelpepsi.Text = number.ToString();
            }
            else
            {
                return;
            }
            int option = 0;
            
            Product lazim = new Product(buttonpepsi.Text, double.Parse(labelpepsiqiymeti.Text), 1);
            for (int i = 0; i < SEBET.Items.Count; i++)
            {
                if ((SEBET.Items[i] as Product).name == lazim.name)
                {

                    Product a = SEBET.Items[i] as Product;
                    a.count += 1;

                    SEBET.Items.RemoveAt(i);
                    SEBET.Items.Insert(i, a);

                    option += 1;
                }
            }


            if (option == 0)
            {
                SEBET.Items.Add(lazim);
            }
            label_odenilmeli.Text = (double.Parse(label_odenilmeli.Text) + double.Parse(labelpepsiqiymeti.Text)).ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double odenilmeli = double.Parse(label_odenilmeli.Text);
            double daxil = double.Parse(label_daxil.Text);
            if (daxil > odenilmeli)
            {
                labelqaliq.Text = (daxil - odenilmeli).ToString();
            }
            else
            {
                labelqaliq.Text = "Pul catismir";
            }
        }

        private void textBox_money_TextChanged(object sender, EventArgs e)
        {
            label_daxil.Text = textBox_money.Text;
        }

        private void button_fanta_Click(object sender, EventArgs e)
        {
            if (label_fanta.Text != "Bitdi")
            {
                double number = double.Parse(label_fanta.Text);
                number -= 1;

                if (number <= 0) label_fanta.Text = "Bitdi";
                else label_fanta.Text = number.ToString();
            }
            else
            {
                return;
            }
            int option = 0;

            Product lazim = new Product(button_fanta.Text, double.Parse(label_fantaqiymeti.Text), 1);
            for (int i = 0; i < SEBET.Items.Count; i++)
            {
                if ((SEBET.Items[i] as Product).name == lazim.name)
                {

                    Product a = SEBET.Items[i] as Product;
                    a.count += 1;

                    SEBET.Items.RemoveAt(i);
                    SEBET.Items.Insert(i, a);

                    option += 1;
                }
            }


            if (option == 0)
            {
                SEBET.Items.Add(lazim);
            }
            label_odenilmeli.Text = (double.Parse(label_odenilmeli.Text) + double.Parse(label_fantaqiymeti.Text)).ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double number = 0;
            for (int i = 0; i < SEBET.Items.Count; i++)
            {
                if((SEBET.Items[i] as Product).name == button_kola.Text)
                {
                    number = double.Parse(label_kola.Text);
                    number += (SEBET.Items[i] as Product).count;
                    label_kola.Text= number.ToString();
                }
                else if ((SEBET.Items[i] as Product).name == button_fanta.Text)
                {
                    number = double.Parse(label_fanta.Text);
                    number += (SEBET.Items[i] as Product).count;
                    label_fanta.Text = number.ToString();
                }
                else if ((SEBET.Items[i] as Product).name == buttonpepsi.Text)
                {
                    number = double.Parse(labelpepsi.Text);
                    number += (SEBET.Items[i] as Product).count;
                    labelpepsi.Text = number.ToString();
                }
                else if ((SEBET.Items[i] as Product).name == button_icetea.Text)
                {
                    number = double.Parse(labelicetea.Text);
                    number += (SEBET.Items[i] as Product).count;
                    labelicetea.Text = number.ToString();
                }
                else if ((SEBET.Items[i] as Product).name == buttonsnickers.Text)
                {
                    number = double.Parse(labelsnickers.Text);
                    number += (SEBET.Items[i] as Product).count;
                    labelsnickers.Text = number.ToString();
                }
                else if ((SEBET.Items[i] as Product).name == buttonbounty.Text)
                {
                    number = double.Parse(labelbounty.Text);
                    number += (SEBET.Items[i] as Product).count;
                    labelbounty.Text = number.ToString();
                }
            }
            SEBET.Items.Clear();
        }

        private void button_icetea_Click(object sender, EventArgs e)
        {
            if (labelicetea.Text != "Bitdi")
            {
                double number = double.Parse(labelicetea.Text);
                number -= 1;

                if (number <= 0) labelicetea.Text = "Bitdi";
                else labelicetea.Text = number.ToString();
            }
            else
            {
                return;
            }
            int option = 0;

            Product lazim = new Product(button_icetea.Text, double.Parse(label_iceteatqiymeti.Text), 1);
            for (int i = 0; i < SEBET.Items.Count; i++)
            {
                if ((SEBET.Items[i] as Product).name == lazim.name)
                {

                    Product a = SEBET.Items[i] as Product;
                    a.count += 1;

                    SEBET.Items.RemoveAt(i);
                    SEBET.Items.Insert(i, a);

                    option += 1;
                }
            }


            if (option == 0)
            {
                SEBET.Items.Add(lazim);
            }
            label_odenilmeli.Text = (double.Parse(label_odenilmeli.Text) + double.Parse(label_iceteatqiymeti.Text)).ToString();
        }

        private void buttonsnickers_Click(object sender, EventArgs e)
        {
            if (labelsnickers.Text != "Bitdi")
            {
                double number = double.Parse(labelsnickers.Text);
                number -= 1;

                if (number <= 0) labelsnickers.Text = "Bitdi";
                else labelsnickers.Text = number.ToString();
            }
            else
            {
                return;
            }
            int option = 0;

            Product lazim = new Product(buttonsnickers.Text, double.Parse(labelsnickersqiymet.Text), 1);
            for (int i = 0; i < SEBET.Items.Count; i++)
            {
                if ((SEBET.Items[i] as Product).name == lazim.name)
                {

                    Product a = SEBET.Items[i] as Product;
                    a.count += 1;

                    SEBET.Items.RemoveAt(i);
                    SEBET.Items.Insert(i, a);

                    option += 1;
                }
            }


            if (option == 0)
            {
                SEBET.Items.Add(lazim);
            }
            label_odenilmeli.Text = (double.Parse(label_odenilmeli.Text) + double.Parse(labelsnickersqiymet.Text)).ToString();
        }

        private void buttonbounty_Click(object sender, EventArgs e)
        {
            if (labelbounty.Text != "Bitdi")
            {
                double number = double.Parse(labelbounty.Text);
                number -= 1;

                if (number <= 0) labelbounty.Text = "Bitdi";
                else labelbounty.Text = number.ToString();
            }
            else
            {
                return;
            }
            int option = 0;

            Product lazim = new Product(buttonbounty.Text, double.Parse(labelbountyqiymet.Text), 1);
            for (int i = 0; i < SEBET.Items.Count; i++)
            {
                if ((SEBET.Items[i] as Product).name == lazim.name)
                {

                    Product a = SEBET.Items[i] as Product;
                    a.count += 1;

                    SEBET.Items.RemoveAt(i);
                    SEBET.Items.Insert(i, a);

                    option += 1;
                }
            }


            if (option == 0)
            {
                SEBET.Items.Add(lazim);
            }
            label_odenilmeli.Text = (double.Parse(label_odenilmeli.Text) + double.Parse(labelbountyqiymet.Text)).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (SEBET.SelectedItem != null)
            {
                double number=0;
            
                if ((SEBET.SelectedItem as Product).name == button_kola.Text)
                {
                    if (label_kola.Text == "Bitdi") label_kola.Text = "0";
                     number = double.Parse(label_kola.Text);
                    number += (SEBET.SelectedItem as Product).count;
                    label_kola.Text = number.ToString();
                }
                else if ((SEBET.SelectedItem as Product).name == button_fanta.Text)
                {
                    if (label_fanta.Text == "Bitdi") label_fanta.Text = "0";
                    number = double.Parse(label_fanta.Text);
                    number += (SEBET.SelectedItem as Product).count;
                    label_fanta.Text = number.ToString();
                }
                else if ((SEBET.SelectedItem as Product).name == buttonpepsi.Text)
                {           
                    if (labelpepsi.Text == "Bitdi") labelpepsi.Text = "0";
                    number = double.Parse(labelpepsi.Text);
                    number += (SEBET.SelectedItem as Product).count;
                    labelpepsi.Text = number.ToString();
                }
                else if ((SEBET.SelectedItem as Product).name == button_icetea.Text)
                {
                    if (labelicetea.Text == "Bitdi") labelicetea.Text = "0";
                    number = double.Parse(labelicetea.Text);
                    number += (SEBET.SelectedItem as Product).count;
                    labelicetea.Text = number.ToString();
                }
                else if ((SEBET.SelectedItem as Product).name == buttonsnickers.Text)
                {
                    if (labelsnickers.Text == "Bitdi") labelsnickers.Text = "0";
                    number = double.Parse(labelsnickers.Text);
                    number += (SEBET.SelectedItem as Product).count;
                    labelsnickers.Text = number.ToString();
                }
                else if ((SEBET.SelectedItem as Product).name == buttonbounty.Text)
                {
                    if (labelbounty.Text == "Bitdi") labelbounty.Text = "0";
                    number = double.Parse(labelbounty.Text);
                    number += (SEBET.SelectedItem as Product).count;
                    labelbounty.Text = number.ToString();
                }
                SEBET.Items.Remove(SEBET.SelectedItem);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (SEBET.SelectedItem != null)
            {
                double number = 0;
                Product a = new Product();
                a = SEBET.SelectedItem as Product;
                a.count--;
                if (a.count-1 < 0) a.count = 0;
                else
                {
                    if ((SEBET.SelectedItem as Product).name == button_kola.Text)
                    {
                        number = double.Parse(label_kola.Text);
                        number ++;
                        label_kola.Text = number.ToString();
                    }
                    else if ((SEBET.SelectedItem as Product).name == button_fanta.Text)
                    {
                        number = double.Parse(label_fanta.Text);
                        number ++ ;
                        label_fanta.Text = number.ToString();
                    }
                    else if ((SEBET.SelectedItem as Product).name == buttonpepsi.Text)
                    {
                        number = double.Parse(labelpepsi.Text);
                        number++;
                        labelpepsi.Text = number.ToString();
                    }
                    else if ((SEBET.SelectedItem as Product).name == button_icetea.Text)
                    {
                        number = double.Parse(labelicetea.Text);
                        number++;
                        labelicetea.Text = number.ToString();
                    }
                    else if ((SEBET.SelectedItem as Product).name == buttonsnickers.Text)
                    {
                        number = double.Parse(labelsnickers.Text);
                        number++;
                        labelsnickers.Text = number.ToString();
                    }
                    else if ((SEBET.SelectedItem as Product).name == buttonbounty.Text)
                    {
                        number = double.Parse(labelbounty.Text);
                        number++;
                        labelbounty.Text = number.ToString();
                    }

                }
                int index = SEBET.SelectedIndex;
                SEBET.Items.RemoveAt(index);
                SEBET.Items.Insert(index, a);
               
                SEBET.Items.Remove(SEBET.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SEBET.SelectedItem != null)
            {
                double number = 0;
                Product a = new Product();
                a = SEBET.SelectedItem as Product;
                a.count++;
                if (a.count - 1 < 0) a.count = 0;
                else
                {
                    if ((SEBET.SelectedItem as Product).name == button_kola.Text)
                    {
                        number = double.Parse(label_kola.Text);
                        number--;
                        label_kola.Text = number.ToString();
                    }
                    else if ((SEBET.SelectedItem as Product).name == button_fanta.Text)
                    {
                        number = double.Parse(label_fanta.Text);
                        number--;
                        label_fanta.Text = number.ToString();
                    }
                    else if ((SEBET.SelectedItem as Product).name == buttonpepsi.Text)
                    {
                        number = double.Parse(labelpepsi.Text);
                        number--;
                        labelpepsi.Text = number.ToString();
                    }
                    else if ((SEBET.SelectedItem as Product).name == button_icetea.Text)
                    {
                        number = double.Parse(labelicetea.Text);
                        number--;
                        labelicetea.Text = number.ToString();
                    }
                    else if ((SEBET.SelectedItem as Product).name == buttonsnickers.Text)
                    {
                        number = double.Parse(labelsnickers.Text);
                        number--;
                        labelsnickers.Text = number.ToString();
                    }
                    else if ((SEBET.SelectedItem as Product).name == buttonbounty.Text)
                    {
                        number = double.Parse(labelbounty.Text);
                        number--;
                        labelbounty.Text = number.ToString();
                    }

                }
                int index = SEBET.SelectedIndex;
                SEBET.Items.RemoveAt(index);
                SEBET.Items.Insert(index, a);

                SEBET.Items.Remove(SEBET.SelectedItem);
            }
        }
    }
}
