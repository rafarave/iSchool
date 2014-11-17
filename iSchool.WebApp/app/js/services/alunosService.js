
angular.module('iSchoolApp.services')

.service('alunosService', function ($http) {

	this.getTodos = function get() {
		return $http.get("../api/alunos", {
			headers: { 'Content-Type': 'application/json' }
		}).success(function (data) {
			return data;
		}).error(function (data) { });
	}

	this.postNovo = function post(aluno) {
		return $http.post("../api/alunos/new", aluno, {
			headers: { 'Content-Type': 'application/json' }
		}).success(function (data) {
			return data;
		}).error(function (data) { });
	}


});
