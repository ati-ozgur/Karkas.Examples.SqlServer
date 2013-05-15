
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
public partial class AciklamaDal : BaseDal<Aciklama>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Ornek";
		}
	}
	protected override void identityKolonDegeriniSetle(Aciklama pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM ORNEKLER.ACIKLAMA";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT AciklamaKey,Aciklama FROM ORNEKLER.ACIKLAMA";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM ORNEKLER.ACIKLAMA WHERE AciklamaKey = @AciklamaKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE ORNEKLER.ACIKLAMA
			 SET 
			Aciklama = @Aciklama
			
			WHERE 
			 AciklamaKey = @AciklamaKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO ORNEKLER.ACIKLAMA 
			 (AciklamaKey,Aciklama) 
			 VALUES 
						(@AciklamaKey,@Aciklama)";
		}
	}
	public Aciklama SorgulaAciklamaKeyIle(Guid p1)
	{
		List<Aciklama> liste = new List<Aciklama>();
		SorguCalistir(liste,String.Format(" AciklamaKey = '{0}'", p1));		
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
			return "AciklamaKey";
		}
	}
	
	public virtual void Sil(Guid AciklamaKey)
	{
		Aciklama satir = new Aciklama();
		satir.AciklamaKey = AciklamaKey;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, Aciklama satir)
	{
		satir.AciklamaKey = dr.GetGuid(0);
		satir.AciklamaProperty = dr.GetString(1);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Aciklama satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@AciklamaKey",SqlDbType.UniqueIdentifier, satir.AciklamaKey);
		builder.parameterEkle("@Aciklama",SqlDbType.VarChar, satir.AciklamaProperty,50);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Aciklama	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@AciklamaKey",SqlDbType.UniqueIdentifier, satir.AciklamaKey);
		builder.parameterEkle("@Aciklama",SqlDbType.VarChar, satir.AciklamaProperty,50);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Aciklama	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@AciklamaKey",SqlDbType.UniqueIdentifier, satir.AciklamaKey);
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
