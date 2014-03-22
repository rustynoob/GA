using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA
{
    class landscape
    {
        Random r;
        int[] x;
        int[] y;
        public landscape(landscape e)
        {
            r = new Random();
            int size = e.size();
            x = new int[size];
            y = new int[size];
            for (int i = 0; i < size; i++)
            {
                x[i] = e.getX(i);
                y[i] = e.getY(i);
            }
        }
        
        public landscape(int size)
        {
            r = new Random();
            x = new int[size];
            y = new int[size];
            for (int i = 0; i < size; i++)
            {
                x[i] = r.Next(100);
                y[i] = r.Next(100);       
            }
        }
        public int size()
        {
            return x.Length;
        }
        public double fittness(Individual path)
        {
            double dist = 0.0;
            int  b = path.get(0);
            for (int i = 1; i < x.Length; i++)
            {
                int a = b;
                int dx = x[a] - x[b];
                dx = dx > 0 ? dx : -dx;
                int dy = y[a] - y[b];
                dy = dy > 0 ? dy : -dy;
                b = path.get(i);
                dist += (Math.Sqrt((double)((dx*dx)+(dy*dy))));
            }
            return dist;
        }
        public int getX(int i){
            return x[i];
        }
        public int getY(int i)
        {
            return y[i];
        }
        public void mutate(int amount){

            for (int i = 0; i < size(); i++)
            {
                double direction = (r.Next() % 360) * 0.0174532925;
                int distance = r.Next() % amount;

                x[i] += (int)(Math.Cos(direction) * distance);
                y[i] += (int)(Math.Sin(direction) * distance);
            }
        }
    }
}
