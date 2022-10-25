using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    internal class Bee
    {
        bool isMin;
        double[,] population;
        int food;
        int iteration;
        int limit;
        int D;
        int[] trail;
        double[] probability;
        double[] OptimumSol;
        Random rand;
        int ub = 1;
        int lb = -1;
        private Func<double, double> my_delegate;

        public Bee(int low, int high, bool isMin, Func<double,double> function)
        {
            this.isMin = isMin;
            food = 10;
            D = 1;
            population = new double[food, D + 1];
            iteration = 500;
            limit = food * D / 2;
            trail = new int[food];
            probability = new double[food];
            OptimumSol = new double[D + 1];
            rand = new Random();
            ub = high;
            lb = low;
            my_delegate = function;
            generateSolution();
        }

        public void generateSolution()
        {
            for (int i = 0; i < food; i++)
            {
                initSol(i);
                trail[i] = 0;
                // evaluate new solution and save it
                // Evaluate solution
                double[] row = fetchRow(i);
                population[i, D] = Evaluate(row);
            }
        }

        public void Search()
        {
            SaveOptimumSol(0);
            SelectOptimumSolution();
            for (int iter = 0; iter < iteration; iter++)
            {
                WorkerBee();
                findProbability();
                LookerBee();
                SelectOptimumSolution();
                ScouterBee();
            }
        }

        public void LookerBee()
        {
            int i, t;
            i = 0;
            t = 0;
            /*onlooker Bee Phase*/
            while (t < food)
            {

                double r = rand.NextDouble();
                for (int k = 0; k < food; k++)
                {
                    if (r < probability[k])
                    {
                        i = k;
                        break;
                    }
                }
                
                t++;
                //--------------------------

                int neighbor = rand.Next(food);
                while (neighbor == i)
                {
                    neighbor = rand.Next(food);
                }
                // detect current sol and new sol
                double[] newRowSolution = LocalSearch(i, neighbor);
                if (this.isMin)
                {
                    if (newRowSolution[D] < population[i, D])
                    {
                        replaceRow(newRowSolution, i);
                        trail[i] = 0;
                    }
                    else
                    {
                        trail[i] += 1;
                    }
                }
                else
                {
                    if (newRowSolution[D] > population[i, D])
                    {
                        replaceRow(newRowSolution, i);
                        trail[i] = 0;
                    }
                    else
                    {
                        trail[i] += 1;
                    }
                }
                
                
                
            }/*while*/

            /*end of onlooker bee phase     */
        }

        public void WorkerBee()
        {
            /*start of employed bee phase*/
            for (int i = 0; i < food; i++)
            {
                int neighbor = rand.Next(food);
                while (neighbor == i)
                {
                    neighbor = rand.Next(food);
                }
                // detect current sol and new sol
                double[] newRowSolution = LocalSearch(i, neighbor);
                if (this.isMin)
                {
                    if (newRowSolution[D] < population[i, D])
                    {
                        replaceRow(newRowSolution, i);
                        trail[i] = 0;
                    }
                    else
                    {
                        trail[i] += 1;
                    }
                }
                else
                {
                    if (newRowSolution[D] > population[i, D])
                    {
                        replaceRow(newRowSolution, i);
                        trail[i] = 0;
                    }
                    else
                    {
                        trail[i] += 1;
                    }
                }
                
            }
            /*end of employed bee phase*/
        }

        public void replaceRow(double[] sol, int idx)
        {
            for (int j = 0; j < D + 1; j++)
            {
                population[idx, j] = sol[j];
            }
        }

        public double[] LocalSearch(int currentIDX, int neighbor)
        {
            double[] newSol = new double[D + 1];
            for (int i = 0; i < D; i++)
            {
                double randomNumber = lb + rand.NextDouble() * (ub - lb);
                newSol[i] = randomNumber; //* (population[currentIDX, i] - population[neighbor, i]);
            }
            // Evaluate solution
            newSol[D] = Evaluate(newSol);
            return newSol;
        }

        public void ScouterBee()
        {
            for (int i = 0; i < food; i++)
            {
                if (trail[i] >= limit)
                {
                    initSol(i);
                    trail[i] = 0;
                    // evaluate new solution and save it
                    // Evaluate solution
                    double[] row = fetchRow(i);
                    population[i, D] = Evaluate(row);
                }
            }
        }

        public double[] fetchRow(int idx)
        {
            double[] row = new double[D + 1];
            for (int j = 0; j < D + 1; j++)
            {
                row[j] = population[idx, j];
            }
            return row;
        }

        public void initSol(int idx)
        {
            for (int i = 0; i < D; i++)
            {
                population[idx, i] = lb + rand.NextDouble() * (ub - lb);
            }
        }

        public void SelectOptimumSolution()
        {
            double minFx = population[0, D];
            int minIndex = 0;
            if (this.isMin)
            {
                if (minFx < OptimumSol[D])
                    SaveOptimumSol(minIndex);
                for (int i = 1; i < food; i++)
                {
                    if (population[i, D] < minFx)
                    {
                        minFx = population[i, D];
                        minIndex = i;
                        if (minFx < OptimumSol[D])
                            SaveOptimumSol(minIndex);
                    }
                }
            }
            else
            {
                if (minFx > OptimumSol[D])
                    SaveOptimumSol(minIndex);
                for (int i = 1; i < food; i++)
                {
                    if (population[i, D] > minFx)
                    {
                        minFx = population[i, D];
                        minIndex = i;
                        if (minFx > OptimumSol[D])
                            SaveOptimumSol(minIndex);
                    }
                }
            }
            
        }

        public void SaveOptimumSol(int idx)
        {
            for (int i = 0; i < D + 1; i++)
            {
                OptimumSol[i] = population[idx, i];
            }
        }

        public void findProbability()
        {
            double sumFX = 0.0;
            for (int i = 0; i < food; i++)
            {
                sumFX += population[i, D];
            }
            probability[0] = population[0, D] / sumFX;
            for (int i = 1; i < food; i++)
            {
                probability[i] = probability[i - 1] + population[i, D] / sumFX;
            }
        }

        public double[] getBestsol()
        {
            return OptimumSol;
        }

        public double Evaluate(double[] sol)
        {
            double result = 0.0;
            for (int i = 0; i < D; i++)
            {
                result += my_delegate(sol[i]);
            }
            return result;
        }

        public double Fx(double value)
        {
            return value * value;
        }
    }
}
