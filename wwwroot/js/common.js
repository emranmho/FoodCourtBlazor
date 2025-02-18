function ShowConfirmationModal() {
    bootstrap.Modal.getOrCreateInstance(document.getElementById('deleteModal')).show();
}

function HideConfirmationModal() {
    bootstrap.Modal.getOrCreateInstance(document.getElementById('deleteModal')).hide();
}