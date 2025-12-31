using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class SimulationModelElement
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
        private String _ID;
        private String _Description;
        //
        //  Data
        private Vector _MyPosition;
        private Double _MyPrimaryAngle;
        private Double _MySecondaryAngle;
        private Double _MyTertiaryAngle;
        private Double _ScaleFactor;
        private SimElementTypeEnum _MySimType;
        //
        //  Owned & Owning Objects
        //
        //  Simulation Objects
        private SimulationModel _MySimModel;
        
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
        //  Simulation Element Type
        public enum SimElementTypeEnum
        {
            SimScene = 0,
            SimulinkBlock,
            SimscapeBlock,
            SimulinkPort,
            SimulinkParameter,
            SimscapePort,
            SimulationTerrain,
            SimulationBodyOfWater,
            SimulationBuilding,
            SimulationVehicle,
            SimulationMachine,
            SimulationRoad,
            SimulationPerson,
            SimulationAnimal,
            SimulationVegetation,
            SimulationStructure,
            SimulationTool,
            SimulationWeapon,
            Other
        }

        #endregion
            //  *****************************************************************************************


            //  *****************************************************************************************
            //  SIMULATIONMODELELEMENTCONSTRUCTOR
            //
            //  ************************************************************
            #region
        public SimulationModelElement()
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
        public String Description
        {
            set => _Description = value;
            get
            {
                return _Description;
            }
        }
        //
        //  ID
        public String ID
        {
            set => _ID = value;
            get
            {
                return _ID;
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
        //  Position
        public Vector MyPosition
        {
            set => _MyPosition = value;
            get
            {
                return _MyPosition;
            }
        }
        //
        //  Angles
        public Double MyPrimaryAngle
        {
            set => _MyPrimaryAngle = value;
            get
            {
                return _MyPrimaryAngle;
            }
        }
        public Double MySecondaryAngle
        {
            set => _MySecondaryAngle = value;
            get
            {
                return _MySecondaryAngle;
            }
        }
        public Double MyTertiaryAngle
        {
            set => _MyTertiaryAngle = value;
            get
            {
                return _MyTertiaryAngle;
            }
        }
        //
        //  Scale Factor
        public Double ScaleFactor
        {
            set => _ScaleFactor = value;
            get
            {
                return _ScaleFactor;
            }
        }
        //
        //  Sim Element Type
        public SimElementTypeEnum MySimType
        {
            set => _MySimType = value;
            get
            {
                return _MySimType;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Simulation Objects
        public SimulationModel MySimModel
        {
            set => _MySimModel = value;
            get
            {
                return _MySimModel;
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
