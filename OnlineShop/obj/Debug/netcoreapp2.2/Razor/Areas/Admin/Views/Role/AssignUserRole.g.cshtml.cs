#pragma checksum "E:\Web Development 2019\Working Project 2020\OnlineShop\OnlineShop\Areas\Admin\Views\Role\AssignUserRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0000ac7fff54c5fb564c4c7089fb6a10e2614b10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role_AssignUserRole), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/AssignUserRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Role/AssignUserRole.cshtml", typeof(AspNetCore.Areas_Admin_Views_Role_AssignUserRole))]
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
#line 1 "E:\Web Development 2019\Working Project 2020\OnlineShop\OnlineShop\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#line 2 "E:\Web Development 2019\Working Project 2020\OnlineShop\OnlineShop\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0000ac7fff54c5fb564c4c7089fb6a10e2614b10", @"/Areas/Admin/Views/Role/AssignUserRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0824ae1f492899eab3f51cf62adf20c585e54e98", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Role_AssignUserRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Web Development 2019\Working Project 2020\OnlineShop\OnlineShop\Areas\Admin\Views\Role\AssignUserRole.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(38, 120, true);
            WriteLiteral("\n<br />\n<br />\n<div class=\"row\">\n    <div class=\"col-6\">\n        <h2 class=\"text-info\">Assign User Role</h2>\n    </div>\n");
            EndContext();
            BeginContext(307, 205, true);
            WriteLiteral("</div>\n<br />\n<div>\n    <table class=\"table table-striped border\">\n        <tr class=\"table-info\">\n            <th>\n               User Name\n            </th>\n\n            <th>Role Name</th>\n        </tr>\n");
            EndContext();
#line 25 "E:\Web Development 2019\Working Project 2020\OnlineShop\OnlineShop\Areas\Admin\Views\Role\AssignUserRole.cshtml"
         foreach (var item in ViewBag.UserRoles)
        {

#line default
#line hidden
            BeginContext(571, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(609, 13, false);
#line 28 "E:\Web Development 2019\Working Project 2020\OnlineShop\OnlineShop\Areas\Admin\Views\Role\AssignUserRole.cshtml"
               Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(622, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(649, 13, false);
#line 29 "E:\Web Development 2019\Working Project 2020\OnlineShop\OnlineShop\Areas\Admin\Views\Role\AssignUserRole.cshtml"
               Write(item.RoleName);

#line default
#line hidden
            EndContext();
            BeginContext(662, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
            BeginContext(1302, 18, true);
            WriteLiteral("            </tr>\n");
            EndContext();
#line 42 "E:\Web Development 2019\Working Project 2020\OnlineShop\OnlineShop\Areas\Admin\Views\Role\AssignUserRole.cshtml"
        }

#line default
#line hidden
            BeginContext(1330, 21, true);
            WriteLiteral("    </table>\n</div>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1368, 174, true);
                WriteLiteral("\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/alertify.min.js\"></script>\n    <script type=\"text/javascript\">\n        $(function(){\n            var save = \'");
                EndContext();
                BeginContext(1543, 16, false);
#line 50 "E:\Web Development 2019\Working Project 2020\OnlineShop\OnlineShop\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
                EndContext();
                BeginContext(1559, 107, true);
                WriteLiteral("\'\n            if(save!=\'\') {\n                alertify.success(save);\n            }\n            var edit = \'");
                EndContext();
                BeginContext(1667, 16, false);
#line 54 "E:\Web Development 2019\Working Project 2020\OnlineShop\OnlineShop\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
                EndContext();
                BeginContext(1683, 106, true);
                WriteLiteral("\'\n            if(edit!=\'\') {\n                alertify.success(edit);\n            }\n            var del = \'");
                EndContext();
                BeginContext(1790, 18, false);
#line 58 "E:\Web Development 2019\Working Project 2020\OnlineShop\OnlineShop\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                  Write(TempData["delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(1808, 105, true);
                WriteLiteral("\'\n            if (del!=\'\') {\n                alertify.error(del);\n            }\n        })\n    </script>\n");
                EndContext();
            }
            );
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
