using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA
{
    public partial class WindowGA : Form
    {
        GA ga;
        Population seed;
        
        public WindowGA()
        {
            InitializeComponent();
            ga = null;
        }

       
        
        private void run_Click_1(object sender, EventArgs e)
        {
            int time;
           
           
            landscape env = new landscape((int)CityCount.Value);
            Population pop = new Population((int)setPopSize.Value, env);
            ga = new GA(pop);

            ga.mutationFactor = (int)setMutFact.Value;

            seed = ga.pop;
            time = ga.evolve().Count;
            fit.Text = "" + time +'\n';
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (seed == null) return;
            int sampleSize = (int)SampSize.Value;
            int mutate = (int)MapDivrg.Value;
            List<List<List<Stat>>> stats = new List<List<List<Stat>>>();
            for (int j = 0; j < sampleSize; j++)
            {
                stats.Add(new List<List<Stat>>());
                for (int i = 0; i < mutate; i++)
                {
                    Population pop = new Population(seed);
                    landscape map = new landscape(seed.home);
                    map.mutate(i + 1);
                    pop.setLandscape(map);
                    GA tempGA = new GA(pop);
                    stats[j].Add(tempGA.evolve());
                }
            }
            string output = "";
            
            
            for (int i = 0; i < stats[0].Count; i++){

                for (int j = 0; j < sampleSize; j++)
                {
                    output += stats[j][i].Count + ",";
                }
                output += Environment.NewLine;
            }
            fit.Text = output;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fit.Text = "";

        }
      
    }
}
