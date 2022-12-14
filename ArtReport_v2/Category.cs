using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtReport_v2
{
    public class Category
    {
        private List<Artwork> artworks = new List<Artwork>();
        private List<Course> courses = new List<Course>();


        //a collection of catergories 

        private string category;

        public Category(string category)
        {
            this.category = category;
        }

        public Category()
        {
        }

        
        
        //methods -artwork

        //adds a new artwork to the collection
        public void AddArtwork(Artwork newArtwork)
        {
            artworks.Add(newArtwork);
        }

     

        public string AddedArtworkSummary()
        {
            return $"Category: {category}\n"+ artworks[artworks.Count - 1].ArtworkSummary();

        }

        public string ArtworkSummaries()
        {
            string artworkSumm = "";

            foreach (Artwork artwork in artworks)
            {
                artworkSumm += AddedArtworkSummary() + "\n------------------------\n";
            }

            return artworkSumm;

        }


        public int CountArtworks()
        {
            int artworksCount = 0;

            foreach (Artwork artwork in artworks)
            {
                artworksCount += 1;
            }

            return artworksCount;

        }

        public int CalculateArtHours()
        {
            int totalhrs = 0;

            foreach (Artwork artwork in artworks)
            {
                totalhrs += artwork.GetTimeSpent();
            }

            return totalhrs;
        }

        //methods- Courses

        public void AddCourse(Course newCourse)
        {
            courses.Add(newCourse);
        }


        public int CalculateCourseHours()
        {
            int totalhrs = 0;

            foreach (Course course in courses)
            {
                totalhrs += course.GetTimeSpent();
            }

            return totalhrs;
        }

        public string AddedCourseSummary()
        {
            return $"Category: {category}\n" + courses[courses.Count - 1].CourseSummary();

        }


        public string CourseSummaries()
        {
            string courseSumm = "";

            foreach (Course course in courses)
            {
                courseSumm += AddedCourseSummary()+ "\n------------------------\n";
            }

            return courseSumm;
           
        }

        public int CountCourses()
        {
            int courseCount = 0;

            foreach (Course course in courses)
            {
                courseCount += 1;
            }

            return courseCount;

        }

       
        public float CalculateOverallPercent()
        {
            float overallPercent = 0;

            foreach (Course course in courses)
            {
                overallPercent += course.GetPercentDone();
            }

            return overallPercent;
        }



        //getters and setters

        public string GetCategory()
        {
            return category;
        }


    }
}
