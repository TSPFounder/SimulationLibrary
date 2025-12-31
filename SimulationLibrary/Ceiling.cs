using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class Ceiling 
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
        //
        //  Dimensions
        private Point _Location;
        private CAD_Dimension _Height;
        private CAD_Dimension _Length;
        private CAD_Dimension _Width;
        //
        //  Owned & Owning Objects
        //
        //  Walls
        private Wall _CurrentWall;
        private List<Wall> _MyWalls;
        //
        //  Floor
        private Ceiling _MyFloor;
        //
        //  Trusses
        private Truss _CurrentTruss;
        private List<Truss> _MyTrusses;
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
        //  CEILING CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public Ceiling()
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
        //
        //  Dimensions
        public CAD_Dimension Length
        {
            set => _Length = value;
            get
            {
                return _Length;
            }
        }
        public CAD_Dimension Width
        {
            set => _Width = value;
            get
            {
                return _Width;
            }
        }
        public CAD_Dimension Height
        {
            set => _Height = value;
            get
            {
                return _Height;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Walls
        public Wall CurrentWall
        {
            set => _CurrentWall = value;
            get
            {
                return _CurrentWall;
            }
        }
        public List<Wall> MyWalls
        {
            set => _MyWalls = value;
            get
            {
                return _MyWalls;
            }
        }
        //
        //  Floor
        public Ceiling MyFloor
        {
            set => _MyFloor = value;
            get
            {
                return _MyFloor;
            }
        }
        //
        //  Trusses
        public Truss CurrentTruss
        {
            set => _CurrentTruss = value;
            get
            {
                return _CurrentTruss;
            }
        }
        public List<Truss> MyTrusses
        {
            set => _MyTrusses = value;
            get
            {
                return _MyTrusses;
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
