﻿using System;

namespace WFM.Models.Store
{
    public partial class BusinessProcessState
    {
        public class ActionToDo
        {
            public Guid Id { get; internal set; }
            public string Name { get; internal set; }
            public DateTime Estimated { get; internal set; }
        }
    }
}
