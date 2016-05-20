angular.module('AngularApp').controller('CategoryController', [
    '$scope', '$location', '$window', '$routeParams', '$compile', 'CategoryServices',
    function ($scope, $location, $window, $routeParams, $compile, CategoryServices) {
        $scope.gautam = "Kadian";
        var articleId = 0;
        var categoryId = 0;
        

        $scope.showDetail = function (u) {
            if ($scope.active != u) {
                $scope.active = u;
            }
            else {
                $scope.active = null;
            }
        };

        $scope.changeView = function (view) {
            $location.path(view);
        }

        //$scope.category = [{ Id: 1, Name: "Maruti" }, { Id: 2, Name: "Hyundai" }, { Id: 3, Name: "volkswagen" }];

        //$scope.articles = [{ Id: 1, Title: "Swift", CategoryId: 1, "CategoryName": "Maruti", "Image": "https://images0.cardekho.com/images/car-images/520x216/Maruti/Maruti-Swift/047.jpg" },

        //{ Id: 3, Title: "Baleno", CategoryId: 1, "CategoryName": "Maruti", "Image": "https://images0.cardekho.com/images/car-images/large/Maruti/Maruti-Baleno/ray-blue.jpg" },
        // { Id: 2, Title: "Polo", CategoryId: 3, "CategoryName": "volkswagen", "Image": "http://images.carandbike.com/car-images/big/volkswagen/polo-gt/volkswagen-polo-gt.jpg?v=3" },
        // { Id: 7, Title: "Vento", CategoryId: 3, "CategoryName": "volkswagen", "Image": "http://www.carroya.com/web/images/vehiculos/1583864/1583864_1_w.jpg.do" },
        //{ Id: 5, Title: "Verna", CategoryId: 2, "CategoryName": "Hyundai", "Image": "http://i.ndtvimg.com/i/2015-02/new-hyundai-verna-main-2_678x352_81423893464.jpg" },
        // { Id: 6, Title: "I20", CategoryId: 2, "CategoryName": "Hyundai", "Image": "http://images.indianexpress.com/2015/06/hyundai-elite-l.jpg" },
        //{ Id: 4, Title: "S-Cross", CategoryId: 1, "CategoryName": "Maruti", "Image": "http://images.indianexpress.com/2015/07/maruti-suzuki-s-cross759.jpg" },
        //];


        CategoryServices.articleList()
        .then(function (result) {
            $scope.articles = CategoryServices.articles;
            if ($routeParams && $routeParams.Id) {
                articleId = $routeParams.Id;
                var articleId = $routeParams.Id;
                $scope.selectedArticle = jLinq.from($scope.articles).equals("Id", parseInt(articleId)).select()[0];
                $scope.selectedCategory = $scope.selectedArticle.CategoryId;
                $scope.selectedCateogoryArticle = jLinq.from($scope.articles).equals("CategoryId", parseInt($scope.selectedCategory)).select();
            }
            if ($routeParams && $routeParams.CategoryId) {
                categoryId = $routeParams.CategoryId;
                $scope.categoryArticles = jLinq.from($scope.articles).equals("CategoryId", parseInt(categoryId)).select();
            }
            else {
                $scope.categoryArticles = $scope.articles;
            }
        },
        function () {
        })
        .then(function () {
        });


        CategoryServices.categoryList()
        .then(function (result) {
            $scope.category = CategoryServices.category;
            
        },
        function () {
        })
        .then(function () {
        });


        

        
    }]);