
angular.module('iSchoolApp.controllers')

.controller('alunosController', function ($scope, alunosService) {

	alunosService.getTodos().success(function (data) {
		$scope.alunos = data;
	});

});
