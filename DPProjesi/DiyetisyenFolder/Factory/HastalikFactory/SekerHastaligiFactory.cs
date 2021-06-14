using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProjesi.DiyetisyenFolder.AbstractFactory.implementation;
using DPProjesi.DiyetisyenFolder.AbstractFactory.YontemInterface;

namespace DPProjesi.DiyetisyenFolder.Factory.HastalikFactory
{
    class SekerHastaligiFactory : HastalikFactory
    {
        protected override HastaTipi Create(string Tip)
        {
            HastaTipi tip;
            ITakvim diyet = new GlutenFreeTakvimi();
            tip = new SekerHastaligi(diyet);
            tip.hastaTip = "Seker Hastaligi";
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
