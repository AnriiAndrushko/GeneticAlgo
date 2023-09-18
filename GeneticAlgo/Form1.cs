using GeneticAlgo.Logic;
using GeneticAlgo.Logic.Objects;
using GeneticAlgo.Logic.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;
using Path = GeneticAlgo.Logic.Path;

namespace GeneticAlgo
{
    public partial class GeneticAlgo : Form
    {
        private Font textFnt = new Font("Arial", 15);
        public GeneticAlgo()
        {
            InitializeComponent();
        }
        
        private void GeneticAlgo_Load(object sender, EventArgs e)
        {
            //canvas.BackColor = Color.White;
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            results.Text = "";
            results.Refresh();
            Graphics g = canvas.CreateGraphics();
            g.Clear(Color.White);
            int padding = 20;
            Path path;
            var algo = new SelectionAlgo((int)AgentsInput.Value, MutatorSlider.Value,
                                        AliveSlider.Value, CityGenerator.GetCities((int)CitiesInput.Value, 
                                        padding, canvas.Size.Width, canvas.Size.Height));

            for (int i = 0; i < (int)IterationsInput.Value; i++)
            {
                algo.MakeIteration();
                path = algo.GetBestPath();
                results.AppendText(results.Text + path.TotalDistance + "\r\n");
                results.Refresh();
                DrawPath(path, g, algo.cities, 2);
            }
            path = algo.GetBestPath();
            results.AppendText(results.Text + path.TotalDistance + "\r\n");
            DrawPath(path, g, algo.cities, 10);
        }

        void DrawPath(Path path, Graphics g, City[] cities, int thickness)
        {

            Random random = new Random();
            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);
            Pen pen = new Pen(Color.FromArgb(red, green, blue), thickness);
            City city1;
            City city2 = null;
            for (int j = 1; j < path.CurPath.Length; j++)
            {
                city1 = path.CurPath[j - 1];
                city2 = path.CurPath[j];
                g.DrawLine(pen, city1.Loaction,
                city2.Loaction);
            }
            g.DrawLine(pen, city2.Loaction,
                path.CurPath[0].Loaction);

            foreach (var city in cities)
            {
                g.DrawString(city.Name,
                    textFnt, Brushes.Blue, city.Loaction);
            }

        }
    }
}
