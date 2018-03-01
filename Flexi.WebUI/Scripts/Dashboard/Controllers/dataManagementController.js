/// <reference path="globalvariables.js" />
//TODO LIST:
//clear fonksiyonu yazilacak. modaldaki tum textbxlar temizlenecek
//server side da update ve insert islemleri hatasiz yapilip forma geri donus verilecek.
// definition tanimlama islemleri yapilacak.
//tum islemler test edilip buglar temizlenecek.
var dataManagementController = function ($scope) {
    var gridRow = {};
    $scope.criterias = [


    ];
    $scope.reportData = [];
    $scope.operationType = '';
    $scope.columnRelationList = [];
    var crudObjectList = [{
        TableName: "",
        KeyColumnName: "",
        KeyColumnValue:"",
        OperationType:"",
        Columns: [
            {
                ColumnName:"",
                ColumnValue: "",
                DataType: ""
            }
        ]
    }];
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
    var getColumnIndex = function (columnName) {
        if ($scope.reportData) {
            if ($scope.reportData.Columns) {
                for (var i = 0; i < $scope.reportData.Columns.length; i++) {
                    if (columnName == $scope.reportData.Columns[i].title) {
                        return i;
                    }
                }
            }
        }
        return -1;
    }
    var setControls = function (tableName, columnArray, dataObject) {
        for (var i = 0; i < columnArray.length; i++) {
            var controlId = '#txt' + columnArray[i].column_name + '_' + tableName.replace('.','_');
            var objectValue = dataObject[columnArray[i].column_name];
            if (columnArray[i].data_type == 'boolean') {
                if(objectValue === true)
                    $(controlId).prop('checked', true);
                else
                    $(controlId).prop('checked', false);
            }
            else {
                $(controlId).val(objectValue);
                
            }
        }
    }
    var clearControls = function () {
        var columnRelations = $scope.reportData.ColumnRelations;
        for (var i = 0; i < columnRelations.length; i++) {
            var cr = columnRelations[i];
            for (var j = 0; j < cr.TableColumns.length; j++) {
                
                var controlId = '#txt' + cr.TableColumns[j].column_name + '_' + cr.TableName.replace('.','_');
                $(controlId).val('');
            }
            
        }
    }
    var getObjectFromControls = function (columnRelationObject,keyColumnValue,operationType) {
        var tableName = columnRelationObject.TableName;
        var crudObject = {};
        crudObject.TableName = tableName;
        crudObject.KeyColumnName = columnRelationObject.TableColumnName;
        crudObject.KeyColumnValue = keyColumnValue;
        crudObject.OperationType = operationType;
        crudObject.Columns = [];
        for (var i = 0; i < columnRelationObject.TableColumns.length; i++) {
            var tableColumnName = columnRelationObject.TableColumns[i].column_name;
            var dataType = columnRelationObject.TableColumns[i].data_type;
            var isNullable = columnRelationObject.TableColumns[i].is_nullable;
            var columnDefault = columnRelationObject.TableColumns[i].column_default;
            let currentVal;
            if (dataType=="boolean") {
                if ($('#txt' + tableColumnName + '_' + tableName.replace('.', '_')).is(":checked"))
                    currentVal = true;
                else
                    currentVal = false;
                       
                
            }
            else {
                    currentVal = $('#txt' + tableColumnName + '_' + tableName.replace('.','_')).val();
            }
          
            //var isSerial = columnDefault.includes('nextval');
             if (isNullable == 'NO' && currentVal.length == 0) {
                    alert('You must enter the ' + tableColumnName + ' value!');
                    return null;
                }
            if (columnDefault == null || (currentVal.length > 0 || dataType == 'boolean')) {
                crudObject.Columns.push({ "ColumnName": tableColumnName, "ColumnValue": currentVal, "DataType": dataType });
            }
        }
        return crudObject;
    }
    $scope.saveDefinition = function()
    {
        if ($scope.Definition === undefined)
        {
            alert('Please enter a definition name!');
            return;
        }
        if ($scope.QueryName === undefined) {
            alert('Please enter a query name!');
            return;
        }
        if ($scope.columnRelationList.length == 0) {
            alert('Please add minimum one column relation');
            return;
        }
        var dataReq = JSON.stringify($scope.columnRelationList);
        ajaxRequest('api/Operation/CreateDMDefinition?description=' + $scope.Definition + '&queryName='+$scope.QueryName, 'POST', dataReq, function (result) {
            responseObject = result;
            if (responseObject.ResponseCode == "0") {
                alert(responseObject.ResponseMessage);
                $scope.Definition = null;
                $scope.QueryName = null;
                $scope.columnRelationList = [];
            }
            else {
                alert('ERROR:' + responseObject.ResponseMessage);
                return;
            }
        });
    }
    $scope.loadDefinition = function () {
        $scope.Definition = $scope.reportData.Definition;
        $scope.QueryName = $scope.reportData.QueryName;
        $scope.columnRelationList = $scope.reportData.ColumnRelations;
        $scope.$apply();
    }
    $scope.addColumnRelation = function () {
        if ($scope.TableName === undefined) {
            alert('Please enter TableName');
            return;
        }
        if ($scope.TableColumnName === undefined) {
            alert('Please enter TableColumnName');
            return;
        }
        if ($scope.QueryColumnName === undefined) {
            alert('Please enter QueryColumnName');
            return;
        }
        var isValid = false;
        $scope.columnRelationList.forEach(function (element) {
            if ($scope.TableName == element.TableName) {
                alert('You have already added this table name:' + element.TableName);
                isValid = false;
                return;
            }
        });

        $scope.columnRelationList.push({'TableName':$scope.TableName,'TableColumnName':$scope.TableColumnName,'QueryColumnName': $scope.QueryColumnName});
    }
    $scope.removeRow = function (idx) {
        $scope.columnRelationList.splice(idx, 1);
    };
    $('#clear').click(function () {
        location.reload();
    });
    $('#btnSubmit').click(function () {
        if($scope.operationType != 'insert')
            executeData('update')
        else 
            executeData('insert');

    });
    $('#btnDelete').click(function () {
        executeData('delete')
    });
    var executeData = function (opType) {
        var dataRequest = [];
        for (var i = 0; i < $scope.reportData.ColumnRelations.length; i++) {
            var columnRelation = $scope.reportData.ColumnRelations[i];
            var queryKeyValue = gridRow[getColumnIndex(columnRelation.QueryColumnName)];
            dataRequest[i] = getObjectFromControls(columnRelation, queryKeyValue, opType);
            if (dataRequest[i] == null) {
                return;
            }

        }
        if (dataRequest.length > 0) {
            //var prm = jQuery.parseJSON(dataRequest);
            var dataReq = JSON.stringify(dataRequest);
            ajaxRequest('api/Operation/ExecuteData', 'POST', dataReq, function (result) {
                responseObject = result;
                if (responseObject.ResponseCode == "0") {
                    alert(responseObject.ResponseMessage);
                    location.reload();
                }
                else {
                    alert('ERROR:' + responseObject.ResponseMessage);
                    $('#myModal').modal('hide');
                }
            });
        }
        else {
            alert('ERROR:dataRequest length is 0!');
            $('#myModal').modal('hide');
        }
    }

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
        var dmId = getUrlParameter('dmId');
        $.each(prm, function (index, item) {
            var prVal = $("#" + prm[index].ParameterKey).val();
            item.Value = prVal;
        });
        var datareq = JSON.stringify(prm);
        if (dmId) {
            $.ajax({
                type: "POST",
                url: serviceurl + 'api/Operation/GetData?dmId=' + dmId,
                async: false,
                data: datareq,
                headers: { "Content-Type": "application/json" },
                success: function (response) {
                    $scope.reportData = response;
                    $scope.$apply();
                    $scope.viewMode = true;
                    $scope.loadDefinition();
                }
            });



        }

        if ($scope.reportData) {
            $(document).ready(function () {
                $('#example').DataTable({
                    data: $scope.reportData.Data,
                    columns: $scope.reportData.Columns,
                    pageLength: 20,
                    buttons: [

                        
                         {
                             text: 'Add New Row',
                             action: function (e, dt, node, config) {
                                 clearControls();
                                 $scope.operationType = 'insert';
                                 $('#modalTitle').text('ADD NEW ROW');
                                 $('#btnDelete').attr("disabled", true);
                                 $('#myModal').modal('show');
                             }
                         },
                        'excelHtml5',
                        'csvHtml5'
                    ],
                    dom: 'Blfrtip',
                    order:[0,'asc']
                });
            });
   

            $('#example').on('dblclick', 'tr', function () {
                gridRow = $('#example').DataTable().row(this).data();
                //$scope.operationType = 'update';
                $('#modalTitle').text('EDIT/DELETE ROW');
                $('#btnDelete').attr("disabled", false);
                var columnRelations = $scope.reportData.ColumnRelations;
                for (var i = 0; i < columnRelations.length; i++) {
                    var queryColumnName = columnRelations[i].QueryColumnName;
                    var tableColumnName = columnRelations[i].TableColumnName;
                    var tableName = columnRelations[i].TableName;
                    var tableColumns = columnRelations[i].TableColumns;
                    var queryKeyValue = gridRow[getColumnIndex(queryColumnName)];
                    if(!queryKeyValue){
                        alert('You have chosen column:' + queryColumnName + '. But its value is null! Please take look at your query again!');
                        return;
                    }
                    var url = 'api/Operation/GetSelectedRow?tableName=' + tableName + '&columnName='+tableColumnName+'&columnValue='+queryKeyValue;
                    var responseObject;
                    ajaxRequest(url, 'GET', null, function (result) {
                        responseObject = result;
                    });
                    if(responseObject.Table.length > 0)
                    {
                        var obj = responseObject.Table[0];
                        setControls(tableName,tableColumns, obj);
                    }
                }
                $('#myModal').modal('show');
               
            });

        }




    });

    $scope.testfunction = function() {
        $('#example thead th').each(function () {
            var title = $(this).text();
            $(this).html('<input type="text" placeholder="Search ' + title + '" />');
        });

            // DataTable
            var otable = $('#example').DataTable();

            // Apply the search
            otable.columns().every(function () {

                var that = this;
                $('input', this.footer()).on('keyup change', function () {
                    if (that.search() !== this.value) {
                        that
                            .search(this.value)
                            .draw();
                    }
                });
            });
    }

    $('#LoadRecordsButton').click(function (e) {
        var dmId = 0;
        var prm = jQuery.parseJSON($("#cFilter").val());
        $.each(prm, function (index, item) {

            var prVal = $("#" + prm[index].ParameterKey).val();
            item.Value = prVal;
            dmId = item.DMId;
        });
        var datareq = JSON.stringify(prm);
        e.preventDefault();
        if (dmId > 0) {
            $.ajax({
                type: "POST",
                url: serviceurl + 'api/Operation/GetData?dmId=' + dmId,
                async: false,
                data: datareq,
                headers: { "Content-Type": "application/json" },
                success: function (response) {
                    $scope.reportData = response;
                }
            });
        }


        var datatable = $('#example').dataTable().api();
        datatable.clear();
        datatable.rows.add($scope.reportData.Data);
        datatable.draw();



    });

};