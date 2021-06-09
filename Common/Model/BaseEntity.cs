using System;

namespace Common.Model
{
    public abstract class BaseEntity
    {
        public long  ID { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}