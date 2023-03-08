////(function () {
////    var _createPersonModal = new app.ModalManager({
////        viewUrl: abp.appPath + 'App/PhoneBook/CreatePersonModal',
////        scriptUrl: abp.appPath + 'view-resources/Areas/App/Views/PhoneBook/_CreatePersonModal.js',
////        modalClass: 'CreatePersonModal'
////    });

////    $('#CreateNewPersonButton').click(function (e) {
////        e.preventDefault();
////        _createPersonModal.open();
////    });

////})();

////var _personService = abp.services.app.person;


////$('#AllPeopleList button.delete-person').click(function (e) {
////    e.preventDefault();
////    var $listItem = $(this).closest('.list-group-item');
////    var personId = $listItem.attr('data-person-id');
////    abp.message.confirm(app.localize('AreYouSureToDeleteThePerson')).then(function (isconfirmed) {
////        if (isconfirmed) {
////            _personService.deletePerson({
////                id: personId
////            }).done(function () {

////                abp.notify.info("Successfully deleted");
////                $listItem.remove();
////            });
////        }
////        else {
////            abp.notify.info("No data available");
////        }
////    }
////    );
////});
//////Edit person button
////debugger;
////$('#AllPeopleList button.edit-person').click(function (e) {
////    e.preventDefault();

////    var $listItem = $(this).closest('.list-group-item');

////    $listItem
////        .toggleClass('person-editing')
////        .siblings().removeClass('person-editing');
////});

//////Save phone button
////debugger;
////$('#AllPeopleList .button-save-phone').click(function (e) {
////    e.preventDefault();

////    var $phoneEditorRow = $(this).closest('tr');

////    abp.ajax({
////        url: abp.appPath + 'App/PhoneBook/AddPhone',
////        dataType: 'html',
////        data: JSON.stringify({

////            personId: $phoneEditorRow.closest('.list-group-item').attr('data-person-id'),
////            Type: $phoneEditorRow.find('select[name=Type]').val(),
////            Number: $phoneEditorRow.find('input[name=Number]').val()
////        })

////    }).done(function (result) {
////        $(result).insertBefore($phoneEditorRow);
////    });
////});

//////Delete phone button
////$('#AllPeopleList').on('click', '.button-delete-phone', function (e) {
////    e.preventDefault();

////    var $phoneRow = $(this).closest('tr');
////    var phoneId = $phoneRow.attr('data-phone-id');

////    _personService.deletePhone({
////        id: phoneId
////    }).done(function () {
////        abp.notify.success(app.localize('SuccessfullyDeleted'));
////        $phoneRow.remove();
////    });
////});





////var _editPersonModal = new app.ModalManager({
////    viewUrl: abp.appPath + 'App/PhoneBook/EditPersonModal',
////    scriptUrl: abp.appPath + 'view-resources/Areas/App/Views/PhoneBook/_EditPersonModal.js',
////    modalClass: 'EditPersonModal'
////});

////$('#AllPeopleList button.edit-person').click(function (e) {
////    e.preventDefault();
////    var $listItem = $(this).closest('.list-group-item');
////    var id = $listItem.data('person-id');
////    _editPersonModal.open({ id: id });
////});





//(function () {
//    $(function () {
        

//        var _$usersTable = $('#UsersTable');
//        var _personService = abp.services.app.person;
//        var dataTable = _$usersTable.DataTable({
//            paging: true,
//            serverSide: true,
//            processing: true,
//            listAction: {
//                ajaxFunction: _personService.getPeople,
//                inputFilter: function () {
//                    return {
//                        filter: $('#UsersTableFilter').val(),
//                        //permissions: _selectedPermissionNames,
//                        //role: $("#RoleSelectionCombo").val(),
//                        //onlyLockedUsers: $("#UsersTable_OnlyLockedUsers").is(':checked')
//                    };
//                }
//            },
//            columnDefs: [
//                {
//                    className: 'control responsive',
//                    orderable: false,
//                    render: function () {
//                        return '';
//                    },
//                    targets: 0
//                },
//                //{
//                //    targets: 1,
//                //    data: null,
//                //    orderable: false,
//                //    autoWidth: false,
//                //    defaultContent: '',
//                //    rowAction: {
//                //        text: '<i class="fa fa-cog"></i> <span class="d-none d-md-inline-block d-lg-inline-block d-xl-inline-block">' + app.localize('Actions') + '</span> <span class="caret"></span>',
//                //        items: [{
//                //            text: app.localize('LoginAsThisUser'),
//                //            visible: function (data) {
//                //                return _permissions.impersonation && data.record.id !== abp.session.userId;
//                //            },
//                //            action: function (data) {
//                //                abp.ajax({
//                //                    url: abp.appPath + 'Account/Impersonate',
//                //                    data: JSON.stringify({
//                //                        tenantId: abp.session.tenantId,
//                //                        userId: data.record.id
//                //                    })
//                //                });
//                //            }
//                //        },
//                //            {
//                //            text: app.localize('Edit'),
//                //            visible: function () {
//                //                return _permissions.edit;
//                //            },
//                //            action: function (data) {
//                //                _createOrEditModal.open({ id: data.record.id });
//                //            }
//                //        }, {
//                //            text: app.localize('Permissions'),
//                //            visible: function () {
//                //                return _permissions.changePermissions;
//                //            },
//                //            action: function (data) {
//                //                _userPermissionsModal.open({ id: data.record.id });
//                //            }
//                //        }, {
//                //            text: app.localize('Unlock'),
//                //            visible: function () {
//                //                return _permissions.unlock;
//                //            },
//                //            action: function (data) {
//                //                _userService.unlockUser({
//                //                    id: data.record.id
//                //                }).done(function () {
//                //                    abp.notify.success(app.localize('UnlockedTheUser', data.record.userName));
//                //                });
//                //            }
//                //        }, {
//                //            text: app.localize('DynamicProperties'),
//                //            visible: function () {
//                //                return _dynamicEntityPropertyManager.canShow('ProjectDemo.Authorization.Users.User');
//                //            },
//                //            //action: function (data) {
//                //            //    _dynamicEntityPropertyManager.modal.open({
//                //            //        entityFullName: 'ProjectDemo.Authorization.Users.User',
//                //            //        rowId: data.record.id
//                //            //    });
//                //            //}
//                //        }, {
//                //            text: app.localize('Delete'),
//                //            visible: function () {
//                //                return _permissions.delete;
//                //            },
//                //            action: function (data) {
//                //                deleteUser(data.record);
//                //            }
//                //        }]
//                //    }
//                //},
//                //{
//                //    targets: 2,
//                //    data: "Name",
//                //    render: function (Name, type, row, meta)
//                //    {
//                //        var $container = $("<span/>");
//                //        var profilePicture = "/Profile/GetProfilePictureByUser?userId=" + row.id + "&profilePictureId=" + row.profilePictureId;

//                //        if (profilePicture) {
//                //            var $link = $("<a/>").attr("href", profilePicture).attr("target", "_blank");
//                //            var $img = $("<img/>")
//                //                .addClass("img-circle")
//                //                .attr("src", profilePicture);

//                //            $link.append($img);
//                //            $container.append($link);
//                //        }

//                //        $container.append(Name);
//                //        return $container[0].outerHTML;
//                //    }
//                //},
//                //{
//                //    targets: 3,
//                //    data: "name"
//                //},

//                {
//                    targets: 1,
//                    data: "name"

//                },
//                {
//                    targets: 2,
//                    data: "surname"
//                },
//                {
//                    targets: 3,
//                    data: "phones",
//                    orderable: false,
//                    render: function (phones) {
//                        var roleNames = '';
//                        for (var j = 0; j < phones.length; j++) {
                         

//                            roleNames = roleNames + phones[j].Number;
//                        }

//                        return roleNames;
//                    }
//                },
//                {
//                    targets: 4,
//                    data: "emailAddress"
//                },
//                  {
//                    targets: 5,
//                    data: "creationTime",
//                    render: function (creationTime) {
//                        return moment(creationTime).format('L');
//                    }
//                }

                
//                //{
//                //    targets: 7,
//                //    data: "isEmailConfirmed",
//                //    render: function (isEmailConfirmed) {
//                //        var $span = $("<span/>").addClass("label");
//                //        if (isEmailConfirmed) {
//                //            $span.addClass("label label-success label-inline").text(app.localize('Yes'));
//                //        } else {
//                //            $span.addClass("label label-dark label-inline").text(app.localize('No'));
//                //        }
//                //        return $span[0].outerHTML;
//                //    }
//                //},
//                //{
//                //    targets: 8,
//                //    data: "isActive",
//                //    render: function (isActive) {
//                //        var $span = $("<span/>").addClass("label");
//                //        if (isActive) {
//                //            $span.addClass("label label-success label-inline").text(app.localize('Yes'));
//                //        } else {
//                //            $span.addClass("label label-dark label-inline").text(app.localize('No'));
//                //        }
//                //        return $span[0].outerHTML;
//                //    }
//                //},
//                //{
//                //    targets: 9,
//                //    data: "creationTime",
//                //    render: function (creationTime) {
//                //        return moment(creationTime).format('L');
//                //    }
//                //}
//            ]
//        });
//        GetPeople();

//        function GetPeople() {
//            dataTable.ajax.reload();
//        }
        
//    }
    
//);
//})();















(function () {
    debugger;
    var _createPersonModal = new app.ModalManager({
        viewUrl: abp.appPath + 'App/PhoneBook/CreatePersonModal',
        scriptUrl: abp.appPath + 'view-resources/Areas/App/Views/PhoneBook/_CreatePersonModal.js',
        modalClass: 'CreatePersonModal'
    });

    $('#CreateNewPersonButton').click(function (e) {
        e.preventDefault();
        _createPersonModal.open();
    });

})();




var _personService = abp.services.app.person;


$('#AllPeopleList button.delete-person').click(function (e) {
    e.preventDefault();
    var $listItem = $(this).closest('.list-group-item');
    var personId = $listItem.attr('data-person-id');
    abp.message.confirm(app.localize('AreYouSureToDeleteThePerson')).then(function (isconfirmed) {
        if (isconfirmed) {
            _personService.deletePerson({
                id: personId
            }).done(function () {

                abp.notify.info("Successfully deleted");
                $listItem.remove();
            });
        }
        else {
            abp.notify.info("No data available");
        }
    }
    );
});





(function () {
    $(function () {


        var _$usersTable = $('#UsersTable');
        var _personService = abp.services.app.person;

        var _$numberOfFilteredPermission = $("#NumberOfFilteredPermission");
        /* var _dynamicEntityPropertyManager = new DynamicEntityPropertyManager();*/

        var _selectedPermissionNames = [];

        //var _$permissionFilterModal = app.modals.PermissionTreeModal.create({
        //    disableCascade: true,
        //    onSelectionDone: function (filteredPermissions) {
        //        _selectedPermissionNames = filteredPermissions;
        //        var filteredPermissionCount = filteredPermissions.length;

        //        _$numberOfFilteredPermission.text(filteredPermissionCount)
        //        abp.notify.success(app.localize('XCountPermissionFiltered', filteredPermissionCount));


        //        debugger;
        //        GetPeople();
        //    }
        //});

        var _permissions = {
            create: abp.auth.hasPermission('Pages.Administration.Users.Create'),
            edit: abp.auth.hasPermission('Pages.Administration.Users.Edit'),
            changePermissions: abp.auth.hasPermission('Pages.Administration.Users.ChangePermissions'),
            impersonation: abp.auth.hasPermission('Pages.Administration.Users.Impersonation'),
            unlock: abp.auth.hasPermission('Pages.Administration.Users.Unlock'),
            'delete': abp.auth.hasPermission('Pages.Administration.Users.Delete')
        };

        var _editPersonModal = new app.ModalManager({
            viewUrl: abp.appPath + 'App/PhoneBook/EditPersonModal',
            scriptUrl: abp.appPath + 'view-resources/Areas/App/Views/PhoneBook/_EditPersonModal.js',
            modalClass: 'EditPersonModal'
        });

        var _userPermissionsModal = new app.ModalManager({
            viewUrl: abp.appPath + 'App/Users/PermissionsModal',
            scriptUrl: abp.appPath + 'view-resources/Areas/App/Views/Users/_PermissionsModal.js',
            modalClass: 'UserPermissionsModal'
        });





        debugger;
        var dataTable = _$usersTable.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            listAction: {
                ajaxFunction: _personService.getPeople,
                inputFilter: function () {
                    return {
                        filter: $('#UsersTableFilter').val(),
                        //permissions: _selectedPermissionNames,
                        //role: $("#RoleSelectionCombo").val(),
                        //onlyLockedUsers: $("#UsersTable_OnlyLockedUsers").is(':checked')
                    };
                }
            },
            columnDefs: [
                {
                    className: 'control responsive',
                    orderable: false,
                    render: function () {
                        return '';
                    },
                    targets: 0
                },
                {
                    targets: 1,
                    data: null,
                    orderable: false,
                    autoWidth: false,
                    defaultContent: '',
                    rowAction: {
                        text: '<i class="fa fa-cog"></i> <span class="d-none d-md-inline-block d-lg-inline-block d-xl-inline-block">' + app.localize('Actions') + '</span> <span class="caret"></span>',
                        items: [
                            {
                                text: app.localize('Edit'),
                                action: function (data) {
                                    _editPersonModal.open({ id: data.record.id });
                                }

                            },


                            {
                                text: app.localize('Delete'),
                                action: function (data) {
                                    deletePerson(data.record);
                                }


                            }]
                    }
                },


                {
                    targets: 2,
                    data: "name"

                },
                {
                    targets: 3,
                    data: "surname"
                },
                {
                    targets: 5,
                    data: "phones",
                    orderable: false,
                    render: function (phones) {
                        var roleNames = '';
                        for (var j = 0; j < phones.length; j++) {
                            if (j == phones.length - 1) {
                                roleNames = roleNames + phones[j].number;
                            }
                            else {
                                roleNames = roleNames + phones[j].number + ' , ';
                            }


                        }

                        return roleNames;
                    }
                },
                {
                    targets: 4,
                    data: "emailAddress"
                },
                {
                    targets: 6,
                    data: "creationTime",
                    render: function (creationTime) {
                        return moment(creationTime).format('L');
                    }
                }

            ]
        });
        GetPeople();


        function GetPeople() {
            dataTable.ajax.reload();
        }
        function deletePerson(person) {

            abp.message.confirm(
                app.localize('UserDeleteWarningMessage', person.name),
                app.localize('AreYouSure'),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _personService.deletePerson({
                            id: person.id
                        }).done(function () {
                            GetPeople(true);
                            abp.notify.success(app.localize('SuccessfullyDeleted'));
                        });
                    }
                }
            );
        }

        var getSortingFromDatatable = function () {
            if (dataTable.ajax.params().order.length > 0) {
                var columnIndex = dataTable.ajax.params().order[0].column;
                var dir = dataTable.ajax.params().order[0].dir;
                var columnName = dataTable.ajax.params().columns[columnIndex].data;

                return columnName + ' ' + dir;
            } else {
                return '';
            }
        };

        $('#ExportUsersToExcelButton').click(function (e) {
            debugger;
            e.preventDefault();
            _userService
                .getUsersToExcel({
                    filter: $('#UsersTableFilter').val(),
                    /*   permissions: _selectedPermissionNames,*/
                    role: $("#RoleSelectionCombo").val(),
                    onlyLockedUsers: $("#UsersTable_OnlyLockedUsers").is(':checked'),
                    sorting: getSortingFromDatatable()
                })
                .done(function (result) {
                    app.downloadTempFile(result);
                });
        });

        $('#GetUsersButton, #RefreshUserListButton').click(function (e) {
            e.preventDefault();
            GetPeople();
        });

        $('#UsersTableFilter').on('keydown', function (e) {

            if (e.keyCode !== 13) {
                return;
            }

            e.preventDefault();
            GetPeople();
        });
        $('#UsersTableFilter').focus();

        $('#ImportUsersFromExcelButton').fileupload({
            url: abp.appPath + 'Users/ImportFromExcel',
            dataType: 'json',
            maxFileSize: 1048576 * 100,
            dropZone: $('#UsersTable'),
            done: function (e, response) {
                var jsonResult = response.result;
                if (jsonResult.success) {
                    abp.notify.info(app.localize('ImportUsersProcessStart'));
                } else {
                    abp.notify.warn(app.localize('ImportUsersUploadFailed'));
                }
            }
        }).prop('disabled', !$.support.fileInput)
            .parent().addClass($.support.fileInput ? undefined : 'disabled');

        $("#FilterByPermissionsButton").click(function () {
            _$permissionFilterModal.open({ grantedPermissionNames: _selectedPermissionNames });
        });


    }


    );
})();























