var dashboardApp = angular.module('dashboardApp', ['ui.bootstrap', 'highcharts-ng','ngSanitize']);

dashboardApp.service('chartdataService', ['$rootScope', '$http', chartdataService]);


dashboardApp.filter('unsafe', function ($sce) { return $sce.trustAsHtml; });
dashboardApp.controller('dashboardController', ['$scope', '$log', dashboardController]);
dashboardApp.controller('chartController', ['$scope', '$log', '$timeout', '$interval', 'chartdataService', 'signalRHubProxy', chartController]);
dashboardApp.controller('customChartController', ['$scope', '$log', '$timeout', '$interval', 'chartdataService', 'signalRHubProxy', customChartController]);

dashboardApp.controller('reportController', ['$scope', reportController]);
dashboardApp.controller('inventoryReportController', ['$scope', inventoryReportController]);
dashboardApp.controller('baseReportController', ['$scope', '$log', '$timeout', '$interval', 'chartdataService', baseReportController]);
dashboardApp.controller('dataManagementController', ['$scope', dataManagementController]);
dashboardApp.controller('inventoryController', ['$scope', inventoryController]);
dashboardApp.controller('fbaAsinFeeController', ['$scope', fbaAsinFeeController]);
dashboardApp.directive('input', [function () {
    return {
        restrict: 'E',
        require: '?ngModel',
        link: function (scope, element, attrs, ngModel) {
            if (
                   'undefined' !== typeof attrs.type
                && 'number' === attrs.type
                && ngModel
            ) {
                ngModel.$formatters.push(function (modelValue) {
                    return Number(modelValue);
                });

                ngModel.$parsers.push(function (viewValue) {
                    return Number(viewValue);
                });
            }
        }
    }
}]);