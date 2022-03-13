using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpoSoft.Domain.Entities
{
    public class HistoricalScore : Score
    {
        public HistoricalScore() { }
        public HistoricalScore(float increaseFactor, float nationalSales, float competitiveFactor, float exportIntention, float activityPerception, float internationalExperience, float futureExperience, float managerProfile, float totalScore, DateTime starDate, DateTime endDate) : base(increaseFactor, nationalSales, competitiveFactor, exportIntention, activityPerception, internationalExperience, futureExperience, managerProfile, totalScore, starDate, endDate)
        {
        }
    }
}
