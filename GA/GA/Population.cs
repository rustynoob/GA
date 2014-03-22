using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA
{
    class Population
    {
        
        public List<Individual> indi;
        public landscape home;
        int dead;
        public int max(){return indi.Count;}
        public int size() { return indi.Count-dead; }
        public Population() { 
            indi = new List<Individual>(100); 
            
        }

        public Population(int size, landscape e) 
        {
            home = e;
            dead = 0;
            indi = new List<Individual>(size*2);
            for (int i = 0; i < size; i++)
            {
                indi.Add(new Individual(home.size()));
                indi[i].setFittness(home);
            }
           
        }

        public Population(Population p)
        {
            dead = p.dead;
            home = p.home;
            indi = new List<Individual>(p.indi.Count);
            for (int i = 0; i < p.indi.Count; i++)
            {
                indi.Add(p.get(i));
                indi[i].setFittness(home);
            }
           
           
        }
        public void setLandscape(landscape e){
            home = e;
            updateFittness();
        }
        private void updateFittness() 
        {
            for (int i = 0; i < indi.Count; i++)
            {
                indi[i].setFittness(home); 
            }
        
        }

        public void remove(int index)
        {
            //dead++;
            indi.RemoveAt(index);//.dead = true;
        }

        public void add(Individual individual)
        {
            individual.setFittness(home);
            indi.Add(individual);
        }

        void mutate(int amnt)
        {
            for (int i = 0; i < indi.Count; i++)
            {
                indi[i].mutate(amnt);
                indi[i].setFittness(home);
            }
        }

        public Individual get(int i){
            return indi[i];
        }
        public double getFittness(int i){
            if(i < indi.Count && i >= 0)
            return indi[i].getFittness();
            return -1;
        }

        public void swap(int a, int b)
        {
            if (a >= 0 && a < indi.Count && b >= 0 && b < indi.Count)
            {
                Individual t = indi[a];
                indi[a] = indi[b];
                indi[b] = t;
            }
        }
        public void sort()
        {
            indi.Sort();
            /*
             for (int i = 0; i < last-1; i++)
             {
                 for (int j = i + 1; j > 0 && getFittness(j) < getFittness(j - 1); swap(j, --j)) ;
             }
             //*/
         
             
        }

        internal bool identical(int o, int p)
        {
            
            for (int i = 0; i < indi[0].genes.Length; i++)
            {
                if (indi[o].genes[i] != indi[p].genes[i])
                {
                    return false;
                }
            }
            return true;
        }
        public string toString()
        {
            string rv = "";
            for (int i = 0; i < indi.Count; i++)
            {
                
                rv += ",";
                //if (!indi[i].dead)
                    rv += indi[i].getFittness();
            }
            return rv;
        }
    }

}

