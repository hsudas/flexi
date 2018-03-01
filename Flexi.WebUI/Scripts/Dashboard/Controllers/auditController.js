var auditController = function ($scope, signalRHubProxy) {
/*
    $scope.AuditQuery = {
        AuditQueryId: '0',
        LastResult: '0',
        AlertLimit:'0'
    };
    */
    $scope.AuditQuery = [];
    var clientPushHubProxy = signalRHubProxy(
       signalRHubProxy.defaultServer, 'MyHub',
           { logging: true });

    clientPushHubProxy.on('auditQueryDetails', function (data) {
        $scope.AuditQuery = data;
        var x = clientPushHubProxy.connection.id;
    });
};