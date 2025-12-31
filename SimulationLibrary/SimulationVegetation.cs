using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class SimulationVegetation : SimulationModelElement
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
        //  Physical Properties
        private Point _Location;
        private CAD_Parameter _Weight;
        private CAD_Dimension _Height;
        private CAD_Dimension _Length;
        private CAD_Dimension _Width;
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
        //  SIMULATIONVEGETATION CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimulationVegetation()
        {
            //  Model Category
            this.MySimType = SimElementTypeEnum.SimulationVegetation;
            
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
        //  Physical Properties
        //
        //  Position & Orientation
        public Point Location
        {
            set => _Location = value;
            get
            {
                return _Location;
            }
        }
        //
        //  Physical Properties
        public CAD_Parameter Weight
        {
            set => _Weight = value;
            get
            {
                return _Weight;
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
