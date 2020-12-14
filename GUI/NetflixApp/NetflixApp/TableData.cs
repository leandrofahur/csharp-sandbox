using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace NetflixApp
{
    class TableData
    {
        // read only auto property:
        public ulong Id
        {
            get;
            set;
        }

        // read-write auto property:
        public string Type
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public DateTime Date
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }
        // Constructor:
        public TableData(ulong id, string type, string title, DateTime date, int year)
        {
            Id = id;
            Type = type;
            Title = title;
            Date = date;
            Year = year;
        }
        // Overload toString according to the exhibit table in listbox:
        public override string ToString()
        {
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
            return string.Format("{0,-10}\t| {1,-10}\t| {2,-50}\t| {3,-10}\t| {4,-10}", Id, Type, Title, Date.ToString("dd-MMM-yyyy", CultureInfo.CreateSpecificCulture("en-US")), Year);
        }


    }
}
