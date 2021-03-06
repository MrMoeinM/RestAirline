﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestAirline.Booking.Api.HyperMedia;
using RestAirline.Booking.Api.Controllers;

namespace RestAirline.Booking.Api.Resources.Booking.Journey
{
    public class SelectJourneysCommand : HyperMedia.HypermediaCommand<JourneysSelectedResource>
    {
        public SelectJourneysCommand()
        {
            JourneyIds = new List<string>();
        }

        public SelectJourneysCommand(IUrlHelper urlHelper) : base(urlHelper.Link((BookingController c) => c.SelectJourneys(null)))
        {
        }
        
        public List<string> JourneyIds { get; set; }
    }
}