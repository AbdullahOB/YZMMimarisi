using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProjesi.DiyetisyenFolder.AbstractFactory.YontemInterface;

namespace DPProjesi.DiyetisyenFolder.AbstractFactory.implementation
{
    class denizUrunleriTakvim : ITakvim
    {
        int days;
        public IDiyetYontem TakvimCreate()
        {
            days = 9;
            return new denizUrunleri();
        }
    }
}
