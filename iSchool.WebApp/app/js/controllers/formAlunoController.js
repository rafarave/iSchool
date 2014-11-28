
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

	//TODO: validar campos
	$scope.salvaAluno = function () {
		if ($scope.modoForm == "Novo") {
			alunosService.postAluno($scope.alunoEntity).success(function (data) {
				toaster.pop('success', "Sucesso!", "Aluno criado com sucesso!");
				$scope.alunoEntity.Aluno.Id = data;//obter id gerado
				$scope.showModal();
			});
		}
		else {
			alunosService.putAluno($scope.alunoEntity).success(function (data) {
				toaster.pop('success', "Sucesso!", "Aluno modificado com sucesso!");
				$scope.showModal();
			});
		}
	};

	$scope.cancela = function () {
		$route.reload();
	};

	$scope.redirecionaResponsavel = function () {
		$scope.hideModal();
		$location.path("/alunos/responsavel/" + $scope.alunoEntity.Aluno.Id);
	};

	$scope.redirecionaAlunos = function () {
		$scope.hideModal();
		$location.path("/alunos");
	};

	$scope.showModal = function () {
		$('#modalDialog').modal({ keyboard: false, backdrop: 'static' });
	};

	$scope.hideModal = function () {
		$('.modal-backdrop').remove();
		$('#modalDialog').modal('hide');
	};

});
