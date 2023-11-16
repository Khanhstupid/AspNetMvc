## Controller 
- la 1 lop ke thua tu thu vien AspnetcoreMvc
- Action trong controller la 1 phuong thuc public ko static
- Action co  the tra ve bat ky kieu du lieu nao pho bien la IActionResult
- Cac dich vu inject vao controller qua ham tao
## View
- La file.cshtml
- View cho Action luu tai : /View/ControllerName/ActionName.cshtml
- Them thu muc luu tru View :
builder.Services.Configure<RazorViewEngineOptions>(options => {

    // Tìm thêm View ở /MyView/ControllerName/ActionName.cshtml
    options.ViewLocationFormats.Add("/MyView/{1}/{0}" + RazorViewEngine.ViewExtension);

});
## Truyen du lieu sang View
- Model
- ViewData
- ViewBag
- TempData