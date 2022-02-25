using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        List<ProductUC> products = new List<ProductUC>() { };
        List<Product> option = new List<Product>();
        List<History> producthistory = new List<History>();



        private void Form1_Load(object sender, EventArgs e)
        {

            //var his = File.ReadAllText("history.json");
            //producthistory = JsonConvert.DeserializeObject<List<History>>(his);


            var hesabjson = File.ReadAllText("baza.json");
            option = JsonConvert.DeserializeObject<List<Product>>(hesabjson);
            if (option.FindAll(n=>/*(n as Product).count.ToString()=="Bitdi" |*/ (n as Product).count== 0).Count>4)
            {
                option.Clear();
                option.Add(new Product("Coca-Cola", 1.5, 10, "https://cdn.iconscout.com/icon/premium/png-256-thumb/cocacola-178382.png"));
                option.Add(new Product("Pepsi", 2.1, 10, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQSOFezLgs9hqE8HLuDPYqF2Awm6U2wLUiKgA&usqp=CAU"));
                option.Add(new Product("Fanta", (3.5), 10, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRIifzWgblZmWXfi160v_3vw0gne_R54gDm7A&usqp=CAU"));
                option.Add(new Product("Ice-tea", 3.5, 10, "https://d2wwnnx8tks4e8.cloudfront.net/images/app/large/5000118047817_3.JPG"));
                option.Add(new Product("Water", 3.5, 10, "https://camzies.com.ng/wp-content/uploads/2016/09/45.jpg"));
                option.Add(new Product("Snickers", 5.6, 10, "https://cf.shopee.com.my/file/1ed10246d8a83c0243670bede85e24a0"));
                option.Add(new Product("Bounty", 2.6, 10, "https://dtgxwmigmg3gc.cloudfront.net/imagery/assets/derivations/icon/256/256/true/eyJpZCI6IjFmMjI5OTQ0ODI4OTg0OGFkMDNhNmVjOGM5YTQ4MGQ4LmpwZyIsInN0b3JhZ2UiOiJwdWJsaWNfc3RvcmUifQ?signature=78e7e64e7ce90bc6725e11090407d0210bf8948f3de8ae589dda4fa1240242a9"));
                option.Add(new Product("Kit-Kat", 3.1, 10, "https://icon-library.com/images/kitkat-icon/kitkat-icon-16.jpg"));
                option.Add(new Product("7 Days Croissant", 7.2, 10, "https://www.kindpng.com/picc/m/154-1543152_double-croissant-7-days-croissant-max-hd-png.png"));
                option.Add(new Product("Twix", 5.6, 10, "https://icon2.cleanpng.com/20180409/rue/kisspng-twix-chocolate-bar-mars-milk-candy-cookie-5acb2e3281ce00.2273096315232650745317.jpg"));
                option.Add(new Product("M&M", 2.4, 10, "https://images.heb.com/is/image/HEBGrocery/000121396?fit=constrain,1&wid=800&hei=800&fmt=jpg&qlt=85,0&resMode=sharp2&op_usm=1.75,0.3,2,0"));
                option.Add(new Product("Oreo", 1.6, 10, "https://digitalcontent.api.tesco.com/v2/media/ghs/e6b2e65a-cd7d-41cc-87a5-1c4108950f6b/3603d539-4f25-4273-930f-f790d22b9195_1014455455.jpeg?h=540&w=540"));
                option.Add(new Product("Tutku", 1.6, 10, "https://www.bosphorusmarket.com/uploads/1/3/4/0/134063848/s435321757357478238_p1514_i1_w1200.jpeg"));





            }
         


            int x = 0;
            int y = 0;
            for (int i = 0; i < option.Count; i++)
            {
                ProductUC lazim = new ProductUC(ref SEBET);
                lazim.button_name.Text = option[i].name;
                lazim.pictureBox1.LoadAsync($@"{option[i].image}");
                lazim.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                lazim.button_name.Text = option[i].name;
                lazim.label_qiymet.Text = (option[i].money).ToString();
                lazim.label_count.Text = (option[i].count).ToString();
                lazim.odenilmeli = label_odenilmeli;
                lazim.label_qiymet.Text = option[i].money.ToString();

                if (i % 3 == 0 && i != 0)
                {

                    y += 400;
                    x = 0;

                    lazim.Location = new Point(x, y);
                }
                else if (i == 0)
                {
                    lazim.Location = new Point(x, y);
                }
                else
                {

                    x += 200;
                    lazim.Location = new Point(x, y);
                }
                products.Add(lazim);
                Controls.Add(lazim);
            }




        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox_money.Text = (double.Parse(textBox_money.Text) + 0.10).ToString();
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



        private void button1_Click_1(object sender, EventArgs e)
        {
            double odenilmeli = double.Parse(label_odenilmeli.Text);
            double daxil = double.Parse(label_daxil.Text);
            if (daxil > odenilmeli)
            {
                labelqaliq.Text = (daxil - odenilmeli).ToString();
                


                List<Product> lazimli = new List<Product>();
                foreach (var item in SEBET.Items)
                {
                    lazimli.Add(item as Product );
                }
                History history = new History(lazimli,daxil,daxil-odenilmeli,DateTime.Now);
                producthistory.Add(history);
                var hisoryproduct = JsonConvert.SerializeObject(producthistory, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("history.json", hisoryproduct);



                SEBET.Items.Clear();
                for (int i = 0; i < products.Count; i++)
                {
                    option[i].name = products[i].button_name.Text;
                    option[i].money = double.Parse(products[i].label_qiymet.Text);
                    if (products[i].label_count.Text == "Bitdi") option[i].count = 0;
                    else option[i].count = int.Parse(products[i].label_count.Text);
                }
                var producs = JsonConvert.SerializeObject(option, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("baza.json", producs);
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








        private void productUC_Kola_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            double number = 0;

            for (int i = 0; i < products.Count; i++)
            {
                foreach (var item in SEBET.Items) {

                    number = 0;
                    if (products[i].button_name.Text == (item as Product).name)
                    {

                        number = double.Parse(products[i].label_count.Text);
                        number += (item as Product).count;
                        products[i].label_count.Text = number.ToString();
                        break;


                    }
                }
            }






            SEBET.Items.Clear();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (SEBET.SelectedItem != null)
            {
                double number = 0;

                for (int i = 0; i < products.Count; i++)
                {


                    number = 0;
                    if (products[i].button_name.Text == (SEBET.SelectedItem as Product).name)
                    {

                        number = double.Parse(products[i].label_count.Text);
                        number += (SEBET.SelectedItem as Product).count;
                        products[i].label_count.Text = number.ToString();

                        break;


                    }

                }
                SEBET.Items.RemoveAt(SEBET.SelectedIndex);
            }

        }

        private void button2_Click(object sender, EventArgs e)
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
                    for (int i = 0; i < products.Count; i++)
                    {


                        number = 0;
                        if ((SEBET.SelectedItem as Product).name == products[i].button_name.Text)
                        {
                            number = double.Parse(products[i].label_count.Text);
                            number--;
                            products[i].label_count.Text = number.ToString();
                        }


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
                a.count--;
                if (a.count - 1 < 0) a.count = 0;
                else
                {
                    for (int i = 0; i < products.Count; i++)
                    {


                        number = 0;
                        if ((SEBET.SelectedItem as Product).name == products[i].button_name.Text)
                        {
                            number = double.Parse(products[i].label_count.Text);
                            number++;
                            products[i].label_count.Text = number.ToString();
                        }


                    }



                }
                int index = SEBET.SelectedIndex;
                SEBET.Items.RemoveAt(index);
                SEBET.Items.Insert(index, a);

                SEBET.Items.Remove(SEBET.SelectedItem);
            }
        }

        private void textBox_money_TextChanged_1(object sender, EventArgs e)
        {
            label_daxil.Text = textBox_money.Text;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
    public class Product
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

        public Product(string name, double money, int count, string image) : this(name, money, count)
        {
            this.image = image;
        }

        public string name { get; set; }
        public double money { get; set; }
        public int count { get; set; }
        public string image { get; set; }
        public override string ToString() => $"{name:10}-------{money}------{count}";
    }
    public class History{
       

        public History(List<Product> sebethistory, double inputmoney, double returnmoney, DateTime time)
        {
            this.sebethistory = sebethistory;
            this.inputmoney = inputmoney;
            this.returnmoney = returnmoney;
            this.time = time;
        }
        public List<Product> sebethistory { get; set; }
        public double inputmoney { get; set; }
        public double returnmoney { get; set; }
        public DateTime time { get; set; }
    }

}
