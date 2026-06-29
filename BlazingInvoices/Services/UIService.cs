using BlazingInvoices.Models;

namespace BlazingInvoices.Services
{
    public class UIService
    {
        public event Action<ConfirmationModel>? ConfirmationTriggered;
        public void Confirm(ConfirmationModel confirmationModel) =>
        ConfirmationTriggered?.Invoke(confirmationModel);
    }
}
