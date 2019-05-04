using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_Counter
{
    public partial class Form1 : Form
    {
        double[] calories = {66, 340, 352, 129, 109, 143, 100, 102, 540, 45, 0.5, 54,
                          150, 43, 72, 105, 10, 80, 41, 125, 10, 20 };
        public Form1()
        {
            InitializeComponent();
            NumericUpDown[] array = { txtBread, txtMusli, txtPasta, txtRice, txtCheese, txtEgg,
                txtChocolate, txtMilk, txtCoffee, txtJuice, txtApple, txtBanana, txtBeer, txtCarrot,
                txtTomato, txtCucumber, txtFish, txtPotato, txtCola, txtBanana, txtStrawberry, txtMeat};
            for (var i = 0; i < 22; i++)
            {
                    array[i].Text = "0";
            }
            txtTotal.Text = "0";
            txtTotal.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Please confirm you want to Exit the App","Counter Calories", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ResetBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is NumericUpDown)
                    {
                        (control as NumericUpDown).Text = "0";
                        (control as NumericUpDown).Enabled = false;
                    }
                    else
                        func(control.Controls);
                    txtTotal.Text = "0";
                    txtTotal.Enabled = false;

                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
                };
            };
            func(Controls);
        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is NumericUpDown)
                        (control as NumericUpDown).Enabled = true;
                    else
                        func(control.Controls);
                };
            };
            func(Controls);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetBoxes();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            NumericUpDown[] array = { txtBread, txtMusli, txtPasta, txtRice, txtCheese, txtEgg,
                txtChocolate, txtMilk, txtCoffee, txtJuice, txtApple, txtBanana, txtBeer, txtCarrot,
                txtTomato, txtCucumber, txtFish, txtPotato, txtCola, txtBanana, txtStrawberry, txtMeat};
            double counter = 0;
            for (var i = 0; i < 22; i++)
            {
                if(array[i].Text != "0" && array[i].Text != "")
                {
                    counter += Convert.ToDouble(array[i].Text) * calories[i];
                }
            }

            txtTotal.Text = Convert.ToString(counter);
            txtTotal.ReadOnly = true;
            txtTotal.BackColor = Color.White;
            txtTotal.ForeColor = Color.Black;
        }
        private void bread_CheckedChanged(object sender, EventArgs e)
        {
            if (bread.Checked == true)
            {
                txtBread.Enabled = true;
                txtBread.Text = "";
                txtBread.Focus();
            }
            else
            {
                txtBread.Enabled = false;
                txtBread.Text = "0";
            }
        }

        private void musli_CheckedChanged(object sender, EventArgs e)
        {

            if (musli.Checked == true)
            {
                txtMusli.Enabled = true;
                txtMusli.Text = "";
                txtMusli.Focus();
            }
            else
            {
                txtMusli.Enabled = false;
                txtMusli.Text = "0";
            }
        }

        private void pasta_CheckedChanged(object sender, EventArgs e)
        {
            if (pasta.Checked == true)
            {
                txtPasta.Enabled = true;
                txtPasta.Text = "";
                txtPasta.Focus();
            }
            else
            {
                txtPasta.Enabled = false;
                txtPasta.Text = "0";
            }
        }

        private void rice_CheckedChanged(object sender, EventArgs e)
        {
            if (rice.Checked == true)
            {
                txtRice.Enabled = true;
                txtRice.Text = "";
                txtRice.Focus();
            }
            else
            {
                txtRice.Enabled = false;
                txtRice.Text = "0";
            }
        }

        private void fish_CheckedChanged(object sender, EventArgs e)
        {
            if (fish.Checked == true)
            {
                txtFish.Enabled = true;
                txtFish.Text = "";
                txtFish.Focus();
            }
            else
            {
                txtFish.Enabled = false;
                txtFish.Text = "0";
            }
        }

        private void meat_CheckedChanged(object sender, EventArgs e)
        {
            if (meat.Checked == true)
            {
                txtMeat.Enabled = true;
                txtMeat.Text = "";
                txtMeat.Focus();
            }
            else
            {
                txtMeat.Enabled = false;
                txtMeat.Text = "0";
            }
        }

        private void egg_CheckedChanged(object sender, EventArgs e)
        {
            if (egg.Checked == true)
            {
                txtEgg.Enabled = true;
                txtEgg.Text = "";
                txtEgg.Focus();
            }
            else
            {
                txtEgg.Enabled = false;
                txtEgg.Text = "0";
            }
        }

        private void cheese_CheckedChanged(object sender, EventArgs e)
        {
            if (cheese.Checked == true)
            {
                txtCheese.Enabled = true;
                txtCheese.Text = "";
                txtCheese.Focus();
            }
            else
            {
                txtCheese.Enabled = false;
                txtCheese.Text = "0";
            }
        }

        private void chocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (chocolate.Checked == true)
            {
                txtChocolate.Enabled = true;
                txtChocolate.Text = "";
                txtChocolate.Focus();
            }
            else
            {
                txtChocolate.Enabled = false;
                txtChocolate.Text = "0";
            }
        }

        private void milk_CheckedChanged(object sender, EventArgs e)
        {
            if (milk.Checked == true)
            {
                txtMilk.Enabled = true;
                txtMilk.Text = "";
                txtMilk.Focus();
            }
            else
            {
                txtMilk.Enabled = false;
                txtMilk.Text = "0";
            }
        }

        private void coffee_CheckedChanged(object sender, EventArgs e)
        {
            if (coffee.Checked == true)
            {
                txtCoffee.Enabled = true;
                txtCoffee.Text = "";
                txtCoffee.Focus();
            }
            else
            {
                txtCoffee.Enabled = false;
                txtCoffee.Text = "0";
            }
        }

        private void juice_CheckedChanged(object sender, EventArgs e)
        {
            if (juice.Checked == true)
            {
                txtJuice.Enabled = true;
                txtJuice.Text = "";
                txtJuice.Focus();
            }
            else
            {
                txtJuice.Enabled = false;
                txtJuice.Text = "0";
            }
        }

        private void cola_CheckedChanged(object sender, EventArgs e)
        {
            if (cola.Checked == true)
            {
                txtCola.Enabled = true;
                txtCola.Text = "";
                txtCola.Focus();
            }
            else
            {
                txtCola.Enabled = false;
                txtCola.Text = "0";
            }
        }

        private void beer_CheckedChanged(object sender, EventArgs e)
        {
            if (beer.Checked == true)
            {
                txtBeer.Enabled = true;
                txtBeer.Text = "";
                txtBeer.Focus();
            }
            else
            {
                txtBeer.Enabled = false;
                txtBeer.Text = "0";
            }
        }

        private void banana_CheckedChanged(object sender, EventArgs e)
        {
            if (banana.Checked == true)
            {
                txtBanana.Enabled = true;
                txtBanana.Text = "";
                txtBanana.Focus();
            }
            else
            {
                txtBanana.Enabled = false;
                txtBanana.Text = "0";
            }
        }

        private void apple_CheckedChanged(object sender, EventArgs e)
        {
            if (apple.Checked == true)
            {
                txtApple.Enabled = true;
                txtApple.Text = "";
                txtApple.Focus();
            }
            else
            {
                txtApple.Enabled = false;
                txtApple.Text = "0";
            }
        }

        private void orange_CheckedChanged(object sender, EventArgs e)
        {
            if (orange.Checked == true)
            {
                txtOrange.Enabled = true;
                txtOrange.Text = "";
                txtOrange.Focus();
            }
            else
            {
                txtOrange.Enabled = false;
                txtOrange.Text = "0";
            }
        }

        private void strawberry_CheckedChanged(object sender, EventArgs e)
        {
            if (strawberry.Checked == true)
            {
                txtStrawberry.Enabled = true;
                txtStrawberry.Text = "";
                txtStrawberry.Focus();
            }
            else
            {
                txtStrawberry.Enabled = false;
                txtStrawberry.Text = "0";
            }
        }

        private void tomato_CheckedChanged(object sender, EventArgs e)
        {
            if (tomato.Checked == true)
            {
                txtTomato.Enabled = true;
                txtTomato.Text = "";
                txtTomato.Focus();
            }
            else
            {
                txtTomato.Enabled = false;
                txtTomato.Text = "0";
            }
        }

        private void cucumber_CheckedChanged(object sender, EventArgs e)
        {
            if (cucumber.Checked == true)
            {
                txtCucumber.Enabled = true;
                txtCucumber.Text = "";
                txtCucumber.Focus();
            }
            else
            {
                txtCucumber.Enabled = false;
                txtCucumber.Text = "0";
            }
        }

        private void potato_CheckedChanged(object sender, EventArgs e)
        {
            if (potato.Checked == true)
            {
                txtPotato.Enabled = true;
                txtPotato.Text = "";
                txtPotato.Focus();
            }
            else
            {
                txtPotato.Enabled = false;
                txtPotato.Text = "0";
            }
        }

        private void carrot_CheckedChanged(object sender, EventArgs e)
        {
            if (carrot.Checked == true)
            {
                txtCarrot.Enabled = true;
                txtCarrot.Text = "";
                txtCarrot.Focus();
            }
            else
            {
                txtCarrot.Enabled = false;
                txtCarrot.Text = "0";
            }
        }
    }
}
