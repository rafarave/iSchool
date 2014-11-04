
angular.module('iSchoolApp.services')

.service('testeService', function ($http) {

	this.get = function getTodosAreaLazer() {
		return $http.get("../api/arealazer/todos", {
			headers: { 'Content-Type': 'application/json' }
		}).success(function (data) {
			//console.log(data);
			return data;
		}).error(function (data) {
			//console.log(data);
		});
	}


});
