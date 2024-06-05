﻿using Core.DataAccess;
using Domain.Enums;

namespace Domain.Entities
{
    public class Appointment : Entity
    {
        public DateTime AppointmentDate { get; set; }
        public AppointmentStatus AppointmentStatus { get; set; }
        public int PatientId { get; set; }
        public virtual User Patient { get; set; }
        public int DoctorId { get; set; }
        public virtual User Doctor { get; set; }
    }
}
