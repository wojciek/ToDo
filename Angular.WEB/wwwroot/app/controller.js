angular.module("app").controller("todoController", function ($scope, $http, $filter) {
    $scope.webPageTitle = "My Simple Todo";

    $scope.Item = {
        Title: ''
    };

    $scope.addTodo = function (Item) {
        $http({
            method: 'POST',
            url: 'http://localhost:19471/api/todo/data',
            data: $scope.Item
        }).then(function () {
            $scope.getTodos();
            $scope.message = "success";
        }, function () {
            $scope.message = "failed"
        });
    }

    $scope.deleteTodo = function (Item) {
        $http({
            method: 'POST',
            url: 'http://localhost:19471/api/todo/delete',
            data: Item
        }).then(function () {
            $scope.getTodos();
            $scope.message = "success";
        }, function () {
            $scope.message = "failed"
        });
    }

    $scope.getTodos = function () {
        $http({
            method: 'GET',
            url: 'http://localhost:19471/api/todo/data',
        }).then(function getData(sendedData) {

            $scope.messageSample = sendedData;
        }, function () {
            $scope.messageSample = "failed"
            });


        $scope.reverse = function (array) {
            var copy = [].concat(array);
            return copy.reverse();
        }
    }



    function init() {
        $scope.getTodos();
    }

    init();
});

