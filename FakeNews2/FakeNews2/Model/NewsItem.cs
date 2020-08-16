using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNews2.Model
{
    public class NewsItem
    {
        public int Id {get; set;}
        public string Category {get; set;}
        public string Headline {get; set;}
        public string Subhead { get; set; }
        public string Dateline { get; set; }
        public string Image { get; set; }

        public static List<NewsItem> getNewsItems() 
        {
                var items = new List<NewsItem>();
                items.Add(new NewsItem() { Id = 1,
                    Category = "Financial",
                    Headline = "Lorem Ipsum",
                    Subhead = "doro sit amet",
                    Dateline = "Nunc tristique nec",
                    Image = "Assets/Financiall.png" });
                items.Add(new NewsItem() { Id = 2,
                    Category = "Financial",
                    Headline = "Etiam ac fells viverra",
                    Subhead = "vulputate nisl ac, aliquet nisi",
                    Dateline = "tortor porttitor, eu fermentum ante tongue",
                    Image = "Assets/Financia12.png" });
                items.Add(new NewsItem() { Id = 3, Category = "Financial",
                    Headline = "Integer sed turpis erat",
                    Subhead = "Sed quis hendrerit lorem, quis interdum dolor",
                    Dateline = "in viverra metus facilisis sed",
                    Image = "Assets/Financia13.png" });
                items.Add(new NewsItem() { Id = 4, Category = "Financial",
                    Headline = "Proin sem neque",
                    Subhead = "aliquet quis ipsum tincidunt",
                    Dateline = "Integer eleifend",
                    Image = "Assets/Financial4.png" });
                items.Add(new NewsItem()
                {
                    Id = 5,
                    Category = "Financial",
                    Headline = "Mauris bibendum non leo vitae tempor",
                    Subhead = "In nisi tortor, eleifend sed ipsum eget",
                    Dateline = "Curabitur dictum augue vitae elementum ultrices",
                    Image = "Assets/Financial5.png"
                });
                items.Add(new NewsItem() 
                { 
                    Id = 6, 
                    Category = "Food",
                    Headline = "Lorem ipsum",
                    Subhead = "dolor sit amet", 
                    Dateline = "Nunc tristique nec", 
                    Image = "Assets/Foodl.png" }); 
                items.Add(new NewsItem() 
                { Id = 7, 
                    Category = "Food", 
                    Headline = "Etiam ac fells viverra", 
                    Subhead = "vulputate nisi ac, aliquet nisi",
                    Dateline = "tortor porttitor, eu fermentum ante congue", 
                    Image = "Assets/Food2.png" }); 
                items.Add(new NewsItem() 
                { Id = 8, 
                    Category = "Food",
                    Headline = "Integer sed turpis erat", 
                    Subhead = "Sed quis hendrerit lorem, quis interdum dolor", 
                    Dateline = "in viverra metus facilisis sed", 
                    Image = "Assets/Food3.png" }); 
                items.Add(new NewsItem() 
                { Id = 9, Category = "Food", 
                    Headline = "Proin sem neque", 
                    Subhead = "aliquet quis ipsum tincidunt",
                    Dateline = "Integer eleifend", 
                    Image = "Assets/Food4.png" }); 
                items.Add(new NewsItem() 
                { Id = 10, 
                    Category = "Food", 
                    Headline = "Mauris bibendum non leo vitae tempor",
                    Subhead = "In nisl tortor, eleifend sed ipsum eget",
                    Dateline = "Curabitur dictum augue vitae elementum ultrices", 
                    Image = "Assets/Food5.png" });

                return items;          
        }
    }
        public class NewsManager : NewsItem
        { 
                public static void GetNews(string category, ObservableCollection<NewsItem> newsltems)
                {

                 var allItems = getNewsItems();

                 var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();

                 newsltems.Clear(); 
            
                 filteredNewsItems.ForEach(p => newsltems.Add(p));

                }
        
        }


}
