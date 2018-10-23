using MyFeeds.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewsFeed.Models
{
    public class DataBaseInitializer: DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            IList<Source> sources = new List<Source> {
                    new Source
                    {
                        Origin ="Td Mas",
                        Address ="Sabana, Costa Rica",
                        Description = "Entertainment",
                        ImageName ="TDMAS.png"
                    },
                    new Source
                    {
                        Origin ="Teletica",
                        Address ="Sabana, Costa Rica",
                        Description = "News",
                        ImageName ="Teletica.png"
                    },
                    new Source
                    {
                        Origin ="Repretel",
                        Address ="Uruca, Costa Rica",
                        Description = "News",
                        ImageName ="Repretel.png"
                    },
            };

            context.Sources.AddRange(sources);

            context.SaveChanges();

            IList<Content> contents = new List<Content> {

                    new Content
                    {
                        Display ="Good team that of sub 20, with 6 legionaries. The future",
                        SourceId = 1,
                        Title = "National Team",
                        Date = new DateTime(2018,10,18),
                        ImageName = "Tdmas1.png"
                    },
                    new Content
                    {
                        Display ="With that Cristiano Watch you can pay the country's foreign debt",
                        SourceId = 1,
                        Title = "Luxury Watch",
                        Date = new DateTime(2018,10,18),
                        ImageName = "Tdmas2.jpg"
                    },
                    new Content
                    {
                        Display ="The referees in Saprissa overprotects Saprissa players",
                        SourceId = 1,
                        Title = "The phrase of the day is by José Miguel Cubero",
                        Date = new DateTime(2018,10,18),
                        ImageName = "Tdmas3.png"
                    },

                         new Content
                    {
                        Display ="On October 31, 2008, the bitcoin, the first decentralized virtual currency, was born with a clearly political intention. Ten years later, this cryptocurrency feeds a complex ecosystem but remains unconvincing in the upper echelons of the economy.",
                        SourceId = 2,
                        Title = "The bitcoin, the largest of cryptocurrencies, turns ten",
                        Date = new DateTime(2018,10,18),
                        ImageName = "Teletica1.jpg"
                    },
                    new Content
                    {
                        Display ="The longest sea bridge in the world built by China measures 55 km, consumed more than one million cubic meters of cement and is capable of withstanding an earthquake of magnitude 8.",
                        SourceId = 2,
                        Title = "The longest bridge in the world",
                        Date = new DateTime(2018,10,18),
                        ImageName = "Teletica2.jpg"
                    },
                 
                         new Content
                    {
                        Display ="The authorities of the states of the Pacific coast of Mexico are preparing for the arrival of Hurricane Willa with large-scale evacuations, the strengthening of its infrastructure and administrative measures such as the suspension of classes in schools, reported RT Noticias.",
                        SourceId = 3,
                        Title = "Thousands of Mexicans are evacuated before the threat of Hurricane Willa",
                        Date = new DateTime(2018,10,18),
                        ImageName = "Repretel1.jpg"
                    },
                    new Content
                    {
                        Display ="We spend all the time connected to our cell phones without noticing that there are certain habits we perform throughout the day that would be reducing the life of your batteries. While there are many myths about what is good and what is not for smartphones, here we will clarify three customs that definitely damage them",
                        SourceId = 3,
                        Title = "The three habits that most damage the cell phone battery",
                        Date = new DateTime(2018,10,18),
                         ImageName = "Repretel2.jpg"
                    },
                    new Content
                    {
                        Display ="In this exquisite recipe you can vary the vegetables or even use another type of cut of beef as jerky or chicken pieces. We know that we all have a flavor that makes us unique, for Lizano no matter what that recipe is, we ticos have a unique flavor and that, we do not change it for anything! To eat with Lizano, how we like it, how it has to be!",
                        SourceId = 3,
                        Title = "Learn how to prepare an irresistible meat in Lizano Sauce",
                        Date = new DateTime(2018,10,18),
                        ImageName = "Repretel3.jpg"
                    }
            };

            context.Contents.AddRange(contents);

            base.Seed(context);
        }
    }
}