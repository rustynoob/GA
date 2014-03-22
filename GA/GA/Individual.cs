using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA
{
    class Individual : IComparable
    {
        public bool dead;
        static Random r;
        public int[] genes;
        double fittness;
        int size() { return genes.Length; }
       
        /*public Individual()
        {
            Console.WriteLine("invalid individual");
            genes = new int[1];
            genes[2] = 0;// a really crappy way to throw an exception
            if (r == null) r = new Random();
            for (int i = 0; i < 100; i++)
            {
                genes[i] = i;
            }
            mutate(20);
        }
        //*/
        public Individual(int size)
        {
            genes = new int[size];
            if (r == null) r = new Random();
            for (int i = 0; i < size; i++)
            {
                genes[i] = i;

            }
            fittness = 0;
            mutate(size / 2);
            dead = false;
        }
        public Individual(Individual Twin)
        {
            genes = new int[Twin.size()];
            for (int i = 0; i < genes.Length; i++)
            {
                genes[i] = Twin.get(i);
            }
            fittness = 0;
            dead = Twin.dead;
        }

        public void mutate(int level)
        {
            int start = r.Next(genes.Length);
            int end = start + r.Next(genes.Length - start);
            int[] temp = new int[end - start];
            for (int i = start; i < end; i++)
            {
                temp[i - start] = genes[i];
            }
            for (int i = start; i + temp.Length < genes.Length; i++)
            {
                genes[i] = genes[i + temp.Length];
            }
            for (int i = 0; i < temp.Length; i++)
            {
                genes[genes.Length - 1 - i] = temp[i];
            }
            dead = false;
        }
        public int get(int i)
        {
            return genes[i];
        }
        public void setFittness(landscape e)
        {
            fittness = 0;
            int b = get(0);
            for (int i = 1; i < genes.Length; i++)
            {
                int a = b;
                b = get(i);
                int dx = e.getX(a) - e.getX(b);
                //dx = dx > 0 ? dx : -dx;
                int dy = e.getY(a) - e.getY(b);
                //dy = dy > 0 ? dy : -dy;
                fittness += (Math.Sqrt((double)((dx * dx) + (dy * dy))));
            }
        }
        public double getFittness() { return fittness; }
        /*
        static public bool operator <(Individual i1, Individual i2)
        {
            return i1.fittness < i2.fittness;
        }
        static public bool operator >(Individual i1, Individual i2)
        {
            return i1.fittness > i2.fittness;
        }
        static public bool operator ==(Individual i1, Individual i2)
        {
            return i1.fittness == i2.fittness;
        }
        static public bool operator !=(Individual i1, Individual i2)
        {
            return i1.fittness != i2.fittness;
        }
        static public bool operator <=(Individual i1, Individual i2)
        {
            return i1.fittness <= i2.fittness;
        }
        static public bool operator >=(Individual i1, Individual i2)
        {
            return i1.fittness >= i2.fittness;
        }
        /*
        public int CompareTo(object obj)
        {
            return (int)( this.fittness - ((Individual)obj).fittness);
        }
        //*/
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Individual other = obj as Individual;
            if (other != null)
                return this.fittness.CompareTo(other.fittness);
            else
                throw new ArgumentException("Object is not a Temperature");
        }
    }
}
