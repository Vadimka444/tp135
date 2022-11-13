using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Serialization
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Group { get; set; }
        public int BirthYear { get; set; }
        public Session Subject { get; set; }
        public Student() { }
        public Student(int id, string name, int group, int birthYear, Session subject)
        {
            Id = id;
            Name = name;
            Group = group;
            BirthYear = birthYear;
            Subject = subject;
        }



        public class Session
        {           
            public string Subject { get; set; }
            public string Teather { get; set; }
            public int Mark { get; set; }
            public Session() { }
            public Session(string subject, string teather, int mark)
            {
                Subject = subject;
                Teather = teather;
                Mark = mark;
            }

        }
    }

    public class JsonHandler<T> where T : class
    {
        private string NameFile;
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };


        public JsonHandler() { }

        public JsonHandler(string NameFile)
        {
            this.NameFile = NameFile;
        }


        public void SetFileName(string NameFile)
        {
            this.NameFile = NameFile;
        }

        public void Write(List<T> list)
        {
            string jsonString = JsonSerializer.Serialize(list, options);

            if (new FileInfo(NameFile).Length == 0)
            {
                File.WriteAllText(NameFile, jsonString);
            }
            else
            {
                Console.WriteLine("Указанный путь к файлу не пустой");
            }
        }

        public void Delete()
        {
            File.WriteAllText(NameFile, string.Empty);
        }

        public void Rewrite(List<T> list)
        {
            string jsonString = JsonSerializer.Serialize(list, options);

            File.WriteAllText(NameFile, jsonString);
        }

        public void Read(ref List<T> list)
        {
            if (File.Exists(NameFile))
            {
                if (new FileInfo(NameFile).Length != 0)
                {
                    string jsonString = File.ReadAllText(NameFile);
                    list = JsonSerializer.Deserialize<List<T>>(jsonString);
                }
                else
                {
                    Console.WriteLine("Указанный путь к файлу не пустой");
                }
            }
        }

        public void OutputJsonContents()
        {
            string jsonString = File.ReadAllText(NameFile);

            Console.WriteLine(jsonString);
        }

        public void OutputSerializedList(List<T> list)
        {
            Console.WriteLine(JsonSerializer.Serialize(list, options));
        }
    }

   public class Program
    {
        static void Main(string[] args)
        {
            List<Student> partsList = new List<Student>();

            JsonHandler<Student> partsHandler = new JsonHandler<Student>("FileStudents.json");

            partsList.Add(new Student(100, "Vadim Korneev", 135, 2004, new Student.Session("Mathematics", "Thsiporkova K.A.", 4)));
            partsList.Add(new Student(101, "Nikita Sacharov", 135, 2003, new Student.Session("Mathematics", "Thsiporkova K.A.", 5)));
            partsList.Add(new Student(102, "Ivan Koltsov", 135, 2003, new Student.Session("History", "Boyarchenkov V.V", 4)));
            partsList.Add(new Student(103, "Sergey Shandala", 135, 2003, new Student.Session("Physics", "Inyakov V.V", 5)));
            partsList.Add(new Student(104, "Vladimir Zhiltsov", 135, 2003, new Student.Session("TIPS", "Miheev A.A.", 3)));

            partsHandler.Rewrite(partsList);
            partsHandler.OutputJsonContents();
        }
    }
}

/* output:
[
  {
    "Id": 100,
    "Name": "Vadim Korneev",
    "Group": 135,
    "BirthYear": 2004,
    "Subject": {
      "Subject": "Mathematics",
      "Teather": "Thsiporkova K.A.",
      "Mark": 4
    }
  },
  {
    "Id": 101,
    "Name": "Nikita Sacharov",
    "Group": 135,
    "BirthYear": 2003,
    "Subject": {
        "Subject": "Mathematics",
      "Teather": "Thsiporkova K.A.",
      "Mark": 5
    }
},
  {
    "Id": 102,
    "Name": "Ivan Koltsov",
    "Group": 135,
    "BirthYear": 2003,
    "Subject": {
        "Subject": "History",
      "Teather": "Boyarchenkov V.V",
      "Mark": 4
    }
},
  {
    "Id": 103,
    "Name": "Sergey Shandala",
    "Group": 135,
    "BirthYear": 2003,
    "Subject": {
        "Subject": "Physics",
      "Teather": "Inyakov V.V",
      "Mark": 5
    }
},
  {
    "Id": 104,
    "Name": "Vladimir Zhiltsov",
    "Group": 135,
    "BirthYear": 2003,
    "Subject": {
        "Subject": "TIPS",
      "Teather": "Miheev A.A.",
      "Mark": 3
    }
}
]*/