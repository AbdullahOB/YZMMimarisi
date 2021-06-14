using DPProjesi.DiyetisyenFolder.AbstractFactory.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProjesi.DiyetisyenFolder;
namespace DPProjesi.DiyetisyenFolder.Factory.HastalikFactory
{
    class ColyakHastalikFactory : HastalikFactory
    {
        protected override HastaTipi Create(string Tip)
        {
            HastaTipi tip;
            ITakvim diyet = new denizUrunleriTakvim();
            tip = new ColyakHastaligi(diyet);
            tip.hastaTip = "Çölyak Hastaligi";

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
