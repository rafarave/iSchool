
angular.module('iSchoolApp')

.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

	$routeProvider.when('/inicio', { templateUrl: 'app/partials/inicio.html', controller: 'inicioController' });
	//$routeProvider.when('/busca', { templateUrl: 'app/partials/busca.html', controller: 'buscaController' });
	//$routeProvider.when('/busca/item', { templateUrl: 'app/partials/parque-praca.html', controller: 'parquePracaController' });//item:codigo
	$routeProvider.otherwise({ redirectTo: '/inicio' });

	// use the HTML5 History API
	//$locationProvider.html5Mode(true);

}]);
