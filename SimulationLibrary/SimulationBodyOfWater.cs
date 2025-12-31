using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;


namespace Simulation
{
    public class SimulationBodyOfWater : SimulationModelElement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification

        //
        //  Data
        private BodyOfWaterTypeEnum _BodyOfWaterType;
        //
        //  Owned & Owning Objects
        //
        //  Waypoints
        //private Waypoint _CurrentWaypoint;
        //private List<Waypoint> _MyWayPoints;
        #endregion
        //  *****************************************************************************************


        //  ****************************************************************************************
        //  INITIALIZATIONS
        //
        //  ************************************************************
        #region

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ENUMERATIONS
        //
        //  ************************************************************
        #region
        public enum BodyOfWaterTypeEnum
        {
            Ocean = 0,
            River,
            Stream,
            Lake,
            Pond,
            Pool,
            Creek,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SIMULATIONBODYOFWATER CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimulationBodyOfWater()
        {
            //  Model Category
            this.MySimType = SimElementTypeEnum.SimulationBodyOfWater;
            //
            //  Lists
            
            
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        #region
        //
        //  Data
        public BodyOfWaterTypeEnum BodyOfWaterType
        {
            set => _BodyOfWaterType = value;
            get
            {
                return _BodyOfWaterType;
            }
        }
        //
        //  Owned & Owning Objects
        
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region
        //
        //  Set the Position
        public Vector SetPosition(Point startPoint, Point endPoint)
        {
            if (this.MyPosition == null)
            {
                this.MyPosition = new Vector(startPoint, endPoint);
            }
            else
            {
                this.MyPosition.StartPoint = startPoint;
                this.MyPosition.EndPoint = endPoint;
            }
            return this.MyPosition;
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************
        #region

        #endregion
        //  *****************************************************************************************
    }
}
