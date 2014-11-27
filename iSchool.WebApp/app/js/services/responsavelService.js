
angular.module('iSchoolApp.services')

.service('responsavelService', function ($http) {

	this.getPorAluno = function (id) {
		return $http.get("../api/responsaveis/aluno/" + id, {
			headers: { 'Content-Type': 'application/json' }
		}).success(function (data) {
			return data;
		}).error(function (data) { });
	}

	this.deleteResponsavel = function (id) {
		return $http.delete("../api/responsaveis/" + id, {
			headers: { 'Content-Type': 'application/json' }
		}).success(function (data) {
			return data;
		}).error(function (data) { });
	}

	this.postResponsavel = function (aluno) {
		return $http.post("../api/responsaveis", aluno, {
			headers: { 'Content-Type': 'application/json' }
		}).success(function (data) {
			return data;
		}).error(function (data) { });
	}

});
