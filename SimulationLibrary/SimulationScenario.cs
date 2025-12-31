using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class SimulationScenario
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _Name;
        //
        //  Data

        //
        //  Owned & Owning Objects
        //
        //  Mission Objects
        private MissionScenario _MyMissionScenario;
        //
        //  Simulation Objects
        private SimulationModel _MySimModel;
        private SimulationTerrain _MySimTerrain;
        private SimulationModelElement _CurrentSimModelElement;
        private List<SimulationModelElement> _MyElements;
        //
        //  My Scene
        private SimulationScene _MyScene;
        //
        //  My Database
        private DatabaseClass _MyDatabase;
        //
        //  Spreadsheets
        private Spreadsheet _CurrentSpreadsheet;
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
        //  SIMULATIONSCENARIO CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimulationScenario()
        {
            this.MyElements = new List<SimulationModelElement>();
            
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
        public String Name
        {
            set => _Name = value;
            get { return _Name; }
        }
        //
        //  Data

        //
        //  Owned & Owning Objects
        //
        //  Mission Objects
        public MissionScenario MyMissionScenario
        {
            set => _MyMissionScenario = value;
            get { return _MyMissionScenario; }
        }
        //
        //  Simulation Objects
        public SimulationModel MySimModel
        {
            set => _MySimModel = value;
            get { return _MySimModel; }
        }
        public SimulationTerrain MySimTerrain
        {
            set => _MySimTerrain = value;
            get { return _MySimTerrain; }
        }
        public SimulationModelElement CurrentSimModelElement
        {
            set => _CurrentSimModelElement = value;
            get { return _CurrentSimModelElement; }
        }
        public List<SimulationModelElement> MyElements
        {
            set => _MyElements = value;
            get { return _MyElements; }
        }
        //
        //  My Scene
        public SimulationScene MyScene
        {
            set => _MyScene = value;
            get { return _MyScene; }
        }
        //
        //  My Database
        public DatabaseClass MyDatabase
        {
            set => _MyDatabase = value;
            get { return _MyDatabase; }
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
