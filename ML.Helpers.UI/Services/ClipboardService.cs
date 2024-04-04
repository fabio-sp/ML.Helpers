using Microsoft.JSInterop;

namespace ML.Helpers.UI.Services;

public class ClipboardService : IClipboardService
{
    private readonly IJSRuntime _jsRuntime;

    public ClipboardService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task CopyToClipboard(string text)
    {
        await _jsRuntime.InvokeVoidAsync("navigator.clipboard.writeText", text);
    }
}

public interface IClipboardService
{
    Task CopyToClipboard(string text);
}