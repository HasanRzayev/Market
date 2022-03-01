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
    
    public partial class ProductUC : UserControl
    {
        public  ListBox productss= new ListBox();
        public Label odenilmeli=new Label();
        public ProductUC()
        {
            InitializeComponent();
        }

        public ProductUC(ref ListBox productss)
        {
            InitializeComponent();
            this.productss = productss;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (label_count.Text != "Bitdi" && label_count.Text != "0")
            {
                double number = double.Parse(label_count.Text);
                number -= 1;

                if (number <= 0) label_count.Text = "Bitdi";
                else label_count.Text = number.ToString();
            }
            else
            {
                return;
            }
            int option = 0;

            Product lazim = new Product(button_name.Text, double.Parse(label_qiymet.Text), 1);

            for (int i = 0; i < productss.Items.Count; i++)
            {
                if ((productss.Items[i] as Product).name == lazim.name)
                {

                    Product a = productss.Items[i] as Product;

                    a.count += 1;

                    productss.Items.RemoveAt(i);
                    productss.Items.Insert(i, a);

                    option += 1;
                }
            }


            if (option == 0)
            {
                productss.Items.Add(lazim);
            }
            odenilmeli.Text = (double.Parse(odenilmeli.Text) + double.Parse(label_qiymet.Text)).ToString();

        }

     
    }
}
