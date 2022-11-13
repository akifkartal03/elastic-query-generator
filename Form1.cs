using KibanaJsonQuery.Model;
using System.IO;
using System.Text.Json;

namespace KibanaJsonQuery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = new List<Should>();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog1.FileName;
                using (StreamReader sr = File.OpenText(file))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        temp.Add(new Should
                        {
                            match_phrase = new MatchPhrase
                            {
                                Id = s
                            }
                        });
                    }
                }
            }
            
            var root = new Root
            {
                query = new Query
                {
                    @bool = new Bool
                    {
                        minimum_should_match = 1,
                        should = temp
                    }
                }
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(root, options);

            richTextBox1.Text = jsonString;
        }
    }
}