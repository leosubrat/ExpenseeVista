using Microsoft.AspNetCore.Components;

namespace ExpenseeVista.Components.Pages
{
    public partial class Index :ComponentBase
    {
        protected override void OnInitialized()
        {
            Nav.NavigateTo("/login");
        }

    }
}