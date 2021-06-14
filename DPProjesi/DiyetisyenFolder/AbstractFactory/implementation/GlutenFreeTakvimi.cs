using DPProjesi.DiyetisyenFolder.AbstractFactory.YontemInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProjesi.DiyetisyenFolder.AbstractFactory;
namespace DPProjesi.DiyetisyenFolder.AbstractFactory.implementation
{
    class GlutenFreeTakvimi : ITakvim
    {
        int days;
        public IDiyetYontem TakvimCreate()
        {
            days = 15;
            return new glutenFree();

        }
    }
}
