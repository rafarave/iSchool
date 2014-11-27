
angular.module('iSchoolApp.controllers')

.controller('responsavelController', function ($scope, $routeParams, $filter, alunosService, responsavelService) {

	$scope.alunoEntity = { Aluno: {} };
	var IdAluno = $routeParams.id;

	$scope.init = function () {
		alunosService.getAluno($routeParams.id).success(function (data) {
			$scope.alunoEntity.Aluno = data;
			$scope.alunoEntity.Aluno.Nascimento = $filter('momentParseDateASPNetJSON')(data.Nascimento);
			$scope.obtemResponsaveisDoAluno(IdAluno);
		});
	};

	$scope.salvaResponsavel = function () {
		var responsavel = {
			Responsavel: {
				Nome: $scope.txtNome,
				Email: $scope.txtEmail
			}
		};
		responsavelService.postResponsavel(responsavel).success(function (data) {
			$scope.obtemResponsaveisDoAluno(IdAluno);
		});
	};

	$scope.excluiResponsavel = function (id) {
		responsavelService.deleteResponsavel(id).success(function (data) {
			$scope.obtemResponsaveisDoAluno(IdAluno);
		});
	};

	//TODO: descomentar apos a criação do serviço
	$scope.obtemResponsaveisDoAluno = function (id) {
		//responsavelService.getPorAluno().success(function (data) { });
	};

	$scope.init();

});
