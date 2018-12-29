﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class ConstHelper
    {
        public static readonly double FontSize = 20.0;
        public static readonly string DefaultSavePath = @".\Save\";
        public static readonly string DefaultSaveFile = "save.dll";
        public static readonly int MinPeriod = 2000;
        public static readonly int DefaultSimilarity = 70;
    }
    public enum WindowMessage
    {
        None = 0x000,

        KeyDown = 0x100,
        KeyUp,
        Char,

        SysKeyDown = 0x104,
        SysKeyUp,

        SysCommand = 0x112,


        LButtonDown = 0x201,
        LButtonUp,
        LButtonDoubleClick,
        RButtonDown,
        RButtonUp,
        RButtonDoubleClick
    }
}
