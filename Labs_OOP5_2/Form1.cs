using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs_OOP5_2
{
    public partial class Form1 : Form
    {
        int[] arr = new int[25];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str+=arr[i].ToString()+"  ";
            }
            label1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = 0;
            string str = "";
            for (int i = 0;;i++)
            {
                if (i == 0)
                {
                    f=arr[i];
                }
                if (i == arr.Length - 1)
                {
                    arr[arr.Length - 1] = f;
                    break;
                }
                arr[i] = arr[i + 1];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i].ToString() + "  ";
            }
            label1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int f = 0;
            string str = "";
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; ; i++)
                {
                    if (i == 0)
                    {
                        f = arr[i];
                    }
                    if (i == arr.Length - 1)
                    {
                        arr[arr.Length - 1] = f;
                        break;
                    }
                    arr[i] = arr[i + 1];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i].ToString() + "  ";
            }
            label1.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int f = 0;
            string str = "";
            for (int i = arr.Length-1; ; i--)
            {
                if (i == 0)
                {
                    arr[0] = f;
                    break;
                }
                if (i == arr.Length - 1)
                {
                    f = arr[i];
                    
                }
                arr[i] = arr[i-1];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i].ToString() + "  ";
            }
            label1.Text = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int f = 0;
            string str = "";
            for (int j = 0; j < 2; j++)
            {
                for (int i = arr.Length - 1; ; i--)
                {
                    if (i == 0)
                    {
                        arr[0] = f;
                        break;
                    }
                    if (i == arr.Length - 1)
                    {
                        f = arr[i];

                    }
                    arr[i] = arr[i - 1];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i].ToString() + "  ";
            }
            label1.Text = str;
        }
    }
}
