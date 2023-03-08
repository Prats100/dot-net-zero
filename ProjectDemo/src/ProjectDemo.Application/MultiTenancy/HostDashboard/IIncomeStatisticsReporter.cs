using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectDemo.MultiTenancy.HostDashboard.Dto;

namespace ProjectDemo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}