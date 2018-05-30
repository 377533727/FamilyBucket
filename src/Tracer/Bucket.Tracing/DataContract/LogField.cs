﻿using MessagePack;

namespace Bucket.Tracing.DataContract
{
    [MessagePackObject]
    public class LogField
    {
        [Key(0)]
        public string Key { get; set; }

        [Key(1)]
        public string Value { get; set; }
    }
}