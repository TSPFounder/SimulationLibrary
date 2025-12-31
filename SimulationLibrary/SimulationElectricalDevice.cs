using System;
using System.Collections.Generic;
using Propulsion;
using Power;
using Structure;
using SensorNamespace;
//using ThermalManagement;
//using GNC;
//using Communications;
//using Fluidics;
using Data;
using CAD;
using Controls;
using SystemsEngineering;
using Mathematics;
using MissionsNamespace;
using Electronics;

namespace Simulation
{
    public class SimluationElectricalDevice : SimulationModelElement
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
        //
        //  Electrical Elements
        private ElectricalElement _CurrentElectricalElem;
        private List<ElectricalElement> _MyElectricalElements;
        
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
        //  SIMULATIONELECTRICALDEVICE CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimluationElectricalDevice()
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
        //  Owned & Owning Objects
        //
        //  Electrical Elements
        public ElectricalElement CurrentElectricalElem
        {
            set => _CurrentElectricalElem = value;
            get
            {
                return _CurrentElectricalElem;
            }
        }
        public List<ElectricalElement> MyElectricalElements
        {
            set => _MyElectricalElements = value;
            get
            {
                return _MyElectricalElements;
            }
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
