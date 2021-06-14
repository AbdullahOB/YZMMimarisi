using DPProjesi.DiyetisyenFolder.AbstractFactory.YontemInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProjesi.DiyetisyenFolder.AbstractFactory.implementation
{
    class yesillikDunyasiTakvimi : ITakvim
    {
        int days;
        public IDiyetYontem TakvimCreate()
        {
            days = 18;
            return new yesilliklerDunyasi();
        }
    }
}
