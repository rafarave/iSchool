
angular.module('iSchoolApp.services')

.service('alunosService', function ($http) {

	this.getTodos = function() {
		return $http.get("../api/alunos", {
			headers: { 'Content-Type': 'application/json' }
		}).success(function (data) {
			return data;
		}).error(function (data) { });
	}

	this.getAluno = function(id) {
		return $http.get("../api/alunos/" + id, {
			headers: { 'Content-Type': 'application/json' }
		}).success(function (data) {
			return data;
		}).error(function (data) { });
	}

	this.deleteAluno = function(id) {
		return $http.delete("../api/alunos/" + id, {
			headers: { 'Content-Type': 'application/json' }
		}).success(function (data) {
			return data;
		}).error(function (data) { });
	}

	this.postAluno = function(aluno) {
		return $http.post("../api/alunos", aluno, {
			headers: { 'Content-Type': 'application/json' }
		}).success(function (data) {
			return data;
		}).error(function (data) { });
	}

	this.putAluno = function(aluno) {
		return $http.put("../api/alunos", aluno, {
			headers: { 'Content-Type': 'application/json' }
		}).success(function (data) {
			return data;
		}).error(function (data) { });
	}

});
