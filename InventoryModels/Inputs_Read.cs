using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using InventoryModels;

namespace InventoryModels
{
    public class Inputs_Read
    {
        private SimulationSystem system;

        public Inputs_Read()
        {
            system = new SimulationSystem();
        }

        public SimulationSystem Read_fromFile()
        {
            FileStream fs = new FileStream("TestCase1.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string w = ""; int prev_max = 0; decimal Cum_Prob = 0;
            string [] spliter = new string[2];

            while ((w = sr.ReadLine()) != null)
            {
                if (w == "") continue;

                if (w == "OrderUpTo")
                    system.OrderUpTo = int.Parse(sr.ReadLine());
                else if (w == "ReviewPeriod")
                    system.ReviewPeriod = int.Parse(sr.ReadLine());
                else if (w == "StartInventoryQuantity")
                    system.StartInventoryQuantity = int.Parse(sr.ReadLine());
                else if (w == "StartLeadDays")
                    system.StartLeadDays = int.Parse(sr.ReadLine());
                else if (w == "StartOrderQuantity")
                    system.StartOrderQuantity = int.Parse(sr.ReadLine());
                else if (w == "NumberOfDays")
                    system.NumberOfDays = int.Parse(sr.ReadLine());
                else if (w == "DemandDistribution")
                {
                    Cum_Prob = 0; prev_max = 0;
                    while ((w = sr.ReadLine()) != "")
                    {
                        spliter = w.Split(',');
                        
                        Distribution dist = new Distribution();

                        dist.Value = int.Parse(spliter[0]);
                        dist.Probability = decimal.Parse(spliter[1]);
                        Cum_Prob = (decimal)(Cum_Prob + dist.Probability);
                        dist.CummProbability = (decimal)(Cum_Prob);
                        dist.MinRange = prev_max + 1;
                        dist.MaxRange = (int)(dist.CummProbability * 100);
                        prev_max = dist.MaxRange;

                        system.DemandDistribution.Add(dist);
                    }
                }
                else if (w == "LeadDaysDistribution")
                {
                    Cum_Prob = 0; prev_max = 0;
                    while ((w = sr.ReadLine()) != null)
                    {
                        spliter = w.Split(',');
                        Distribution dist = new Distribution();

                        dist.Value = int.Parse(spliter[0]);
                        dist.Probability = decimal.Parse(spliter[1]);
                        Cum_Prob = (decimal)(Cum_Prob + dist.Probability);
                        dist.CummProbability = (decimal)(Cum_Prob);
                        dist.MinRange = prev_max + 1;
                        dist.MaxRange = (int)(dist.CummProbability * 100);
                        prev_max = dist.MaxRange;

                        system.LeadDaysDistribution.Add(dist);
                    }
                }
            }

            sr.Close();
            fs.Close();
            return system;
        }
    }
}
