using ExpoSoft.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpoSoft.Domain.Entities
{
    public abstract class Score : Entity<int>
    {
        private float IncreaseFactor { get; set; }
        private float NationalSales { get; set; }
        private float CompetitiveFactor { get; set; }
        private float ExportIntention { get; set; }
        private float ActivityPerception { get; set; }
        private float InternationalExperience { get; set; }
        private float FutureExperience { get; set; }
        private float ManagerProfile { get; set; }
        private float TotalScore { get; set; }
        protected Score(float increaseFactor, float nationalSales, float competitiveFactor, float exportIntention, float activityPerception, float internationalExperience, float futureExperience, float managerProfile, float totalScore)
        {
            IncreaseFactor = increaseFactor;
            NationalSales = nationalSales;
            CompetitiveFactor = competitiveFactor;
            ExportIntention = exportIntention;
            ActivityPerception = activityPerception;
            InternationalExperience = internationalExperience;
            FutureExperience = futureExperience;
            ManagerProfile = managerProfile;
            TotalScore = totalScore;
        }
    }
}
