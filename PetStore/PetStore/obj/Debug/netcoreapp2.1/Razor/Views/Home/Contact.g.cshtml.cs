#pragma checksum "E:\Programming\ASP.NET\IPD15-2018-ASP.NET\PetStore\PetStore\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df7cf45b4ee48a6cd6b0df9a651761c5ad0cbe56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Programming\ASP.NET\IPD15-2018-ASP.NET\PetStore\PetStore\Views\_ViewImports.cshtml"
using PetStore;

#line default
#line hidden
#line 2 "E:\Programming\ASP.NET\IPD15-2018-ASP.NET\PetStore\PetStore\Views\_ViewImports.cshtml"
using PetStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df7cf45b4ee48a6cd6b0df9a651761c5ad0cbe56", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f074bd498ab3477b7c3a87bf830928496b90bfb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Programming\ASP.NET\IPD15-2018-ASP.NET\PetStore\PetStore\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(48, 17, false);
#line 4 "E:\Programming\ASP.NET\IPD15-2018-ASP.NET\PetStore\PetStore\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(65, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(77, 19, false);
#line 5 "E:\Programming\ASP.NET\IPD15-2018-ASP.NET\PetStore\PetStore\Views\Home\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(96, 357, true);
            WriteLiteral(@"</h3>

<address>
    Pet Store Forever<br />
    Redmond, WA 98052-6399<br />
    <abbr title=""Phone"">P:</abbr>
    425.555.0100
</address>

<address>
    <strong>Career:</strong> <a href=""mailto:Support@example.com"">Career@example.com</a><br />
    <strong>Blog:</strong> <a href=""mailto:Marketing@example.com"">Blog@example.com</a>
</address>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
