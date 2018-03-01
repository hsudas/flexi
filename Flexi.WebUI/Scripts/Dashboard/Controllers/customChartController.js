/// <reference path="globalvariables.js" />
var customChartController = function ($scope, $log, $timeout, $interval, chartdataService, signalRHubProxy) {

    $scope.series = [];
    $scope.summaryData = {
        TotalOrderItems: 0,
        UnitsOrdered: 0,
        OrderedProductSales: 0,
        AvgSalesOrderItem: 0,
        AvgUnitsOrderItem: 0,
        RefundAmount: 0,
        Profit: 0
    }
    $scope.summaryDataModel = {

    }
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
            text: 'Order Amount Chart'
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
            min: 0,
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
                chart.reflow();
            }, 0);
        }
    }
    $scope.getDayCount = function (firstDate,secondDate) {
       
        var start = $('#dpStart').datepicker('getDate');
        var end = $('#dpEnd').datepicker('getDate');

        var days = (end - start) / 1000 / 60 / 60 / 24;
    }
    $scope.criterias = [


    ];

    $scope.removeRow = function (idx) {
        $scope.criterias.splice(idx, 1);
        if ($scope.criterias.length == 0) {
            $('#dpStart').datepicker('enable');
            $('#dpEnd').datepicker('enable');
           
            $('#period').prop('disabled', false);
            $('#period').selectpicker('refresh');
            $('#ctype').prop('disabled', false);
            $('#ctype').selectpicker('refresh');
            $('#xperiod').prop('disabled', true);
            $('#xperiod').selectpicker('refresh');
        }
    };

    $scope.addCriteria = function () {
        $("#dpStart").datepicker("option", "dateFormat", "mm/dd/yy");
        $("#dpEnd").datepicker("option", "dateFormat", "mm/dd/yy");

        $scope.startdate = $("#dpStart").datepicker().val();
        $scope.enddate = $("#dpEnd").datepicker().val();
       
        if ($scope.startdate == '' || $scope.enddate == '') {
            alert('Please set  start date and end date.');
            return;
        }
        $scope.period = $("#period").val();
       
        if ($scope.period == ''|| $scope.period == null) {
            alert('Please select daily or monthly period.');
            return;
        }
        
     
        $scope.datatype = $("#datatype").val();
        if ($scope.xperiod == '? undefined:undefined ?') {
            $scope.xperiod = null;
        }
     
      
        $('#period').prop('disabled', true);
        $('#period').selectpicker('refresh');


        $('#ctype').prop('disabled', true);
        $('#ctype').selectpicker('refresh');

        $('#dpStart').datepicker('disable');
        $('#dpEnd').datepicker('disable');

        $scope.criterias.push({ 'startdate': $scope.startdate, 'enddate': $scope.enddate, 'period': $scope.period, 'fulfill': $scope.fulfill, 'sku': $scope.sku, 'skutitle': $scope.skutitle, 'vendor': $scope.vendor,'asin' : $scope.asin,'datatype' : $scope.datatype,'xperiod' : $scope.xperiod });
        $('#xperiod').prop('disabled', false);
        $('#xperiod').selectpicker('refresh');
    }
    

    $scope.refreshChart = function () {
        $scope.ctype = $("#ctype").val();
        
        var datareq = JSON.stringify($scope.criterias);
        
        if ($scope.ctype == 'Column') {
            $scope.chartConfig.options.chart.type = 'column';

        }
        else {
            $scope.chartConfig.options.chart.type = 'line';
        }
        var gr = null;
        $.ajax({
            type: "POST",
            url: serviceurl + 'api/reportdata/GetRealData',
            async: false,
            data: datareq,
            headers: { "Content-Type": "application/json" },
            success: function (response) {
                $scope.chartConfig.xAxis.categories = response.XAxis;
                $scope.chartConfig.series = response.GraphList;
            }
        });
        //summary datas will load
        $.ajax({
            type: "POST",
            url: serviceurl + 'api/reportdata/GetSummaryData',
            async: true,
            data: datareq,
            headers: { "Content-Type": "application/json" },
            success: function (response) {
                $scope.summaryDataModel = response;
                $scope.$apply();
              
            }
        });
    }



    $('#clear').click(function () {
        location.reload();
    });

   
    //controls
    $(function () {
        $("#dpStart").datepicker(/*{ dateFormat: 'dd.mm.yy' }*/);
    });
    $(function () {
        $("#dpEnd").datepicker(
            );
    });
    
   

    $(function() {

        $('#ctype').on('change', function () {
            var selected = $(this).find("option:selected").val();
            $scope.ctype = selected;
        });
        $('#xperiod').on('change', function () {
            var selected = $(this).find("option:selected").val();
            $scope.xperiod = selected;
        });

        $('#period').on('change', function () {
            var selected = $(this).find("option:selected").val();
            $scope.period = selected;
        });
        $('#fulfill').on('change', function () {
            var selected = $(this).find("option:selected").val();
            if (selected != '') {
                $scope.fulfill = selected;

            }
            else {
                $scope.fulfill = null;
            }
        });


        $('#xperiod').prop('disabled', true);
        $('#xperiod').selectpicker('refresh');
    })
    function toDate(dateStr) {
        var parts = dateStr.split(".");
        return new Date(parts[2], parts[1] - 1, parts[0]);
    }
    var dtEndDateSelect = function (dateText) {

        var endDate = toDate($("#dpEnd").datepicker().val());
        var startDate = toDate($("#dpStart").datepicker().val());
        if (endDate < startDate) {
            alert('End Date must be greater then Start Date!');
        }
        else {
            $scope.startdate = startDate;
            $scope.enddate = endDate;
        }
       
    }






};