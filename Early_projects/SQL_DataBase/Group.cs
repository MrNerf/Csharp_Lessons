using System.Collections.Generic;

namespace SQL_DataBase
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }
        //can be null
        public int? Year { get; set; }
        //collection of songs fo entity
        public virtual ICollection<Song> Songs { get; set; }
    }
}
