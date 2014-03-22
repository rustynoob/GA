using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA
{
    class GA
    {
         
       public static Random r;
       public  Population pop;
       public  landscape world;
       public List<Population> pops;
       public  List<Stat> stats;
       public  int generation;
       public  int mutationFactor = 10;
       public  int targetSize;
       public  int maxGeneration = 10000;
     
        public GA()
        {
            System.Diagnostics.Debug.WriteLine("Initilizing invalid GA");
           
            if(r == null)r = new Random();
            world = new landscape(12);
            pop = new Population(50, world);
            generation = 0;
            targetSize = pop.size();
            stats = new List<Stat>(maxGeneration);
        }
        public GA(Population Pop)
        
        {
           
            if (r == null) r = new Random();
            world = new landscape(Pop.home);
            pop = new Population(Pop);
            generation = 0;
            targetSize = Pop.size();
            stats = new List<Stat>(maxGeneration);
        }
        public void reproduce()
        {
            pop.sort();
            for (int i = pop.indi.Count; i > 0; i--)
            {
                if (i < r.Next(pop.indi.Count) && !pop.indi[i].dead )
                {
                    Individual individual = new Individual(pop.get(i));
                    individual.mutate(r.Next(maxGeneration-generation)/mutationFactor );
                    pop.add(individual);
                }
            }
            
            while (pop.size() < targetSize)
            {
                Individual individual = new Individual(pop.get(r.Next(pop.size())));
                individual.mutate(mutationFactor);
                pop.add(individual);
            }
        }
        public void kull() {
            pop.sort();
            Individual best = pop.get(0);
            
            pop.sort();
            for (int i = pop.size()-1; i > 0 ; i--)
            {

                if (pop.identical(i, i - 1) && !pop.indi[i].dead)
                {
                    pop.remove(i);
                }
            }
            for (int i = pop.indi.Count-1; i > 5 && pop.size() > targetSize; i--) //
            {
                if (i > r.Next(pop.indi.Count) && !pop.indi[i].dead)
                {
                    pop.remove(i);
                }
            }
           
        }
        public bool done() 
        {
            
            // add stat comparsion stuff
            if (generation >= maxGeneration)
            {
                return true;
            }
            int rise = 1;
            int run = 10;
            if (stats.Count > run)
            {
                return  stats[stats.Count-run].med-stats[stats.Count-1].med <= rise;
            }
            return false;
            
        }
        public List<Stat> evolve()
        {
            pops = new List<Population>(maxGeneration);
            generation = 0;// this is to allow debuging 
            do
            {

                reproduce();

                kull();
                pop.sort();
                pops.Add(new Population(pop));
                stats.Add(new Stat(world, pop));
                generation++;
            } while (!done());
            return stats;
        }
    }
}
