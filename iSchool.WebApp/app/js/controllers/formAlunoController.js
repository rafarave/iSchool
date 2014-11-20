
angular.module('iSchoolApp.controllers')

.controller('formAlunoController', function ($scope, $route, $location, alunosService) {

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
		console.log(aluno);

		alunosService.postAluno(aluno).success(function (data) {
			console.log('sucesso');
			console.log(data);
		});

	};

	$scope.cancela = function () {
		$route.reload();
	};

});
