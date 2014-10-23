using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiTrainMileageCalc
{
    public partial class StationMileage
    {


        public int TrainId { get; set; }
        public string TrainName { get; set; }
        public double Mileage { get; set; }
        public int LineGroup { get; set; }
    }

    

    public class MileageCalc
    {


        public double GetCalcMileage(List<StationMileage> AllMileagesList, List<int> StationCrosses, int CurrentTrainId, int NextTrainId)
        {
            try
            {
                return GetCalcMileage(AllMileagesList, StationCrosses, 0, CurrentTrainId, NextTrainId);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        
        public double GetCalcMileage(List<StationMileage> AllMileagesList, List<int> StationCrosses,int Level, int CurrentTrainId, int NextTrainId)
        {
            try
            {
                Level = Level + 1;
                var CurrentMileagesList = AllMileagesList.Where(m => m.TrainId == CurrentTrainId).ToList();
                var NextMileagesList = AllMileagesList.Where(m => m.TrainId == NextTrainId).ToList();

                List<double> CalcMileages = new List<double>();


                //不跨線
                var NoCrossMileages = from Current in CurrentMileagesList
                           join Next in NextMileagesList
                           on Current.LineGroup equals Next.LineGroup
                           select Math.Abs(Current.Mileage - Next.Mileage);

                CalcMileages.AddRange(NoCrossMileages);
                

                if (CalcMileages.Any() == false)
                {
                    if (Level >=3 
                        || StationCrosses == null 
                        || StationCrosses.Any() == false)
                    {
                        return 0;
                    }

                    foreach (var StationCross in StationCrosses)
                    {
                        if (StationCross == CurrentTrainId || StationCross == NextTrainId)
                        {
                            continue;
                        }
                        var m1 = GetCalcMileage(AllMileagesList, StationCrosses, Level, CurrentTrainId, StationCross);
                        var m2 = GetCalcMileage(AllMileagesList, StationCrosses, Level, StationCross, NextTrainId);
                        if (m1 > 0 && m2 > 0)
                        {
                            CalcMileages.Add(m1 + m2);
                            //return CalcMileages.Min();
                        }
                    }
                }

                return CalcMileages.Min();
            }
            catch (Exception ex)
            {
                return 0;
            }


        }

    }
}
