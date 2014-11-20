﻿
angular.module('iSchoolApp')

.config(['$routeProvider', '$httpProvider', '$locationProvider', function ($routeProvider, $httpProvider, $locationProvider) {

	$routeProvider.when('/inicio', { templateUrl: 'app/partials/inicio.html', controller: 'inicioController' });
	$routeProvider.when('/comunicados', { templateUrl: 'app/partials/comunicados.html', controller: 'comunicadosController' });
	$routeProvider.when('/alunos', { templateUrl: 'app/partials/alunos.html', controller: 'alunosController' });
	$routeProvider.when('/alunos/novo', { templateUrl: 'app/partials/formAluno.html', controller: 'formAlunoController' });
	$routeProvider.when('/alunos/edit', { templateUrl: 'app/partials/formAluno.html', controller: 'formAlunoController' });
	$routeProvider.when('/alunos/responsavel', { templateUrl: 'app/partials/responsavel.html', controller: 'responsavelController' });
	//$routeProvider.when('/aluno/:id', { templateUrl: 'app/partials/alunos.html', controller: 'alunosController' });//

	//error handlers
	$routeProvider.when('/erro/500', { templateUrl: 'app/partials/500.html', controller: 'httpHandlerController' });
	$routeProvider.when('/erro/400', { templateUrl: 'app/partials/400.html', controller: 'httpHandlerController' });
	$routeProvider.when('/erro/404', { templateUrl: 'app/partials/404.html', controller: 'httpHandlerController' });
	$routeProvider.otherwise({ redirectTo: '/inicio' });

	// use the HTML5 History API
	//$locationProvider.html5Mode(true);

}]);
