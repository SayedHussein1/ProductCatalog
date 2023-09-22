﻿function LoadData() {
    var table = $('.table').DataTable(
        {
            "searching": false,
            "aaSorting": [],
            "buttons": [
                {
                    "extend": 'excelHtml5', "title": Resources.SharedResource.Language, "text": '<span>' + Resources.SharedResource.exportexcel + ' <i class="icon-file-excel"></i></span>', "className": 'dt-button buttons-print btn btn-light', "exportOptions":
                    {
                        "columns": ':visible'
                    }
                },
                {
                    "extend": 'colvis', "text": '<span>' + Resources.SharedResource.selectrows + '<i class="icon-three-bars"></i></span>', "className": 'dt-button buttons-print btn btn-light'
                }
            ],
            "columnDefs": [
                { "width": "30%" },
                { "className": "text-center custom-middle-align" },
            ],
            "order": [
                [0, "desc"]
            ],
            "serverSide": true,
            "ajax":
            {
                "url": "/Language/LoadData?Search=" + $("#Name").val()
                    + "&StatusId=" + $("#StatusId").val(),
                "type": "Post",
                "dataType": "JSON",
            },
            "columns": [
                { "data": "Name" },
                { "data": "LanguageCulture" },
                { "data": "DisplayOrder" },
                {
                    "mData": null,
                    "bSortable": false,
                    "mRender": function (o) {
                        if (o.IsPublish) {
                            return '<span class="badge bg-success">' + Resources.SharedResource.published + '</span>';
                        }
                        else {
                            return '<span class="badge bg-danger">' + Resources.SharedResource.notpublished + '</span>';
                        }
                    }
                },
                {
                    "mData": null,
                    "bSortable": false,
                    "mRender": function (o) {
                        return '<div class="list-icons">'
                            + '<a href="/Language/AddEdit/' + o.Id + '" class="list-icons-item text-primary-600" data-popup="tooltip" title="' + Resources.SharedResource.edit + '"><i class="icon-pencil"></i></a> &nbsp;'
                            + (o.IsPublish ? ' <a href = "javascript:Status(' + o.Id + ',false);" class="list-icons-item text-danger-600" data - popup="tooltip" data-container="body" title="' + Resources.SharedResource.notpublished + '" > <i class="icon-blocked"></i></a > ' : ' <a href="javascript:Status(' + o.Id + ',true);" class="list-icons-item text-success-600" data-popup="tooltip" data-container="body" title="' + Resources.SharedResource.published + '"> <i class="icon-checkmark"></i></a>')
                            + '&nbsp;<a href="javascript:Delete(\'' + o.Id + '\');" class="list-icons-item text-danger-600" data-popup="tooltip" title="' + Resources.SharedResource.Delete + '"><i class="icon-cross2"></i></a></div > ';
                    }
                }
            ]
        });
  
}
function RefreshTable() {
    var table = $('.table').DataTable();
    table.destroy();
    LoadData();
}
$(document).ready(function () {
    LoadData();
});
$('#txtSearch').keypress(function (e) {
    var key = e.which;
    if (key == 13)  // the enter key code
    {
        RefreshTable();
    }
});
function Delete(id) {
    swal({
        title: "", text: Resources.SharedResource.deleteconfirm, type: "warning",
        showCancelButton: true, confirmButtonColor: "#DD6B55",
        confirmButtontext: Resources.SharedResource.successfullymsg,
        cancelButtonText: Resources.SharedResource.cancel,
        closeOnCancel: true, closeOnConfirm: false
    },
        function (isConfirm) {
            if (isConfirm) {
                $.ajax({
                    url: '/Language/Delete/' + id,
                    type: 'Post',
                    cache: false,
                    success: function (data) {
                        if (data == true) {
                            RefreshTable();
                        }
                        else {
                            swal({ title: '', text: data, type: "error" }, function () {
                                console.log('------------------Error In Delete Data---------------')
                            });
                        }
                    }
                });
            }
        });
}

function Status(id, status) {
    $.post('/Language/Status?id=' + id + "&status=" + status, function (response) {
        if (response == true) {
            RefreshTable();
        }
        else {
            swal({ title: '', text: response, type: "error" }, function () {
                console.log('------------------Error In Delete Data---------------')
            });
        }
    });
}