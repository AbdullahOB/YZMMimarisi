using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProjesi.DiyetisyenFolder.AbstractFactory;
using DPProjesi.DiyetisyenFolder.AbstractFactory.implementation;
using DPProjesi.DiyetisyenFolder.AbstractFactory.YontemInterface;

namespace DPProjesi.DiyetisyenFolder.Factory
{
    class ObezHastaligi : HastaTipi
    {

        readonly ITakvim _takvim;
        public ObezHastaligi(ITakvim diyet)
        {
            _takvim = diyet;
        }
        
    }
}
