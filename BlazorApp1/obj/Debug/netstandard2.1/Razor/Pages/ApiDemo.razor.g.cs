#pragma checksum "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\ApiDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8445851bc523ef998e0d7a7087b0b74f09486434"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\ApiDemo.razor"
using BlazorApp1.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\ApiDemo.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/apidemo")]
    public partial class ApiDemo : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<global::BlazorApp1.Components.WheelchairsList>(3);
            __builder.AddAttribute(4, "SelectedObjectChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 7 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\ApiDemo.razor"
                                                                            ShowDetails

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "Wheelchairs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<BlazorApp1.Data.ListViewModel>>(
#nullable restore
#line 7 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\ApiDemo.razor"
                                        wheelchairs

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "WheelchairsChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Collections.Generic.IEnumerable<BlazorApp1.Data.ListViewModel>>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Collections.Generic.IEnumerable<BlazorApp1.Data.ListViewModel>>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => wheelchairs = __value, wheelchairs))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenComponent<global::BlazorApp1.Components.WhelchairDetails>(8);
            __builder.AddAttribute(9, "Wheelchair", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::BlazorApp1.Data.DetailsViewModel>(
#nullable restore
#line 9 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\ApiDemo.razor"
                                        SelectedWheelchair

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "WheelchairChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::BlazorApp1.Data.DetailsViewModel>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::BlazorApp1.Data.DetailsViewModel>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedWheelchair = __value, SelectedWheelchair))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\ApiDemo.razor"
       
    [Parameter]
    public IEnumerable<ListViewModel> wheelchairs { get; set; }
    //public DetailsViewModel SelectedWheelchair { get; set; }

    string apiBaseAddress = "https://localhost:44322/api/Wheelchairs";
    protected override async Task OnInitializedAsync()
    {
        wheelchairs = await client.GetFromJsonAsync<IEnumerable<ListViewModel>>(apiBaseAddress);
    }

    [Parameter]
    public DetailsViewModel SelectedWheelchair { get; set; }
    private async Task ShowDetails(int id)
    {
        SelectedWheelchair = await client.GetFromJsonAsync<DetailsViewModel>(apiBaseAddress + $"/{id}");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
