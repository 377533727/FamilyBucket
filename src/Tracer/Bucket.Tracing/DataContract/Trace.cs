﻿using System.Collections.Generic;
using MessagePack;

namespace Bucket.Tracing.DataContract
{
    [MessagePackObject]
    public class Trace
    {
        [Key(0)]
        public string TraceId { get; set; }

        [Key(1)]
        public List<Span> Spans { get; set; }
    }
}