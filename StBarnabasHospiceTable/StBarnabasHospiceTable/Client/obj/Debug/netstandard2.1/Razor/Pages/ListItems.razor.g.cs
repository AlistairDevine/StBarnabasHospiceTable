#pragma checksum "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cbe098c4068e03e881ca49ddbea1ee5f04648b4"
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
#line 1 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using StBarnabasHospiceTable.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using StBarnabasHospiceTable.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using StBarnabasHospiceTable.Client.Pages.SessionState;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Blazorme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
using StBarnabasHospiceTable.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
using StBarnabasHospiceTable.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listitem")]
    public partial class ListItems : ListItemsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "items");
            __builder.AddAttribute(2, "class", "widget");
            __builder.AddMarkupContent(3, "\r\n    \r\n    ");
            __builder.OpenElement(4, "h3");
            __builder.AddAttribute(5, "style", "margin-bottom: 10px;");
            __builder.AddContent(6, "Items");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "type", "submit");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                                                          AddItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "class", "btn btn-primary edit-btn float-right");
            __builder.AddContent(11, "Add PNG Item");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    \r\n    ");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table table-bordered");
            __builder.AddAttribute(15, "style", "width:90%;");
            __builder.AddMarkupContent(16, "\r\n        \r\n        ");
            __builder.AddMarkupContent(17, "<thead>\r\n            <tr>\r\n                <th scope=\"col\">Item Name</th>\r\n                <th scope=\"col\">Description</th>\r\n                \r\n                <th scope=\"col\">Image</th>\r\n            </tr>\r\n        </thead>\r\n        \r\n        ");
            __builder.OpenElement(18, "tbody");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 27 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
             foreach (var item in Items)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 30 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 31 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                         item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "img");
            __builder.AddAttribute(31, "src", 
#nullable restore
#line 32 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                   item.Image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 34 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.AddContent(39, 
#nullable restore
#line 38 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
         Message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 41 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
 if (ShowPopup == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "    \r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "modal");
            __builder.AddAttribute(46, "tabindex", "-1");
            __builder.AddAttribute(47, "style", "display:block");
            __builder.AddAttribute(48, "role", "dialog");
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "modal-dialog");
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "modal-content");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "modal-header");
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.AddMarkupContent(59, "<h3 class=\"modal-title\">Add item</h3>\r\n                    \r\n                    ");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "type", "button");
            __builder.AddAttribute(62, "class", "close");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                                                  ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.AddMarkupContent(65, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                \r\n                ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "modal-body");
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(71);
            __builder.AddAttribute(72, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 56 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                      HRItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 56 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                                              HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(75, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(76);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(78);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                        ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group row");
                __builder2.AddMarkupContent(82, "\r\n                            ");
                __builder2.AddMarkupContent(83, "<label for=\"name\" class=\"col-sm-3\">Name: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(84);
                __builder2.AddAttribute(85, "id", "name");
                __builder2.AddAttribute(86, "class", "form-control col-sm-8");
                __builder2.AddAttribute(87, "placeholder", "Enter Item Name");
                __builder2.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                                                                             HRItem.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HRItem.Name = __value, HRItem.Name))));
                __builder2.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HRItem.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                        ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group row");
                __builder2.AddMarkupContent(95, "\r\n                            ");
                __builder2.AddMarkupContent(96, "<label for=\"name\" class=\"col-sm-3\">Description: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(97);
                __builder2.AddAttribute(98, "id", "description");
                __builder2.AddAttribute(99, "class", "form-control col-sm-8");
                __builder2.AddAttribute(100, "placeholder", "Enter Item Description");
                __builder2.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                                                                                        HRItem.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HRItem.Description = __value, HRItem.Description))));
                __builder2.AddAttribute(103, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HRItem.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n                        ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "form-group row");
                __builder2.AddMarkupContent(108, "\r\n                            ");
                __builder2.AddMarkupContent(109, "<label for=\"name\" class=\"col-sm-3\">Image Link: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(110);
                __builder2.AddAttribute(111, "id", "image");
                __builder2.AddAttribute(112, "class", "form-control col-sm-8");
                __builder2.AddAttribute(113, "placeholder", "Enter Item Image Link");
                __builder2.AddAttribute(114, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                                                                              HRItem.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HRItem.Image = __value, HRItem.Image))));
                __builder2.AddAttribute(116, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HRItem.Image));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(117, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                        ");
                __builder2.AddMarkupContent(119, "<button type=\"submit\" class=\"btn btn-primary edit-btn\">Add Item</button>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(120, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n");
#nullable restore
#line 77 "C:\Users\Dvine\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IItemDataService itemService { get; set; }
    }
}
#pragma warning restore 1591
