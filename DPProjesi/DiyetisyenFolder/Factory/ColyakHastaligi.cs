using DPProjesi.DiyetisyenFolder.AbstractFactory.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProjesi.DiyetisyenFolder.Factory
{
    class ColyakHastaligi : HastaTipi
    {
        readonly ITakvim _takvim;
        public ColyakHastaligi(ITakvim diyet)
        {
            _takvim = diyet;
        }
    }
}
