using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConverterArraySetAdapterLib.Interfaces;
using ConverterArraySetAdapterLib.Adapters;
using System.Collections;

namespace Lab6_AdapterPattern_ArrayToSet
{
    public partial class Form1 : Form
    {
        IUser<int> user = new ConverterAdapter<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            string[] numbersArray = textBox1.Text.Split(' ');
            int[] intArray = Array.ConvertAll(numbersArray, int.Parse);

            var intSet = user.ArrayToSet(intArray);

            foreach (var i in intSet)
                textBox2.Text += i + " ";

            textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            string[] numbersArray = textBox2.Text.Split(' ');
            HashSet<int> intSet = numbersArray.Select(int.Parse).ToHashSet();

            var intArray = user.SetToArray(intSet);

            foreach (var i in intArray)
                textBox1.Text += i + " ";

            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }
    }
}
