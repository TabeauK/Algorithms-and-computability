using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace TAIO
{
    public class Rotation
    {
        public List<(int x, int y)> Fields { get; private set; }

        public Rotation(params (int x, int y)[] fields)
        {
            Fields = new List<(int x, int y)>();
            foreach(var elem in fields)
            {
                Fields.Add(elem);
            }
        }
    }
}
