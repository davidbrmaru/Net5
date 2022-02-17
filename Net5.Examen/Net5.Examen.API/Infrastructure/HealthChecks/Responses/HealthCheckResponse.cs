﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Net5.Examen.API.Infrastructure.HealthChecks.Responses
{
    public class HealthCheckResponse
    {
        public string Status { get; set; }
        public IEnumerable<IndividualHealthCheckResponse> HealthChecks { get; set; }
        public TimeSpan HealthCheckDuration { get; set; }
    }
}
