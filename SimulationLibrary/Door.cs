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
    public class Door 
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification

        //
        //  Data
        //
        //  Dimensions
        private CAD_Dimension _Length;
        private CAD_Dimension _Width;
        private CAD_Dimension _Height;
        //
        //  Physical Properties
        private CAD_Parameter _Weight;
        //
        //  Owned & Owning Objects
        //
        //  Panels
        private List<Panel> _MyPanels;
        //
        //  Windows
        private List<Window> _MyWindows;
        //
        //  Lock
        private List<Lock> _MyLocks;
        //  *****************************************************************************************


        //  ****************************************************************************************
        //  INITIALIZATIONS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ENUMERATIONS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  DOOR CONSTRUCTOR
        //
        //  ************************************************************
        public Door()
        {

        }
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
        //  Owned & Owning Objects
        //
        //  Panels
        public List<Panel> MyPanels
        {
            set => _MyPanels = value;
            get
            {
                return _MyPanels;
            }
        }
        //
        //  Windows
        public List<Window> MyWindows
        {
            set => _MyWindows = value;
            get
            {
                return _MyWindows;
            }
        }
        //
        //  Lock
        public List<Lock> MyLocks
        {
            set => _MyLocks = value;
            get
            {
                return _MyLocks;
            }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
