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

namespace ChromeDino
{
    public partial class ListScore : Form
    {
        public ListScore(int intPoints)
        {
            InitializeComponent();
            List();
            this.score = Convert.ToString(intPoints);
        }

        string text;
        string score;
        Game game = new Game();

        private void List()
        {
            int numberOfFile = 0;
            string[] files = Directory.GetFiles(Application.StartupPath);
            foreach (var file in files)
            {
                if (file.EndsWith(".txt"))
                {

                    using (StreamReader personData = new StreamReader(files[numberOfFile]))
                    {
                        text = personData.ReadToEnd();
                    }
                    listTxt.Text += text;
                }
                numberOfFile++;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e) { this.Close(); }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            listTxt.Clear();
            string name = nameText.Text;
            string fileName = name + " - " + score + ".txt";

            if (!String.IsNullOrEmpty(nameText.Text))
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                StreamWriter wr = new StreamWriter(fs);
                wr.WriteLine(name + " - " + score);
                wr.Close();
                fs.Close();
            }
            List();
        }
    }
}
