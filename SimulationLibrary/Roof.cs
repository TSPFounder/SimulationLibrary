using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;
using Structures;

namespace Simulation
{
    public class Roof 
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
        //  Enumerations
        private RoofGeometryTypeEnum _RoofGeometry;
        private RoofMaterialTypeEnum _RoofMaterial;
        //
        //  Dimensions
        private CAD_Dimension _Length;
        private CAD_Dimension _Width;
        private CAD_Dimension _Thickness;
        //
        //  Owned & Owning Objects
        //
        //  My Building
        private SimulationBuilding _MyBuilding;
        //
        //  Shingles
        private BuildingShingle _CurrentShingle;
        private List<BuildingShingle> _MyShingles;
        //
        //  Trusses
        private Truss _CurrentTruss;
        private List<Truss> _MyTrusses;
        //
        //  Purlins
        private Beam _CurrentPurlin;
        private List<Beam> _MyPurlins;

        //
        // Rafters
        private Beam _CurrentRafter;
        private List<Beam> _MyRafters;
        //
        //  Ridge
        private Beam _MyRidge;
        //
        //  Roof Sheets
        private StructuralSheet _CurrentRoofSheet;
        private List<StructuralSheet> _MyRoofSheets;


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
        //
        //  Roof Geometry
        public enum RoofGeometryTypeEnum
        {
            Gabled = 0,
            ClippedGabled,
            DutchGabled,
            Gambrel,
            Hip,
            Mansard,
            Shed,
            Flat,
            Other
        }
        //
        //  Roof Material
        public enum RoofMaterialTypeEnum
        {
            Asphalt = 0,
            Metal,
            SpanishTile,
            Other
        }
        #endregion
            //  *****************************************************************************************


            //  *****************************************************************************************
            //  ROOF CONSTRUCTOR
            //
            //  ************************************************************
            #region
        public Roof()
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
        //  Enumerations
        public RoofGeometryTypeEnum RoofGeometry
        {
            set => _RoofGeometry = value;
            get
            {
                return _RoofGeometry;
            }
        }
        public RoofMaterialTypeEnum RoofMaterial
        {
            set => _RoofMaterial = value;
            get
            {
                return _RoofMaterial;
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
        //  My Building
        public SimulationBuilding MyBuilding
        {
            set => _MyBuilding = value;
            get
            {
                return _MyBuilding;
            }
        }
        //
        //  Shingles
        public BuildingShingle CurrentShingle
        {
            set => _CurrentShingle = value;
            get
            {
                return _CurrentShingle;
            }
        }
       public List<BuildingShingle> MyShingles
        {
            set => _MyShingles = value;
            get
            {
                return _MyShingles;
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
        //
        //  Purlins
        public Beam CurrentPurlin
        {
            set => _CurrentPurlin = value;
            get
            {
                return _CurrentPurlin;
            }
        }
        public List<Beam> MyPurlins
        {
            set => _MyPurlins = value;
            get
            {
                return _MyPurlins;
            }
        }

        //
        // Rafters
        public Beam CurrentRafter
        {
            set => _CurrentRafter = value;
            get
            {
                return _CurrentRafter;
            }
        }
        public List<Beam> MyRafters
        {
            set => _MyRafters = value;
            get
            {
                return _MyRafters;
            }
        }
        //
        //  Ridge
        public Beam MyRidge
        {
            set => _MyRidge = value;
            get
            {
                return _MyRidge;
            }
        }
        //
        //  Roof Sheets
        public StructuralSheet CurrentRoofSheet
        {
            set => _CurrentRoofSheet = value;
            get
            {
                return _CurrentRoofSheet;
            }
        }
        public List<StructuralSheet> MyRoofSheets
        {
            set => _MyRoofSheets = value;
            get
            {
                return _MyRoofSheets;
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
