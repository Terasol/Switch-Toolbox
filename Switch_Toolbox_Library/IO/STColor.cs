﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Toolbox.Library
{
    //Class that contains colors and useful color related methods
    public class STColor
    {
        public float R { get; set; }
        public float G { get; set; }
        public float B { get; set; }
        public float A { get; set; }

        public float Time { get; set; }

        public Color Color
        {
            get
            {
                int red = Utils.FloatToIntClamp(R);
                int green = Utils.FloatToIntClamp(G);
                int blue = Utils.FloatToIntClamp(B);
                int alpha = Utils.FloatToIntClamp(A);

                return Color.FromArgb(alpha, red, green, blue);
            }
            set
            {
                var color = value;
                R = color.R / 255f;
                G = color.G / 255f;
                B = color.B / 255f;
                A = color.A / 255f;
            }
        }

        public static STColor FromBytes(byte[] color)
        {
            STColor col = new STColor();
            col.R = color[0] / 255f;
            col.G = color[1] / 255f;
            col.B = color[2] / 255f;
            col.A = color[3] / 255f;

            return col;
        }

        public STColor()
        {
            R = 1;
            G = 1;
            B = 1;
            A = 1;
        }

        public override string ToString()
        {
            return String.Format("R:{0} G:{1} B:{2} A:{3}", R, G, B, A);
        }

        public string ToHexString()
        {
            return String.Format("R:{0:X2} G:{1:X2} B:{2:X2} A:{3:X2}", R, G, B, A);
        }
    }
}
