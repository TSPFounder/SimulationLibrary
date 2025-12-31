using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class StairCase 
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
        private Boolean _IsEscalator;
        private StairCaseTypeEnum _StairCaseType;
        //
        //  Owned & Owning Objects
        private SimulationBuilding _MyBuilding;
        //
        //  Stairs
        private Stair _CurrentStair;
        private List<Stair> _MyStairs;
        //
        //  Waypoints
        private Waypoint _CurrentWaypoint;
        private List<Waypoint> _MyWayPoints;
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
        public enum StairCaseTypeEnum
        {
            Straight = 0,
            Curved,
            Spiral,
            UShaped,
            LShaped,
            Split,
            Bifurcated,
            Floating,
            Circular,
            Switchback,
            QuarterTurn,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  STAIRCASE    CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public StairCase()
        {

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
        public Boolean IsEscalator
        {
            set => _IsEscalator = value;
            get { return _IsEscalator; }
        }
        public StairCaseTypeEnum StairCaseType
        {
            set => _StairCaseType = value;
            get { return _StairCaseType; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Stairs
        public Stair CurrentStair
        {
            set => _CurrentStair = value;
            get { return _CurrentStair; }
        }
        public List<Stair> MyStairs
        {
            set => _MyStairs = value;
            get { return _MyStairs; }
        }
        //
        //  Waypoints
        public Waypoint CurrentWaypoint
        {
            set => _CurrentWaypoint = value;
            get
            {
                return _CurrentWaypoint;
            }
        }
        public List<Waypoint> MyWayPoints
        {
            set => _MyWayPoints = value;
            get
            {
                return _MyWayPoints;
            }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region

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
