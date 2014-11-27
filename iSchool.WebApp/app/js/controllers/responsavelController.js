
angular.module('iSchoolApp.controllers')

.controller('responsavelController', function ($scope, $routeParams, alunosService, $filter) {

	$scope.alunoEntity = { Aluno: {} };

	$scope.init = function () {
		alunosService.getAluno($routeParams.id).success(function (data) {
			$scope.alunoEntity.Aluno = data;
			$scope.alunoEntity.Aluno.Nascimento = $filter('momentParseDateASPNetJSON')(data.Nascimento);

			responsavelService.getPorAluno().success(function (data) {

			});
		});
	};

	$scope.init();

});
