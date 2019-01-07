﻿using OpenCvSharp;
using System;
using System.Drawing;
using OpenCvSharp.Extensions;
namespace Macro.Infrastructure
{
    public class OpenCVHelper
    {
        public static int Search(Bitmap source, Bitmap target)
        {
            var sourceMat = BitmapConverter.ToMat(source);
            var targetMat = BitmapConverter.ToMat(target);

            sourceMat.ConvertTo(sourceMat, MatType.CV_8UC4);
            sourceMat.ExtractChannel(1);
            var match = sourceMat.MatchTemplate(targetMat, TemplateMatchModes.CCoeffNormed);

            Cv2.MinMaxLoc(match, out double min, out double max);
            return Convert.ToInt32(max * 100);
        }
    }
}