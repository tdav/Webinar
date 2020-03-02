﻿using System.Collections.Generic;
using System.Linq;

namespace Webinar.Utils
{
    public static class CEnumerable
    {
        public static bool IsAny<T>(this IEnumerable<T> data)
        {
            return data != null && data.Any();
        }
    }
}
