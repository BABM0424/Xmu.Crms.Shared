﻿namespace Xmu.Crms.Shared.Models
{
    public class FixGroupMember
    {
        public int Id { get; set; }

        public FixGroup FixGroup { get; set; }

        public Student Student { get; set; }
    }
}