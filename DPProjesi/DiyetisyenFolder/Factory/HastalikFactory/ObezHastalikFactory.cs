using DPProjesi.DiyetisyenFolder.AbstractFactory.implementation;
using DPProjesi.DiyetisyenFolder.AbstractFactory.YontemInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProjesi.DiyetisyenFolder.Factory.HastalikFactory
{
    class ObezHastalikFactory : HastalikFactory
    {
        protected override HastaTipi Create(string Tip)
        {
            HastaTipi tip;
            ITakvim diyet = new AkdenizTakvimi();
            tip = new ObezHastaligi(diyet);
            tip.hastaTip = "Obez Hastaligi";
            string hTip = tip.hastaTip;
            AppendToComboBox(hTip);
            return tip;
        }

        public void AppendToComboBox(string tip)
        {
            HastaEkle t = new HastaEkle();
            t.hastaTipiCmb.Items.Add(tip);
        }
    }
}
