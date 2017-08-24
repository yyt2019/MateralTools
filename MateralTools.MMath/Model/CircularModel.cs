﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MateralTools.MMath
{
    public class CircularModel
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="P">圆心点</param>
        /// <param name="R">半径</param>
        public CircularModel(Point P, double R)
        {
            Central = P;
            Radius = R;
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="P">圆心点</param>
        /// <param name="R">半径</param>
        public CircularModel(double X, double Y, double R)
        {
            Central = new Point(X, Y);
            Radius = R;
        }
        /// <summary>
        /// 圆心
        /// </summary>
        public Point Central { get; set; }
        /// <summary>
        /// 半径
        /// </summary>
        public double Radius { get; set; }
        /// <summary>
        /// 周长
        /// </summary>
        public double Perimeter
        {
            get
            {
                return Math.PI * Radius * 2;
            }
        }
        /// <summary>
        /// 面积
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
    }
}