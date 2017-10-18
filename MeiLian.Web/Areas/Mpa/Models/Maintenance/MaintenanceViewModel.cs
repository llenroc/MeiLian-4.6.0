using System.Collections.Generic;
using MeiLian.Caching.Dto;

namespace MeiLian.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}
