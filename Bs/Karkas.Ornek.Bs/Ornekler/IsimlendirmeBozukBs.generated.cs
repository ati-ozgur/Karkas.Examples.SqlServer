
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Ornek.TypeLibrary;
using Karkas.Ornek.TypeLibrary.Ornekler;
using Karkas.Ornek.Dal.Ornekler;


namespace Karkas.Ornek.Bs.Ornekler
{
	public partial class IsimlendirmeBozukBs : BaseBs<IsimlendirmeBozuk, IsimlendirmeBozukDal>
	{
		public override string DatabaseName
		{
			get
			{
				return "Karkas.Ornek";
			}
		}
		public void Sil(int pKisiOid)
		{
			dal.Sil( pKisiOid);
		}
		public IsimlendirmeBozuk SorgulaKisiOidIle(int p1)
		{
			return dal.SorgulaKisiOidIle(p1);
		}
	}
}
