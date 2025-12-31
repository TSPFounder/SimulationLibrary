using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class SimulationAnimal : SimulationModelElement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _CommonName;
        private String _Breed;
        private String _Species;
        private String _Genus;
        private String _Kingdom;
        //
        //  Data
        //
        // Booleans
        private Boolean _IsBipedal;
        
        //
        //  Physical Properties
        private CAD_Parameter _Weight;
        private CAD_Dimension _Height;
        private CAD_Dimension _Length;
        private CAD_Dimension _Width;
        //
        //  Performance
        //
        //  Motion Properties
        private CAD_Parameter _MaxSpeed;
        private Vector _MyPosition;

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

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SIMULATIONANIUMAL CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimulationAnimal()
        {
            //  Model Category
            this.MySimType = SimElementTypeEnum.SimulationAnimal;
            //  Lists
            
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
        public String CommonName
        {
            set => _CommonName = value;
            get
            {
                return _CommonName;
            }
        }
        public String Breed
        {
            set => _Breed = value;
            get
            {
                return _Breed;
            }
        }
        public String Species
        {
            set => _Species = value;
            get
            {
                return _Species;
            }
        }
        public String Genus
        {
            set => _Genus = value;
            get
            {
                return _Genus;
            }
        }
        public String Kingdom
        {
            set => _Kingdom = value;
            get
            {
                return _Kingdom;
            }
        }
        //  
        //  Data
        //
        //  Performance
        //
        //  Position & Orientation
        //
        //  Motion Properties
        public CAD_Parameter MaxSpeed
        {
            set => _MaxSpeed = value;
            get
            {
                return _MaxSpeed;
            }
        }
        public Vector MyPosition
        {
            set => _MyPosition = value;
            get
            {
                return _MyPosition;
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
