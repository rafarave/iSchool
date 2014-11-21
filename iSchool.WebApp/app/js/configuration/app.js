'use strict';

angular.module('iSchoolApp.controllers', []);
angular.module('iSchoolApp.services', []);
angular.module('iSchoolApp.directives', []);
angular.module('iSchoolApp.filters', []);

angular.module('iSchoolApp', ['ngRoute', 'ngLocale', 'ngCookies', 'ngAnimate', 'toaster', /*'ui.bootstrap',*/  'iSchoolApp.controllers', 'iSchoolApp.services', 'iSchoolApp.directives', 'iSchoolApp.filters']);
