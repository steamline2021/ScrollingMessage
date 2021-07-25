using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace ScrollingMessage
{
    public partial class EquityDisplay : Form
    {
        private readonly ObservableCollection<string> mylist = new ObservableCollection<string>();
        

        private Timer t1 = new Timer();

        public EquityDisplay()
        {
            InitializeComponent();
            AddToList();
            InitializeComposite();
            DisplayListItems();
            DisplayCollectionInGrid();
        }

        private void DisplayCollectionInGrid()
        {
            listBox1.Items.Clear();
            foreach (var x in mylist)
            {
                listBox1.Items.Add(x);
            }
        }

        private void AddToList()
        {
            mylist.Add("ICE:121");
            mylist.Add("NIO:43");
            mylist.Add("TSLA:643");
            //mylist.Add("GOOG:2763");
            //mylist.Add("SPCE:29");
            //mylist.Add("TWTR:71");
            //mylist.Add("TWLO:409");
        }

        private void DisplayListItems()
        {
            label1.Text = string.Empty;
            foreach (var x in mylist)
            {
                label1.Text += " " + x;
            }
        }

        private void InitializeComposite()
        {
            //Creating Leaf Objects
            IComponent hardDisk = new Ticker("ICE", "121");
            IComponent ram = new Ticker("GOOG", "2700");
            IComponent cpu = new Ticker("TSLA", "645");
            IComponent mouse = new Ticker("MSFT", "289");
            //IComponent keyboard = new Ticker("Keyboard", 2000);

            //Creating composite objects
            Composite motherBoard = new Composite("Peripherals");
            Composite cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");
            Composite computer = new Composite("Computer");

            //Creating tree structure
            //Ading CPU and RAM in Mother board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);

            //Ading mother board and hard disk in Cabinet
            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);

            //Ading mouse and keyborad in peripherals
            peripherals.AddComponent(mouse);
            //peripherals.AddComponent(keyboard);

            //Ading cabinet and peripherals in computer
            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t1.Interval = 20;
            t1.Tick += T1_Tick;
            t1.Start();
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            int i;
            i = label1.Location.X;
            if (i >= this.Width)
                i = 0;
            else
                i = label1.Location.X + 1;
            label1.Location = new Point(i, 10);
            label1.Width = 20;
            label1.Height = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            mylist.Add(" " + textBoxSymbol.Text.ToUpper() + ":" + rand.Next(50, 101).ToString());//textBoxPrice.Text.ToUpper());
            DisplayListItems();
            DisplayCollectionInGrid();
            textBoxSymbol.Clear();
            //textBoxPrice.Clear();
        }

   

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string itemToRemove = "";
            if (listBox1.SelectedItem != null)
            {
                itemToRemove = listBox1.SelectedItem.ToString();
            }


            if (mylist.Contains(itemToRemove.ToUpper()))
            {
                mylist.Remove(itemToRemove);
            }
            DisplayListItems();
            DisplayCollectionInGrid();
        }


        private void textBoxPrice_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPrice.Clear();
        }

        private void textBoxSymbol_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxSymbol.Clear();
        }
    }
}
