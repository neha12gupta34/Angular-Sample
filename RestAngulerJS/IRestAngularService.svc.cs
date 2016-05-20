using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace RestAngulerJS
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
                 ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestAngularService : IRestAngularService
    {
        public List<Article> GetArticleList()
        {
            List<Article> articles = new List<Article>();
            articles.Add(new Article
            {
                Id = 1,
                Title = "Swift",
                ImageUrl = "https://images0.cardekho.com/images/car-images/520x216/Maruti/Maruti-Swift/047.jpg",
                Body = "Maruti cars",
                DatePublished = DateTime.Today.AddMonths(-1),
                CategoryId = 1,
                CategoryName = "Maruti"
            });
            articles.Add(new Article
            {
                Id = 2,
                Title = "Baleno",
                ImageUrl = "https://images0.cardekho.com/images/car-images/large/Maruti/Maruti-Baleno/ray-blue.jpg",
                Body = "Baleno cars",
                DatePublished = DateTime.Today.AddMonths(1),
                CategoryId = 1,
                CategoryName = "Maruti"
            });
            articles.Add(new Article
            {
                Id = 3,
                Title = "Polo",
                ImageUrl = "http://images.carandbike.com/car-images/big/volkswagen/polo-gt/volkswagen-polo-gt.jpg?v=3",
                Body = "VolksWagen cars",
                DatePublished = DateTime.Today.AddMonths(-1),
                CategoryId = 2,
                CategoryName = "VolksWagen"
            });
            articles.Add(new Article
            {
                Id = 4,
                Title = "Vento",
                ImageUrl = "http://www.carroya.com/web/images/vehiculos/1583864/1583864_1_w.jpg.do",
                Body = "Vento Company 1",
                DatePublished = DateTime.Today,
                CategoryId = 2,
                CategoryName = "VolksWagen"
            });
            articles.Add(new Article
            {
                Id = 5,
                Title = "Verna",
                ImageUrl = "http://i.ndtvimg.com/i/2015-02/new-hyundai-verna-main-2_678x352_81423893464.jpg",
                Body = "Verna Company 2",
                DatePublished = DateTime.Today,
                CategoryId = 3,
                CategoryName = "Hyundai"
            });

            articles.Add(new Article
            {
                Id = 6,
                Title = "I20",
                ImageUrl = "http://images.indianexpress.com/2015/06/hyundai-elite-l.jpg",
                Body = "I20 1",
                DatePublished = DateTime.Today,
                CategoryId = 3,
                CategoryName = "Hyundai"
            });
            articles.Add(new Article
            {
                Id = 4,
                Title = "S-Cross",
                ImageUrl = "http://images.indianexpress.com/2015/07/maruti-suzuki-s-cross759.jpg",
                Body = "SpareParts 2",
                DatePublished = DateTime.Today,
                  CategoryId = 1,
                CategoryName = "Maruti"
            });
            return articles;
        }

        public Article GetArticleByArticleId(string id)
        {
            List<Article> lstArticles = GetArticleList();
            var articleInformation = lstArticles.Where(x => x.Id == Convert.ToInt32(id)).FirstOrDefault();
            articleInformation.CategoryName = GetCategoryItem(articleInformation.CategoryId).Name;
            return articleInformation;
        }

        public List<Category> GetCategoryList()
        {
            List<Category> category = new List<Category>();
            category.Add(new Category
            {
                Id = 1,
                Name = "Maruti"
            });
            category.Add(new Category
            {
                Id = 2,
                Name = "VolksWagen"
            });
            category.Add(new Category
            {
                Id = 3,
                Name = "Hyundai"
            });
            return category;
        }

        public Category GetCategoryItem(int categoryId)
        {
            List<Category> category = GetCategoryList();
            return category.Where(x => x.Id == categoryId).FirstOrDefault();
        }
    }
}
