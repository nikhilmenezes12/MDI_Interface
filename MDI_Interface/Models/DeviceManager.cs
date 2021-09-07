using System;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.CompilerServices;

using MDI_Interface.Wrapper;
using MDI_Interface.CustomDataTypes.Enums;

namespace MDI_Interface.Models
{
    class DeviceManager
    {
        public ushort Connect() {
            // cnc_allclibhndl2 must be used as multiple threads are used for the communication with the CNC
            // handle is only declared as local variable inside function that no problems arise with multiple threading solutions, else handle is always overwritten
            // Change nodeID to 0 for hardware CNC, change nodeID to 9 for CNC Guide
            ushort handle;
            int nodeID = 9;
            ErrorFlagChecker((FocasErrorFlag)Focas1.cnc_allclibhndl2(nodeID, out handle));
            return handle;
        }

        public void Disconnect(ushort handle)
        {
            ErrorFlagChecker((FocasErrorFlag)Focas1.cnc_freelibhndl(handle));
        }

        public void UpdateAddress(ushort handle, short address, short bitCode) {

            Focas1.IODBPMC1 PMC_byte_address = new Focas1.IODBPMC1();

            PMC_byte_address.type_a = 5;
            PMC_byte_address.type_d = 0;
            PMC_byte_address.datano_s = address;
            PMC_byte_address.datano_e = address;
            PMC_byte_address.idata = new short[5];

            // Sum of the power of 2 of the bitCodes which should be 1 at the address
            // Example: 404.1 -> 1, 404.2 -> 1, we need to send 2^1 + 2^2 = 6 (when all the other member of the address should remain zero)
            PMC_byte_address.idata[0] = (short)Math.Pow(2.0, bitCode);
            ErrorFlagChecker((FocasErrorFlag)Focas1.pmc_wrpmcrng(handle, 9, PMC_byte_address));

            // Only a trigger needs to be provided, that the system works
            // Thread Sleep is required, as else the trigger is not long enough and then the CNC does not see the signal
            Thread.Sleep(10);
            PMC_byte_address.idata[0] = (short)0;
            ErrorFlagChecker((FocasErrorFlag)Focas1.pmc_wrpmcrng(handle, 9, PMC_byte_address));

        }

        public bool ReadAddress(ushort handle, short address, short bitCode) {

            short pmc_type = 5;
            Focas1.IODBPMC1 PMC_byte_address = new Focas1.IODBPMC1();
            ErrorFlagChecker((FocasErrorFlag)Focas1.pmc_rdpmcrng(handle, pmc_type, 0, (ushort)address, (ushort)address, 9, PMC_byte_address));
            
            string idata = Convert.ToString(PMC_byte_address.idata[0], 2).PadLeft(8, '0');

            if (idata[7-bitCode] == '1')
            {
                return true;
            }
            else {
                return false;
            }
        }

        public void ErrorFlagChecker(FocasErrorFlag errorFlag, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string functionName = "")
        {
            if ((errorFlag != FocasErrorFlag.EW_OK) && (!(errorFlag == FocasErrorFlag.EW_HANDLE && functionName == "Disconnect")))
            {
               MessageBox.Show("ErrorFlag: "+ errorFlag.ToString() +", Function: " + functionName +", Line Number: " + lineNumber.ToString());
            }
        }
    }
}
