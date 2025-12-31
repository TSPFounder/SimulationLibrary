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

namespace Simulation
{
    public class SimulationFood : SimulationModelElement
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
        private CAD_Parameter _FatInGrams;
        private CAD_Parameter _Calories;
        private CAD_Parameter _Weight;
        //
        //  Owned & Owning Objects

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
        public enum FoodTypeEnum {
            Fruit =0,
            Vegetable,
            Meat,
            Dairy,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SIMULATIONFOOD CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimulationFood(SimulationModel myModel) : base(myModel)
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
