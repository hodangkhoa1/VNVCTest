using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNVC_Client
{
    public class CustomButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        public int BorderSize 
        { 
            get => borderSize;
            set 
            {
                borderSize = value;
                this.Invalidate();
            } 
        }

        public int BorderRadius 
        { 
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor 
        { 
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        private GraphicsPath GetFigurePath(Rectangle rectangle, float radius)
        {
            GraphicsPath graphicsPath = new();
            float curveSize = radius * 2F;

            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.X, rectangle.Y, curveSize, curveSize, 180, 90);
            graphicsPath.AddArc(rectangle.Right - curveSize, rectangle.Y, curveSize, curveSize, 270, 90);
            graphicsPath.AddArc(rectangle.Right - curveSize, rectangle.Bottom - curveSize, curveSize, curveSize, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Bottom - curveSize, curveSize, curveSize, 90, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;

            if (borderSize > 0)
            {
                smoothSize = borderSize;
            }

            if (borderRadius > 2)
            {
                using GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius);
                using GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize);
                using Pen penSurface = new(this.Parent.BackColor, smoothSize);
                using Pen penBorder = new(borderColor, borderSize);
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                this.Region = new Region(pathSurface);

                pevent.Graphics.DrawPath(penSurface, pathSurface);

                if (borderSize >= 1)
                {
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;

                this.Region = new Region(rectSurface);

                if (borderSize >= 1)
                {
                    using Pen penBorder = new(borderColor, borderSize);
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(ContainerBackColorChanged);
        }

        private void ContainerBackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
