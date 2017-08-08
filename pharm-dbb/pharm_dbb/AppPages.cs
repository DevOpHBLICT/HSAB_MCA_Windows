using System;
using SQLite;

namespace SAFA
{
	public class AppPages
	{
		public AppPages ()
		{
		}

        //	[PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}

