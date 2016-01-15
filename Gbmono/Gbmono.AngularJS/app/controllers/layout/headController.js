/*
   header block controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'categoryDataFactory'];

    // create controller
    module.controller('headerController', ctrl);
    // controller body
    function ctrl($scope, categoryDataFactory) {
        init();
        // page init method
        // 当该view被初始化时 需要执行的功能
        function init() {
            loadCategory();
        }

        // get products
        function loadCategory() {
            categoryDataFactory.getAll()
             .success(function (data) {
                 // success callback
                 // retreive the data into local array
                 // $scope.products can be accessed from the view
                 $scope.categories = data;
             });
        }

        //$scope.categoryHover = function (category) {
        //    var childCategories = GetCategoryByParentId(category.CategoryId);

        //};

        //function GetCategoryByParentId(parentId) {
        //    var childCategoriesArray = new Array();
        //    angular.forEach($scope.categories, function (data, index, array) {
        //        var category = array[index];
        //        if (category.ParentId==parentId) {
        //            childCategoriesArray.push(category);
        //        }
                
        //    });
        //    return childCategoriesArray;
        //}


      
    }

})(angular.module('gbmono'));
