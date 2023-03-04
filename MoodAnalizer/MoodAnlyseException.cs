﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalizer
{
    public class MoodAnlyseException:Exception
    {
        public enum MoodAnlyseExceptionType
        {
            NullMood,
            EmptyMood
        }
        public MoodAnlyseExceptionType Type;
        public MoodAnlyseException(MoodAnlyseExceptionType Type,string message):base(message) 
        {
            this.Type = Type;
        }
    }
}
