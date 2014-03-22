using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA
{
    class Stat
    {
        public double min;
        public double max;
        public double med;
        public double mean;
        public int count;
        public Stat(landscape e, Population p){
            process(e, p);
        }
        public void process(landscape e, Population p)
        {
            p.sort();
            min = p.getFittness(0);
            max = p.getFittness(p.size()-1);
            mean = 0;
            count = p.size();
           
            for (int i = 0; i < p.size(); i++)
            {
                double fittness = p.getFittness(i);
                mean += fittness;
                /*
                if (fittness < min)
                {
                    min = fittness;
                }
                if (fittness > max)
                {
                    max = fittness;
                }
                 * */
            }
            med = p.getFittness(p.size() / 2);
            mean /= (double)p.size();
        }
        public string toString()
        {
            //return "max-" + max + " min-" + min + " med-" + med + " mean-" + mean;
            return max + "," + min + "," + med + "," + mean;// +"," + count;
            
        }
       
        
    }
}
