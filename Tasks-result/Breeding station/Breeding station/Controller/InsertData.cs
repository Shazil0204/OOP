using System;
using System.Collections.Generic;
using Breeding_station.Model.List;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_station.Controller
{
    internal class InsertData
    {
        internal ListMethod listMethod = new ListMethod();
        public void AllInsert()
        {
            listMethod.InsertAll();
        }
    }
}
