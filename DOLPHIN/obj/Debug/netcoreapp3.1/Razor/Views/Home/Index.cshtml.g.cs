#pragma checksum "C:\Users\minht\Desktop\Project_Ql\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23bd1f06b03ec871d68756aeef3b29478437e8f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\minht\Desktop\Project_Ql\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\_ViewImports.cshtml"
using DOLPHIN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\minht\Desktop\Project_Ql\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\_ViewImports.cshtml"
using DOLPHIN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23bd1f06b03ec871d68756aeef3b29478437e8f0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe1b367f9a07c07c313aef6d4d41b9edc5f731", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\minht\Desktop\Project_Ql\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-info"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 16 "C:\Users\minht\Desktop\Project_Ql\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\Home\Index.cshtml"
                       Write(ViewBag.ToTrinhIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        <p>S??? l?????ng t??? tr??nh qu???n l??</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-bag""></i>
                    </div>
                    <a href=""/ToTrinh/Index"" class=""small-box-footer"">Chi ti???t <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-success"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 31 "C:\Users\minht\Desktop\Project_Ql\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\Home\Index.cshtml"
                       Write(ViewBag.CongTrinhKhaiThacIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<sup style=""font-size: 20px"">up</sup></h3>

                        <p>S??? l?????ng c??ng tr??nh khai th??c</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-stats-bars""></i>
                    </div>
                    <a href=""/CongTrinhKhaiThac/Index"" class=""small-box-footer"">Chi ti???t <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-warning"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 46 "C:\Users\minht\Desktop\Project_Ql\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\Home\Index.cshtml"
                       Write(ViewBag.CanBoQuanLyIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        <p>C??n b??? qu???n l??</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-person-add""></i>
                    </div>
                    <a href=""/CanBo/Index"" class=""small-box-footer"">Chi ti???t <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-danger"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 61 "C:\Users\minht\Desktop\Project_Ql\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\Home\Index.cshtml"
                       Write(ViewBag.GiaHanIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        <p>S??? gia h???n</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-pie-graph""></i>
                    </div>
                    <a href=""/SoGiaHan/Index"" class=""small-box-footer"">Chi ti???t <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->
        <div class=""row"">
            <!-- Left col -->
            <section class=""col-lg-7 connectedSortable"">
                <!-- Custom tabs (Charts with tabs)-->
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            <i class=""fas fa-chart-pie mr-1""></i>
                            Bi???u ????? th???ng k?? d??? ??n khai th??c n??m 2021
                        </h3>
                        <div class=""card-tools"">
                            ");
            WriteLiteral(@"<ul class=""nav nav-pills ml-auto"">
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" href=""#revenue-chart"" data-toggle=""tab"">Export</a>
                                </li>
                            </ul>
                        </div>
                    </div><!-- /.card-header -->
                    <div class=""card-body"">
                        <div class=""tab-content p-0"">
                            <!-- Morris chart - Sales -->
                            <div class=""chart tab-pane active"" id=""revenue-chart"" style=""position: relative; height: 300px;"">
                                <canvas id=""revenue-chart-canvas"" height=""300"" style=""height: 300px;""></canvas>
                            </div>
                            <div class=""chart tab-pane"" id=""sales-chart"" style=""position: relative; height: 300px;"">
                                <canvas id=""sales-chart-canvas"" height=""300"" style=""height: 300px;""></canvas>");
            WriteLiteral(@"
                            </div>
                        </div>
                    </div><!-- /.card-body -->
                </div>
                <!-- /.card -->
                <!-- TO DO List -->
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            <i class=""ion ion-clipboard mr-1""></i>
                            C??ng vi???c c???n tri???n khai
                        </h3>

                        <div class=""card-tools"">
                            <ul class=""pagination pagination-sm"">
                                <li class=""page-item""><a href=""#"" class=""page-link"">&laquo;</a></li>
                                <li class=""page-item""><a href=""#"" class=""page-link"">1</a></li>
                                <li class=""page-item""><a href=""#"" class=""page-link"">2</a></li>
                                <li class=""page-item""><a href=""#"" class=""page-link"">3</a></li>
                  ");
            WriteLiteral(@"              <li class=""page-item""><a href=""#"" class=""page-link"">&raquo;</a></li>
                            </ul>
                        </div>
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body"">
                        <ul class=""todo-list"" data-widget=""todo-list"">
                            <li>
                                <!-- drag handle -->
                                <span class=""handle"">
                                    <i class=""fas fa-ellipsis-v""></i>
                                    <i class=""fas fa-ellipsis-v""></i>
                                </span>
                                <!-- checkbox -->
                                <div class=""icheck-primary d-inline ml-2"">
                                    <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 6351, "\"", 6359, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo1"" id=""todoCheck1"">
                                    <label for=""todoCheck1""></label>
                                </div>
                                <!-- todo text -->
                                <span class=""text"">Th???ng k?? d??? ??n 2020</span>
                                <!-- Emphasis label -->
                                <small class=""badge badge-danger""><i class=""far fa-clock""></i> 2 mins</small>
                                <!-- General tools such as edit or delete-->
                                <div class=""tools"">
                                    <i class=""fas fa-edit""></i>
                                    <i class=""fas fa-trash-o""></i>
                                </div>
                            </li>
                            <li>
                                <span class=""handle"">
                                    <i class=""fas fa-ellipsis-v""></i>
                                    <i class=""fas fa-ellipsis-v""></i>
             ");
            WriteLiteral("                   </span>\r\n                                <div class=\"icheck-primary d-inline ml-2\">\r\n                                    <input type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 7546, "\"", 7554, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo2"" id=""todoCheck2"" checked>
                                    <label for=""todoCheck2""></label>
                                </div>
                                <span class=""text"">H???p giao ban</span>
                                <small class=""badge badge-info""><i class=""far fa-clock""></i> 4 hours</small>
                                <div class=""tools"">
                                    <i class=""fas fa-edit""></i>
                                    <i class=""fas fa-trash-o""></i>
                                </div>
                            </li>
                            <li>
                                <span class=""handle"">
                                    <i class=""fas fa-ellipsis-v""></i>
                                    <i class=""fas fa-ellipsis-v""></i>
                                </span>
                                <div class=""icheck-primary d-inline ml-2"">
                                    <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 8554, "\"", 8562, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo3"" id=""todoCheck3"">
                                    <label for=""todoCheck3""></label>
                                </div>
                                <span class=""text"">Kh???o s??t c??ng tr??nh Th??? D???u 1</span>
                                <small class=""badge badge-warning""><i class=""far fa-clock""></i> 1 day</small>
                                <div class=""tools"">
                                    <i class=""fas fa-edit""></i>
                                    <i class=""fas fa-trash-o""></i>
                                </div>
                            </li>
                            <li>
                                <span class=""handle"">
                                    <i class=""fas fa-ellipsis-v""></i>
                                    <i class=""fas fa-ellipsis-v""></i>
                                </span>
                                <div class=""icheck-primary d-inline ml-2"">
                                    <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 9572, "\"", 9580, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo4"" id=""todoCheck4"">
                                    <label for=""todoCheck4""></label>
                                </div>
                                <span class=""text"">Kh???o s??t c??ng tr??nh XLA1</span>
                                <small class=""badge badge-success""><i class=""far fa-clock""></i> 3 days</small>
                                <div class=""tools"">
                                    <i class=""fas fa-edit""></i>
                                    <i class=""fas fa-trash-o""></i>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <!-- /.card-body -->
                    <div class=""card-footer clearfix"">
                        <button type=""button"" class=""btn btn-info float-right""><i class=""fas fa-plus""></i> Th??m</button>
                    </div>
                </div>
                <!-- /.card -->
            </section>
            <!-- /.Left col -->
    ");
            WriteLiteral(@"        <!-- right col (We are only adding the ID to make the widgets sortable)-->
            <section class=""col-lg-5 connectedSortable"">

                <!-- Calendar -->
                <div class=""card bg-gradient-success"">
                    <div class=""card-header border-0"">

                        <h3 class=""card-title"">
                            <i class=""far fa-calendar-alt""></i>
                            Calendar
                        </h3>
                        <!-- tools card -->
                        <div class=""card-tools"">
                            <!-- button with a dropdown -->
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-success btn-sm dropdown-toggle"" data-toggle=""dropdown""
                                        data-offset=""-52"">
                                    <i class=""fas fa-bars""></i>
                                </button>
                                <div class=""dr");
            WriteLiteral(@"opdown-menu"" role=""menu"">
                                    <a href=""#"" class=""dropdown-item"">Add new event</a>
                                    <a href=""#"" class=""dropdown-item"">Clear events</a>
                                    <div class=""dropdown-divider""></div>
                                    <a href=""#"" class=""dropdown-item"">View calendar</a>
                                </div>
                            </div>
                            <button type=""button"" class=""btn btn-success btn-sm"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-success btn-sm"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                        <!-- /. tools -->
                    </div>
                    <!-- /.card-header -->
            ");
            WriteLiteral(@"        <div class=""card-body pt-0"">
                        <!--The calendar -->
                        <div id=""calendar"" style=""width: 100%""></div>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </section>
            <!-- right col -->
        </div>
        <!-- /.row (main row) -->
    </div><!-- /.container-fluid -->
</section>
<!-- /.content -->
");
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
