using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavoriteBandsApp.Web.Models
{
    public class BandService
    {
        static List<Band> bands = new List<Band>
        {
            new Band { Id = 1, YtPath="https://www.youtube.com/embed/qyxrzUe_TDM", ImgPath = "Ghost.jpg", Name = "Ghost", Description = "Ghost, also formerly known as Ghost B.C. in the United States, is a Swedish rock band that was formed in Linköping in 2006. In 2010, they released a three-track demo followed by a 7-inch vinyl titled \"Elizabeth\", and later their debut full-length album Opus Eponymous. The song Ritual was chosen by Kerrang! as one of \"The 50 Most Evil Songs Ever\". The Grammis-nominated album was widely praised and significantly increased their popularity. Their second album and major label debut, Infestissumam, was released in 2013, debuted at number one in Sweden, and won the Grammis Award for Best Hard Rock/Metal Album. The band released their third studio album, Meliora, in 2015 to much critical acclaim and high record sales, reaching number one in their home country of Sweden, and number eight in the United States. Its lead single, \"Cirice\", earned them the 2016 Grammy Award for Best Metal Performance. The band released their fourth studio album, Prequelle, in 2018.",
                Albums = new List<Album>
                {
                    new Album { Name = "Opus Eponymous", Label = "Rise Above", Year = 2010 },
                    new Album { Name = "Infestissumam", Label = "Loma Vista, Universal", Year = 2013 },
                    new Album { Name = "Meliora", Label = "Loma Vista, Universal", Year = 2015 },
                    new Album { Name = "Prequelle", Label = "Loma Vista", Year = 2018 }
                }
            },
            new Band { Id = 2, YtPath="https://www.youtube.com/embed/sTJ1XwGDcA4", ImgPath = "Marko.jpg", Name = "Markool & The Gang", Description = "A good group...",
                Albums = new List<Album>
                {
                    new Album { Name = "Kool and the Gang", Label = "De-Lite", Year = 1970 },
                    new Album { Name = "Forever", Label = "Mercury", Year = 1986 },
                    new Album { Name = "State of Affairs", Label = "Curb", Year = 1996 },
                    new Album { Name = "Kool for the Holidays", Label = "ATO", Year = 2013 }
                }
            },
            new Band { Id = 3, YtPath="https://www.youtube.com/embed/J7UwSVsiwzI", ImgPath = "Lo.jpg", Name = "Lo-Fi Lo 'n Crazy Cat Esther", Description = "Also a good group...",
                Albums = new List<Album>
                {
                    new Album { Name = "Ta-Miu", Label = "18th dynasty of Egypt", Year = 1549 },
                    new Album { Name = "Mačak", Label = "Nikola Tesla", Year = 1939 },
                    new Album { Name = "Oscar", Label = "Unsinkable Sam", Year = 1941 },
                    new Album { Name = "Chief Mouser Larry", Label = "10 Downing Street", Year = 2011 }
                }
            }
        };

        public Band[] GetAllBands()
        {
            return bands
                    .OrderBy(o => o.Id)
                    .ToArray();
        }

        public Band GetBandById(int id)
        {
            return bands.FirstOrDefault(b => b.Id == id);
        }
    }
}
