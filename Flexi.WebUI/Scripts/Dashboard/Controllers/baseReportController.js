/// <reference path="globalvariables.js" />
var baseReportController = function ($scope, $log, $timeout, $interval, chartdataService) {
    var getUrlParameter = function getUrlParameter(sParam) {
        var sPageURL = decodeURIComponent(window.location.search.substring(1)),
            sURLVariables = sPageURL.split('&'),
            sParameterName,
            i;

        for (i = 0; i < sURLVariables.length; i++) {
            sParameterName = sURLVariables[i].split('=');

            if (sParameterName[0] === sParam) {
                return sParameterName[1] === undefined ? true : sParameterName[1];
            }
        }
    };
    $scope.criterias = [


    ];

    $('#clear').click(function () {
        location.reload();
    });

    $(function () {
        var x = new Date();
        var year = x.getFullYear();
        var day = x.getDate();
        var month = x.getMonth() + 1;
        var thisMonthFirstDay = new Date(year, month, 1);
        $("#dpStart").datepicker();
        $("#dpEnd").datepicker();

        $("#dpStart").datepicker().val(month + '/1/' + year);
        $("#dpEnd").datepicker().val(month + '/' + day + '/' + year);
        var prm = jQuery.parseJSON($("#cFilter").val());
        var reportId = getUrlParameter('ReportId');
        $.each(prm, function (index, item) {
            var prVal = $("#" + prm[index].ParameterKey).val();
            item.Value = prVal;
        });
        var datareq = JSON.stringify(prm);
        $.ajax({
            type: "POST",
            url: serviceurl + 'api/ReportData/GetBaseReportData?reportId=' + reportId,
            async: false,
            data: datareq,
            headers: { "Content-Type": "application/json" },
            success: function (response) {
                $scope.reportData = response;
                refreshChart(response);
            }
        });


        $(document).ready(function () {
            $('#example').DataTable({
                data: $scope.reportData.data,
                columns: $scope.reportData.columns,
                pageLength: 100,
                buttons: [
                  
                    'excelHtml5',
                    'csvHtml5'
                ],
                dom: 'Blfrtip'
            });
        });
      
       
    });

    $('#LoadRecordsButton').click(function (e) {
        var reportId = getUrlParameter('ReportId');
    
        var prm = jQuery.parseJSON($("#cFilter").val());
        
        $.each(prm, function (index, item) {

            var prVal = $("#" + prm[index].ParameterKey).val();
            item.Value = prVal;
            reportId = item.ReportId;
        });
        var datareq = JSON.stringify(prm);
        e.preventDefault();
        $.ajax({
            type: "POST",
            url:  serviceurl + 'api/ReportData/GetBaseReportData?reportId=' + reportId,
            async: false,
            data: datareq,
            headers: { "Content-Type": "application/json" },
            success: function (response) {
                $scope.reportData = response;
                refreshChart(response);
            }
        });

        var datatable = $('#example').dataTable().api();
        datatable.clear();
        datatable.rows.add($scope.reportData.data);
        datatable.draw();
     

      
    });

    //------------------CHART-----------------------------------
     $scope.series = [];

    //This is not a highcharts object. It just looks a little like one!
     $scope.chartConfig = {
         options: {
             //This is the Main Highcharts chart config. Any Highchart options are valid here.
             //will be overriden by values specified below.
             chart: {
                 style: {
                     fontFamily: 'Lato'
                 }
             },
             tooltip: {
                 headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
                 pointFormat: '<tr><td style="color:{series.color};padding:0">{series.name}: </td>' +
                     '<td style="padding:0"><b>{point.y:.1f} </b></td></tr>',
                 footerFormat: '</table>',
                 shared: true,
                 useHTML: true
             },
         },
         plotOptions: {
             column: {
                 pointPadding: 0.2,
                 borderWidth: 0
             }
         },

         //The below properties are watched separately for changes.

         //Series object (optional) - a list of series using normal highcharts series options.
         series: $scope.series.GraphList,
         //Title configuration (optional)
         title: {
             text: ''
         },

         subtitle: {
             text: 'Source: royalqg.com'
         },
         //Boolean to control showng loading status on chart (optional)
         //Could be a string if you want to show specific loading text.
         loading: false,
         //Configuration for the xAxis (optional). Currently only one x axis can be dynamically controlled.
         //properties currentMin and currentMax provied 2-way binding to the chart's maximimum and minimum
         xAxis: {
             categories: $scope.series.XAxis,
             crosshair: true
         },
         yAxis: {
        
             title: {
                 text: 'Amount'
             }
         },
         //Whether to use HighStocks instead of HighCharts (optional). Defaults to false.
         useHighStocks: false,
         //size (optional) if left out the chart will default to size of the div or something sensible.
         size: {
             height: 500
         },
         //function (optional)
         func: function (chart) {
             
             $timeout(function () {
                    if(chart)
                     chart.reflow();
                 }, 0);
         }
     }
     let refreshChart = function (response) {
         if (response.ReportChart && response.ReportChart.GraphList&& response.ReportChart.GraphList.length > 0) {
            // $scope.ctype = $("#ctype").val();

            //var datareq = JSON.stringify($scope.criterias);

            //if ($scope.ctype == 'Column') {
                //$scope.chartConfig.options.chart.type = 'column';

            //}
            //else {
            $scope.chartConfig.options.chart.type = 'line';
           // }
            var gr = null;
            $scope.chartConfig.xAxis.categories =  response.ReportChart.XAxis;
            $scope.chartConfig.series = response.ReportChart.GraphList;
            $scope.chartConfig.title.text = getUrlParameter('ReportName');
            $scope.$apply();
         }

      
    }
};