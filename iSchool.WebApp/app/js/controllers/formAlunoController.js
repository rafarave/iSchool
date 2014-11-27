
angular.module('iSchoolApp.controllers')

.controller('formAlunoController', function ($scope, $route, $routeParams, $location, alunosService, toaster, $filter) {

	$scope.alunoEntity = { Aluno: {} };

	if ($location.path() == "/alunos/novo")
		$scope.modoForm = "Novo";
	else {
		$scope.modoForm = "Editar";
		alunosService.getAluno($routeParams.id).success(function (data) {
			$scope.alunoEntity.Aluno = data;
			$scope.alunoEntity.Aluno.Nascimento = $filter('momentParseDateASPNetJSON')(data.Nascimento);
		});
	}

	//TODO: validar campos e remover toaster
	$scope.salvaAluno = function () {
		if ($scope.modoForm == "Novo") {
			alunosService.postAluno($scope.alunoEntity).success(function (data) {
				toaster.pop('success', "Sucesso!", "Aluno criado com sucesso!");
				$location.path("/alunos");
			});
		}
		else {
			alunosService.putAluno($scope.alunoEntity).success(function (data) {
				toaster.pop('success', "Sucesso!", "Aluno modificado com sucesso!");
				$location.path("/alunos");
			});
		}
		toaster.pop('success', "Sucesso!", "Aluno criado com sucesso!");
	};

	//TODO: decidir se volta pra tela de pesquisa ou se soh limpa os campos
	$scope.cancela = function () {
		$route.reload();
	};

});
