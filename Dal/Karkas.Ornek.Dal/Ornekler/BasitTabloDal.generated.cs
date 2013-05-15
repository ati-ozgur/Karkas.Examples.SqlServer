
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
public partial class BasitTabloDal : BaseDal<BasitTablo>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Ornek";
		}
	}
	protected override void identityKolonDegeriniSetle(BasitTablo pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM ORNEKLER.BASIT_TABLO";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT BasitTabloKey,Adi,Soyadi,GKullaniciKey,UTarihi FROM ORNEKLER.BASIT_TABLO";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM ORNEKLER.BASIT_TABLO WHERE BasitTabloKey = @BasitTabloKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE ORNEKLER.BASIT_TABLO
			 SET 
			Adi = @Adi
,Soyadi = @Soyadi
,GKullaniciKey = @GKullaniciKey
,UTarihi = @UTarihi
			
			WHERE 
			 BasitTabloKey = @BasitTabloKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO ORNEKLER.BASIT_TABLO 
			 (BasitTabloKey,Adi,Soyadi,GKullaniciKey,UTarihi) 
			 VALUES 
						(@BasitTabloKey,@Adi,@Soyadi,@GKullaniciKey,@UTarihi)";
		}
	}
	public BasitTablo SorgulaBasitTabloKeyIle(Guid p1)
	{
		List<BasitTablo> liste = new List<BasitTablo>();
		SorguCalistir(liste,String.Format(" BasitTabloKey = '{0}'", p1));		
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
			return "BasitTabloKey";
		}
	}
	
	public virtual void Sil(Guid BasitTabloKey)
	{
		BasitTablo satir = new BasitTablo();
		satir.BasitTabloKey = BasitTabloKey;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, BasitTablo satir)
	{
		satir.BasitTabloKey = dr.GetGuid(0);
		satir.Adi = dr.GetString(1);
		satir.Soyadi = dr.GetString(2);
		if (!dr.IsDBNull(3))
		{
			satir.GkullaniciKey = dr.GetGuid(3);
		}
		if (!dr.IsDBNull(4))
		{
			satir.Utarihi = dr.GetDateTime(4);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, BasitTablo satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@BasitTabloKey",SqlDbType.UniqueIdentifier, satir.BasitTabloKey);
		builder.parameterEkle("@Adi",SqlDbType.VarChar, satir.Adi,50);
		builder.parameterEkle("@Soyadi",SqlDbType.VarChar, satir.Soyadi,50);
		builder.parameterEkle("@GKullaniciKey",SqlDbType.UniqueIdentifier, satir.GkullaniciKey);
		builder.parameterEkle("@UTarihi",SqlDbType.SmallDateTime, satir.Utarihi);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	BasitTablo	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@BasitTabloKey",SqlDbType.UniqueIdentifier, satir.BasitTabloKey);
		builder.parameterEkle("@Adi",SqlDbType.VarChar, satir.Adi,50);
		builder.parameterEkle("@Soyadi",SqlDbType.VarChar, satir.Soyadi,50);
		builder.parameterEkle("@GKullaniciKey",SqlDbType.UniqueIdentifier, satir.GkullaniciKey);
		builder.parameterEkle("@UTarihi",SqlDbType.SmallDateTime, satir.Utarihi);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	BasitTablo	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@BasitTabloKey",SqlDbType.UniqueIdentifier, satir.BasitTabloKey);
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
