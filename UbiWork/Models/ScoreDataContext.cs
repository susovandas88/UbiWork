using System;
using System.Data.Entity;

namespace UbiWork.Models
{
    public class ScoreDataContext: DbContext
    {
        public ScoreDataContext():base("ScoreDataContext")
        {

        }

        public DbSet<ScoreData> ScoreDatas { get; set; }
    }
}
