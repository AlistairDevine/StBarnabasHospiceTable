#pragma checksum "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ButtonTemplate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea27009240d0a0ed672409a98cd8a33992d6e09c"
// <auto-generated/>
#pragma warning disable 1591
namespace StBarnabasHospiceTable.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using StBarnabasHospiceTable.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using StBarnabasHospiceTable.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ButtonTemplate.razor"
using Blazorme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ButtonTemplate.razor"
using StBarnabasHospiceTable.Client.Pages.SessionState;

#line default
#line hidden
#nullable disable
    public partial class ButtonTemplate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ButtonTemplate.razor"
 for (int i = 0; i < 2; i++)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazorme.SplitPane>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "<div class=\"container-pane\"><a class=\"oi oi-plus btn button1\" aria-hidden=\"true\" style=\"border-radius:35%; padding:50px\"></a></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ButtonTemplate.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, @"<style>
    a.button1 {
        border: 0.1em solid #000000;
        border-radius: 0.12em;
        box-sizing: border-box;
        color: #000000;
    }

        a.button1:hover {
            color: #FFFFFF;
            background-color: #000000;
        }

    .container-pane {
        padding: 70px 0;
        vertical-align: middle
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ButtonTemplate.razor"
       
    bool displayButton = true;
    int buttonCount = 0;

    public void ButtonOneValue()
    {
        buttonCount = 1;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
