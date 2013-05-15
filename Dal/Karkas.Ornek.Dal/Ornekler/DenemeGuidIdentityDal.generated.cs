
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
public partial class DenemeGuidIdentityDal : BaseDal<DenemeGuidIdentity>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Ornek";
		}
	}
	protected override void identityKolonDegeriniSetle(DenemeGuidIdentity pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM ORNEKLER.DENEME_GUID_IDENTITY";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT DenemeKey,DenemeNo,DenemeKolon FROM ORNEKLER.DENEME_GUID_IDENTITY";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM ORNEKLER.DENEME_GUID_IDENTITY WHERE DenemeKey = @DenemeKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE ORNEKLER.DENEME_GUID_IDENTITY
			 SET 
			DenemeNo = @DenemeNo
,DenemeKolon = @DenemeKolon
			
			WHERE 
			 DenemeKey = @DenemeKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO ORNEKLER.DENEME_GUID_IDENTITY 
			 (DenemeKey,DenemeNo,DenemeKolon) 
			 VALUES 
						(@DenemeKey,@DenemeNo,@DenemeKolon)";
		}
	}
	public DenemeGuidIdentity SorgulaDenemeKeyIle(Guid p1)
	{
		List<DenemeGuidIdentity> liste = new List<DenemeGuidIdentity>();
		SorguCalistir(liste,String.Format(" DenemeKey = '{0}'", p1));		
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
			return "DenemeKey";
		}
	}
	
	public virtual void Sil(Guid DenemeKey)
	{
		DenemeGuidIdentity satir = new DenemeGuidIdentity();
		satir.DenemeKey = DenemeKey;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, DenemeGuidIdentity satir)
	{
		satir.DenemeKey = dr.GetGuid(0);
		satir.DenemeNo = dr.GetInt32(1);
		satir.DenemeKolon = dr.GetString(2);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, DenemeGuidIdentity satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@DenemeKey",SqlDbType.UniqueIdentifier, satir.DenemeKey);
		builder.parameterEkle("@DenemeNo",SqlDbType.Int, satir.DenemeNo);
		builder.parameterEkle("@DenemeKolon",SqlDbType.VarChar, satir.DenemeKolon,50);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	DenemeGuidIdentity	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@DenemeKey",SqlDbType.UniqueIdentifier, satir.DenemeKey);
		builder.parameterEkle("@DenemeNo",SqlDbType.Int, satir.DenemeNo);
		builder.parameterEkle("@DenemeKolon",SqlDbType.VarChar, satir.DenemeKolon,50);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	DenemeGuidIdentity	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@DenemeKey",SqlDbType.UniqueIdentifier, satir.DenemeKey);
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
