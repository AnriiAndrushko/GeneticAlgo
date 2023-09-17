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
        private Font textFnt = new Font("Arial", 10);
        public GeneticAlgo()
        {
            InitializeComponent();
        }
        
        private void GeneticAlgo_Load(object sender, EventArgs e)
        {
            canvas.BackColor = Color.White;
            //canvas.Paint += new PaintEventHandler(this.canvas_Paint);
            //this.Controls.Add(canvas);
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            Graphics g = canvas.CreateGraphics();
            g.DrawString("Test city",
            textFnt, Brushes.Blue, new Point(30, 30));

            g.DrawLine(Pens.Red, 0, 0,
                canvas.Size.Width, canvas.Size.Height);
        }
    }
}
