
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
public partial class MusteriSiparisDal : BaseDal<MusteriSiparis>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Ornek";
		}
	}
	protected override void identityKolonDegeriniSetle(MusteriSiparis pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM ORNEKLER.MUSTERI_SIPARIS";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT MusteriSiparisKey,MusteriKey,Tutar,SiparisTarihi FROM ORNEKLER.MUSTERI_SIPARIS";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM ORNEKLER.MUSTERI_SIPARIS WHERE MusteriSiparisKey = @MusteriSiparisKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE ORNEKLER.MUSTERI_SIPARIS
			 SET 
			MusteriKey = @MusteriKey
,Tutar = @Tutar
,SiparisTarihi = @SiparisTarihi
			
			WHERE 
			 MusteriSiparisKey = @MusteriSiparisKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO ORNEKLER.MUSTERI_SIPARIS 
			 (MusteriSiparisKey,MusteriKey,Tutar,SiparisTarihi) 
			 VALUES 
						(@MusteriSiparisKey,@MusteriKey,@Tutar,@SiparisTarihi)";
		}
	}
	public MusteriSiparis SorgulaMusteriSiparisKeyIle(Guid p1)
	{
		List<MusteriSiparis> liste = new List<MusteriSiparis>();
		SorguCalistir(liste,String.Format(" MusteriSiparisKey = '{0}'", p1));		
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
			return "MusteriSiparisKey";
		}
	}
	
	public virtual void Sil(Guid MusteriSiparisKey)
	{
		MusteriSiparis satir = new MusteriSiparis();
		satir.MusteriSiparisKey = MusteriSiparisKey;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, MusteriSiparis satir)
	{
		satir.MusteriSiparisKey = dr.GetGuid(0);
		satir.MusteriKey = dr.GetGuid(1);
		satir.Tutar = dr.GetDecimal(2);
		satir.SiparisTarihi = dr.GetDateTime(3);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, MusteriSiparis satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@MusteriSiparisKey",SqlDbType.UniqueIdentifier, satir.MusteriSiparisKey);
		builder.parameterEkle("@MusteriKey",SqlDbType.UniqueIdentifier, satir.MusteriKey);
		builder.parameterEkle("@Tutar",SqlDbType.Decimal, satir.Tutar);
		builder.parameterEkle("@SiparisTarihi",SqlDbType.DateTime, satir.SiparisTarihi);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	MusteriSiparis	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@MusteriSiparisKey",SqlDbType.UniqueIdentifier, satir.MusteriSiparisKey);
		builder.parameterEkle("@MusteriKey",SqlDbType.UniqueIdentifier, satir.MusteriKey);
		builder.parameterEkle("@Tutar",SqlDbType.Decimal, satir.Tutar);
		builder.parameterEkle("@SiparisTarihi",SqlDbType.DateTime, satir.SiparisTarihi);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	MusteriSiparis	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@MusteriSiparisKey",SqlDbType.UniqueIdentifier, satir.MusteriSiparisKey);
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
