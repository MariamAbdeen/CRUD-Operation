#pragma checksum "D:\Backend\Export Projects\Youmna\CRUD-Operations-Systems\Demo.PL\Views\Account\CheckYourInbox.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1ec5697c80074c977e7626e6fd21c6b603cc8ee722b0d9695e27f5ea86e4b2c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CheckYourInbox), @"mvc.1.0.view", @"/Views/Account/CheckYourInbox.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Backend\Export Projects\Youmna\CRUD-Operations-Systems\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Backend\Export Projects\Youmna\CRUD-Operations-Systems\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Backend\Export Projects\Youmna\CRUD-Operations-Systems\Demo.PL\Views\_ViewImports.cshtml"
using Demo.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Backend\Export Projects\Youmna\CRUD-Operations-Systems\Demo.PL\Views\_ViewImports.cshtml"
using Demo.BLL.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ec5697c80074c977e7626e6fd21c6b603cc8ee722b0d9695e27f5ea86e4b2c5", @"/Views/Account/CheckYourInbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1e786825d51b3443bc6a0b2c44f929e99f546286acca1ed705df153b886cc412", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_CheckYourInbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Backend\Export Projects\Youmna\CRUD-Operations-Systems\Demo.PL\Views\Account\CheckYourInbox.cshtml"
  
    ViewData["Title"] = "Check Your Inbox";
    Layout = "~/Views/Shared/_AuthLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-agileinfo"">
	<div class=""agileits-top"">
        <div class=""body"">
            <div>
                <p>Passoword reset link has been sent to your Email. Pleasw check your inbox</p>
            </div>
            <div>
                <a href=""https://mail.google.com/mail/u/0/#inbox"">Your Inbox</a>
            </div>
        </div>
	</div>
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
