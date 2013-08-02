
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Ornek.TypeLibrary;
using Karkas.Ornek.TypeLibrary.Dbo;
using Karkas.Ornek.Dal.Dbo;


namespace Karkas.Ornek.Bs.Dbo
{
	public partial class SysdiagramsBs : BaseBs<Sysdiagrams, SysdiagramsDal>
	{
		public override string DatabaseName
		{
			get
			{
				return "Karkas.Ornek";
			}
		}
		public void Sil(int pDiagramId)
		{
			dal.Sil( pDiagramId);
		}
		public Sysdiagrams SorgulaDiagramIdIle(int p1)
		{
			return dal.SorgulaDiagramIdIle(p1);
		}
	}
}
