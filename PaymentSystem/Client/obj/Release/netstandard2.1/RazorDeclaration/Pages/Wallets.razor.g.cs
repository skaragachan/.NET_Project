#pragma checksum "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Wallets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a881b0215676902369aea932b73fa690b473a9d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PaymentSystem.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using PaymentSystem.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using PaymentSystem.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Wallets.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Wallets.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Wallets.razor"
using PaymentSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Wallets.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/wallets")]
    public partial class Wallets : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Wallets.razor"
       
    private List<Wallet> WalletList;
    private string Currency;

    protected override async Task OnInitializedAsync()
    {
        await LoadWallets();
    }

    private async Task LoadWallets()
    {
        try
        {
            WalletList = await HttpClient.GetFromJsonAsync<List<Wallet>>("api/wallet");
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

    private async Task CreateWallet()
    {
        try
        {
            if (string.IsNullOrWhiteSpace(Currency))
                return;
            // TODO: call backend and create wallet
            var response = await HttpClient.PostAsync("api/wallet?currency="+Currency, null);
            if (response.IsSuccessStatusCode)
            {
                await LoadWallets();
            }
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

    private async Task DeleteWallet(Guid id)
    {
        try
        {
            await HttpClient.DeleteAsync("api/wallet/" + id);
            await LoadWallets();
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

    private async Task MakeTransfer(Guid id)
    {
        try
        {
            navManager.NavigateTo($"transfer/{id}");
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591