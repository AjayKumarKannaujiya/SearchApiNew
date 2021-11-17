var mymodule = angular.module('app', []);
mymodule.controller("mycontroller", function ($scope, $http) {
    GetData();

    function GetData() {
        $http({
            method: 'GET',
            url: 'api/Values/Index',
        }).then(function (result) {
            // $scope.loading = false;
            $scope.StoreData = result.data;
        })
    }

    $scope.search = function () {
        var searchtext = {
            Text: $scope.text,
            Price: $scope.price
        };
        if (searchtext.Text != "undefined" && searchtext.Text != "") {

            $http({
                method: 'POST',
                url: 'api/values/search',
                data: searchtext,
            }).then(function (result) {
                $scope.StoreData = result.data;
                $scope.text = null;
            })
        } else if (searchtext.Price != "undefined" && searchtext.Price != "") {
            
            $http({
                method: 'POST',
                url: 'api/values/search',
                data: searchtext,
            }).then(function (result) {
                $scope.StoreData = result.data;
                searchtext.Price = null;
            })
        }

    }


})