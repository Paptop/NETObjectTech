﻿using System;
using System.Collections.Generic;
using System.Text;
using Task5.Classic.Visitors;

namespace Task5.Classic.Components
{
    public abstract class Node
    {
        public abstract void Accept(IVisitor visitor);
    }
}