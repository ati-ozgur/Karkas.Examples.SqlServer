
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
public partial class IdentitySmallIntDal : BaseDal<IdentitySmallInt>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Ornek";
		}
	}
	protected override void identityKolonDegeriniSetle(IdentitySmallInt pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM ORNEKLER.IDENTITY_SMALL_INT";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT IdentitySmallIntKey,Adi FROM ORNEKLER.IDENTITY_SMALL_INT";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM ORNEKLER.IDENTITY_SMALL_INT WHERE IdentitySmallIntKey = @IdentitySmallIntKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE ORNEKLER.IDENTITY_SMALL_INT
			 SET 
			Adi = @Adi
			
			WHERE 
			 IdentitySmallIntKey = @IdentitySmallIntKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO ORNEKLER.IDENTITY_SMALL_INT 
			 (IdentitySmallIntKey,Adi) 
			 VALUES 
						(@IdentitySmallIntKey,@Adi)";
		}
	}
	public IdentitySmallInt SorgulaIdentitySmallIntKeyIle(short p1)
	{
		List<IdentitySmallInt> liste = new List<IdentitySmallInt>();
		SorguCalistir(liste,String.Format(" IdentitySmallIntKey = '{0}'", p1));		
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
			return "IdentitySmallIntKey";
		}
	}
	
	public virtual void Sil(short IdentitySmallIntKey)
	{
		IdentitySmallInt satir = new IdentitySmallInt();
		satir.IdentitySmallIntKey = IdentitySmallIntKey;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, IdentitySmallInt satir)
	{
		satir.IdentitySmallIntKey = dr.GetInt16(0);
		satir.Adi = dr.GetString(1);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, IdentitySmallInt satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@IdentitySmallIntKey",SqlDbType.SmallInt, satir.IdentitySmallIntKey);
		builder.parameterEkle("@Adi",SqlDbType.VarChar, satir.Adi,50);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	IdentitySmallInt	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@IdentitySmallIntKey",SqlDbType.SmallInt, satir.IdentitySmallIntKey);
		builder.parameterEkle("@Adi",SqlDbType.VarChar, satir.Adi,50);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	IdentitySmallInt	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@IdentitySmallIntKey",SqlDbType.SmallInt, satir.IdentitySmallIntKey);
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
