using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class Truss 
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
        //  Dimensions
        private Point _Location;
        private CAD_Dimension _Height;
        private CAD_Dimension _Length;
        private CAD_Dimension _Width;
        //
        //  Enums
        private TrussTypeEnum _TrussType;

        //
        //  Owned & Owning Objects
        //
        //  Cross Members
        private Beam _X_Member;
        private List<Beam> _My_X_Members;

        //
        //  Profile
        private CAD_Sketch _X_MemberProfile;
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
        public enum TrussTypeEnum
        {
            Roof = 0,
            Floor,
            Bridge,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  TRUSS CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public Truss()
        {
            this.MyCAD_Models = new List<CAD_Model>();
            this.MyCoordinateSystems = new List<CoordinateSystem>();
            this.MyLoads = new List<StructuralLoad>();
            this.My_X_Members = new List<Beam>();
            
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
        //  Enums
        public TrussTypeEnum TrussType
        {
            set => _TrussType = value;
            get
            {
                return _TrussType;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Cross Members
        public Beam X_Member
        {
            set => _X_Member = value;
            get
            {
                return _X_Member;
            }
        }
        public List<Beam> My_X_Members
        {
            set => _My_X_Members = value;
            get
            {
                return _My_X_Members;
            }
        }
        public CAD_Sketch X_MemberProfile
        {
            set => _X_MemberProfile = value;
            get
            {
                return _X_MemberProfile;
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
