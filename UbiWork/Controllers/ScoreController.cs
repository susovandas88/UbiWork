using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using UbiWork.Authentation;
using UbiWork.Models;

namespace UbiWork.Controllers
{
    [BasicAuth]
    public class ScoreController : ApiController
    {
        public async Task<IEnumerable<ScoreData>> Get()
        {
            using (var ctx = new ScoreDataContext())
            {
                List<ScoreData> scores = await
                    (from p in ctx.ScoreDatas
                     orderby p.ScoreId
                     select p).ToListAsync();
                return scores;
            }
        }


        public async Task<int> Post(List<ScoreData> scoreDatalist)
        {
            using (var ctx = new ScoreDataContext())
            {
                ctx.ScoreDatas.AddRange(scoreDatalist);
                return await ctx.SaveChangesAsync();

                
            }
        }


    }
}
