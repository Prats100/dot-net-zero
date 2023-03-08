using System.Collections.Generic;
using ProjectDemo.Caching.Dto;

namespace ProjectDemo.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}