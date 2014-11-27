
angular.module('iSchoolApp.controllers')

.controller('alunosController', function ($scope, alunosService, toaster) {

	//TODO: ta aqui por enquanto, nao exibira tudo, ira realizar a pesquisa e trazer exatamente o aluno desejado,
	//se houver novas definicoes de pesquisa faremos em outra tela
	$scope.init = function () {
		alunosService.getTodos().success(function (data) {
			$scope.alunos = data;
		});
	};

	$scope.excluiAluno = function (id) {
		if (confirm("confirma a exclusão?")) {
			alunosService.deleteAluno(id).success(function (data) {
				toaster.pop('success', "Sucesso!", "Aluno excluído com sucesso!");
				$scope.init();
			});
		}
	};

	$scope.buscaAluno = function (matricula) {
		alunosService.getAlunoPorMatricula(matricula).success(function (data) {
			$scope.alunos = data;
		});
	};

	$scope.init();

});
