
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'categoryDataFactory'];

    // create controller
    module.controller('categoriesController', ctrl);

    // controller body
    function ctrl($scope, categoryDataFactory) {
     

        // call page init function
        init();
        // page init method
        function init() {
            loadCategory();
        }

        function loadCategory() {
            categoryDataFactory.getAll()
             .success(function (data) { 
                 console.log(data);
                 // success callback
                 // retreive the data into local array
                 // $scope.products can be accessed from the view
                 $scope.allCategories = data;
             });
        }
    
    }
})(angular.module('gbmono'));