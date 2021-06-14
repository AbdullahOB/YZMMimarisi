using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProjesi.DiyetisyenFolder.Factory.HastalikFactory
{
    abstract class HastalikFactory
    {
        public HastaTipi mk(string Tip)
        {
            var hastalikTipi = Create(Tip);

            return hastalikTipi;
        }
        protected abstract HastaTipi Create(string Tip);
    }
}
