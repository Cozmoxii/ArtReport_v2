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

        public int CalculateArtHours()
        {
            int totalhrs = 0;

            foreach (Artwork artwork in artworks)
            {
                totalhrs += artwork.GetTimeSpent();
            }

            return totalhrs;
        }

        public string AddedArtworkSummary()
        {
            return "---Artwork---\n"+$"Category: {category}\n"+ artworks[artworks.Count - 1].ArtworkSummary();

        }

        public string AddedCourseSummary()
        {

            return "----Course----\n" + $"Category: {category}\n" + courses[courses.Count - 1].CourseSummary();

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
        

        public int CountCourses()
        {
            int courseCount = 0;

            foreach (Course course in courses)
            {
                courseCount += 1;
            }

            return courseCount;

        }

       

        //----------

        public float CalculateOverallPercent()
        {
            float overallPercent = 1;

            foreach (Course course in courses)
            {

                overallPercent *= course.GetPercentDone();
            }

            return overallPercent / 100;
        }

        public string ProgressSummary()
        {
            string summary = $"Overall Course Percentage ={CalculateOverallPercent()}%\n"+
                                $"Total Hours Spent on Courses = {CalculateCourseHours()} hrs\n" +
                                $"Total Hours Spent on Artworks = {CalculateArtHours()} hrs\n" +
                                $"Total Hours Overall = {CalculateArtHours()+CalculateCourseHours()} hrs";

            return summary;
        }

        public int CalculateOverallHours()
        {
            int overallHours = CalculateArtHours() + CalculateCourseHours();

            return overallHours;
        }




        //getters and setters

        public string GetCategory()
        {
            return category;
        }
    }
}
