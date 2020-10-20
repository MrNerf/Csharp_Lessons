using System;
using System.Collections.Generic;

namespace SQL_DataBase
{
    internal class Program
    {
        private static void Main()
        {

            using (var context = new DataBaseContext())
            {
                var group = new Group()
                {
                    Name = "Linking Park",
                    Year = 1996
                };
                context.Groups.Add(group);
                
                var group2 = new Group()
                {
                    Name = "Metallica"
                };

                context.Groups.Add(group2);
                context.SaveChanges();

                var songs = new List<Song>()
                {
                    new Song(){Name =  "In the end", GroupId = group.Id},
                    new Song(){Name =  "Numb", GroupId = group.Id},
                    new Song(){Name =  "Metal", GroupId = group2.Id}
                };
                context.Songs.AddRange(songs);
                context.SaveChanges();

                Console.WriteLine($"id: {group.Id}, name: {group.Name}, year: {group.Year}");
            }

            Console.ReadLine();
        }
    }
}
