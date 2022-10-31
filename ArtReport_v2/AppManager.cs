using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtReport_v2
{
    public class AppManager
    {
        private List<Category> categories = new List<Category>();
        private List<string> Categories = new List<string>();


        public AppManager()
        {
            LoadCategories();

            foreach (string category in Categories)
            {
                categories.Add(new Category(category));
            }
        }


        //methods

        //Artwork
        public void AddArtwork(string categorySearch, Artwork newArtwork)
        {
            categories[FindIndexOfCat(categorySearch)].AddArtwork(newArtwork);
        }



        //course
        public void AddCourse(string categorySearch, Course newCourse)
        {
            categories[FindIndexOfCat(categorySearch)].AddCourse(newCourse);
        }

        public string AddedCourseSummary(string categorySearch)
        {
            return categories[FindIndexOfCat(categorySearch)].AddedCourseSummary();
        }

        public string AddedArtworkSummary(string categorySearch)
        {
            return categories[FindIndexOfCat(categorySearch)].AddedArtworkSummary();
        }


        public int FindIndexOfCat(string categorySearch)
        {
            int index = 0;

            foreach (Category category in categories)
            {
                if (category.GetCategory().Equals(categorySearch))
                {
                    return index;
                }

                index++;
            }

            return -1;

        }


        //adds the total course hours to the total art hours to find a total

        //public int TotalHours()
        //{
        //    int totalhours = 0;
        //    foreach (Category category in categories)
        //    {
        //        totalhours += category.CalculateCourseHours() + category.CalculateArtHours();
        //    }

        //    return totalhours;
        //}


        //summary methods

        public int CourseHours()
        {
            int coursehours = 0;

            foreach (Category category in categories)
            {
                coursehours += category.CalculateCourseHours();
            }

            return coursehours;
        }

        public int ArtHours()
        {
            int arthours = 0;

            foreach (Category category in categories)
            {
                arthours += category.CalculateArtHours();
            }

            return arthours;
        }


        public int CountArtworks()
        {
            int artworkCount = 0;

            foreach (Category category in categories)
            {
                artworkCount += category.CountArtworks();
            }

            return artworkCount;
        }

        public int CountCourses()
        {
            int courseCount = 0;

            foreach (Category category in categories)
            {
                courseCount += category.CountCourses();
            }

            return courseCount;
        }

        public float OverallPercentage()
        {
            float overallPercentage = 1;

            foreach (Category category in categories)
            {

                overallPercentage *= category.CalculateOverallPercent()*100; 
            }

            return overallPercentage;
        }

        public string Summary()
        {
            string summary = "Total Hours = " + (ArtHours()+CourseHours())+" hrs"+
                "\nHours Spent on Artworks = "+ ArtHours()+
                 "\nHours Spent on Courses = " + CourseHours() +
                 "\nCourse Percentage Completed ="+ OverallPercentage()+
                "\n\nNumber of Artworks Added = " +CountArtworks()+
                "\nNumber of Courses Added = "+CountCourses();

            return summary;
        }



        //search for specified category and return it's overall percentage
        public float CatOverallPercent(string categorySearch)
        {
            foreach (Category category in categories)
            {
                if (category.GetCategory().Equals(categorySearch))
                {
                    return category.CalculateOverallPercent();
                }
            }

            return -1f;
        }


        //search for specified category and returns the number of hours

        //returns number of categories that are in the text file 

        public int CountCategories()
        {
            return categories.Count();
        }

        public string GetCategory(int categoryIndex)
        {
            return categories[categoryIndex].GetCategory();
        }


        //loads in my categories from the text file so they can be used within my program

        public void LoadCategories()
        {
            string line;

            StreamReader sr = new StreamReader("Categories.txt");

            line = sr.ReadLine();

            Console.WriteLine(line);

            String[] category = line.Split(',');

            for (int i = 0; i < category.Length; i++)
            {
                Categories.Add(category[i]);
            }

        }


        
    }
}
