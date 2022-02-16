using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTry3
{
    interface WriteList
    {
        void SaveAsXML(IList<Client> clients);
    }
}
