using System.Xml.Linq;

namespace Flames
{
    public partial class Form1 : Form
    {
        private string name1, name2;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] flamesValue = new string[] { "FRIEND", "LOVE", "AFFECTION", "MARRIAGE", "ENEMY", "SISTER" };
            int[] visit = new int[name2.Length];
            int count = name1.Length + name2.Length;
            for (int i = 0; i < name2.Length; i++)
            {
                visit[i] = 0;
            }
            for (int i = 0; i < name1.Length; i++)
            {
                for (int j = 0; j < name2.Length; j++)
                {
                    if (name1[i] == name2[j] && visit[j] == 0)
                    {
                        visit[j] = 1;
                        count -= 2;
                        break;
                    }
                }
            }

            if (count < 7)
            {
                textBox3.Text = flamesValue[count - 1];
            }
            else
            {
                int value = count % 7;
                textBox3.Text = flamesValue[value];
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name1 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            name2 = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}