using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    QuestionText = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    FirstVariant = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    SecondVariant = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ThirdVariant = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    FourthVariant = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    RightAnswer = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "FirstVariant", "FourthVariant", "QuestionText", "RightAnswer", "SecondVariant", "ThirdVariant" },
                values: new object[,]
                {
                    { new Guid("c3ff65e4-49bd-4b7d-bfe5-448add9d5b33"), "Humanity", "Household", "In the UK, the abbreviation NHS stands for National what Service?", "Health", "Health", "Honour" },
                    { new Guid("dfff40e2-823c-41d1-82a8-92866beb6b3e"), "Pocahontas", "Elsa", "Which Disney character famously leaves a glass slipper behind at a royal ball?", "Cinderella", "Sleeping Beauty", "Cinderella" },
                    { new Guid("c248f691-14d0-4903-b0de-680f935a5786"), "Hangar", "Carousel", "What name is given to the revolving belt machinery in an airport that delivers checked luggage from the plane to baggage reclaim?", "Carousel", "Terminal", "Concourse" },
                    { new Guid("fa994cdd-d023-46d2-bfa9-f03f51ab3ddc"), "Phillips", "Ronseal", "Which of these brands was chiefly associated with the manufacture of household locks?", "Chubb", "Flymo", "Chubb" },
                    { new Guid("146d12b7-f4b1-46d1-b76f-35d911e425e1"), "Republicanism", "Liberalism", "The hammer and sickle is one of the most recognisable symbols of which political ideology?", "Communism", "Communism", "Conservatism" },
                    { new Guid("5f27960d-282e-4c92-8975-b685b1ca5191"), "Bratz Dolls", "Transformers", "Which toys have been marketed with the phrase “robots in disguise”?", "Transformers", "Sylvanian Families", "Hatchimals" },
                    { new Guid("43465c18-8e29-40c2-8369-e24b6590b002"), "Angry", "Shy", "What does the word loquacious mean?", "Chatty", "Chatty", "Beautiful" },
                    { new Guid("4f45024b-45bd-48bf-a943-ae431bb38d2c"), "Childbirth", "Old age", "Obstetrics is a branch of medicine particularly concerned with what?", "Childbirth", "Broken bones", "Heart conditions" },
                    { new Guid("1f0fa010-fee2-4dcc-a1c8-e64ded001485"), "Bow-tie, braces and tweed jacket", "Cape, velvet jacket and frilly shirt", "In Doctor Who, what was the signature look of the fourth Doctor, as portrayed by Tom Baker?", "Wide-brimmed hat and extra long scarf", "Wide-brimmed hat and extra long scarf", "Pinstripe suit and trainers" },
                    { new Guid("10be75e0-90c9-4d2f-8cc9-d0548fa7a9dd"), "Ramadan", "Hanukkah", "Which of these religious observances lasts for the shortest period of time during the calendar year?", "Diwali", "Diwali", "Lent" },
                    { new Guid("341ad7a0-cfd2-4004-a42b-b1e785ab2830"), "Bahamas", "Bermuda", "At the closest point, which island group is only 50 miles south-east of the coast of Florida?", "Bahamas", "US Virgin Islands", "Turks and Caicos Islands" },
                    { new Guid("5bc53373-f15c-4cc7-8491-5b0f50faf502"), "Empire State Building", "Big Ben Clock Tower", " Construction of which of these famous landmarks was completed first?", "Big Ben Clock Tower", "Royal Albert Hall", "Eiffel Tower" },
                    { new Guid("4276dce0-dc74-49e1-9f60-87172952c0d7"), "Gray whale", "Humpback whale", "Which of these cetaceans is classified as a “toothed whale”?", "Sperm whale", "Minke whale", "Sperm whale" },
                    { new Guid("6ac3f615-295b-4903-90f6-3338b52b6db1"), "David Lloyd George", "John Major", "Who is the only British politician to have held all four “Great Offices of State” at some point during their career?", "James Callaghan", "Harold Wilson", "James Callaghan" },
                    { new Guid("51b51dd3-bad6-43aa-95a8-9c967f163b10"), "Calico Jack", "Captain Kidd", "In 1718, which pirate died in battle off the coast of what is now North Carolina?", "Blackbeard", "Blackbeard", "Bartholomew Roberts" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
