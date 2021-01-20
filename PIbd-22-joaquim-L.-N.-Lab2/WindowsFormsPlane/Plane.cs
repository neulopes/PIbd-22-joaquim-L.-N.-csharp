﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    public class Plane : Vehicle
    {
        protected readonly int planeWidth = 90;      
        protected readonly int planeHeight = 50;

        public Plane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
       
        protected Plane(int maxSpeed, float weight, Color mainColor, int planeWidth, int planeHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.planeWidth = planeWidth;
            this.planeHeight = planeHeight;
        }
       
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth - 120)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight - 90)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Blue);
            Brush planeBody = new SolidBrush(MainColor);

            g.DrawRectangle(pen, _startPosX + 20, _startPosY + 40, 110, 40);
            g.DrawRectangle(pen, _startPosX + 20, _startPosY + 50, 110, 20);
            g.DrawEllipse(pen, _startPosX + 20, _startPosY + 40, 15, 30);
            g.DrawEllipse(pen, _startPosX + 50, _startPosY + 50, 15, 30);
            g.DrawEllipse(pen, _startPosX + 80, _startPosY + 40, 15, 30);
            g.DrawEllipse(pen, _startPosX + 110, _startPosY + 50, 15, 30);
            g.DrawEllipse(pen, _startPosX + 140, _startPosY + 40, 15, 30);

            // Inside
            Brush brSilver = new SolidBrush(Color.Silver);
            g.FillRectangle(brSilver, _startPosX + 20, _startPosY + 40, 110, 41);
            g.FillEllipse(planeBody, _startPosX + 110, _startPosY + 39, 91, 42);
            g.FillEllipse(planeBody, _startPosX + 110, _startPosY + 40, 90, 40);

            // side
            g.DrawRectangle(pen, _startPosX + 35, _startPosY + 20, 15, 20);
            g.DrawRectangle(pen, _startPosX + 35, _startPosY + 80, 15, 20);
            g.DrawRectangle(pen, _startPosX + 130, _startPosY + 15, 20, 25);
            g.DrawRectangle(pen, _startPosX + 130, _startPosY + 80, 20, 25);

            g.FillRectangle(planeBody, _startPosX + 35, _startPosY + 20, 15, 20);
            g.FillRectangle(planeBody, _startPosX + 35, _startPosY + 80, 15, 20);
            g.FillRectangle(planeBody, _startPosX + 130, _startPosY + 15, 20, 25);
            g.FillRectangle(planeBody, _startPosX + 130, _startPosY + 80, 20, 25);

            Brush brSkyBlue = new SolidBrush(Color.SkyBlue);
            g.FillEllipse(brSkyBlue, _startPosX + 20, _startPosY + 40, 15, 30);
            g.FillEllipse(brSkyBlue, _startPosX + 50, _startPosY + 50, 15, 30);
            g.FillEllipse(brSkyBlue, _startPosX + 80, _startPosY + 40, 15, 30);
            g.FillEllipse(brSkyBlue, _startPosX + 110, _startPosY + 50, 15, 30);
            g.FillEllipse(brSkyBlue, _startPosX + 140, _startPosY + 40, 15, 30);

            //стекла
            g.DrawEllipse(pen, _startPosX + 164, _startPosY + 54, 25, 12);
            Brush brIvory = new SolidBrush(Color.Ivory);
            g.FillEllipse(brIvory, _startPosX + 164, _startPosY + 54, 25, 12);

            // frente
            g.DrawEllipse(pen, _startPosX + 199, _startPosY + 60, 4, 3);
            Brush brLawnGreen = new SolidBrush(Color.LawnGreen);
            g.FillEllipse(brLawnGreen, _startPosX + 199, _startPosY + 60, 4, 3);

            // back
            g.DrawRectangle(pen, _startPosX + 18, _startPosY + 45, 2, 10);
            g.DrawRectangle(pen, _startPosX + 18, _startPosY + 55, 2, 10);
            g.DrawRectangle(pen, _startPosX + 18, _startPosY + 65, 2, 10);

            g.FillRectangle(brLawnGreen, _startPosX + 18, _startPosY + 45, 2, 9);
            g.FillRectangle(brLawnGreen, _startPosX + 18, _startPosY + 55, 2, 10);
            g.FillRectangle(brLawnGreen, _startPosX + 18, _startPosY + 65, 2, 11);
        }
    }
}
