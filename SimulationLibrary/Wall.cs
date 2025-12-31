using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class Wall 
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
        //  Booleans
        private Boolean _IsLoadBearing;

        //
        //  Owned & Owning Objects
        //
        // Building
        private SimulationBuilding _MyBuilding;
        //
        //  Structure
        private Beam _Sill;
        private Beam _TopPlate;
        //
        //  Studs
        private Beam _CurrentStud;
        private List<Beam> _MyStuds;
        //
        //  Drywall
        private StructuralSheet _CurrentDrywallSheet;
        private List<StructuralSheet> _MyDrywallSheets;
        //
        //  Windows
        private Window _CurrentWindow;
        private List<Window> _MyWindows;
        //
        //  Wall Sheathing
        private StructuralSheet _CurrentWallSheath;
        private List<StructuralSheet> _MyWallSheathing;
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
        //  WALL CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public Wall()
        {
            this.MyCAD_Models = new List<CAD_Model>();
            this.MyCoordinateSystems = new List<CoordinateSystem>();
            this.MyDrywallSheets = new List<StructuralSheet>();
            this.MyFeatures = new List<CAD_Feature>();
            this.MyStuds = new List<Beam>();
            this.MyWindows = new List<Window>();
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
        //  Booleans
        public Boolean IsLoadBearing
        {
            set => _IsLoadBearing = value;
            get
            {
                return _IsLoadBearing;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Structure
        public Beam Sill
        {
            set => _Sill = value;
            get
            {
                return _Sill;
            }
        }
        public Beam TopPlate
        {
            set => _TopPlate = value;
            get
            {
                return _TopPlate;
            }
        }
        //
        //  Studs
        public Beam CurrentStud
        {
            set => _CurrentStud = value;
            get
            {
                return _CurrentStud;
            }
        }
        public List<Beam> MyStuds
        {
            set => _MyStuds = value;
            get
            {
                return _MyStuds;
            }
        }
        //
        //  Drywall
         public StructuralSheet CurrentDrywallSheet
        {
            set => _CurrentDrywallSheet = value;
            get
            {
                return _CurrentDrywallSheet;
            }
        }
        public List<StructuralSheet> MyDrywallSheets
        {
            set => _MyDrywallSheets = value;
            get
            {
                return _MyDrywallSheets;
            }
        }
        //
        //  Windows
        public Window CurrentWindow
        {
            set => _CurrentWindow = value;
            get
            {
                return _CurrentWindow;
            }
        }
        public List<Window> MyWindows
        {
            set => _MyWindows = value;
            get
            {
                return _MyWindows;
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
