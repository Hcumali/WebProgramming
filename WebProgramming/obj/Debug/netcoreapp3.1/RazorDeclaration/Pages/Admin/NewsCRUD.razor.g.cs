// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebProgramming.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Pages\Admin\NewsCRUD.razor"
using WebProgramming.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/news")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class NewsCRUD : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Pages\Admin\NewsCRUD.razor"
       
    private List<News> news = new List<News>();

    protected async override Task OnInitializedAsync()
    {
        using (NewsDbContext context = new NewsDbContext())
        {
            news = await context.News.ToListAsync();
        }
        await base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
