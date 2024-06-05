﻿using Core.DataAccess;
using Domain.Enums;

namespace Domain.Entities
{
    public class PatientReport : Entity
    {
        public ReportTitle ReportTitle { get; set; }
        public string ReportDetails { get; set; }
        public int PatientId { get; set; }
        public virtual User Patient { get; set; }
        public int DoctorId { get; set; }
        public virtual User Doctor { get; set; }
        public int AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}
