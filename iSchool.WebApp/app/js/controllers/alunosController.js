
angular.module('iSchoolApp.controllers')

.controller('alunosController', function ($scope, alunosService) {

	//TODO: ta aqui por enquanto, nao exibira tudo, ira realizar a pesquisa e trazer exatamente o aluno desejado,
	//se houver novas definicoes de pesquisa faremos em outra tela
	$scope.init = function () {
		alunosService.getTodos().success(function (data) {
			$scope.alunos = data;
		});
	};

	//TODO: arrumar mensagens
	$scope.excluiAluno = function (id) {
		if (confirm("confirma a exclusão?")) {
			alunosService.deleteAluno(id).success(function (data) {
				alert("YES");
				$scope.init();
			});
		}
	};

	$scope.init();

});
