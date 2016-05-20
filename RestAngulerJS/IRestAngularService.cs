using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestAngulerJS
{
    [ServiceContract]
    public interface IRestAngularService
    {
        [OperationContract]
        //[WebGet(ResponseFormat = WebMessageFormat.Json)]
        [WebInvoke(Method = "GET",
                ResponseFormat = WebMessageFormat.Json)]
        List<Article> GetArticleList();

        [OperationContract]
        [WebGet(UriTemplate = "Article/{id}")]
        Article GetArticleByArticleId(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetCategoryList",
                ResponseFormat = WebMessageFormat.Json)]
        List<Category> GetCategoryList();

    }

    [DataContract]
    public class Article
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string ImageUrl { get; set; }
        [DataMember]
        public string Body { get; set; }
        [DataMember]
        public DateTime DatePublished { get; set; }
        [DataMember]
        public int CategoryId { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
    }
    [DataContract]
    public class Category
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
