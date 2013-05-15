
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
public partial class IdentityBigIntDal : BaseDal<IdentityBigInt>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Ornek";
		}
	}
	protected override void identityKolonDegeriniSetle(IdentityBigInt pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM ORNEKLER.IDENTITY_BIG_INT";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT IdentityBigIntKey,Adi FROM ORNEKLER.IDENTITY_BIG_INT";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM ORNEKLER.IDENTITY_BIG_INT WHERE IdentityBigIntKey = @IdentityBigIntKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE ORNEKLER.IDENTITY_BIG_INT
			 SET 
			Adi = @Adi
			
			WHERE 
			 IdentityBigIntKey = @IdentityBigIntKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO ORNEKLER.IDENTITY_BIG_INT 
			 (IdentityBigIntKey,Adi) 
			 VALUES 
						(@IdentityBigIntKey,@Adi)";
		}
	}
	public IdentityBigInt SorgulaIdentityBigIntKeyIle(long p1)
	{
		List<IdentityBigInt> liste = new List<IdentityBigInt>();
		SorguCalistir(liste,String.Format(" IdentityBigIntKey = '{0}'", p1));		
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
			return false;
		}
	}
	
	
	public override string PrimaryKey
	{
		get
		{
			return "IdentityBigIntKey";
		}
	}
	
	public virtual void Sil(long IdentityBigIntKey)
	{
		IdentityBigInt satir = new IdentityBigInt();
		satir.IdentityBigIntKey = IdentityBigIntKey;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, IdentityBigInt satir)
	{
		satir.IdentityBigIntKey = dr.GetInt64(0);
		if (!dr.IsDBNull(1))
		{
			satir.Adi = dr.GetString(1);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, IdentityBigInt satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@IdentityBigIntKey",SqlDbType.BigInt, satir.IdentityBigIntKey);
		builder.parameterEkle("@Adi",SqlDbType.VarChar, satir.Adi,50);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	IdentityBigInt	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@IdentityBigIntKey",SqlDbType.BigInt, satir.IdentityBigIntKey);
		builder.parameterEkle("@Adi",SqlDbType.VarChar, satir.Adi,50);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	IdentityBigInt	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@IdentityBigIntKey",SqlDbType.BigInt, satir.IdentityBigIntKey);
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
