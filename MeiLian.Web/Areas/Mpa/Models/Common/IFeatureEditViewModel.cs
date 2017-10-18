using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MeiLian.Editions.Dto;

namespace MeiLian.Web.Areas.Mpa.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}
