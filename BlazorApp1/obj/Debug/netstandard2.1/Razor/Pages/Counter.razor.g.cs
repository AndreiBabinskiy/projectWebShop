#pragma checksum "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c056232ce5140d2c7924978d1abb80f2ffc528ab"
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
#line 2 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\Counter.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
#nullable restore
#line 6 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\Counter.razor"
__builder.AddContent(3, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 38 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\Counter.razor"
                 input

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 38 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\Counter.razor"
                                       SetCounter

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
                global::__Blazor.BlazorApp1.Pages.Counter.TypeInference.CreateInputNumber_0(__builder2, 19, 20, "form-control col-sm-2", 21, 
#nullable restore
#line 41 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\Counter.razor"
                              input.CounterValue

#line default
#line hidden
#nullable disable
                , 22, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => input.CounterValue = __value, input.CounterValue)), 23, () => input.CounterValue);
                __builder2.AddMarkupContent(24, "\r\n    <input type=\"submit\" class=\"btn btn-outline-info mt-2 mb-2\" value=\"Set counter\">\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Pages\Counter.razor"
       
    class Input
    {
        [DataType("int")]
        [Range(0, int.MaxValue)]
        public int CounterValue { get; set; }
    }
    Input input;

    private int currentCount = 0;

    protected override void OnInitialized()
    {
        input = new Input();
    }

    private void IncrementCount()
    {
        currentCount++;
    }

    private void SetCounter()

    {
        currentCount = input.CounterValue;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorApp1.Pages.Counter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591