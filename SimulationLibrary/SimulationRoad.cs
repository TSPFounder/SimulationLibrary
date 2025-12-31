using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class SimulationRoad : SimulationModelElement
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
        private CAD_Dimension _RoadWidth;
        private CAD_Parameter _NumberOfLanes;
        private Point _StartPoint;
        //
        //  Owned & Owning Objects
        //
        
        //
        //  Path
        private ThreeDGeometry _MyPath;
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

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SIMULATIONROAD CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimulationRoad() 
        {
            //  Model Category
            this.MySimType = SimElementTypeEnum.SimulationRoad;
            //
            //  Lists
            
            
            //
            //  My Singular Objects
            this.MyPath = new ThreeDGeometry();
            

            
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        #region
        //  
        //  Identification

        //
        //  Data
        public CAD_Dimension RoadWidth
        {
            set => _RoadWidth = value;
            get
            {
                return _RoadWidth;
            }
        }
        public CAD_Parameter NumberOfLanes
        {
            set => _NumberOfLanes = value;
            get
            {
                return _NumberOfLanes;
            }
        }
        public Point StartPoint
        {
            set => _StartPoint = value;
            get
            {
                return _StartPoint;
            }
        }
        //
        //  Owned & Owning Objects
        
        //
        //  Path
        public ThreeDGeometry MyPath
        {
            set => _MyPath = value;
            get
            {
                return _MyPath;
            }
        }
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
