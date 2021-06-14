using DPProjesi.DiyetisyenFolder.AbstractFactory.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProjesi.DiyetisyenFolder.Factory
{
    class SekerHastaligi : HastaTipi
    {
        readonly ITakvim _takvim;
        public SekerHastaligi(ITakvim diyet)
        {
            _takvim = diyet;
        }
    }
}
