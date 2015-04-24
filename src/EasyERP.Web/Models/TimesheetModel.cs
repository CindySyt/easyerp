﻿namespace EasyERP.Web.Models
{
    using EasyERP.Web.Framework.Mvc;
    using Infrastructure.Domain.Model;

    public class TimesheetModel : BaseModel
    {
        public int Id { get; set; }

        public string DateOfWeek { get; set; }

        public string EmployeeName { get; set; }

        public double Mon { get; set; }

        public double Tue { get; set; }

        public double Wed { get; set; }

        public double Thu { get; set; }

        public double Fri { get; set; }

        public double Sat { get; set; }

        public double Sun { get; set; }
    }
}