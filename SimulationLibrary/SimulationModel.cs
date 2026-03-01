using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class SimulationModel 
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _Name;
        private String _Version;
        private String _Path;
        //
        //  Data
        private Boolean _IsHDRP;
        private SimModelType _MyModelType;
        private SimModelFileType _MyModelFileType;
        private ModelCategory _MyModelCategory;
        //
        //  Owned & Owning Objects
        //
        //  Models
        private SimulationModel _CurrentChildModel;
        private List<SimulationModel> _MyChildModels;
        //
        //  Simulation Elements
        private SimulationModelElement _CurrentSimElement;
        private List<SimulationModelElement> _MySimElements;
        //
        //  Prefabs
        private SimulationModel _CurrentPrefab;
        private List<SimulationModel> _MyPrefabs;
        
        //
        //  Surfaces
        private CAD_Surface _CurrentCAD_Surface;
        private List<CAD_Surface> _MyCAD_Surfaces;
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
        //  Model Type
        public enum SimModelType
        {
            Simulink = 0,
            Simscape,
            Matlab,
            UnrealEngine,
            Unity,
            Blender,
			Custom,
            Other
        }
        //
        //  Model File Type
        public enum SimModelFileType
        {
            FBX = 0,
            STL,
            STEP,            
            Blender,
			TXT,
			CSV,
            Other
        }
        //
        //  Model Category
        public enum ModelCategory
        {
            Terrain=0,
            Vegetation,
            Animal,
            Person,
            Road,
            BodyOfWater,
            Building,
            Vehicle,
            Machine,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SIMULATIONMODEL CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimulationModel() 
        {
            //this.Application = new ApplicationClass();
            //this.Application.MyType = ApplicationClass.AppTypeEnum.Simulation;
            //
            //  Lists           
            _MyChildModels = new List<SimulationModel>();
            _MySimElements = new List<SimulationModelElement>();            
            _MyPrefabs = new List<SimulationModel>();
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
        //  Name
        public String Name
        {
            set => _Name = value;
            get
            {
                return _Name;
            }
        }
        //
        //  Version
        public String Version
        {
            set => _Version = value;
            get
            {
                return _Version;
            }
        }
        //
        //  Path
        public String Path
        {
            set => _Path = value;
            get
            {
                return _Path;
            }
        }
        //
        //  Data
        //
        //  Is an HDRP Model
        public Boolean IsHDRP
        {
            set => _IsHDRP = value;
            get { return _IsHDRP; }
        }
        //
        //  ModelType
        public SimModelType MyModelType
        {
            set => _MyModelType = value;
            get { return _MyModelType; }
        }
        //
        //  ModelFileType
        public SimModelFileType MyModelFileType
        {
            set => _MyModelFileType = value;
            get { return _MyModelFileType; }
        }
        //
        //  Model Category
        public ModelCategory MyModelCategory
        {
            set => _MyModelCategory = value;
            get { return _MyModelCategory; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Models
        public SimulationModel CurrentChildModel
        {
            set => _CurrentChildModel = value;
            get { return _CurrentChildModel; }
        }
        public List<SimulationModel> MyChildModels
        {
            //set => _MyChildModels = value;
            get { return _MyChildModels; }
        }
        //
        //  Simulation Elements
       public SimulationModelElement CurrentSimElement
        {
            set => _CurrentSimElement = value;
            get { return _CurrentSimElement; }
        }
        public List<SimulationModelElement> MySimElements
        {
            //set => _MySimElements = value;
            get { return _MySimElements; }
        }
        //
        //  Prefabs
        public SimulationModel CurrentPrefab
        {
            set => _CurrentPrefab = value;
            get { return _CurrentPrefab; }
        }
        public List<SimulationModel> MyPrefabs
        {
            //set => _MyPrefabs = value;
            get { return _MyPrefabs; }
        }
        
        //
        //  Surfaces
        public CAD_Surface CurrentCAD_Surface
        {
            set => _CurrentCAD_Surface = value;
            get { return _CurrentCAD_Surface; }
        }
         public List<CAD_Surface> MyCAD_Surfaces
        {
           // set => _MyCAD_Surfaces = value;
            get { return _MyCAD_Surfaces; }
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
