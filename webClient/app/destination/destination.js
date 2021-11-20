'use strict';

angular.module('myApp.destination', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/destination', {
    templateUrl: 'destination/destination.html',
    controller: 'DestinationCtrl'
  });
}])
.controller('DestinationCtrl',   function($scope ,$http ) { 
  $scope.unix= "meta";

  $http.get('http://localhost:30502/destination').then(function (response) {
            console.log(response);
        })
});