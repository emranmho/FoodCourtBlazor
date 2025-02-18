using Microsoft.JSInterop;

namespace FoodCourtBlazor.Services.Extensions;

public static class JsRuntimeExtension
{
    public static async Task ShowNotification(this IJSRuntime js, string type, string message)
    {
        await js.InvokeVoidAsync("ShowToastr", type, message);
    }
}