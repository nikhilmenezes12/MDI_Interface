using System.Collections.Generic;
using System.Linq;

using MDI_Interface.CustomDataTypes.Enums;

namespace MDI_Interface.CustomDataTypes.Structs
{
    public struct MDICommandData {
        public MDICommand command;
        public short inputAddress;
        public short inputBit;
        public short outputAddress;
        public short outputBit;
    }

    public struct MDIButtonData {
        public MDICommand command;
        public string name;
    }

    class StructListManipulator {
        public List<MDIButtonData> RearrangeStructList(List<MDIButtonData> list)
        {
            List<int> order = new List<int>();
            for (int i = 0; i < list.Count; i++) {
                order.Add((int)list[i].command);
            }

            return order.Select(i => list[i]).ToList(); ;
        }

        public List<MDICommandData> RearrangeStructList(List<MDICommandData> list)
        {
            List<int> order = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                order.Add((int)list[i].command);
            }

            return order.Select(i => list[i]).ToList(); ;
        }
    }
}
