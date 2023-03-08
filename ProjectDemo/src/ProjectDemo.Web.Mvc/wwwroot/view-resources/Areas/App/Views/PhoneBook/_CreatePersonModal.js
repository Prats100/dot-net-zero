(function ($) {
    app.modals.CreatePersonModal = function () {

        var _modalManager;
        var _personService = abp.services.app.person;
        var _$form = null;

        this.init = function (modalManager) {
            
            _modalManager = modalManager;

            _$form = _modalManager.getModal().find('form');
            _$form.validate();
        };

        this.save = function () {
            if (!_$form.valid()) {
                return;
            }

            var person = _$form.serializeFormToObject();
            //debugger;

            _modalManager.setBusy(true);
            _personService.createPerson(person).done(function () {
                _modalManager.close();
                location.reload();
            }).always(function () {
                _modalManager.setBusy(false);
            });
        };
    };
})(jQuery);

//var _editPersonModal = new app.ModalManager({
//    viewUrl: abp.appPath + 'App/PhoneBook/EditPersonModal',
//    scriptUrl: abp.appPath + 'view-resources/Areas/App/Views/PhoneBook/_EditPersonModal.js',
//    modalClass: 'EditPersonModal'
//});

//$('#AllPeopleList button.edit-person').click(function (e) {
//    e.preventDefault();
//    var $listItem = $(this).closest('.list-group-item');
//    var id = $listItem.data('person-id');
//    _editPersonModal.open({ id: id });
//});
