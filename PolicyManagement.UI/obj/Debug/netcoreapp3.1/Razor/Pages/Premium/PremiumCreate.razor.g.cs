#pragma checksum "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6da3d870e65b163d05446508d994ebabf642c9d"
// <auto-generated/>
#pragma warning disable 1591
namespace PolicyManagement.UI.Pages.Premium
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\_Imports.razor"
using PolicyManagement.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\_Imports.razor"
using PolicyManagement.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\_Imports.razor"
using PolicyManagement.UI.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreatePremium/")]
    public partial class PremiumCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "height:500px;overflow-y:scroll");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                          policyRequestModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                                              HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "<h3>Create Premium</h3>\r\n            <hr>\r\n            ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddMarkupContent(9, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n                    First Name :\r\n                </label>\r\n                ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-sm-5");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "firstName");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                            policyRequestModel.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => policyRequestModel.FirstName = __value, policyRequestModel.FirstName))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => policyRequestModel.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group row");
                __builder2.AddMarkupContent(21, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n                    Last Name :\r\n                </label>\r\n                ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col-sm-5");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "id", "lastName");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                            policyRequestModel.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => policyRequestModel.LastName = __value, policyRequestModel.LastName))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => policyRequestModel.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group row");
                __builder2.AddMarkupContent(33, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n                    Phone Number :\r\n                </label>\r\n                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-sm-5");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "id", "email");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                            policyRequestModel.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => policyRequestModel.PhoneNumber = __value, policyRequestModel.PhoneNumber))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => policyRequestModel.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group row");
                __builder2.AddMarkupContent(45, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n                    Date Of Birth :\r\n                </label>\r\n                ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-sm-5");
                __Blazor.PolicyManagement.UI.Pages.Premium.PremiumCreate.TypeInference.CreateInputDate_0(__builder2, 48, 49, "birthdate", 50, "form-control col-sm-8", 51, "Enter birthdate", 52, 
#nullable restore
#line 39 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                            policyRequestModel.DateOfBirth

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => policyRequestModel.DateOfBirth = __value, policyRequestModel.DateOfBirth)), 54, () => policyRequestModel.DateOfBirth);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group row");
                __builder2.AddMarkupContent(58, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n                    Registration:\r\n                </label>\r\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-sm-5");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "id", "email");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                            policyRequestModel.RegistrationNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => policyRequestModel.RegistrationNumber = __value, policyRequestModel.RegistrationNumber))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => policyRequestModel.RegistrationNumber));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-group row");
                __builder2.AddMarkupContent(70, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n                    Car Model\r\n                </label>\r\n                ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "col-sm-5");
                __builder2.OpenElement(73, "select");
                __builder2.AddAttribute(74, "class", "custom-select my-1 mr-sm-2 input-field font-xs");
                __builder2.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                                                                              OnCarModelSelect

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "id", "RequestType");
                __builder2.AddAttribute(77, "required", true);
                __builder2.OpenElement(78, "option");
                __builder2.AddAttribute(79, "value", true);
                __builder2.AddAttribute(80, "disabled", true);
                __builder2.AddAttribute(81, "hidden", true);
                __builder2.AddAttribute(82, "selected", true);
                __builder2.AddMarkupContent(83, "\r\n                            Select Vehicle Make\r\n                        ");
                __builder2.CloseElement();
#nullable restore
#line 61 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                         foreach (var mod in modelMakes)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(84, "option");
                __builder2.AddAttribute(85, "value", 
#nullable restore
#line 63 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                            mod.CardMake

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(86, 
#nullable restore
#line 63 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                                           mod.CardMake

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 64 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n\r\n            ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group d-flex align-items-end mt-4 font-sm");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "col-lg-8 px-0 d-flex align-items-center flex-wrap");
                __builder2.AddMarkupContent(92, "<div class=\"col-lg-4 px-0\"><label for class=\" mb-0\">Vehicle Model:</label></div>\r\n                    ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "px-0 col-lg-7");
                __builder2.OpenElement(95, "p");
                __builder2.AddAttribute(96, "class", "mb-0");
                __builder2.AddContent(97, 
#nullable restore
#line 75 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                         policyRequestModel.CarModel

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n            ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group row");
                __builder2.AddMarkupContent(101, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n                    Car Body Type\r\n                </label>\r\n                ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col-sm-5");
                __builder2.OpenElement(104, "select");
                __builder2.AddAttribute(105, "class", "custom-select my-1 mr-sm-2 input-field font-xs");
                __builder2.AddAttribute(106, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                                                                              OnPremiumTypeSelect

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(107, "id", "RequestType");
                __builder2.AddAttribute(108, "required", true);
                __builder2.OpenElement(109, "option");
                __builder2.AddAttribute(110, "value", true);
                __builder2.AddAttribute(111, "disabled", true);
                __builder2.AddAttribute(112, "hidden", true);
                __builder2.AddAttribute(113, "selected", true);
                __builder2.AddMarkupContent(114, "\r\n                            Select Premium Type\r\n                        ");
                __builder2.CloseElement();
#nullable restore
#line 89 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                         foreach (var mod in premiumTypes)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(115, "option");
                __builder2.AddAttribute(116, "value", 
#nullable restore
#line 91 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                            mod.PremType

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(117, 
#nullable restore
#line 91 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                                           mod.PremType

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 92 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n            ");
                __builder2.OpenElement(119, "div");
                __builder2.AddAttribute(120, "class", "form-group d-flex align-items-end mt-4 font-sm");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "col-lg-8 px-0 d-flex align-items-center flex-wrap");
                __builder2.AddMarkupContent(123, "<div class=\"col-lg-4 px-0\"><label for class=\" mb-0\">Premium Rate:</label></div>\r\n                    ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "px-0 col-lg-7");
                __builder2.OpenElement(126, "p");
                __builder2.AddAttribute(127, "class", "mb-0");
                __builder2.AddContent(128, 
#nullable restore
#line 102 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                         policyRequestModel.Premium

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n\r\n            ");
                __builder2.AddMarkupContent(130, "<button type=\"submit\" class=\"btn btn-primary edit-btn\">Create Premium</button>\r\n            ");
                __builder2.OpenElement(131, "a");
                __builder2.AddAttribute(132, "class", "btn btn-outline-primary edit-outline-btn");
                __builder2.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
                                                                           NavigateToOverview

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(134, "Cancel");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Users\okosodor\source\repos\VehicleThirdPartyPolicyManagement\PolicyManagement.UI\Pages\Premium\PremiumCreate.razor"
      
    void OnCarModelSelect(ChangeEventArgs e)
    {
        policyRequestModel.CardMake = modelMakes.Where(x => x.CardMake == e.Value.ToString()).Select(x => x.CardMake).FirstOrDefault();
        policyRequestModel.CarModel = modelMakes.Where(x => x.CardMake == e.Value.ToString()).Select(x => x.CarModel).FirstOrDefault();
    }
    void @OnPremiumTypeSelect(ChangeEventArgs e)
    {
        policyRequestModel.PremType = premiumTypes.Where(x => x.PremType == e.Value.ToString()).Select(x => x.PremType).FirstOrDefault();
        policyRequestModel.Premium = premiumTypes.Where(x => x.PremType == e.Value.ToString()).Select(x => x.Premium).FirstOrDefault();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.PolicyManagement.UI.Pages.Premium.PremiumCreate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
