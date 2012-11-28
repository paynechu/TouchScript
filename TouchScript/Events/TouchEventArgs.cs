﻿/*
 * Copyright (C) 2012 Interactive Lab
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the 
 * 
 */

using System;
using System.Collections.Generic;

namespace TouchScript.Events {
    /// <summary>
    /// Touch event arguments
    /// </summary>
    public class TouchEventArgs : EventArgs {
        public List<TouchPoint> TouchPoints;

        public TouchEventArgs(List<TouchPoint> touchPoints) {
            TouchPoints = touchPoints;
        }
    }
}