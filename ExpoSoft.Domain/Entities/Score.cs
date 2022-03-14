using ExpoSoft.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpoSoft.Domain.Entities
{
    public abstract class Score : Entity<int>, IAggregateRoot
    {
        public float IncreaseFactor { get; private set; }
        public float NationalSales { get; private set; }
        public float CompetitiveFactor { get; private set; }
        public float ExportIntention { get; private set; }
        public float ActivityPerception { get; private set; }
        public float InternationalExperience { get; private set; }
        public float FutureExperience { get; private set; }
        public float ManagerProfile { get; private set; }
        public float TotalScore { get; private set; }
        public DateTime StarDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public Score() { }
        protected Score(float increaseFactor, float nationalSales, float competitiveFactor, float exportIntention, float activityPerception, float internationalExperience, float futureExperience, float managerProfile, float totalScore, DateTime starDate, DateTime endDate)
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
            StarDate = starDate;
            EndDate = endDate;
        }
    }
}
