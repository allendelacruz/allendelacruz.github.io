using allendelacruz.github.io.Common.Interfaces;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace allendelacruz.github.io.Common.Services
{
    public class JSUtilityService : IJSUtilityService
    {
        private readonly IJSRuntime _js;

        public JSUtilityService(IJSRuntime js)
            => _js = js;

        public async ValueTask DisplayAlert(string message)
            => await _js.InvokeVoidAsync("alert", message);
    }
}