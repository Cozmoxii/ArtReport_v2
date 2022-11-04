using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtReport_v2
{
    public class Artwork
    {

        //object properties

        //access modifiers - public / private / protected
        private string artworkName;
        private int timeSpent;
        private string notes;
        private string medium;


        //Constructor - Constructs an onject by assigning values to the properties
        public Artwork(string an, string m, int ts, string nts)
        {
            artworkName = an;
            medium = m;
            timeSpent = ts;
            notes = nts;
        }

        //methods

        public string ArtworkSummary()
        {            
            string summary = $"Name: {artworkName}\n" +
                                $"Time Spent: {timeSpent} hrs\n" +
                                $"Medium: {medium}\n"+
                                $"Notes: {notes}";
            return summary;
        }

        //getter and setter methods

        //artworkName
        public string GetArtworkName()
        {
            return artworkName;
        }

        public void SetArtworkName(string an)
        {
            artworkName = an;
        }

        //medium
        public string GetMedium()
        {
            return medium;
        }

        public void SetMedium(string m)
        {
            medium = m;
        }

        //timeSpent
        public int GetTimeSpent()
        {
            return timeSpent;
        }

        public void SetTimeSpent(int ts)
        {
            timeSpent = ts;
        }

        //notes
        public string GetNotes()
        {
            return notes;
        }

        public void SetNotes(string n)
        {
            notes = n;
        }


    }
}
