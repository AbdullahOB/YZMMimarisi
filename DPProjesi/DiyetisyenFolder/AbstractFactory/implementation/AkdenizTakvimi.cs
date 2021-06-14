using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProjesi.DiyetisyenFolder.AbstractFactory;
using DPProjesi.DiyetisyenFolder.AbstractFactory.YontemInterface;

namespace DPProjesi.DiyetisyenFolder.AbstractFactory.implementation
{
    class AkdenizTakvimi : ITakvim
    {
        int days;
        public IDiyetYontem TakvimCreate()
        {
            days = 10;
            return new akdeniz();
        }
    }
}
