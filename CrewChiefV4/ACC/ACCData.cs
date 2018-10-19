﻿using System;
using System.Runtime.InteropServices;

namespace CrewChiefV4.ACC
{
    class ACCConstant
    {
        public const string SharedMemoryName = "Local\\CrewChief_ACC";
        public const string SharedMemoryNamePhysics = "Local\\acpmf_physics"; // Local\\acpmf_physics
    }    
    namespace Data
    {
        public enum AC_WHEELS
        {
            FL = 0,
            FR = 1,
            RL = 2,
            RR = 3,
        }
        [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Ansi)]
        [Serializable]
        public struct acsVec3
        {
            public float x;
            public float y;
            public float z;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
        [Serializable]
        public struct SPageFilePhysics
        {

            public int packetId;
            public float gas;
            public float brake;
            public float fuel;
            public int gear;
            public int rpms;
            public float steerAngle;
            public float speedKmh;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] velocity;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] accG;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] wheelSlip;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] wheelLoad;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] wheelsPressure;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] wheelAngularSpeed;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] tyreWear;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] tyreDirtyLevel;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] tyreCoreTemperature;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] camberRAD;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] suspensionTravel;

            public float drs;
            public float tc;
            public float heading;
            public float pitch;
            public float roll;
            public float cgHeight;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public float[] carDamage;
            public int numberOfTyresOut;
            public int pitLimiterOn;
            public float abs;
            public float kersCharge;
            public float kersInput;
            public int autoShifterOn;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public float[] rideHeight;
            public float turboBoost;
            public float ballast;
            public float airDensity;
            public float airTemp;
            public float roadTemp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] localAngularVel;
            public float finalFF;
            public float performanceMeter;

            public int engineBrake;
            public int ersRecoveryLevel;
            public int ersPowerLevel;
            public int ersHeatCharging;
            public int ersIsCharging;
            public float kersCurrentKJ;

            public int drsAvailable;
            public int drsEnabled;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] brakeTemp;
            public float clutch;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] tyreTempI;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] tyreTempM;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] tyreTempO;
            public int isAIControlled;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public acsVec3[] tyreContactPoint;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public acsVec3[] tyreContactNormal;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public acsVec3[] tyreContactHeading;
            float brakeBias;
            public acsVec3 localVelocity;
        }

        public enum CarLocation  : byte
        {
	        ECarLocation__Null = 0,
	        ECarLocation__Track = 1,
	        ECarLocation__PitLane = 2,
	        ECarLocation__PitEntry = 3,
	        ECarLocation__PitExit = 4,
	        ECarLocation__ECarLocation_MAX = 5
        };

        public enum RaceSessionType : byte
	    {
		    FreePractice1 = 0,
		    FreePractice2 = 1,
		    PreQualifying = 2,
		    WarmUp = 3,
		    Qualifying = 4,
		    Qualifying1 = 5,
		    Qualifying2 = 6,
		    Qualifying3 = 7,
		    Qualifying4 = 8,
		    Superpole = 9,
		    Race = 10,
		    Hotlap = 11,
		    Hotstint = 12,
		    HotlapSuperpole = 13,
            RaceSessionType_Max = 14,
	    };

	    public enum  RaceSessionPhase  : byte
	    {
		    StartingUI = 0,
		    PreFormationTime = 1,
		    FormationTime = 2,
		    PreSessionTime = 3,
		    SessionTime = 4,
		    SessionOverTime = 5,
		    PostSessionTime = 6,
		    ResultUI = 7,
            RaceSessionPhase_Max = 8, 
	    };

	    public enum  DriverCategory  : byte
	    {
		    EDriverCategory__Platinum = 0,
		    EDriverCategory__Gold = 1,
		    EDriverCategory__Silver = 2,
		    EDriverCategory__Bronze = 3,
		    EDriverCategory__EDriverCategory_MAX = 4
	    };

	    public enum  Nationality  : short
	    {
		    ENationality__Any = 0,
		    ENationality__Italy = 1,
		    ENationality__Germany = 2,
		    ENationality__France = 3,
		    ENationality__Spain = 4,
		    ENationality__GreatBritain = 5,
		    ENationality__Hungary = 6,
		    ENationality__Belgium = 7,
		    ENationality__Switzerland = 8,
		    ENationality__Austria = 9,
		    ENationality__Russia = 10,
		    ENationality__Thailand = 11,
		    ENationality__Netherlands = 12,
		    ENationality__Poland = 13,
		    ENationality__Argentina = 14,
		    ENationality__Monaco = 15,
		    ENationality__Ireland = 16,
		    ENationality__Brazil = 17,
		    ENationality__SouthAfrica = 18,
		    ENationality__PuertoRico = 19,
		    ENationality__Slovakia = 20,
		    ENationality__Oman = 21,
		    ENationality__Greece = 22,
		    ENationality__SaudiArabia = 23,
		    ENationality__Norway = 24,
		    ENationality__Turkey = 25,
		    ENationality__SouthKorea = 26,
		    ENationality__Lebanon = 27,
		    ENationality__Armenia = 28,
		    ENationality__Mexico = 29,
		    ENationality__Sweden = 30,
		    ENationality__Finland = 31,
		    ENationality__Denmark = 32,
		    ENationality__Croatia = 33,
		    ENationality__Canada = 34,
		    ENationality__China = 35,
		    ENationality__Portugal = 36,
		    ENationality__ENationality_MAX = 37
	    };

	    public enum  CarModelType  : byte
	    {
		    ECarModelType__Porsche_991_GT3_R = 0,
		    ECarModelType__Mercedes_AMG_GT3 = 1,
		    ECarModelType__Ferrari_488_GT3 = 2,
		    ECarModelType__Audi_R8_LMS = 3,
		    ECarModelType__Lamborghini_Huracan_GT3 = 4,
		    ECarModelType__Mclaren_650s_GT3 = 5,
		    ECarModelType__Nissan_GT_R_Nismo_GT3 = 6,
		    ECarModelType__BMW_M6_GT3 = 7,
		    ECarModelType__Bentley_Continental_GT3 = 8,
		    ECarModelType__Porsche_991II_GT3_Cup = 9,
		    ECarModelType__Nissan_GT_R_Nismo_GT301 = 10,
		    ECarModelType__Bentley_Continental_GT301 = 11,
		    ECarModelType__Aston_Martin_Vantage_V12_GT3 = 12,
		    ECarModelType__Lamborghini_Gallardo_R_EX = 13,
		    ECarModelType__Jaguar_G3 = 14,
		    ECarModelType__Lexus_RC_F_GT3 = 15,
		    ECarModelType__Lamborghini_Huracan_GT301 = 16,
		    ECarModelType__ECarModelType_MAX = 17
	    };

	    public enum  MarshalFlagType  : byte
	    {
		    EMarshalFlagType__White = 0,
		    EMarshalFlagType__Green = 1,
		    EMarshalFlagType__Red = 2,
		    EMarshalFlagType__Blue = 3,
		    EMarshalFlagType__Yellow = 4,
		    EMarshalFlagType__Black = 5,
		    EMarshalFlagType__BlackWhite = 6,
		    EMarshalFlagType__Checkered = 7,
		    EMarshalFlagType__OrangeCircle = 8,
		    EMarshalFlagType__RedYellowStipes = 9,
		    EMarshalFlagType__None = 10,
		    EMarshalFlagType__EMarshalFlagType_MAX = 11
	    };

	    public enum  CupCategory  : byte
	    {
		    ECupCategory__Overall = 0,
		    ECupCategory__ProAm = 1,
		    ECupCategory__Am = 2,
		    ECupCategory__Silver = 3,
		    ECupCategory__National = 4,
		    ECupCategory__ECupCategory_MAX = 5
	    };

	    public enum RaceEventType  : byte
	    {
		    ERaceEventType__A_3H = 0,
		    ERaceEventType__B_24H = 1,
		    ERaceEventType__C_6H = 2,
		    ERaceEventType__D_1H = 3,
		    ERaceEventType__ERaceEventType_MAX = 4
	    };
        // i think this one is supposed to be a bitfield but IDA cant always tell the differance 
	    public enum LapStateFlags : short
	    {
		    HasCut = 0x0001,
            IsInvalidLap = 0x0002,
            HasPenalty = 0x0004,
            IsOutLap = 0x0008,
            IsInLap = 0x0010,
            IsFormationLap = 0x0020,
            IsSafetyCarOnTrack = 0x0040,
            IsFullCourseYellow = 0x0080,
            IsRetired = 0x0100,
            IsDisqualified = 0x0200,
            IsOnPitWorkingZone = 0x0400,
            DriverSwap = 0x0800,
	    };

	    public enum PitStopRepairType : byte
	    {
		    Chassis = 0x0,
		    SuspensionLF = 0x1,
		    SuspensionRF = 0x2,
		    SuspensionLR = 0x3,
		    SuspensionRR = 0x4,
		    Brakes = 0x5,
		    Radiator = 0x6,
		    GearBox = 0x7,
	    };

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        [Serializable]
        public struct ACCMarshal
        {
            public float startPos;
            public float endPos;
            public MarshalFlagType flag;	
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        [Serializable]
        public struct Marshals
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public ACCMarshal[] marshals;
            public int marshalCount;
            public byte checkeredFlagMarshalIndex;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        [Serializable]
        public struct Vec3
        {
            public float x;
            public float y;
            public float z;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        [Serializable]
        public struct Rotation
        {
            public float pitch;
            public float yaw;
            public float roll;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        [Serializable]
        public struct WeatherStatus
        {
            public float ambientTemperature;
            public float roadTemperature;
            public float wetLevel;
            public float windSpeed;
            public float windDirection;
            public float rainLevel;
            public float cloudLevel;
        };
        [StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
        [Serializable]
        public struct Track
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public String name;
            public int Id;
            public float length;
            public int sectors;
            public int corners;
            public byte isPolesitterOnLeft;
            public WeatherStatus weatherState;
            
        }
        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        [Serializable]
        public struct Lap 
	    {
            public UInt16 driverIndex;
            public float timeStamp;
            public int lapTime;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] sectorTimes;
		    public LapStateFlags lapStates;
	    };
        [StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
        [Serializable]
        public struct Driver
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
	        public String name;
            public Nationality nation;
	        public Vec3 location;
	        public Rotation rotation;
            public float distanceRoundTrack;
            public float speedMS;
            public float speedKMH;
            public float lastSectorTimeStamp;
            public int position;
            public int realTimePosition;
            public int lapCount;
            public int totalTime;
	        public int currentDelta;
            public int currentSector;          //0 based index, when formation lap starts in last sector this value will be tracksector count
            public int currentlaptime;
            public Lap currentLap;
            public Lap lastLap;
            public float trottle;
            public float brake;
            public float clutch;
            public float rpm;
	        public float fuel;
            public float maxFuel;
            public byte isBetweenSafetyCarLines;
            public byte isSessionOver;
            public byte isDisqualified;
            public byte isRetired;
            public byte isCarOutOfTrack;
            public UInt16 driverIndex;
            public byte formationLapCounter;
            public CarLocation trackLocation;	
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        [Serializable]
        public struct ACCSessionData
        {
            public float physicsTime;           //total time session has been running
            public float sessionStartTimeStamp; //this gets set on session change
            public float receivedServerTime;
            public float serverTimeOffset;      //Not 100 sure what this one does but i assume we will have to use it when online
            public float sessionStartTime;      
            public float sessionEndTime;
            public int sessionDuration;
            public UInt32 pitWindowOpenAtTime;
            public UInt32 pitWindowCloseAtTime;
            public UInt32 maxDrivingTime;
            public byte isServer;
            public byte isClient;
            public byte areCarsInitializated;
            public byte isTimeStopped;
            public byte isEventInitializated;
            public byte isSessionInitializated;        
            public UInt16 currentEventIndex;
            public UInt16 currentSessionIndex;
            public RaceSessionType currentSessionType;
            public RaceSessionPhase currentSessionPhase;
            public byte mandatoryPitStopCount;
            public byte pitlaneSpeedLimitKmh;
            public byte isOnline;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        [Serializable]
        public struct  ACCSharedMemoryData
        {
            public ACCSessionData sessionData;
            public Track track;
            public byte isReady;
            public float update;            
            public Driver playerDriver;         
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public Driver[]drivers;             //Array of total drivers connected including player
	        public int driverCount;
            public Marshals marshals;

        }        
    }    
}
