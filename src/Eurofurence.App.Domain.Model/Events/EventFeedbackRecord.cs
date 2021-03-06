﻿using System;
using System.Runtime.Serialization;

namespace Eurofurence.App.Domain.Model.Events
{
    [DataContract]
    public class EventFeedbackRecord : EntityBase
    {
        [DataMember]
        public Guid EventId { get; set; }

        [DataMember]
        public string AuthorUid { get; set; }

        [DataMember]
        public int Rating { get; set; }

        [DataMember]
        public bool ForwardToPanelist { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}