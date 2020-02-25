﻿using System.Drawing;

namespace GUI
{
    public class VertexData
    {
        public VertexType VertexType { get; set; }
        public PointF Location { get; set; }

        public VertexData(PointF location, VertexType type = VertexType.Junction)
        {
            Location = location;
            VertexType = type;
        }
    }
}
