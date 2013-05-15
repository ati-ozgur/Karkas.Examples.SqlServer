
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
public partial class MusteriDal : BaseDal<Musteri>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Ornek";
		}
	}
	protected override void identityKolonDegeriniSetle(Musteri pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM ORNEKLER.MUSTERI";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT MusteriKey,Adi,Soyadi,IkinciAdi,DogumTarihi,AktifMi,Onemi,Kredisi,TamAdi FROM ORNEKLER.MUSTERI";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM ORNEKLER.MUSTERI WHERE MusteriKey = @MusteriKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE ORNEKLER.MUSTERI
			 SET 
			Adi = @Adi
,Soyadi = @Soyadi
,IkinciAdi = @IkinciAdi
,DogumTarihi = @DogumTarihi
,AktifMi = @AktifMi
,Onemi = @Onemi
,Kredisi = @Kredisi
			
			WHERE 
			 MusteriKey = @MusteriKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO ORNEKLER.MUSTERI 
			 (MusteriKey,Adi,Soyadi,IkinciAdi,DogumTarihi,AktifMi,Onemi,Kredisi) 
			 VALUES 
						(@MusteriKey,@Adi,@Soyadi,@IkinciAdi,@DogumTarihi,@AktifMi,@Onemi,@Kredisi)";
		}
	}
	public Musteri SorgulaMusteriKeyIle(Guid p1)
	{
		List<Musteri> liste = new List<Musteri>();
		SorguCalistir(liste,String.Format(" MusteriKey = '{0}'", p1));		
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
			return "MusteriKey";
		}
	}
	
	public virtual void Sil(Guid MusteriKey)
	{
		Musteri satir = new Musteri();
		satir.MusteriKey = MusteriKey;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, Musteri satir)
	{
		satir.MusteriKey = dr.GetGuid(0);
		satir.Adi = dr.GetString(1);
		satir.Soyadi = dr.GetString(2);
		if (!dr.IsDBNull(3))
		{
			satir.IkinciAdi = dr.GetString(3);
		}
		if (!dr.IsDBNull(4))
		{
			satir.DogumTarihi = dr.GetDateTime(4);
		}
		satir.AktifMi = dr.GetBoolean(5);
		if (!dr.IsDBNull(6))
		{
			satir.Onemi = dr.GetInt32(6);
		}
		if (!dr.IsDBNull(7))
		{
			satir.Kredisi = dr.GetDecimal(7);
		}
		if (!dr.IsDBNull(8))
		{
			satir.TamAdi = dr.GetString(8);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Musteri satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@MusteriKey",SqlDbType.UniqueIdentifier, satir.MusteriKey);
		builder.parameterEkle("@Adi",SqlDbType.VarChar, satir.Adi,50);
		builder.parameterEkle("@Soyadi",SqlDbType.VarChar, satir.Soyadi,50);
		builder.parameterEkle("@IkinciAdi",SqlDbType.VarChar, satir.IkinciAdi,50);
		builder.parameterEkle("@DogumTarihi",SqlDbType.DateTime, satir.DogumTarihi);
		builder.parameterEkle("@AktifMi",SqlDbType.Bit, satir.AktifMi);
		builder.parameterEkle("@Onemi",SqlDbType.Int, satir.Onemi);
		builder.parameterEkle("@Kredisi",SqlDbType.Decimal, satir.Kredisi);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Musteri	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@MusteriKey",SqlDbType.UniqueIdentifier, satir.MusteriKey);
		builder.parameterEkle("@Adi",SqlDbType.VarChar, satir.Adi,50);
		builder.parameterEkle("@Soyadi",SqlDbType.VarChar, satir.Soyadi,50);
		builder.parameterEkle("@IkinciAdi",SqlDbType.VarChar, satir.IkinciAdi,50);
		builder.parameterEkle("@DogumTarihi",SqlDbType.DateTime, satir.DogumTarihi);
		builder.parameterEkle("@AktifMi",SqlDbType.Bit, satir.AktifMi);
		builder.parameterEkle("@Onemi",SqlDbType.Int, satir.Onemi);
		builder.parameterEkle("@Kredisi",SqlDbType.Decimal, satir.Kredisi);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Musteri	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@MusteriKey",SqlDbType.UniqueIdentifier, satir.MusteriKey);
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
