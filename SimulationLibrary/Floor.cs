using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class Floor 
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
        private CAD_Dimension _Length;
        private CAD_Dimension _Width;
        private CAD_Dimension _Thickness;
        //
        //  Owned & Owning Objects
        //
        //  Owned & Owning Objects
        private SimulationBuilding _MyBuilding;
        //
        //  Walls
        private Wall _CurrentWall;
        private List<Wall> _MyWalls;
        //
        //  Ceiling
        private Ceiling _MyCeiling;
        //
        //  Joists
        private Beam _CurrentJoist;
        private List<Beam> _MyJoists;
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
        //  FLOOR CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public Floor()
        {
            
            this.MyTrusses = new List<Truss>();
            this.MyWalls = new List<Wall>();
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
        public CAD_Dimension Thickness
        {
            set => _Thickness = value;
            get
            {
                return _Thickness;
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
        //  Ceiling
        public Ceiling MyCeiling
        {
            set => _MyCeiling = value;
            get
            {
                return _MyCeiling;
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
