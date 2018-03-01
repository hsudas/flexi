var reportController = function ($scope) {

    $scope.criterias = [


    ];
    $scope.summaryData = {
        TotalOrderItems: 0,
        UnitsOrdered: 0,
        OrderedProductSales:0,
        AvgSalesOrderItem: 0,
        AvgUnitsOrderItem: 0,
        RefundAmount : 0,
        Profit : 0
    }
    $scope.setDates = function () {
        $.each($scope.criterias, function (index, item) {
            item.startdate = $("#dpStart").datepicker().val();
            item.enddate = $("#dpEnd").datepicker().val();
        });
        $scope.$apply();
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
        if ($scope.sku=='') {
            $scope.sku = null;
        }
        if ($scope.vendor == '') {
            $scope.vendor = null;
        }
        if ($scope.asin == '') {
            $scope.asin = null;
        }
        if ($scope.skutitle == '') {
            $scope.skutitle = null;
        }
        $scope.criterias.push({ 'startdate': $scope.startdate, 'enddate': $scope.enddate, 'sku': $scope.sku, 'skutitle': $scope.skutitle, 'vendor': $scope.vendor, 'asin': $scope.asin, 'fulfill': $scope.fulfill, });
    }

    $scope.removeRow = function (idx) {
        $scope.criterias.splice(idx, 1);
        if ($scope.criterias.length == 0) {
            $('#dpStart').datepicker('enable');
            $('#dpEnd').datepicker('enable');
            $("#speed").selectmenu().selectmenu('enable');
            $("#ctype").selectmenu().selectmenu('enable');
            $('#xperiod').selectmenu().selectmenu('disable');
        }
    };
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
        $('#fulfill').on('change', function () {
            var selected = $(this).find("option:selected").val();
            if (selected != '')
            {
                $scope.fulfill = selected;

            }
            else {
                $scope.fulfill = null;
            }
        });

    });
    $(document).ready(function () {
        $('#ProductSourceTable').jtable({
            title: 'Order Report',
            paging: true,
            pageSize: 50,
            sorting: true,
            actions: {
                 listAction: '/Report/GetOrderReportDate'
                
            },
            toolbar: {
                items: [{
                    icon: '/images/excel.png',
                    text: 'Export to Excel',
                    click: function () {
                        var criteriaString = JSON.stringify($scope.criterias);
        
                        window.location.href = '/Report/ExportClientsListToExcel?criteria=' + criteriaString;
                    }
                }]
            },
            fields: {
                //ProductSourceId: {
                //    key: true,
                //    list: false
                //},
                Vendor: {
                    title: 'Vendor'

                },
                Asin: {
                    title: 'Asin'

                },
                SKU: {
                    title: 'SKU'

                },
                MarketplaceName: {
                    title: 'Marketplace Name'

                },
                Quantity: {
                    title: 'Quantity'

                },
                OrderUAmount: {
                    title: 'OrderUAmount'

                },
                OrderUQuantity: {
                    title: 'OrderUQuantity'

                },
                RefundUAmount: {
                    title: 'RefundUAmount'

                },
                RefundUQuantity: {
                    title: 'RefundUQuantity'

                },
                TotalCost: {
                    title: 'TotalCost'

                },
                AmountOther: {
                    title: 'AmountOther'

                },
                Profit: {
                    title: 'Profit'

                },


            },
            recordsLoaded: function (event, data) {
                  $scope.summaryData =  data.serverResponse.Summary;
                  $scope.$apply();
            }
        });

        // $('#ProductSourceTable').jtable('load');
    });
  
    $('#LoadRecordsButton').click(function (e) {

        e.preventDefault();
    
        var criteriaString = JSON.stringify($scope.criterias);
        
        $('#ProductSourceTable').jtable('load', {
            criteria: criteriaString
        });

       
    });

    //Load all records when page is first shown
    //$('#LoadRecordsButton').click();*/
};