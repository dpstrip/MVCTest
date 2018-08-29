using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApplication.ViewModels
{
    public class FileUploadViewModel:BaseViewModel
    {
        public HttpPostedFileBase fileUpload { get; set; }
    }
}