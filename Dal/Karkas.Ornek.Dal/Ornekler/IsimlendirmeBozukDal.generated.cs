
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
public partial class IsimlendirmeBozukDal : BaseDal<IsimlendirmeBozuk>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Ornek";
		}
	}
	protected override void identityKolonDegeriniSetle(IsimlendirmeBozuk pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM ORNEKLER.ISIMLENDIRME_BOZUK";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT KISI_OID,ADI,SOYADI FROM ORNEKLER.ISIMLENDIRME_BOZUK";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM ORNEKLER.ISIMLENDIRME_BOZUK WHERE KISI_OID = @KISI_OID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE ORNEKLER.ISIMLENDIRME_BOZUK
			 SET 
			ADI = @ADI
,SOYADI = @SOYADI
			
			WHERE 
			 KISI_OID = @KISI_OID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO ORNEKLER.ISIMLENDIRME_BOZUK 
			 (KISI_OID,ADI,SOYADI) 
			 VALUES 
						(@KISI_OID,@ADI,@SOYADI)";
		}
	}
	public IsimlendirmeBozuk SorgulaKisiOidIle(int p1)
	{
		List<IsimlendirmeBozuk> liste = new List<IsimlendirmeBozuk>();
		SorguCalistir(liste,String.Format(" KISI_OID = '{0}'", p1));		
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
			return "KISI_OID";
		}
	}
	
	public virtual void Sil(int KisiOid)
	{
		IsimlendirmeBozuk satir = new IsimlendirmeBozuk();
		satir.KisiOid = KisiOid;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, IsimlendirmeBozuk satir)
	{
		satir.KisiOid = dr.GetInt32(0);
		satir.Adi = dr.GetString(1);
		satir.Soyadi = dr.GetString(2);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, IsimlendirmeBozuk satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@KISI_OID",SqlDbType.Int, satir.KisiOid);
		builder.parameterEkle("@ADI",SqlDbType.VarChar, satir.Adi,50);
		builder.parameterEkle("@SOYADI",SqlDbType.VarChar, satir.Soyadi,50);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	IsimlendirmeBozuk	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@KISI_OID",SqlDbType.Int, satir.KisiOid);
		builder.parameterEkle("@ADI",SqlDbType.VarChar, satir.Adi,50);
		builder.parameterEkle("@SOYADI",SqlDbType.VarChar, satir.Soyadi,50);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	IsimlendirmeBozuk	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@KISI_OID",SqlDbType.Int, satir.KisiOid);
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
