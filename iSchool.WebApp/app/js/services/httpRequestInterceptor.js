
angular.module('iSchoolApp')

.factory('httpRequestInterceptor', function ($q, $location) {
	return {
		'responseError': function (rejection) {
			if (rejection.status === 500)
				$location.path('/erro/500');
			else if (rejection.status === 404)
				$location.path('/erro/404');
			else if (rejection.status === 400)
				$location.path('/erro/400');
			return $q.reject(rejection);
		}
	};
});