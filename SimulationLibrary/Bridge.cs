using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class Bridge :SimulationModelElement
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
        //  Location
        private Point _Location;
        //
        //  Dimensions
        private CAD_Dimension _Height;
        private CAD_Dimension _Length;
        private CAD_Dimension _Width;
        //
        //  Owned & Owning Objects
        //
        //  My Road
        private SimulationRoad _MyRoad;
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
        //  BRIDGE CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public Bridge()
        {
            //  Model Category
            this.MySimType = SimElementTypeEnum.SimulationStructure;
            //
            //  Lists
           
            this.MyTrusses = new List<Truss>();
            

            // 
            //  My Singular Objects
            this.MyRoad = new SimulationRoad();
            
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
        //  Position & Orientation
        public Point Location
        {
            set => _Location = value;
            get
            {
                return _Location;
            }
        }
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
        //  My Road
        public SimulationRoad MyRoad
        {
            set => _MyRoad = value;
            get
            {
                return _MyRoad;
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
