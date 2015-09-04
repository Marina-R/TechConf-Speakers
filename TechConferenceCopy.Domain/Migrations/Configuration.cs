using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechConferenceCopy.Domain.Entities;

namespace TechConferenceCopy.Domain.Migrations
{
    internal sealed class Configuration :  DbMigrationsConfiguration<TechConferenceCopy.Domain.Context.TechContext>  
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(TechConferenceCopy.Domain.Context.TechContext context)
        {
            //  This method will be called after migrating to the latest version.  

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method   
            //  to avoid creating duplicate seed data. E.g.  
            //  
            //    context.People.AddOrUpdate(  
            //      p => p.FullName,  
            //      new Person { FullName = "Andrew Peters" },  
            //      new Person { FullName = "Brice Lambson" },  
            //      new Person { FullName = "Rowan Miller" }  
            //    );  
  
            TimeSlot slot1 = new TimeSlot() {Id=1, Time="09:00-10:00", Order=1};
            TimeSlot slot2 = new TimeSlot() {Id=2, Time="10:00-11:00", Order=2};
            TimeSlot slot3 = new TimeSlot() {Id=3, Time="11:00-12:00", Order=3};
            TimeSlot slot4 = new TimeSlot() {Id=4, Time="12:00-13:00", Order=4};
            TimeSlot slot5 = new TimeSlot() {Id=5, Time="13:00-14:00", Order=5};
            TimeSlot slotToBeDecided = new TimeSlot() {Id=6, Time="Yet to be decided", Order=6};

            context.TimeSlot.AddOrUpdate(p => p.Id, slot1);
            context.TimeSlot.AddOrUpdate(p => p.Id, slot2);
            context.TimeSlot.AddOrUpdate(p => p.Id, slot3);
            context.TimeSlot.AddOrUpdate(p => p.Id, slot4);
            context.TimeSlot.AddOrUpdate(p => p.Id, slot5);
            context.TimeSlot.AddOrUpdate(p => p.Id, slotToBeDecided);

            Track track1 = new Track() { Id = 1, TrackNumber = "1" };
            Track track2 = new Track() { Id = 2, TrackNumber = "2" };
            Track track3 = new Track() { Id = 3, TrackNumber = "3" };
            Track track4 = new Track() { Id = 4, TrackNumber = "All Tracks" };
            context.Track.AddOrUpdate(x => x.Id, track1);
            context.Track.AddOrUpdate(x => x.Id, track2);
            context.Track.AddOrUpdate(x => x.Id, track3);
            context.Track.AddOrUpdate(x => x.Id, track4);

            Speaker chander = new Speaker()
            {
                Id = 1,
                FullName = "CHANDER DHALL",
                AchievementShort = "Microsoft MVP, Tech Ed Speaker, Dev Chair - DevConnections",
                Achievements = "Microsoft MVP, Tech Ed Speaker, Asp.NET Insider, Web API Advisor, Dev Chair - DevConnections, Professional Software Architect/Lead Developer, INETA Speaker, President and CEO of Chander Dhall Inc and Organizer(MVP MIX, jsSaturday - LA, Dallas, Bulgaria, Australia)",
                Bio = "Chander Dhall is a Microsoft MVP, Tech Ed Speaker, ASP.NET Insider, Web API Advisor, Dev Chair - DevConnections professional software architect/lead developer, trainer, INETA speaker, open source contributor, community leader and organizer with years of experience in enterprise Software Development. Chander started coding since he was 6 and created his first successful software product at the age of 14. He is the President and CEO of Chander Dhall Inc and previously of Ria Consulting, LLC. He has proven track record of making clients successful and saving millions of dollars to them. He is the Dev Chair of Dev Connections and he works in a goal oriented, technologically driven, fast paced AGILE (SCRUM) environment. He is the founder of Dallas day of dot net, MVPMIX.com and jsSaturday. He has a Master's Degree in computer science with specialization in algorithms, principles and patterns and is focused on building high performing modular software. Chander leads the HTML5/Node.js group in Los Angeles and the .NET user group at UTDallas. Chander recently got recognized as 'One of the top organizers by Eventbrite.' Chander has been a featured speaker in numerous conferences and code camps all over the world.",
                Twitter = "https://twitter.com/csdhall",
                Facebook = "https://www.facebook.com/chander.dhall.9",
                PictureURL = "http://www.mvpmix.com/Content/images/speaker/ChanderDhall.png",
                Order = 1
            };

            Speaker rob = new Speaker()
            {
                Id = 2,
                FullName = "ROB EISENBERG",
                AchievementShort = "Ex-Google Angularjs team, Creator - Aurelia, Durandal, Caliburn Micro",
                Achievements = "Creator of Durandal, Member of AngularJs Core Team, JavaScript Expert, .Net Architect",
                Bio = "Rob Eisenberg is a JavaScript expert and .NET architect working out of Tallahassee, FL and he is the CTO of Durandal Inc. Rob got his start with computer programming at the age of nine, when he thoroughly fell in love with his family’s new Commodore 64. His fascination with programming started with the Commodore Basic language, then moved to Q Basic and QuickBasic and quickly continued on to C, C++, C# and JavaScript. Rob publishes technical articles regularly at www.eisenbergeffect.bluespire.com and has spoken at regional events and to companies concerning Web and .NET technologies, Agile software practices and UI engineering. He is coauthor of Sam’s Teach Yourself WPF in 24 Hours and is the creator of the Durandal and Caliburn.Micro frameworks. He’s formerly a member of the AngularJS 2.0 Core team, before leaving to return to work on Durandal and it’s next generation version: Aurelia.",
                Twitter = "https://twitter.com/eisenbergeffect",
                Facebook = "https://www.facebook.com/rob.eisenberg",
                PictureURL = "http://www.mvpmix.com/Content/images/speaker/RobEisenberg.png",
                Order = 2
            };
            context.Speaker.AddOrUpdate(x => x.Id, chander);
            context.Speaker.AddOrUpdate(x => x.Id, rob);
        }  
    }
}
