using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class SimulationScene :SimulationModelElement
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
        private MissionScene _MyMissionScene;
        //
        //  Simulation Objects
        private SimulationModel _MySimModel;
        private SimulationTerrain _MySimTerrain;
        private List<SimulationModelElement> _MyElements;
        //
        //  Game Objects
        private GameObject _CurrentGameObject;
        private List<GameObject> _MyGameObjects;
        //
        // Simulation Scenarios
        private SimulationScenario _CurrentSimScenario;
        private List<SimulationScenario> _MySimScenarios;
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
        //  SIMULATIONSCENE CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimulationScene(SimulationModel myModel) : base(myModel)
        {
            this.MySimTerrain = new SimulationTerrain();
            this.MyAssets = new List<GameAsset>();
            this.MySimScenarios = new List<SimulationScenario>();
            this.MyGameObjects = new List<GameObject>();
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
        public MissionScene MyMissionScene
        {
            set => _MyMissionScene = value;
            get { return _MyMissionScene; }
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
        public List<SimulationModelElement> MyElements
        {
            set => _MyElements = value;
            get { return _MyElements; }
        }
        //
        //  Game Objects
        public GameObject CurrentGameObject
        {
            set => _CurrentGameObject = value;
            get { return _CurrentGameObject; }
        }
       public List<GameObject> MyGameObjects
        {
            set => _MyGameObjects = value;
            get { return _MyGameObjects; }
        }
        //
        // Simulation Scenarios
        public SimulationScenario CurrentSimScenario
        {
            set => _CurrentSimScenario = value;
            get { return _CurrentSimScenario; }
        }
        
        public List<SimulationScenario> MySimScenarios
        {
            set => _MySimScenarios = value;
            get { return _MySimScenarios; }
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
