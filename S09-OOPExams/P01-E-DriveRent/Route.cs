using System;
using System.Collections.Generic;
using System.Text;

namespace P01_E_DriveRent
{
    public class Route
    {
        private string startPoint;
        private string endPoint;
        private double length;
        private int routeId;
        private bool isLocked = false;

        public Route(string startPoint, string endPoint, double length, int routeId)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.Length = length;
            this.RouteId = routeId;
        }

        public string StartPoint
        {
            get { return startPoint; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("StartPoint cannot be null or whitespace!");
                }
                startPoint = value;
            }
        }
        public string EndPoint
        {
            get { return endPoint; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("EndPoint cannot be null or whitespace!");
                }
                endPoint = value;
            }
        }
        public double Length
        {
            get { return length; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Length cannot be less than 1 kilometer.");
                }
                length = value;
            }
        }
        public int RouteId { get => routeId; private set => routeId = value; }
        public bool IsLocked { get => isLocked; set => isLocked = value; }
        public void LockRoute()
        {
            this.isLocked = true;
        }
    }
}
