var app = angular.module('AngularApp', ['ngRoute', 'angular.filter'], function ($controllerProvider, $compileProvider, $provide) {
    //providers = {
    //    $controllerProvider: $controllerProvider,
    //    $compileProvider: $compileProvider,
    //    $provide: $provide
    //};
});

//Register Angular configurations
app.config(function ($routeProvider) {
    var siteUrl = window.location.protocol + "//" + window.location.host;
    $routeProvider.when("/Category/:CategoryId", {
        controller: "CategoryController",
        templateUrl: siteUrl + "/Angular/Views/CategoryView.html"
    });
    
    $routeProvider.when("/Article/:Id", {
        controller: "CategoryController",
        templateUrl: siteUrl + "/Angular/Views/ArticleView.html"
    });

    $routeProvider.when("/Category", {
        controller: "CategoryController",
        templateUrl: siteUrl + "/Angular/Views/CategoryView.html"
    });
    var defaultView = "/Category";
    //By default angular view configuration
    //In this case, by default redirect to Landing Contracts
    $routeProvider.otherwise({ redirectTo: defaultView });
}).run(function ($rootScope) {

    $rootScope
        .$on('$routeChangeStart',
            function (event, toState, toParams, fromState, fromParams) {
                console.log("State Change: transition begins!");
            });

    $rootScope
        .$on('$routeChangeSuccess',
            function (event, toState, toParams, fromState, fromParams) {
                console.log("State Change: State change success!");
                //if (ajaxCount <= 0) {
                //    hidePageLoader();
                //}
            });

    $rootScope
        .$on('$routeChangeError',
            function (event, toState, toParams, fromState, fromParams) {
                console.log("State Change: Error!");

            });

    $rootScope
        .$on('$routeNotFound',
            function (event, toState, toParams, fromState, fromParams) {
                console.log("State Change: State not found!");

            });

    $rootScope
        .$on('$viewContentLoading',
            function (event, viewConfig) {
                console.log("View Load: the view is loaded, and DOM rendered!");
            });

    $rootScope
        .$on('$viewContentLoaded',
            function (event, viewConfig) {
                console.log("View Load: the view is loaded, and DOM rendered!");
            });

});