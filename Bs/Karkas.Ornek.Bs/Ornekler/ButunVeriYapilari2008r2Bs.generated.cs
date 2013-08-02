
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
	public partial class ButunVeriYapilari2008r2Bs : BaseBs<ButunVeriYapilari2008r2, ButunVeriYapilari2008r2Dal>
	{
		public override string DatabaseName
		{
			get
			{
				return "Karkas.Ornek";
			}
		}
		public void Sil(int pButunVeriYapilari2008r2key)
		{
			dal.Sil( pButunVeriYapilari2008r2key);
		}
		public ButunVeriYapilari2008r2 SorgulaButunVeriYapilari2008r2keyIle(int p1)
		{
			return dal.SorgulaButunVeriYapilari2008r2keyIle(p1);
		}
	}
}
