#pragma checksum "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca077d51242c7c6f52dcd0aed14f21dff1b4cfc5"
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
#line 2 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
using Blazorme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
using StBarnabasHospiceTable.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
using StBarnabasHospiceTable.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
using StBarnabasHospiceTable.Client.Pages.SessionState;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/barnabas")]
    public partial class StBarnabas : StBarnabasBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p></p>\r\n");
            __builder.AddMarkupContent(1, @"<style>
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
</style>

");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid border border-primary");
            __builder.AddAttribute(4, "style", "text-align:center; width: 100%; height:600px");
            __builder.OpenComponent<Blazorme.Split>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorme.SplitPane>(7);
                __builder2.AddAttribute(8, "SizeInPercentage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                     33

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "MinSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 33 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                  0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorme.Split>(11);
                    __builder3.AddAttribute(12, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorme.SplitDirection>(
#nullable restore
#line 34 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                               SplitDirection.Vertical

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "GutterSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                    5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<StBarnabasHospiceTable.Client.Pages.ButtonTemplate>(15);
                        __builder4.AddComponentReferenceCapture(16, (__value) => {
#nullable restore
#line 35 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                      buttonOne = (StBarnabasHospiceTable.Client.Pages.ButtonTemplate)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Blazorme.SplitPane>(18);
                __builder2.AddAttribute(19, "SizeInPercentage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                     33

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "MinSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 38 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                  0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorme.Split>(22);
                    __builder3.AddAttribute(23, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorme.SplitDirection>(
#nullable restore
#line 39 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                               SplitDirection.Vertical

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "GutterSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                    5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorme.SplitPane>(26);
                        __builder4.AddAttribute(27, "MinSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 40 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                    0

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 41 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                     if (displayButton == true)
                    {
                        buttonCount = 3;

#line default
#line hidden
#nullable disable
                            __builder5.OpenElement(29, "div");
                            __builder5.AddAttribute(30, "class", "container-pane");
                            __builder5.OpenElement(31, "a");
                            __builder5.AddAttribute(32, "id", "threePane");
                            __builder5.AddAttribute(33, "class", "oi oi-plus btn button1");
                            __builder5.AddAttribute(34, "aria-hidden", "true");
                            __builder5.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                                                          ShowPopup

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(36, "style", "border-radius:35%; padding:50px");
                            __builder5.CloseElement();
                            __builder5.CloseElement();
#nullable restore
#line 47 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                    }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n                ");
                        __builder4.OpenComponent<Blazorme.SplitPane>(38);
                        __builder4.AddAttribute(39, "MinSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 49 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                    0

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 50 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                     if (displayButton == true)
                    {
                        buttonCount = 4;

#line default
#line hidden
#nullable disable
                            __builder5.OpenElement(41, "div");
                            __builder5.AddAttribute(42, "class", "container-pane");
                            __builder5.OpenElement(43, "a");
                            __builder5.AddAttribute(44, "id", "fourPane");
                            __builder5.AddAttribute(45, "class", "oi oi-plus btn button1");
                            __builder5.AddAttribute(46, "aria-hidden", "true");
                            __builder5.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                                                         ShowPopup

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(48, "style", "border-radius:35%; padding:50px");
                            __builder5.CloseElement();
                            __builder5.CloseElement();
#nullable restore
#line 56 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                    }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenComponent<Blazorme.SplitPane>(50);
                __builder2.AddAttribute(51, "SizeInPercentage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 60 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                     33

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "MinSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 60 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                  0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorme.Split>(54);
                    __builder3.AddAttribute(55, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorme.SplitDirection>(
#nullable restore
#line 61 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                               SplitDirection.Vertical

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "GutterSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 61 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                    5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorme.SplitPane>(58);
                        __builder4.AddAttribute(59, "MinSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 62 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                    0

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 63 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                     if (displayButton == true)
                    {
                        buttonCount = 5;

#line default
#line hidden
#nullable disable
                            __builder5.OpenElement(61, "div");
                            __builder5.AddAttribute(62, "class", "container-pane");
                            __builder5.OpenElement(63, "a");
                            __builder5.AddAttribute(64, "id", "fivePane");
                            __builder5.AddAttribute(65, "class", "oi oi-plus btn button1");
                            __builder5.AddAttribute(66, "aria-hidden", "true");
                            __builder5.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                                                         ShowPopup

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(68, "style", "border-radius:35%; padding:50px");
                            __builder5.CloseElement();
                            __builder5.CloseElement();
#nullable restore
#line 69 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                    }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(69, "\r\n                ");
                        __builder4.OpenComponent<Blazorme.SplitPane>(70);
                        __builder4.AddAttribute(71, "MinSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 71 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                    0

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(73, "div");
                            __builder5.AddAttribute(74, "class", "container-pane");
                            __builder5.OpenElement(75, "a");
                            __builder5.AddAttribute(76, "id", "sixPane");
                            __builder5.AddAttribute(77, "class", "oi oi-plus btn button1");
                            __builder5.AddAttribute(78, "aria-hidden", "true");
                            __builder5.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                                                    ShowPopup

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(80, "style", "border-radius:35%; padding:50px");
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
 if (imagePopup == true)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "modal");
            __builder.AddAttribute(83, "tabindex", "-1");
            __builder.AddAttribute(84, "style", "display:block");
            __builder.AddAttribute(85, "role", "dialog");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "modal-dialog");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "modal-content");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "modal-header");
            __builder.AddMarkupContent(92, "<h3 class=\"modal-title\">Select image </h3>\r\n                    \r\n                    ");
            __builder.OpenElement(93, "a");
            __builder.AddAttribute(94, "type", "button");
            __builder.AddAttribute(95, "class", "close oi oi-circle-x");
            __builder.AddAttribute(96, "aria-hidden", "true");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                                               ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "modal-body");
            __builder.OpenElement(101, "select");
            __builder.AddAttribute(102, "class", "form-control selectpicker");
            __builder.OpenElement(103, "option");
            __builder.AddContent(104, "--Select--");
            __builder.CloseElement();
#nullable restore
#line 95 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                         foreach (var item in Items)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(105, "option");
            __builder.AddAttribute(106, "value", 
#nullable restore
#line 97 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                            item.ItemId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(107, 
#nullable restore
#line 97 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                          item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 98 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "modal-footer");
            __builder.AddAttribute(111, "style", "text-align:center");
            __builder.OpenElement(112, "a");
            __builder.AddAttribute(113, "type", "button");
            __builder.AddAttribute(114, "class", "oi oi-circle-check");
            __builder.AddAttribute(115, "aria-hidden", "true");
            __builder.AddAttribute(116, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                                             EventHandleSelect

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(117, " Select ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 107 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
       
    /// <summary>
    /// Global variables
    /// </summary>
    [Inject]
    public IItemDataService itemService { get; set; }
    public List<Item> Items { get; set; } = new List<Item>();

    /// <summary>
    /// Popup code
    /// </summary>
    bool imagePopup = false;
    bool displayButton = true;

    void CloseButton()
    {
        displayButton = false;
    }
    void ShowButton()
    {
        displayButton = true;
    }

    void ClosePopup()
    {
        imagePopup = false;
    }
    void ShowPopup()
    {
        imagePopup = true;
    }

    void EventHandleSelect()
    {
        ClosePopup();
        CloseButton();
    }

    /// <summary>
    /// Button / Session State  code
    /// </summary>
    //Have display button1, button2, button3, button4...
    //OR
    //Figure out a reference id type for each button
    int buttonCount = 0;
    public int Count { get; set; }
    //PWD:: Research
    private ButtonTemplate buttonOne;
    private void buttonCounting()
    {
        //Session State management calls the GetCurrentCount method for the current count
        //int buttonCount = CounterState.GetCurrentCount();
        //Set the current count to the button value
        buttonOne.ButtonOneValue();
        //...
        //Set Current count on the Session State object
        //CounterState.UpdateCurrentCount(buttonCount);
    }

    /// <summary>
    /// Rendering code
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        ClosePopup();
        ShowButton();
        Items = (await itemService.GetAllItems()).ToList();

        if (Count != 0)
        {
            Items = Items.Take(Count).ToList();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
