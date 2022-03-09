using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpoSoft.Domain.Entities
{
    public class HistoricalScore : Score
    {
        private DateTime StarDate { get; set; }
        private DateTime EndDate { get; set; }

        public  HistoricalScore(DateTime starDate, DateTime endDate, float increaseFactor, float nationalSales, float competitiveFactor, float exportIntention, float activityPerception, float internationalExperience, float futureExperience, float managerProfile, float totalScore): base(increaseFactor, nationalSales, competitiveFactor, exportIntention, activityPerception, internationalExperience, futureExperience, managerProfile, totalScore)
        {
            StarDate = starDate;
            EndDate = endDate;
        }
    }
}
