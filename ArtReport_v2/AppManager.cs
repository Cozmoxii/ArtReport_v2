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

        private string goal;

        public AppManager()
        {
            LoadCategories();

            goal = "";

            foreach (string category in Categories)
            {
                categories.Add(new Category(category));
            }
        }

        //methods


        public void SetGoal(string goal)
        {
            this.goal = goal;
        }

        public string GetGoal()
        {
            return goal;
        }

        public List<Category> GetCategories()
        {
            return categories;
        }


        public void AddArtwork(string categorySearch, Artwork newArtwork)
        {
            categories[FindIndexOfCat(categorySearch)].AddArtwork(newArtwork);
        }


        public void AddCourse(string categorySearch, Course newCourse)
        {
            categories[FindIndexOfCat(categorySearch)].AddCourse(newCourse);
        }

        //adds the category to the course summary
        public string AddedCourseSummary(string categorySearch)
        {
            return categories[FindIndexOfCat(categorySearch)].AddedCourseSummary();
        }

        //adds the category to the artwork summary
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



        //calculated the total hours spent on courses
        public int CourseHours()
        {
            int coursehours = 0;

            foreach (Category category in categories)
            {
                coursehours += category.CalculateCourseHours();
            }

            return coursehours;
        }

        //calculated the total hours spent on art
        public int ArtHours()
        {
            int arthours = 0;

            foreach (Category category in categories)
            {
                arthours += category.CalculateArtHours();
            }

            return arthours;
        }

        //counts the number of added artworks
        public int CountArtworks()
        {
            int artworkCount = 0;

            foreach (Category category in categories)
            {
                artworkCount += category.CountArtworks();
            }

            return artworkCount;
        }

        //counts the number of added courses
        public int CountCourses()
        {
            int courseCount = 0;

            foreach (Category category in categories)
            {
                courseCount += category.CountCourses();
            }

            return courseCount;
        }

        //puts all my course summaries into a string to be used in my see all form
        public string FinalCourseSummaries()
        {
            string courseSumm = "";

            if (CountCourses()>0)
            {
                courseSumm += "------------------------\n";

                foreach (Category category in categories)
                {
                    courseSumm += category.CourseSummaries();
                }
            }

            return courseSumm;
        }

        //calculated the average percentage completed across all categories
        public float OverallPercentage()
        {
            float overallPercentage = 0;

            if (CountCourses()>0)
            {
                foreach (Category category in categories)
                {
                    overallPercentage += category.CalculateOverallPercent();
                }

                return (float)Math.Round(overallPercentage / CountCourses(),2);
            }

            return 0;
        }

        //returns string summary with all calculated values
        public string Summary()
        {
            string summary = "-----------SUMMARY------------" +
                "\n\nTotal Hours = " + (ArtHours()+CourseHours())+" hrs"+
                "\nHours Spent on Artworks = "+ ArtHours()+
                 "\nHours Spent on Courses = " + CourseHours() +
                 "\nAverage Percentage Completed = "+ OverallPercentage()+"%"+
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

        //puts all my total hours per category into a list for my graph
        public List<int> CatListHours()
        {
            List<int> catHours = new List<int>();

            foreach (Category category in categories)
	        {

                if (category.CalculateArtHours() + category.CalculateCourseHours() > 0)
                {
                    catHours.Add(category.CalculateArtHours() + category.CalculateCourseHours()); 
                }
                
	        }

            return catHours;
        }

        //puts all my category names into a list to use in my graph
        public List<string> CategoryNames()
        {
            List<string> catNames = new List<string>();

            foreach (Category category in categories)
            {
                if (category.CalculateArtHours() + category.CalculateCourseHours() > 0)
                {
                    catNames.Add(category.GetCategory());
                }

            }

            return catNames;
        }

        //putting all my artwork summaries in a string

        public string FinalArtworkSummaries()
        {

            string artSumm = "";
            if (CountArtworks() > 0)
            {
                artSumm += "------------------------\n";

                foreach (Category category in categories)
                {
                    artSumm += category.ArtworkSummaries();
                }

            }

            return artSumm;

        }


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
