#pragma checksum "C:\Users\GHERAA\DevOps\webapp\PollinateV2.0\PollinateV2.0\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c61effd79e8216a0085aba58213646fa614a5380"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PollinateV2._0.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
namespace PollinateV2._0.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\GHERAA\DevOps\webapp\PollinateV2.0\PollinateV2.0\Pages\_ViewImports.cshtml"
using PollinateV2._0;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c61effd79e8216a0085aba58213646fa614a5380", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23352a645d80bd7dd6d41e1080dd8ed0ecfbf708", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Contact</h3>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\GHERAA\DevOps\webapp\PollinateV2.0\PollinateV2.0\Pages\Contact.cshtml"
 if(Model.hasData)
 {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Hello ");
#nullable restore
#line 9 "C:\Users\GHERAA\DevOps\webapp\PollinateV2.0\PollinateV2.0\Pages\Contact.cshtml"
        Write(Model.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\GHERAA\DevOps\webapp\PollinateV2.0\PollinateV2.0\Pages\Contact.cshtml"
                         Write(Model.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>We received message:</p>\r\n    <p>");
#nullable restore
#line 11 "C:\Users\GHERAA\DevOps\webapp\PollinateV2.0\PollinateV2.0\Pages\Contact.cshtml"
  Write(Model.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\GHERAA\DevOps\webapp\PollinateV2.0\PollinateV2.0\Pages\Contact.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container""
    <from method=""POST"">
        <label for=""fname"">First Name</label><br />
        <input type=""text"" id=""fname"" name=""firstname"" /> <br />



        <label for=""lname"">Last Name</label><br />
        <input type=""text"" id=""lname"" name=""lastname"" /> <br />


        <label for=""message"">Message</label><br />
        <textarea id=""message"" name=""message"" style=""height:200px""></textarea><br />


        <input type=""submit"" value=""Submit""

    </from>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PollinateV2._0.Pages.ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PollinateV2._0.Pages.ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PollinateV2._0.Pages.ContactModel>)PageContext?.ViewData;
        public PollinateV2._0.Pages.ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
