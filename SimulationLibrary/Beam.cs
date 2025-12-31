using System;
using System.Collections.Generic;
using CAD;
using Mathematics;
using SE_Library;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Simulation
{
    public class Beam 
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _Version;
        //
        //  Types
        private BeamTypeEnum _BeamType;
        private BeamCrossSectionTypeEnum _BeamCrossSectionType;
        private BeamSupportTypeEnum _BeamSupportType;
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
        //  Cross-Section Sketch
        private List<CAD_Sketch> _CrossSectionSketch;
        //
        //  Sweep Curve
        private ThreeDGeometry _SweepCurve;
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
        public enum BeamTypeEnum
        {
            I_Beam = 0,
            T_Beam,
            L_Angle,
            WideFlange,
            HSS,
            Channel,
            Spar,
            Other
        }
        public enum BeamCrossSectionTypeEnum
        {
            I_Section = 0,
            T_Section,
            L_Section,
            Rectangular_Section,
            Triangular_Section,
            Circular_Section,
            Channel_Section,
            Other
        }
        public enum BeamSupportTypeEnum
        {
            Cantilever = 0,
            Simple,
            Overhanging,
            Continuous,
            FixedEnded,
            Cantilever_Simple,
            Other
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  BEAM CONSTRUCTOR
        //
        //  ************************************************************
        public Beam()
        {
            //
            //  Lists
            
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
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
        //
        //  Types
        //
        //  Beam Type
        public BeamTypeEnum BeamType
        {
            set => _BeamType = value;
            get
            {
                return _BeamType;
            }
        }
        //
        //  Beam Cross-Section Type
        public BeamCrossSectionTypeEnum BeamCrossSectionType
        {
            set => _BeamCrossSectionType = value;
            get
            {
                return _BeamCrossSectionType;
            }
        }
        //
        //  Beam Type
        public BeamSupportTypeEnum BeamSupportType
        {
            set => _BeamSupportType = value;
            get
            {
                return _BeamSupportType;
            }
        }
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
        //  Cross-Section Sketch
        public List<CAD_Sketch> CrossSectionSketch
        {
            set => _CrossSectionSketch = value;
            get
            {
                return _CrossSectionSketch;
            }
        }
        //
        //  Sweep Curve
        public ThreeDGeometry SweepCurve
        {
            set => _SweepCurve  = value;
            get
            {
                return _SweepCurve;
            }
        }
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
