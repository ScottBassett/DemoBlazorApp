#pragma checksum "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ed07f9e58907548a3d25637b6f25c459931c42f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemoUi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Training\BlazorDemoApp\BlazorDemoUi\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Training\BlazorDemoApp\BlazorDemoUi\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Training\BlazorDemoApp\BlazorDemoUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Training\BlazorDemoApp\BlazorDemoUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Training\BlazorDemoApp\BlazorDemoUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Training\BlazorDemoApp\BlazorDemoUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Training\BlazorDemoApp\BlazorDemoUi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Training\BlazorDemoApp\BlazorDemoUi\_Imports.razor"
using BlazorDemoUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Training\BlazorDemoApp\BlazorDemoUi\_Imports.razor"
using BlazorDemoUi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
using DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
using BlazorDemoUi.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/People")]
    public partial class People : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>People Page test</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>Insert New Person</h4>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
                  _newPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
                                              InsertPerson

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "firstName");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
                                           _newPerson.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _newPerson.FirstName = __value, _newPerson.FirstName))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _newPerson.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "id", "lastName");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
                                          _newPerson.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _newPerson.LastName = __value, _newPerson.LastName))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _newPerson.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "email");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
                                       _newPerson.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _newPerson.Email = __value, _newPerson.Email))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _newPerson.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n    \r\n    ");
                __builder2.AddMarkupContent(29, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n\r\n");
            __builder.AddMarkupContent(31, "<h4>Current People</h4>\r\n\r\n");
#nullable restore
#line 25 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
 if (_people is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "    ");
            __builder.AddMarkupContent(33, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 30 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "    ");
            __builder.OpenElement(35, "table");
            __builder.AddAttribute(36, "class", "table table-striped");
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.AddMarkupContent(38, "<thead>\r\n        <tr>\r\n            <th>First Name</th>\r\n            <th>Last Name</th>\r\n            <th>Email</th>\r\n        </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(39, "tbody");
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 42 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
         foreach (var person in _people)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "            ");
            __builder.OpenElement(42, "tr");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 45 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
                     person.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 46 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
                     person.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 47 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
                     person.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "td");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
                                        () => DeletePerson(person)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "class", "btn btn-danger");
            __builder.AddContent(57, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 50 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 53 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
       
    private List<Person> _people;
    private DisplayPersonModel _newPerson = new DisplayPersonModel();

    protected override async Task OnInitializedAsync() =>
        _people = await _db.GetPeople();

    private async Task InsertPerson()
    {
        var p = new Person
        {
            FirstName = _newPerson.FirstName,
            LastName = _newPerson.LastName,
            Email = _newPerson.Email
        };

        await _db.InsertPerson(p);

        _people.Add(p);

        _newPerson = new DisplayPersonModel();
    }

    private async Task DeletePerson(Person p)
    {
        
        await _db.DeletePerson(p);

        _people.Remove(p);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleRepository _db { get; set; }
    }
}
#pragma warning restore 1591