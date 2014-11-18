
angular.module('iSchoolApp.filters')

// ex: <div>{{ date | momentDisplay:'fromNow' }}</div>
.filter('momentDisplay', [
	function () {
		return function (date, method) {
			var momented = moment(date);
			return momented[method].apply(momented, Array.prototype.slice.call(arguments, 2));
		};
	}
])

// ex: <p>{{ date | momentParseDateASPNetJSON }}</p>
.filter('momentParseDateASPNetJSON', function () {
	return function (date) {
		return moment(date).format("DD/MM/YYYY");
	}
});
