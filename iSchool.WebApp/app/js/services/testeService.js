
angular.module('iSchoolApp.services')

.service('testeService', function ($http) {

	this.get = function getTodos() {
		return $http.get("../api/aluno/todos", {
			headers: { 'Content-Type': 'application/json' }
		}).success(function (data) {
			return data;
		}).error(function (data) { });
	}


});
