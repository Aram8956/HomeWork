/*Ստեղծել, Course, Group, Module կլասները
Course - ինֆորմացիա է պարունակում դասընթացի մասին
(անուն,  ամսավճար, մոդուլներ)
Module - ինֆորմացիա է պարունակում դասընթացի առանձին կտորի մասին
(վերնագիր, տևողություն)
Group - Ներկայացնում է խմբի տվյլաները
(անուն, ուսանողների քանակ, կուրս)
Course կլասից ժառանգվում են Web, Game, AI  կլասները
ընդ որում Web-ը ունի նաև type դաշտ, որը կարող է լինել frontend, backend, fullstack
Game-ը ունի engine դաշտ, որը կարող է լինել unity, unreal:
Course,Module և Group, Course կապը has a է, իսկ Course=>Web,Game,Ai -ը is a:
namespace Class;*/

class Program
{
    static void Main(string[] args)
    {
        Course[] courses = new Course[]
        {
            new Web("Frontend Development", 500000, new Module[] 
            { 
                new Module("HTML & CSS", 2), new Module("JavaScript", 3) 
            }
            ,"frontend"),
            new Web("Fullstack Development", 60000, new Module[] 
            { 
                new Module("Node.js", 4), new Module("React", 5) 
            }, "fullstack"),
            new AI("Machine Learning", 80000, new Module[] 
            { 
                new Module("Python for AI", 6), new Module("Deep Learning", 8) 
            }),
            new Game("Game Development", 72000, new Module[] 
            { 
                new Module("C# for Unity", 5), new Module("Physics in Games", 4) 
            }, "Unity"),
            new Game("Game Dev Advanced", 42000, new Module[] 
            { 
                new Module("Blueprints", 6), new Module("C++ for Unreal", 7) 
            }, "Unreal")
        };
        Group[] groups = new Group[]
        {
            new Group("Frontend Group 1", 15, courses[0]),   // Frontend Development
            new Group("Fullstack Group 1", 12, courses[1]),  // Fullstack Development
            new Group("AI Group 1", 10, courses[2]),         // Machine Learning
            new Group("Game Dev Group 1", 20, courses[3]),   // Unity Game Development
            new Group("Game Dev Group 2", 18, courses[4])    // Unreal Game Development
        };

        int web = 0;
        int monthlyUnreal = 0;
        Group mostpopular = groups[0];
        Course mostpopularCourse = mostpopular.course;
        for (int i = 0; i < courses.Length; i++)
        {
            if (courses[i] is Web)
            {
                ++web;
            }

            if (courses[i] is Game && courses[i].name.Contains("Unreal"))
            {
                monthlyUnreal += courses[i].month;
            }
        }

        for (int i = 0; i < groups.Length; i++)
        {
            if (mostpopular.quantity < groups[i].quantity)
            {
                mostpopular = groups[i];
                mostpopularCourse = mostpopular.course;
            }
        }
    }
}
