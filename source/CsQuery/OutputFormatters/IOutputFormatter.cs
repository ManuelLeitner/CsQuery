﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CsQuery
{
    public interface IOutputFormatter
    {
        void Format(CQ selection,TextWriter writer);
    }
}
