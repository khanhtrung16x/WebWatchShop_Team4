#pragma checksum "F:\ASP.NET-WatchShopMVC\ASP.NET-WatchShopMVC\PesonalShopSolution\Areas\Admin\Views\Home\Notification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88c8ff0ad1440549763f3d5ec7db42ab68e325a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Notification), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Notification.cshtml")]
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
#nullable restore
#line 1 "F:\ASP.NET-WatchShopMVC\ASP.NET-WatchShopMVC\PesonalShopSolution\Areas\Admin\Views\_ViewImports.cshtml"
using PesonalShopSolution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ASP.NET-WatchShopMVC\ASP.NET-WatchShopMVC\PesonalShopSolution\Areas\Admin\Views\_ViewImports.cshtml"
using PesonalShopSolution.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c8ff0ad1440549763f3d5ec7db42ab68e325a9", @"/Areas/Admin/Views/Home/Notification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3859016ee4e29c557f36286aa234b8a8a3e8511", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Notification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""content"">
    <div class=""container-fluid"">
        <div class=""card"">
            <div class=""card-header card-header-primary"">
                <h3 class=""card-title"">Notifications</h3>
                <p class=""card-category"">
                    Handcrafted by our friend
                    <a target=""_blank"" href=""https://github.com/mouse0270"">Robert McIntosh</a>. Please checkout the
                    <a href=""http://bootstrap-notify.remabledesigns.com/"" target=""_blank"">full documentation.</a>
                </p>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <h4 class=""card-title"">Notifications Style</h4>
                        <div class=""alert alert-info"">
                            <span>This is a plain notification</span>
                        </div>
                        <div class=""alert alert-info"">
                            <button type=""button"" cl");
            WriteLiteral(@"ass=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <i class=""material-icons"">close</i>
                            </button>
                            <span>This is a notification with close button.</span>
                        </div>
                        <div class=""alert alert-info alert-with-icon"" data-notify=""container"">
                            <i class=""material-icons"" data-notify=""icon"">add_alert</i>
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <i class=""material-icons"">close</i>
                            </button>
                            <span data-notify=""message"">This is a notification with close button and icon.</span>
                        </div>
                        <div class=""alert alert-info alert-with-icon"" data-notify=""container"">
                            <i class=""material-icons"" data-notify=""icon"">add_alert</i>
                 ");
            WriteLiteral(@"           <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <i class=""material-icons"">close</i>
                            </button>
                            <span data-notify=""message"">This is a notification with close button and icon and have many lines. You can see that the icon and the close button are always vertically aligned. This is a beautiful notification. So you don't have to worry about the style.</span>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <h4 class=""card-title"">Notification states</h4>
                        <div class=""alert alert-info"">
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <i class=""material-icons"">close</i>
                            </button>
                            <span>
                                <b> Info - </b> This ");
            WriteLiteral(@"is a regular notification made with "".alert-info""
                            </span>
                        </div>
                        <div class=""alert alert-success"">
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <i class=""material-icons"">close</i>
                            </button>
                            <span>
                                <b> Success - </b> This is a regular notification made with "".alert-success""
                            </span>
                        </div>
                        <div class=""alert alert-warning"">
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <i class=""material-icons"">close</i>
                            </button>
                            <span>
                                <b> Warning - </b> This is a regular notification made with "".alert-warning");
            WriteLiteral(@"""
                            </span>
                        </div>
                        <div class=""alert alert-danger"">
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <i class=""material-icons"">close</i>
                            </button>
                            <span>
                                <b> Danger - </b> This is a regular notification made with "".alert-danger""
                            </span>
                        </div>
                        <div class=""alert alert-primary"">
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <i class=""material-icons"">close</i>
                            </button>
                            <span>
                                <b> Primary - </b> This is a regular notification made with "".alert-primary""
                            </span>
           ");
            WriteLiteral(@"             </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-12"">
                <div class=""places-buttons"">
                    <div class=""row"">
                        <div class=""col-md-6 ml-auto mr-auto text-center"">
                            <h4 class=""card-title"">
                                Notifications Places
                                <p class=""category"">Click to view notifications</p>
                            </h4>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-lg-8 col-md-10 ml-auto mr-auto"">
                            <div class=""row"">
                                <div class=""col-md-4"">
                                    <button class=""btn btn-primary btn-block"" onclick=""md.showNotification('top','left')"">Top Left</button>
                                </div>
                                <div class=""col-m");
            WriteLiteral(@"d-4"">
                                    <button class=""btn btn-primary btn-block"" onclick=""md.showNotification('top','center')"">Top Center</button>
                                </div>
                                <div class=""col-md-4"">
                                    <button class=""btn btn-primary btn-block"" onclick=""md.showNotification('top','right')"">Top Right</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-lg-8 col-md-10 ml-auto mr-auto"">
                            <div class=""row"">
                                <div class=""col-md-4"">
                                    <button class=""btn btn-primary btn-block"" onclick=""md.showNotification('bottom','left')"">Bottom Left</button>
                                </div>
                                <div class=""col-md-4"">
                                    <b");
            WriteLiteral(@"utton class=""btn btn-primary btn-block"" onclick=""md.showNotification('bottom','center')"">Bottom Center</button>
                                </div>
                                <div class=""col-md-4"">
                                    <button class=""btn btn-primary btn-block"" onclick=""md.showNotification('bottom','right')"">Bottom Right</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
