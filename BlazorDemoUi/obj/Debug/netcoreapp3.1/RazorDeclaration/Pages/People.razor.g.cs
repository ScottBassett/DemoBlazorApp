// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Training\BlazorDemoApp\BlazorDemoUi\Pages\People.razor"
       
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
