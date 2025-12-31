using System;
using System.Collections.Generic;
using Propulsion;
using Power;
using Structure;
using SensorNamespace;
using Data;
using CAD;
using Controls;
using SystemsEngineering;
using MissionsNamespace;
using Mathematics;

namespace Simulation
{
    public class SimulationMachine : SimulationModelElement
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
        //  Owned & Owning Objects
        private DWM_System _MySystem;
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
        //  SIMULATIONMACHINE CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimulationMachine(SimulationModel myModel) : base(myModel)
        {
            //  Model Category
            this.MySimType = SimElementTypeEnum.SimulationMachine;
            

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
        //  Owned & Owning Objects
        public DWM_System MySystem
        {
            set => _MySystem = value;
            get { return _MySystem; }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region
        //
        //  Set the Position
        public Vector SetPosition(Point startPoint, Point endPoint)
        {
            if (this.MyPosition == null)
            {
                this.MyPosition = new Vector(startPoint, endPoint);
            }
            else
            {
                this.MyPosition.StartPoint = startPoint;
                this.MyPosition.EndPoint = endPoint;
            }
            return this.MyPosition;
        }
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
