using DataAccesLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer
{
    public class DataContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DataContext()
        {
        }
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Question>().HasData(new Question[]{
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "In the UK, the abbreviation NHS stands for National what Service?",
                    FirstVariant = "Humanity",
                    SecondVariant = "Health",
                    ThirdVariant = "Honour",
                    FourthVariant = "Household",
                    RightAnswer = "Health"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "Which Disney character famously leaves a glass slipper behind at a royal ball?",
                    FirstVariant = "Pocahontas",
                    SecondVariant = "Sleeping Beauty",
                    ThirdVariant = "Cinderella",
                    FourthVariant = "Elsa",
                    RightAnswer = "Cinderella"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "What name is given to the revolving belt machinery in an airport that delivers checked luggage from the plane to baggage reclaim?",
                    FirstVariant = "Hangar",
                    SecondVariant = "Terminal",
                    ThirdVariant = "Concourse",
                    FourthVariant = "Carousel",
                    RightAnswer = "Carousel"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "Which of these brands was chiefly associated with the manufacture of household locks?",
                    FirstVariant = "Phillips",
                    SecondVariant = "Flymo",
                    ThirdVariant = "Chubb",
                    FourthVariant = "Ronseal",
                    RightAnswer = "Chubb"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "The hammer and sickle is one of the most recognisable symbols of which political ideology?",
                    FirstVariant = "Republicanism",
                    SecondVariant = "Communism",
                    ThirdVariant = "Conservatism",
                    FourthVariant = "Liberalism",
                    RightAnswer = "Communism"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "Which toys have been marketed with the phrase “robots in disguise”?",
                    FirstVariant = "Bratz Dolls",
                    SecondVariant = "Sylvanian Families",
                    ThirdVariant = "Hatchimals",
                    FourthVariant = "Transformers",
                    RightAnswer = "Transformers"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "What does the word loquacious mean?",
                    FirstVariant = "Angry",
                    SecondVariant = "Chatty",
                    ThirdVariant = "Beautiful",
                    FourthVariant = "Shy",
                    RightAnswer = "Chatty"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "Obstetrics is a branch of medicine particularly concerned with what?",
                    FirstVariant = "Childbirth",
                    SecondVariant = "Broken bones",
                    ThirdVariant = "Heart conditions",
                    FourthVariant = "Old age",
                    RightAnswer = "Childbirth"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "In Doctor Who, what was the signature look of the fourth Doctor, as portrayed by Tom Baker?",
                    FirstVariant = "Bow-tie, braces and tweed jacket",
                    SecondVariant = "Wide-brimmed hat and extra long scarf",
                    ThirdVariant = "Pinstripe suit and trainers",
                    FourthVariant = "Cape, velvet jacket and frilly shirt",
                    RightAnswer = "Wide-brimmed hat and extra long scarf"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "Which of these religious observances lasts for the shortest period of time during the calendar year?",
                    FirstVariant = "Ramadan",
                    SecondVariant = "Diwali",
                    ThirdVariant = "Lent",
                    FourthVariant = "Hanukkah",
                    RightAnswer = "Diwali"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "At the closest point, which island group is only 50 miles south-east of the coast of Florida?",
                    FirstVariant = "Bahamas",
                    SecondVariant = "US Virgin Islands",
                    ThirdVariant = "Turks and Caicos Islands",
                    FourthVariant = "Bermuda",
                    RightAnswer = "Bahamas"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = " Construction of which of these famous landmarks was completed first?",
                    FirstVariant = "Empire State Building",
                    SecondVariant = "Royal Albert Hall",
                    ThirdVariant = "Eiffel Tower",
                    FourthVariant = "Big Ben Clock Tower",
                    RightAnswer = "Big Ben Clock Tower"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "Which of these cetaceans is classified as a “toothed whale”?",
                    FirstVariant = "Gray whale",
                    SecondVariant = "Minke whale",
                    ThirdVariant = "Sperm whale",
                    FourthVariant = "Humpback whale",
                    RightAnswer = "Sperm whale"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "Who is the only British politician to have held all four “Great Offices of State” at some point during their career?",
                    FirstVariant = "David Lloyd George",
                    SecondVariant = "Harold Wilson",
                    ThirdVariant = "James Callaghan",
                    FourthVariant = "John Major",
                    RightAnswer = "James Callaghan"
                },
                new Question
                {
                    Id = System.Guid.NewGuid(),
                    QuestionText = "In 1718, which pirate died in battle off the coast of what is now North Carolina?",
                    FirstVariant = "Calico Jack",
                    SecondVariant = "Blackbeard",
                    ThirdVariant = "Bartholomew Roberts",
                    FourthVariant = "Captain Kidd",
                    RightAnswer = "Blackbeard"
                },
            });
        }
    }
}
