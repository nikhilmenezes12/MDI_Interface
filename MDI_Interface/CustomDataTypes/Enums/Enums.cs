namespace MDI_Interface.CustomDataTypes.Enums
{
    public enum MDICommand { 
        Auto = 0,
        Edit = 1,
        Mdi = 2,
        Remote = 3,
        Ref = 4,
        Jog = 5,
        Inc = 6,
        Handle = 7,
        Restart = 8,
        PSynch = 9,
        PathPlus = 10,
        PathMinus = 11,
        CycleStart = 12,
        CycleStop = 13,
        Plus = 14,
        Minus = 15,
        X1 = 16,
        X10 = 17,
        X100 = 18,
        X1000 = 19,
        Axis7 = 20,
        Axis8 = 21,
        X = 22,
        Y = 23,
        Z = 24,
        Axis4 = 25,
        Axis5 = 26,
        Axis6 = 27,

    }

    public enum FocasErrorFlag { 
        EW_OK = 0,
        EW_HANDLE = (-8)
    }
}
