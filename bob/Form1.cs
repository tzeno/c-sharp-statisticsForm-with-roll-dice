using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bob
{
  public partial class Form1 : Form
  {
    int index = 0;
    int sum = 0;
    int dice = 0;
    public Form1()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
      
    private void button1_Click(object sender, EventArgs e)
    {
      int num = 0;
      
      switch (index)
      {
        case 0:
          num = Roll();
          textBox1.Text = num.ToString();
          break;
        case 1:
          num = Roll();
          textBox2.Text = num.ToString();
          break;
        case 2:
          num = Roll();
          textBox3.Text = num.ToString();
          break;
        case 3:
          num = Roll();
          textBox4.Text = num.ToString();
          break;
        case 4:
          num = Roll();
          textBox5.Text = num.ToString();
          break;
        case 5:
          num = Roll();
          textBox6.Text = num.ToString();
          break;
      }
      index++;
      sum = (sum+ num);
      label7.Text = sum.ToString(); 

    }
    int Roll()
    {
      label8.Text = "";

      int sum = 0;
      Random rand = new Random();
      for(int i = 0; i < 3; i++)
      {
        dice = rand.Next(1, 6);
        sum += dice;
        label8.Text = String.Format("");
      }
      return sum;
      //
    }

    private void button2_Click(object sender, EventArgs e)
    {
      index = 0;
      sum = 0;
      textBox1.Text = "";
      textBox2.Text = "";
      textBox3.Text = "";
      textBox4.Text = "";
      textBox5.Text = "";
      textBox6.Text = "";


    }
  }
}
