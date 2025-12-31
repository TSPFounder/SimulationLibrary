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
    public class SimulationBuilding : SimulationModelElement
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
        //  Owned & Owning Objects
        private Window _CurrentWindow;
        private Door _CurrentDoor;
        private Floor _CurrentFloor;
        private Wall _CurrentWall;
        private Roof _CurrentRoof;
        private HVAC _CurrentHVAC;
        private Pipe _CurrentWaterPipe;
        private Pipe _CurrentGasPipe;
        private Duct _CurrentHVAC_Duct;
        private Room _CurrentRoom;
        private StairCase _CurrentStaircase;
        private BuildingElevator _CurrentElevator;

        private List<Window> _MyWindows;
        private List<Door> _MyDoors;
        private List<Floor> _MyFloors;
        private List<Wall> _MyWalls;
        private List<Roof> _MyRoofs;
        private List<HVAC> _MyHVACs;
        private List<Pipe> _MyWaterPipes;
        private List<Pipe> _MyGasPipes;
        private List<Duct> _MyHVAC_Ducts;
        private List<Room> _MyRooms;
        private List<StairCase> _MyStaircases;
        private List<BuildingElevator> _MyElevators;

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
        //  SIMULATIONBUILDING CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimulationBuilding(SimulationModel myModel) 
        {
            //  Model Category
            this.MySimType = SimElementTypeEnum.SimulationBuilding;
            //
            //  Lists
            this.MyAssets = new List<GameAsset>();
            this.MyDoors = new List<Door>();
            this.MyElevators = new List<BuildingElevator>();
            this.MyFloors = new List<Floor>();
            this.MyGasPipes = new List<Pipe>();
            this.MyHVACs = new List<HVAC>();
            this.MyHVAC_Ducts = new List<Duct>();
            this.MyRoofs = new List<Roof>();
            this.MyRooms = new List<Room>();
            this.MySimModel = new SimulationModel();
            this.MyStaircases = new List<StairCase>();
            this.MyWalls = new List<Wall>();
            this.MyWaterPipes = new List<Pipe>();
            this.MyWindows = new List<Window>();
            
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
        public StairCase CurrentStaircase
        {
            set => _CurrentStaircase = value;
            get
            {
                return _CurrentStaircase;
            }
        }
        public BuildingElevator CurrentElevator
        {
            set => _CurrentElevator = value;
            get
            {
                return _CurrentElevator;
            }
        }
        //
        //  Windows
        public Window CurrentWindow
        {
            set => _CurrentWindow = value;
            get
            {
                return _CurrentWindow;
            }
        }
        public List<Window> MyWindows
        {
            set => _MyWindows = value;
            get
            {
                return _MyWindows;
            }
        }
        //
        //  Doors
        public Door CurrentDoor
        {
            set => _CurrentDoor = value;
            get
            {
                return _CurrentDoor;
            }
        }
        public List<Door> MyDoors
        {
            set => _MyDoors = value;
            get
            {
                return _MyDoors;
            }
        }
        //
        //   Floors
        public Floor CurrentFloor
        {
            set => _CurrentFloor = value;
            get
            {
                return _CurrentFloor;
            }
        }
        public List<Floor> MyFloors
        {
            set => _MyFloors = value;
            get
            {
                return _MyFloors;
            }
        }
        //
        //   Walls
        public Wall CurrentWall
        {
            set => _CurrentWall = value;
            get
            {
                return _CurrentWall;
            }
        }
        public List<Wall> MyWalls
        {
            set => _MyWalls = value;
            get
            {
                return _MyWalls;
            }
        }
        //
        //   Roofs
        public Roof CurrentRoof
        {
            set => _CurrentRoof = value;
            get
            {
                return _CurrentRoof;
            }
        }
        public List<Roof> MyRoofs
        {
            set => _MyRoofs = value;
            get
            {
                return _MyRoofs;
            }
        }
        //
        //   HVAC
        public HVAC CurrentHVAC
        {
            set => _CurrentHVAC = value;
            get
            {
                return _CurrentHVAC;
            }
        }
        public List<HVAC> MyHVACs
        {
            set => _MyHVACs = value;
            get
            {
                return _MyHVACs;
            }
        }
        //
        //   Water Pipes
        public Pipe CurrentWaterPipe
        {
            set => _CurrentWaterPipe = value;
            get
            {
                return _CurrentWaterPipe;
            }
        }
        public List<Pipe> MyWaterPipes
        {
            set => _MyWaterPipes = value;
            get
            {
                return _MyWaterPipes;
            }
        }
        //
        //   Gas Pipes
        public Pipe CurrentGasPipe
        {
            set => _CurrentGasPipe = value;
            get
            {
                return _CurrentGasPipe;
            }
        }
        public List<Pipe> MyGasPipes
        {
            set => _MyGasPipes = value;
            get
            {
                return _MyGasPipes;
            }
        }
        //
        //   HVAC Ducts
        public Duct CurrentHVAC_Duct
        {
            set => _CurrentHVAC_Duct = value;
            get
            {
                return _CurrentHVAC_Duct;
            }
        }
        public List<Duct> MyHVAC_Ducts
        {
            set => _MyHVAC_Ducts = value;
            get
            {
                return _MyHVAC_Ducts;
            }
        }
        //
        //   Rooms
        public Room CurrentRoom
        {
            set => _CurrentRoom = value;
            get
            {
                return _CurrentRoom;
            }
        }              
        public List<Room> MyRooms
        {
            set => _MyRooms = value;
            get
            {
                return _MyRooms;
            }
        }
        public List<StairCase> MyStaircases
        {
            set => _MyStaircases = value;
            get
            {
                return _MyStaircases;
            }
        }
        public List<BuildingElevator> MyElevators
        {
            set => _MyElevators = value;
            get
            {
                return _MyElevators;
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
