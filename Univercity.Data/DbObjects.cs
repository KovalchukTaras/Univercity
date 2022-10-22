using Univercity.Data.Models;

namespace Univercity.Data
{
    public class DbObjects
    {
        public static void Initial(AppDbContent content)
        {

            if (!content.Courses.Any())
                content.Courses.AddRange(
                    new Course { Id = 1, CourseName = "CR-01", CourseDescription = "Android Development 1.1" },
                    new Course { Id = 2, CourseName = "CR-02", CourseDescription = "Front-end development Angular) 1.1" },
                    new Course { Id = 3, CourseName = "CR-03", CourseDescription = "GO Mentoring" },
                    new Course { Id = 4, CourseName = "CR-04", CourseDescription = "Front-end development React) 1.1" },
                    new Course { Id = 5, CourseName = "CR-05", CourseDescription = "Java Spring 1.1" },
                    new Course { Id = 6, CourseName = "CR-06", CourseDescription = "Android Development" },
                    new Course { Id = 7, CourseName = "CR-07", CourseDescription = "Automation QA 2.0" },
                    new Course { Id = 8, CourseName = "CR-08", CourseDescription = "C#/.Net development" }
                    );

            if (!content.Groups.Any())
                content.Groups.AddRange(
                    new Group { Id = 1, CourseId = 1, GroupName = "SR-01" },
                    new Group { Id = 2, CourseId = 2, GroupName = "SR-02" },
                    new Group { Id = 3, CourseId = 3, GroupName = "SR-03" },
                    new Group { Id = 4, CourseId = 4, GroupName = "SR-04" },
                    new Group { Id = 5, CourseId = 5, GroupName = "SR-01" },
                    new Group { Id = 6, CourseId = 6, GroupName = "SR-02" },
                    new Group { Id = 7, CourseId = 7, GroupName = "SR-03" },
                    new Group { Id = 8, CourseId = 7, GroupName = "SR-04" },
                    new Group { Id = 9, CourseId = 8, GroupName = "SR-01" },
                    new Group { Id = 10, CourseId = 8, GroupName = "SR-02" },
                    new Group { Id = 11, CourseId = 2, GroupName = "SR-03" },
                    new Group { Id = 12, CourseId = 1, GroupName = "SR-04" },
                    new Group { Id = 13, CourseId = 4, GroupName = "SR-01" },
                    new Group { Id = 14, CourseId = 3, GroupName = "SR-02" },
                    new Group { Id = 15, CourseId = 6, GroupName = "SR-03" },
                    new Group { Id = 17, CourseId = 7, GroupName = "SR-04" },
                    new Group { Id = 18, CourseId = 4, GroupName = "SR-01" },
                    new Group { Id = 19, CourseId = 3, GroupName = "SR-02" },
                    new Group { Id = 20, CourseId = 2, GroupName = "SR-03" },
                    new Group { Id = 21, CourseId = 6, GroupName = "SR-04" },
                    new Group { Id = 22, CourseId = 5, GroupName = "SR-01" },
                    new Group { Id = 23, CourseId = 3, GroupName = "SR-02" },
                    new Group { Id = 24, CourseId = 2, GroupName = "SR-03" },
                    new Group { Id = 25, CourseId = 4, GroupName = "SR-04" },
                    new Group { Id = 26, CourseId = 5, GroupName = "SR-01" },
                    new Group { Id = 27, CourseId = 7, GroupName = "SR-02" },
                    new Group { Id = 28, CourseId = 2, GroupName = "SR-03" },
                    new Group { Id = 29, CourseId = 8, GroupName = "SR-04" }
                    );

            if (!content.Students.Any())
                content.Students.AddRange(
                    new Student { Id = 1, GroupId = 1, FirstName = "Samah", LastName = "Valdez" },
                    new Student { Id = 2, GroupId = 1, FirstName = "Korban", LastName = "Forster" },
                    new Student { Id = 3, GroupId = 1, FirstName = "Hania", LastName = "Chester" },
                    new Student { Id = 4, GroupId = 22, FirstName = "Maxime", LastName = "Bone" },
                    new Student { Id = 5, GroupId = 1, FirstName = "Dev", LastName = "Justice" },
                    new Student { Id = 6, GroupId = 1, FirstName = "Anderson", LastName = "Carver" },
                    new Student { Id = 7, GroupId = 1, FirstName = "Daisy", LastName = "Hickman" },
                    new Student { Id = 8, GroupId = 2, FirstName = "Annabella", LastName = "Garrison" },
                    new Student { Id = 9, GroupId = 3, FirstName = "Preston", LastName = "Burks" },
                    new Student { Id = 10, GroupId = 2, FirstName = "Shanna", LastName = "Erickson" },
                    new Student { Id = 11, GroupId = 2, FirstName = "Ian", LastName = "Wolfe" },
                    new Student { Id = 12, GroupId = 2, FirstName = "Norah", LastName = "Franks" },
                    new Student { Id = 13, GroupId = 5, FirstName = "Danniella", LastName = "Gould" },
                    new Student { Id = 14, GroupId = 2, FirstName = "Chelsey", LastName = "Rennie" },
                    new Student { Id = 15, GroupId = 2, FirstName = "Mica", LastName = "Schaefer" },
                    new Student { Id = 16, GroupId = 3, FirstName = "Tyler", LastName = "Nicholls" },
                    new Student { Id = 17, GroupId = 21, FirstName = "Ayra", LastName = "Moyer" },
                    new Student { Id = 18, GroupId = 3, FirstName = "Gabriela", LastName = "Stevens" },
                    new Student { Id = 19, GroupId = 3, FirstName = "Olivia-Rose", LastName = "Sears" },
                    new Student { Id = 20, GroupId = 4, FirstName = "Lula", LastName = "Hirst" },
                    new Student { Id = 21, GroupId = 4, FirstName = "Mamie", LastName = "Regan" },
                    new Student { Id = 22, GroupId = 4, FirstName = "Celeste", LastName = "Avila" },
                    new Student { Id = 23, GroupId = 22, FirstName = "Lynden", LastName = "Doherty" },
                    new Student { Id = 24, GroupId = 5, FirstName = "Kaleb", LastName = "Kirk" },
                    new Student { Id = 25, GroupId = 5, FirstName = "Arjun", LastName = "Oneal" },
                    new Student { Id = 26, GroupId = 6, FirstName = "Benjamin", LastName = "Vaughn" },
                    new Student { Id = 27, GroupId = 16, FirstName = "Dillon", LastName = "Lyon" },
                    new Student { Id = 28, GroupId = 6, FirstName = "Ehsan", LastName = "Lott" },
                    new Student { Id = 29, GroupId = 6, FirstName = "Seamus", LastName = "Bannister" },
                    new Student { Id = 30, GroupId = 6, FirstName = "Nikhil", LastName = "Villa" },
                    new Student { Id = 31, GroupId = 7, FirstName = "Alena", LastName = "Perry" },
                    new Student { Id = 32, GroupId = 7, FirstName = "Saba", LastName = "Pearce" },
                    new Student { Id = 33, GroupId = 3, FirstName = "Ayah", LastName = "Mcgee" },
                    new Student { Id = 34, GroupId = 7, FirstName = "Devonte", LastName = "Keeling" },
                    new Student { Id = 35, GroupId = 7, FirstName = "Klay", LastName = "Smyth" },
                    new Student { Id = 36, GroupId = 7, FirstName = "Kajol", LastName = "Woods" },
                    new Student { Id = 37, GroupId = 12, FirstName = "Landon", LastName = "Jarvis" },
                    new Student { Id = 38, GroupId = 7, FirstName = "Tyler-Jay", LastName = "Arellano" },
                    new Student { Id = 39, GroupId = 8, FirstName = "Ayoub", LastName = "Salt" },
                    new Student { Id = 40, GroupId = 8, FirstName = "Kirandeep", LastName = "Copeland" },
                    new Student { Id = 41, GroupId = 8, FirstName = "Esmai", LastName = "Hogg" },
                    new Student { Id = 42, GroupId = 18, FirstName = "Rudi", LastName = "Palmer" },
                    new Student { Id = 43, GroupId = 9, FirstName = "Suzanne", LastName = "Reynolds" },
                    new Student { Id = 44, GroupId = 9, FirstName = "Annette", LastName = "May" },
                    new Student { Id = 45, GroupId = 10, FirstName = "Isaac", LastName = "Donald" },
                    new Student { Id = 46, GroupId = 11, FirstName = "Claude", LastName = "Halliday" },
                    new Student { Id = 47, GroupId = 10, FirstName = "Padraig", LastName = "Rollins" },
                    new Student { Id = 48, GroupId = 11, FirstName = "Mikey", LastName = "Lord" },
                    new Student { Id = 49, GroupId = 10, FirstName = "Avaya", LastName = "Melia" },
                    new Student { Id = 50, GroupId = 11, FirstName = "Kate", LastName = "Murray" },
                    new Student { Id = 51, GroupId = 12, FirstName = "Yvette", LastName = "Zimmerman" },
                    new Student { Id = 52, GroupId = 12, FirstName = "Eilish", LastName = "Finnegan" },
                    new Student { Id = 53, GroupId = 15, FirstName = "Hazel", LastName = "Blevins" },
                    new Student { Id = 54, GroupId = 13, FirstName = "Josiah", LastName = "Portillo" },
                    new Student { Id = 55, GroupId = 13, FirstName = "Sabiha", LastName = "Torres" },
                    new Student { Id = 56, GroupId = 14, FirstName = "Kimberley", LastName = "Arnold" },
                    new Student { Id = 57, GroupId = 12, FirstName = "Dianne", LastName = "Moore" },
                    new Student { Id = 58, GroupId = 15, FirstName = "Stefan", LastName = "Pitts" },
                    new Student { Id = 59, GroupId = 17, FirstName = "Levison", LastName = "Baker" },
                    new Student { Id = 60, GroupId = 15, FirstName = "Usama", LastName = "Logan" },
                    new Student { Id = 61, GroupId = 15, FirstName = "Pierre", LastName = "Ferry" },
                    new Student { Id = 62, GroupId = 16, FirstName = "Lennon", LastName = "Guzman" },
                    new Student { Id = 63, GroupId = 17, FirstName = "Brielle", LastName = "Bell" },
                    new Student { Id = 64, GroupId = 1, FirstName = "Warren", LastName = "Mcneill" },
                    new Student { Id = 65, GroupId = 18, FirstName = "Jawad", LastName = "Pittman" },
                    new Student { Id = 66, GroupId = 19, FirstName = "Monique", LastName = "Whitworth" },
                    new Student { Id = 67, GroupId = 22, FirstName = "Livia", LastName = "Arias" },
                    new Student { Id = 68, GroupId = 21, FirstName = "Jago", LastName = "Duncan" },
                    new Student { Id = 69, GroupId = 23, FirstName = "Freya", LastName = "Cowan" },
                    new Student { Id = 70, GroupId = 22, FirstName = "Aadam", LastName = "Trevino" },
                    new Student { Id = 71, GroupId = 23, FirstName = "Carter", LastName = "Guerra" },
                    new Student { Id = 72, GroupId = 24, FirstName = "Pawel", LastName = "Rowley" },
                    new Student { Id = 73, GroupId = 21, FirstName = "Sheikh", LastName = "Steadman" },
                    new Student { Id = 74, GroupId = 25, FirstName = "Manon", LastName = "Krueger" },
                    new Student { Id = 75, GroupId = 25, FirstName = "Mahir", LastName = "Fletcher" },
                    new Student { Id = 76, GroupId = 1, FirstName = "Sneha", LastName = "Leigh" },
                    new Student { Id = 77, GroupId = 26, FirstName = "Emme", LastName = "Shelton" },
                    new Student { Id = 78, GroupId = 3, FirstName = "Elis", LastName = "James" },
                    new Student { Id = 79, GroupId = 26, FirstName = "Mercedes", LastName = "Cooper" },
                    new Student { Id = 80, GroupId = 27, FirstName = "Eddison", LastName = "Howells" },
                    new Student { Id = 81, GroupId = 27, FirstName = "Loren", LastName = "Potts" },
                    new Student { Id = 82, GroupId = 28, FirstName = "Roberta", LastName = "Hurley" },
                    new Student { Id = 83, GroupId = 9, FirstName = "August", LastName = "Gale" },
                    new Student { Id = 84, GroupId = 28, FirstName = "Jaeden", LastName = "Mercado" },
                    new Student { Id = 85, GroupId = 28, FirstName = "Gracie-Leigh", LastName = "Benitez" },
                    new Student { Id = 86, GroupId = 28, FirstName = "Ariana", LastName = "Prentice" }
                    );


            content.SaveChanges();
        }
    }
}

