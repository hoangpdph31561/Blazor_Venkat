using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Useable_web_razor
{
    public partial class DeleteConfirm
    {
        protected bool ShowConfirmation { get; set; }
        [Parameter]
        public string ConfirmationTitle { get; set; } = "Confirm Delete";

        [Parameter]
        public string ConfirmationMessage { get; set; } = "Are you sure you want to delete";
        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }
        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }
        protected async Task OnConfirmationChange(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChanged.InvokeAsync(value);
        }
    }
}
