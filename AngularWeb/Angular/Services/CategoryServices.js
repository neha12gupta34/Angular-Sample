angular.module('AngularApp').service("CategoryServices", [
    '$http', '$q', '$location',
    function ($http, $q, $location) {

        var _categories = [];
        var _articles = [];
        var _getCategories = function () {
            var deferred = $q.defer();

            $http.get("http://localhost:3165/Irestangularservice.svc/GetCategoryList")
            .then(function (result) {
                //success
                angular.copy(result.data, _categories);
                _isInit = true;
                deferred.resolve();
            },
            function () {
                deferred.reject();
            });
            return deferred.promise;
        };

        var _getArticles = function () {
            var deferred = $q.defer();

            $http.get("http://localhost:3165/Irestangularservice.svc/GetArticleList")
            .then(function (result) {
                //success
                angular.copy(result.data, _articles);
                _isInit = true;
                deferred.resolve();
            },
            function () {
                deferred.reject();
            });
            return deferred.promise;
        };


        return {
            categoryList: _getCategories,
            category: _categories,
            articleList: _getArticles,
            articles: _articles
        }
    }]);