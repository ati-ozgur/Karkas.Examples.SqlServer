
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Ornek.TypeLibrary;
using Karkas.Ornek.TypeLibrary.Ornekler;


namespace Karkas.Ornek.Dal.Ornekler
{
public partial class ConcurrencyOrnekDal : BaseDal<ConcurrencyOrnek>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Ornek";
		}
	}
	protected override void identityKolonDegeriniSetle(ConcurrencyOrnek pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM ORNEKLER.CONCURRENCY_ORNEK";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT ConcurrencyOrnekKey,Adi,VersiyonZamani FROM ORNEKLER.CONCURRENCY_ORNEK";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM ORNEKLER.CONCURRENCY_ORNEK WHERE ConcurrencyOrnekKey = @ConcurrencyOrnekKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE ORNEKLER.CONCURRENCY_ORNEK
			 SET 
			Adi = @Adi
			
			WHERE 
			 ConcurrencyOrnekKey = @ConcurrencyOrnekKey
 AND VersiyonZamani = @VersiyonZamani
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO ORNEKLER.CONCURRENCY_ORNEK 
			 (ConcurrencyOrnekKey,Adi) 
			 VALUES 
						(@ConcurrencyOrnekKey,@Adi)";
		}
	}
	public ConcurrencyOrnek SorgulaConcurrencyOrnekKeyIle(Guid p1)
	{
		List<ConcurrencyOrnek> liste = new List<ConcurrencyOrnek>();
		SorguCalistir(liste,String.Format(" ConcurrencyOrnekKey = '{0}'", p1));		
		if (liste.Count > 0)
		{
			return liste[0];
		}
		else
		{
			return null;
		}
	}
	
	protected override bool IdentityVarMi
	{
		get
		{
			return false;
		}
	}
	
	protected override bool PkGuidMi
	{
		get
		{
			return true;
		}
	}
	
	
	public override string PrimaryKey
	{
		get
		{
			return "ConcurrencyOrnekKey";
		}
	}
	
	public virtual void Sil(Guid ConcurrencyOrnekKey)
	{
		ConcurrencyOrnek satir = new ConcurrencyOrnek();
		satir.ConcurrencyOrnekKey = ConcurrencyOrnekKey;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, ConcurrencyOrnek satir)
	{
		satir.ConcurrencyOrnekKey = dr.GetGuid(0);
		satir.Adi = dr.GetString(1);
		satir.VersiyonZamani = (Byte[])dr.GetValue(2);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, ConcurrencyOrnek satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@ConcurrencyOrnekKey",SqlDbType.UniqueIdentifier, satir.ConcurrencyOrnekKey);
		builder.parameterEkle("@Adi",SqlDbType.VarChar, satir.Adi,50);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	ConcurrencyOrnek	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@ConcurrencyOrnekKey",SqlDbType.UniqueIdentifier, satir.ConcurrencyOrnekKey);
		builder.parameterEkle("@Adi",SqlDbType.VarChar, satir.Adi,50);
		builder.parameterEkle("@VersiyonZamani",SqlDbType.Timestamp, satir.VersiyonZamani);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	ConcurrencyOrnek	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@ConcurrencyOrnekKey",SqlDbType.UniqueIdentifier, satir.ConcurrencyOrnekKey);
	}
	public override string DbProviderName
	{
		get
		{
			return "System.Data.SqlClient";
		}
	}
}
}
