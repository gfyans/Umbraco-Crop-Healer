using System;
using System.Linq;
using System.Web.Http;

using Umbraco.Core;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace Our.Umbraco.CropHealer.Controllers
{
    [PluginController("CropHealer")]
    [IsBackOffice]
    public class CropHealerApiController : UmbracoApiController
    {
        [HttpGet]
        public bool RunCropHealer()
        {
            var dts = ApplicationContext.Services.DataTypeService;

            CropHealer.SeekAndHeal(dts.GetDataTypeDefinitionByControlId(new Guid(Constants.PropertyEditors.ImageCropper)).FirstOrDefault(), dts);

            return true;
        }
    }
}