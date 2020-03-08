using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using K_PBL_test1.Data;


namespace K_PBL_test1.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AcceptableContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AcceptableContext>>()))
            {
                // Look for any movies.
                if (context.Centers.Any())
                {
                    return;   // DB has been seeded
                }

                context.Centers.AddRange(
                    new Center
                    {
                        Name = "手術室",
                    },

                    new Center
                    {
                        Name = "麻酔科",
                    },

                    new Center
                    {
                        Name = "脳外科",
                    },

                    new Center
                    {
                        Name = "心外",
                    }
                );
                context.AcceptableLevels.AddRange(
                    new AcceptableLevel
                    {
                        Name = "即対応",
                    },
                    new AcceptableLevel
                    {
                        Name = "2H以内",
                    },
                    new AcceptableLevel
                    {
                        Name = "本日中",
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
