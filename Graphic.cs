using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;
using SkiaSharp.Views.Desktop;

namespace CSAssessment2
{
    public partial class frmGraphic : Form
    {

        private SKControl skControl;
        public frmGraphic()
        {
            InitializeComponent();
            //Initialize the instance of SKControl class
            skControl = new SKControl { Dock = DockStyle.Fill };
            //Event controller to paint the form
            skControl.PaintSurface += frmGraphic_Paint;
            Controls.Add(skControl);
        }

        private void frmGraphic_Paint(object sender, SKPaintSurfaceEventArgs e)
        {
            SKCanvas canvas = e.Surface.Canvas;
            canvas.Clear(SKColors.White);

            // Draw the house base
            var housePaint = new SKPaint
            {
                Color = new SKColor(255,228,204),
                IsAntialias = true,
                Style = SKPaintStyle.Fill
            };
            canvas.DrawRect(new SKRect(250, 150, 500, 300), housePaint);

            var garagePaint = new SKPaint
            {
                Color = new SKColor(224, 224, 224),
                IsAntialias = true,
                Style = SKPaintStyle.Fill
            };
            canvas.DrawRect(new SKRect(100, 150, 250, 300), garagePaint);

            // Draw the roof
            var roofPaint = new SKPaint
            {
                Color = new SKColor(128, 128, 128),
                IsAntialias = true,
                Style = SKPaintStyle.Fill
            };
            var roofPath = new SKPath();
            roofPath.MoveTo(100, 150);
            roofPath.LineTo(175, 50);
            roofPath.LineTo(250, 150);
            roofPath.LineTo(375, 30);
            roofPath.LineTo(500, 150);
            roofPath.Close();
            canvas.DrawPath(roofPath, roofPaint);

            // Draw the door
            var doorPaint = new SKPaint
            {
                Color = new SKColor(181, 112, 51),
                IsAntialias = true,
                Style = SKPaintStyle.Fill
            };
            var doorPath = new SKPath();
            doorPath.MoveTo(275, 300); 
            doorPath.LineTo(275, 225);
            doorPath.ArcTo(25,25,0,SKPathArcSize.Small,SKPathDirection.Clockwise, 350, 225); 
            doorPath.LineTo(350, 300);
            doorPath.Close();
            canvas.DrawPath(doorPath, doorPaint);

            //Draw the doorknob
            var doorknobPaint = new SKPaint
            {
                Color = SKColors.Yellow,
                IsAntialias = true,
                Style = SKPaintStyle.Fill
            };
            canvas.DrawCircle(285,263,5,doorknobPaint);


            // Draw the window
            var windowPaint = new SKPaint
            {
                Color = SKColors.White,
                IsAntialias = true,
                Style = SKPaintStyle.Fill
            };
            canvas.DrawRect(new SKRect(400, 200, 475, 275), windowPaint);

            // Draw the garage
            var garagedoorPaint = new SKPaint
            {
                Color = new SKColor(192,192,192),
                IsAntialias = true,
                Style = SKPaintStyle.Fill
            };
            canvas.DrawRect(new SKRect(125, 175, 225, 300), garagedoorPaint);
            var garagedoorlinePaint = new SKPaint
            {
                Color = new SKColor(170, 170, 170),
                IsAntialias = true,
                Style = SKPaintStyle.Stroke,
                StrokeWidth = 2,
                StrokeCap = SKStrokeCap.Round
            };
            var garagedoorlinePath = new SKPath();
            float startX = 125, endX = 205, startY = 200, waveHeight = 10, waveLength = 20;

            for (float y = startY; y <= 290; y += 20) // Draw multiple wavy lines
            {
                garagedoorlinePath.MoveTo(startX, y);
                for (float x = startX; x <= endX; x += waveLength)
                {
                    float controlX = x + waveLength / 2;
                    float controlY = y + (y % (waveHeight * 2) == 0 ? waveHeight : -waveHeight);
                    garagedoorlinePath.QuadTo(controlX, controlY, x + waveLength, y);
                }
            }
            canvas.DrawPath(garagedoorlinePath,garagedoorlinePaint);

            // Draw the drive way
            var drivewayPaint = new SKPaint
            { 
                Color = new SKColor(244,244,244),
                IsAntialias = true,
                Style = SKPaintStyle.Fill,
            };
            var drivewayPath = new SKPath();
            drivewayPath.MoveTo(50, 440);
            drivewayPath.LineTo(100, 300);
            drivewayPath.LineTo(250, 300);
            drivewayPath.LineTo(215, 440);
            drivewayPath.Close();
            canvas.DrawPath(drivewayPath, drivewayPaint);

            //Draw the garden
            var gardenPaint = new SKPaint
            {
                Color = new SKColor(129, 164, 136),
                IsAntialias = true,
                Style = SKPaintStyle.Fill,
            };
            var gardenPath = new SKPath();
            gardenPath.MoveTo(215, 440);
            gardenPath.LineTo(250, 300);
            gardenPath.LineTo(500, 300);
            gardenPath.LineTo(475, 440);
            gardenPath.Close();
            canvas.DrawPath(gardenPath, gardenPaint);
        }

        private void btnExit_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
