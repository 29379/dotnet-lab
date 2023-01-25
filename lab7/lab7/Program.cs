using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace lab7
{
    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Department(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{Id,2}), {Name,11}";
        }
    }

    public enum Gender
    {
        Female,
        Male
    }

    public class StudentWithTopics
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public bool Active { get; set; }
        public int DepartmentId { get; set; }

        public List<string> Topics { get; set; }
        
        public StudentWithTopics(int id, int index, string name, Gender gender, bool active,
            int departmentId, List<string> topics)
        {
            this.Id = id;
            this.Index = index;
            this.Name = name;
            this.Gender = gender;
            this.Active = active;
            this.DepartmentId = departmentId;
            this.Topics = topics;
        }

        public override string ToString()
        {
            var result = $"{Id,2}) {Index,5}, {Name,11}, {Gender,6},{(Active ? "active" : "no active"),9},{DepartmentId,2}, topics: ";
            foreach (var str in Topics)
                result += str + ", ";
            return result;
        }
    }

    public static class Generator
    {
        public static int[] GenerateIntsEasy()
        {
            return new int[] { 5, 3, 9, 7, 1, 2, 6, 7, 8 };
        }

        public static int[] GenerateIntsMany()
        {
            var result = new int[10000];
            Random random = new Random();
            for (int i = 0; i < result.Length; i++)
                result[i] = random.Next(1000);
            return result;
        }

        public static List<string> GenerateNamesEasy()
        {
            return new List<string>() {
                "Nowak",
                "Kowalski",
                "Schmidt",
                "Newman",
                "Bandingo",
                "Miniwiliger"
            };
        }
        
        public static List<StudentWithTopics> GenerateStudentsWithTopicsEasy()
        {
            return new List<StudentWithTopics>() {
            new StudentWithTopics(1,12345,"Nowak", Gender.Female,true,1,
                    new List<string>{"C#","PHP","algorithms"}),
            new StudentWithTopics(2, 13235, "Kowalski", Gender.Male, true,1,
                    new List<string>{"C#","C++","fuzzy logic"}),
            new StudentWithTopics(3, 13444, "Schmidt", Gender.Male, false,2,
                    new List<string>{"Basic","Java"}),
            new StudentWithTopics(4, 14000, "Newman", Gender.Female, false,3,
                    new List<string>{"JavaScript","neural networks"}),
            new StudentWithTopics(5, 14001, "Bandingo", Gender.Male, true,3,
                    new List<string>{"Java","C#"}),
            new StudentWithTopics(6, 14100, "Miniwiliger", Gender.Male, true,2,
                    new List<string>{"algorithms","web programming"}),
            new StudentWithTopics(11,22345,"Nowak", Gender.Female,true,2,
                    new List<string>{"C#","PHP","algorithms"}),
            new StudentWithTopics(12, 23235, "Nowak", Gender.Male, true,1,
                    new List<string>{"C#","C++","fuzzy logic"}),
            new StudentWithTopics(13, 23444, "Schmidt", Gender.Male, false,1,
                    new List<string>{"Basic","Java"}),
            new StudentWithTopics(14, 24000, "Newman", Gender.Female, false,1,
                    new List<string>{"JavaScript","neural networks"}),
            new StudentWithTopics(15, 24001, "Bandingo", Gender.Male, true,3,
                    new List<string>{"Java","C#"}),
            new StudentWithTopics(16, 24100, "Bandingo", Gender.Male, true,2,
                    new List<string>{"algorithms","web programming"}),
            };
        }

        public static List<Department> GenerateDepartmentsEasy()
        {
            return new List<Department>() {
            new Department(1,"Computer Science"),
            new Department(2,"Electronics"),
            new Department(3,"Mathematics"),
            new Department(4,"Mechanics")
            };
        }
    }

    //  ----------------------------------------------------------
    //  MY CLASSES
    class Topic
    {
        public int id { private set; get; }
        public string name { private set; get; }

        public Topic(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{id} - {name}";
        }

        public void rename(string name)
        {
            this.name = name;
        }
    }
    class Student
    {
        public int id { get; set; }
        public int index { get; set; }
        public string name { get; set; }
        public Gender gender { get; set; }
        public bool active { get; set; }
        public int departmentId { get; set; }
        public List<int> topics { get; set; }

        public Student(int id, int index, string name, Gender gender, bool active,
            int departmentId, List<int> topics)
        {
            this.id = id;
            this.index = index;
            this.name = name;
            this.gender = gender;
            this.active = active;
            this.departmentId = departmentId;
            this.topics = topics;
        }
        public override string ToString()
        {
            var output = $"{id,2})" +
                $" {index,5}," +
                $" {name,11}," +
                $" {gender,6}," +
                $"{(active ? "active" : "no active"),9}" +
                $",{departmentId,2}," +
                $" topics: ";
            foreach (var str in topics)
                output += str + ", ";
            return output;
        }
    }
    //  -------------------------------------------------------------

    class Program
    {
        //  --------------------------------------------------------
        //  ZAD 1

        static List<StudentWithTopics> OrderBySurname(List<StudentWithTopics> students)
        {
            return students
                .OrderBy(s => s.Name)
                .ThenBy(s => s.Index)
                .ToList();
        }
        
        static IEnumerable<IGrouping<int, StudentWithTopics>> GroupStudents(int n)
        {
            var id = 0;
            return from s in Generator.GenerateStudentsWithTopicsEasy()
                   orderby s.Name, s.Index
                   group s by id++ / n;
        }

        static void Zad1(int n)
        {
            Console.WriteLine("------------------------ ZAD 1 ------------------------\n");
            foreach (var group in GroupStudents(n))
            {
                group.ToList().ForEach(s => Console.WriteLine(s));
                Console.WriteLine("\n                         * * *\n");
            }
        }

        //  --------------------------------------------------------
        //  ZAD 2

        static List<string> OrderByTopicPopularity(List<StudentWithTopics> students)
        {
            return (
                from student in students.SelectMany(s => s.Topics)
                group student by student into grp
                orderby grp.Count() descending
                select grp.Key)
                .ToList();
        }

        static List<StudentWithTopics> DivideByGender(List<StudentWithTopics> students, Gender gender)
        {
            return students.Where(s => s.Gender == gender).ToList();
        }

        static void Zad2()
        {
            List<StudentWithTopics> students = Generator.GenerateStudentsWithTopicsEasy();
            List<StudentWithTopics> males = DivideByGender(students, Gender.Male);
            List<StudentWithTopics> females = DivideByGender(students, Gender.Female);

            Console.WriteLine("------------------------ ZAD 2 ------------------------\n");

            foreach (var elem in OrderByTopicPopularity(students)){
                Console.WriteLine(elem);
            }
            Console.WriteLine("\n                         Males");
            foreach (var elem in OrderByTopicPopularity(males))
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("\n                       Females");
            foreach (var elem in OrderByTopicPopularity(females))
            {
                Console.WriteLine(elem);
            }



            var newApproach = students
                .GroupBy(s => s.Gender)
                .Select(group => new {
                    Gender = group.Key,
                    Topics = group.SelectMany(elem => elem.Topics)
                            .GroupBy(t => t)
                            .Select(group => group.Key)
                            .OrderBy(g => g)
                }).ToList();
            Console.WriteLine("\n                     New approach");
            foreach (var elem in newApproach)
            {
                Console.WriteLine($"\n                         {elem.Gender}");
                foreach (var topic in elem.Topics.ToList())
                {
                    Console.Write($"{topic}\n");
                }
            }

        }

        //  --------------------------------------------------------
        //  ZAD 3
        static IEnumerable<Topic> GetAllTopics(List<StudentWithTopics> studentsWithTopic)
        {
            return (
                from topic in studentsWithTopic.SelectMany(s => s.Topics)
                group topic by topic into g
                select g.Key)
                .Select((tStr, position) => new Topic(position, tStr));
        }

        static IEnumerable<int> TopicToId(List<string> topicNames, IEnumerable<Topic> topics)
        {
            return topicNames
                .SelectMany(tStr => topics.Where(tT => tT.name == tStr))
                .Select(t => t.id);
        }

        static List<Student> FromStudentWithTopic(List<StudentWithTopics> studentsWithTopic, List<Topic> topics)
        {
            return studentsWithTopic
                .Select(s => new Student(s.Id, s.Index, s.Name, s.Gender, s.Active, s.DepartmentId,
                TopicToId(s.Topics, topics).ToList()))
                .ToList();
        }

        static void Zad3()
        {
            Console.WriteLine("\n------------------------ ZAD 3 ------------------------\n");

            var topicsByHand = new List<Topic>() {
                new Topic(1,"C#"),
                new Topic(2,"C++"),
                new Topic(3,"Java"),
                new Topic(4,"PHP"),
                new Topic(5,"algorithms"),
                new Topic(6,"fuzzy logic"),
                new Topic(7,"Basic"),
                new Topic(8,"JavaScript"),
                new Topic(9,"neural networks"),
                new Topic(10,"web programming")
            };
            List<StudentWithTopics> studentsWithTopic = Generator.GenerateStudentsWithTopicsEasy();
            foreach (var elem in studentsWithTopic)
            {
                Console.WriteLine(elem);
            }

            List<Student> toStudentByHand = FromStudentWithTopic(studentsWithTopic, topicsByHand);

            List<Topic> topics = GetAllTopics(studentsWithTopic).ToList();
            List<Student> toStudentByQuery = FromStudentWithTopic(studentsWithTopic, topics);

            Console.WriteLine("\n                         * * *\n");
            foreach (var elem in topics)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("\n                 Topics created by hand\n");
            foreach (var elem in toStudentByHand)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("\n               Topics created with query\n");
            foreach (var elem in toStudentByQuery)
            {
                Console.WriteLine(elem);
            }
        }

        //  --------------------------------------------------------
        //  ZAD 4

        static void Zad4()
        {   
            Console.WriteLine("\n------------------------ ZAD 4 ------------------------\n");

            //Topic topic = new Topic(19, "Physics");
            //Type type1 = typeof(Topic);
            Type type1 = Type.GetType("lab7.Topic");

            ConstructorInfo cInfo = type1.GetConstructor(new[] { typeof(int), typeof(string) });

            Object topic = cInfo.Invoke(new object[] { 1, "Topic created with the invoke method" });
            Console.WriteLine($"Before: {topic}");

            MethodInfo info1 = topic.GetType().GetMethod("rename", new Type[] { typeof(string) });
            info1.Invoke(topic, new object[] { "Maths" });
            Console.WriteLine($"After: {topic}");

            Console.WriteLine("\n                         * * *\n");

            List<int> list = new() { 1, 2, 3, 4 };
            Console.Write("Before: ");
            foreach(var elem in list)
            {
                Console.Write($"{elem} - ");
            }
            MethodInfo info2 = list.GetType().GetMethod("RemoveAt", new Type[] { typeof(int) });
            info2.Invoke(list, new object[] { 2 });
            Console.Write("\nAfter: ");
            foreach (var elem in list)
            {
                Console.Write($"{elem} - ");
            }
        }

        //  --------------------------------------------------------
        static void Main(string[] args)
        {
            Zad1(5);
            Zad2();
            Zad3();
            Zad4();
        }
    }

}
