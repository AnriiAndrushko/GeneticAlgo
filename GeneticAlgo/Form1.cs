using GeneticAlgo.Logic;
using GeneticAlgo.Logic.Objects;
using GeneticAlgo.Logic.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Graphics g = canvas.CreateGraphics();
            int padding = 20;
            var algo = new SelectionAlgo((int)IterationsInput.Value, (int)AgentsInput.Value, 
                                        MutatorSlider.Value, CityGenerator.GetCities((int)CitiesInput.Value, 
                                        padding, canvas.Size.Width, canvas.Size.Height));
            foreach (var path in algo.currentGeneration)
            {
                Random random = new Random();
                int red = random.Next(256);
                int green = random.Next(256);
                int blue = random.Next(256);
                Pen pen = new Pen(Color.FromArgb(red, green, blue), 2);
                City city1;
                City city2 = null;
                for (int i = 1; i<path.CurPath.Length; i++)
                {
                    city1 = path.CurPath[i-1];
                    city2 = path.CurPath[i];
                    g.DrawLine(pen, city1.Loaction,
                    city2.Loaction);
                }
                g.DrawLine(pen, city2.Loaction,
                    path.CurPath[0].Loaction);
            }
            foreach(var city in algo.cities)
            {
                g.DrawString(city.Name,
                    textFnt, Brushes.Blue, city.Loaction);
            }


        }
    }
}
