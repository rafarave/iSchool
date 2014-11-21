
angular.module('iSchoolApp.controllers')

.controller('formAlunoController', function ($scope, $route, $location, alunosService, toaster) {

	$scope.modoForm = "Editar";
	if ($location.path() == "/alunos/novo")
		$scope.modoForm = "Novo";

	$scope.salvaAluno = function () {
		var aluno = {
			Aluno: {
				Nome: $scope.modelNome,
				Nascimento: $scope.modelNascimento,
				Email: $scope.modelEmail,
				Endereco: $scope.modelEndereco,
				Numero: $scope.modelNumero,
				Complemento: $scope.modelComplemento,
				CEP: $scope.modelCEP,
				Cidade: $scope.modelCidade,
				Estado: $scope.modelEstado
			}
		};

		if ($scope.modoForm == "Novo") {
			alunosService.postAluno(aluno).success(function (data) {
				toaster.pop('success', "Sucesso!", "Aluno criado com sucesso!");
				$location.path("/alunos");
			});
		}
		else {
			alunosService.putAluno(aluno).success(function (data) {
				toaster.pop('success', "Sucesso!", "Aluno modificado com sucesso!");
				$location.path("/alunos");
			});
		}

	};

	$scope.cancela = function () {
		$route.reload();
	};

});
