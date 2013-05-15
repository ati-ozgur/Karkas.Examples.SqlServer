
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
public partial class OrnekTabloDal : BaseDal<OrnekTablo>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Ornek";
		}
	}
	protected override void identityKolonDegeriniSetle(OrnekTablo pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM ORNEKLER.ORNEK_TABLO";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT OrnekTabloKey,KolonBigInt,KolonBinary,KolonBit,KolonChar,KolonDateTime,KolonDecimal,KolonFloat,KolonImage,KolonInt,KolonMoney,KolonNChar,KolonNText,KolonNumeric,KolonNVarchar,KolonNVarcharMax,KolonReal,KolonSmallDateTime,KolonSmallInt,KolonSmallMoney,KolonSqlVariant,KolonText,KolonTimeStamp,KolonTinyInt,KolonUniqueIdentifier,KolonVarBinary,KolonVarBinaryMax,KolonVarchar,KolonVarcharMax,KolonXml FROM ORNEKLER.ORNEK_TABLO";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM ORNEKLER.ORNEK_TABLO WHERE OrnekTabloKey = @OrnekTabloKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE ORNEKLER.ORNEK_TABLO
			 SET 
			KolonBigInt = @KolonBigInt
,KolonBinary = @KolonBinary
,KolonBit = @KolonBit
,KolonChar = @KolonChar
,KolonDateTime = @KolonDateTime
,KolonDecimal = @KolonDecimal
,KolonFloat = @KolonFloat
,KolonImage = @KolonImage
,KolonInt = @KolonInt
,KolonMoney = @KolonMoney
,KolonNChar = @KolonNChar
,KolonNText = @KolonNText
,KolonNumeric = @KolonNumeric
,KolonNVarchar = @KolonNVarchar
,KolonNVarcharMax = @KolonNVarcharMax
,KolonReal = @KolonReal
,KolonSmallDateTime = @KolonSmallDateTime
,KolonSmallInt = @KolonSmallInt
,KolonSmallMoney = @KolonSmallMoney
,KolonSqlVariant = @KolonSqlVariant
,KolonText = @KolonText
,KolonTinyInt = @KolonTinyInt
,KolonUniqueIdentifier = @KolonUniqueIdentifier
,KolonVarBinary = @KolonVarBinary
,KolonVarBinaryMax = @KolonVarBinaryMax
,KolonVarchar = @KolonVarchar
,KolonVarcharMax = @KolonVarcharMax
,KolonXml = @KolonXml
			
			WHERE 
			 OrnekTabloKey = @OrnekTabloKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO ORNEKLER.ORNEK_TABLO 
			 (OrnekTabloKey,KolonBigInt,KolonBinary,KolonBit,KolonChar,KolonDateTime,KolonDecimal,KolonFloat,KolonImage,KolonInt,KolonMoney,KolonNChar,KolonNText,KolonNumeric,KolonNVarchar,KolonNVarcharMax,KolonReal,KolonSmallDateTime,KolonSmallInt,KolonSmallMoney,KolonSqlVariant,KolonText,KolonTinyInt,KolonUniqueIdentifier,KolonVarBinary,KolonVarBinaryMax,KolonVarchar,KolonVarcharMax,KolonXml) 
			 VALUES 
						(@OrnekTabloKey,@KolonBigInt,@KolonBinary,@KolonBit,@KolonChar,@KolonDateTime,@KolonDecimal,@KolonFloat,@KolonImage,@KolonInt,@KolonMoney,@KolonNChar,@KolonNText,@KolonNumeric,@KolonNVarchar,@KolonNVarcharMax,@KolonReal,@KolonSmallDateTime,@KolonSmallInt,@KolonSmallMoney,@KolonSqlVariant,@KolonText,@KolonTinyInt,@KolonUniqueIdentifier,@KolonVarBinary,@KolonVarBinaryMax,@KolonVarchar,@KolonVarcharMax,@KolonXml)";
		}
	}
	public OrnekTablo SorgulaOrnekTabloKeyIle(Guid p1)
	{
		List<OrnekTablo> liste = new List<OrnekTablo>();
		SorguCalistir(liste,String.Format(" OrnekTabloKey = '{0}'", p1));		
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
			return "OrnekTabloKey";
		}
	}
	
	public virtual void Sil(Guid OrnekTabloKey)
	{
		OrnekTablo satir = new OrnekTablo();
		satir.OrnekTabloKey = OrnekTabloKey;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, OrnekTablo satir)
	{
		satir.OrnekTabloKey = dr.GetGuid(0);
		if (!dr.IsDBNull(1))
		{
			satir.KolonBigInt = dr.GetInt64(1);
		}
		if (!dr.IsDBNull(2))
		{
			satir.KolonBinary = (Byte[])dr.GetValue(2);
		}
		if (!dr.IsDBNull(3))
		{
			satir.KolonBit = dr.GetBoolean(3);
		}
		if (!dr.IsDBNull(4))
		{
			satir.KolonChar = dr.GetString(4);
		}
		if (!dr.IsDBNull(5))
		{
			satir.KolonDateTime = dr.GetDateTime(5);
		}
		if (!dr.IsDBNull(6))
		{
			satir.KolonDecimal = dr.GetDecimal(6);
		}
		if (!dr.IsDBNull(7))
		{
			satir.KolonFloat = dr.GetDouble(7);
		}
		if (!dr.IsDBNull(8))
		{
			satir.KolonImage = (Byte[])dr.GetValue(8);
		}
		if (!dr.IsDBNull(9))
		{
			satir.KolonInt = dr.GetInt32(9);
		}
		if (!dr.IsDBNull(10))
		{
			satir.KolonMoney = dr.GetDecimal(10);
		}
		if (!dr.IsDBNull(11))
		{
			satir.KolonNchar = dr.GetString(11);
		}
		if (!dr.IsDBNull(12))
		{
			satir.KolonNtext = dr.GetString(12);
		}
		if (!dr.IsDBNull(13))
		{
			satir.KolonNumeric = dr.GetDecimal(13);
		}
		if (!dr.IsDBNull(14))
		{
			satir.KolonNvarchar = dr.GetString(14);
		}
		if (!dr.IsDBNull(15))
		{
			satir.KolonNvarcharMax = dr.GetString(15);
		}
		if (!dr.IsDBNull(16))
		{
			satir.KolonReal = dr.GetFloat(16);
		}
		if (!dr.IsDBNull(17))
		{
			satir.KolonSmallDateTime = dr.GetDateTime(17);
		}
		if (!dr.IsDBNull(18))
		{
			satir.KolonSmallInt = dr.GetInt16(18);
		}
		if (!dr.IsDBNull(19))
		{
			satir.KolonSmallMoney = dr.GetDecimal(19);
		}
		if (!dr.IsDBNull(20))
		{
			satir.KolonSqlVariant = dr.GetValue(20);
		}
		if (!dr.IsDBNull(21))
		{
			satir.KolonText = dr.GetString(21);
		}
		if (!dr.IsDBNull(22))
		{
			satir.KolonTimeStamp = (Byte[])dr.GetValue(22);
		}
		if (!dr.IsDBNull(23))
		{
			satir.KolonTinyInt = dr.GetByte(23);
		}
		if (!dr.IsDBNull(24))
		{
			satir.KolonUniqueIdentifier = dr.GetGuid(24);
		}
		if (!dr.IsDBNull(25))
		{
			satir.KolonVarBinary = (Byte[])dr.GetValue(25);
		}
		if (!dr.IsDBNull(26))
		{
			satir.KolonVarBinaryMax = (Byte[])dr.GetValue(26);
		}
		if (!dr.IsDBNull(27))
		{
			satir.KolonVarchar = dr.GetString(27);
		}
		if (!dr.IsDBNull(28))
		{
			satir.KolonVarcharMax = dr.GetString(28);
		}
		if (!dr.IsDBNull(29))
		{
			satir.KolonXml = dr.GetString(29);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, OrnekTablo satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@OrnekTabloKey",SqlDbType.UniqueIdentifier, satir.OrnekTabloKey);
		builder.parameterEkle("@KolonBigInt",SqlDbType.BigInt, satir.KolonBigInt);
		builder.parameterEkle("@KolonBinary",SqlDbType.Binary, satir.KolonBinary);
		builder.parameterEkle("@KolonBit",SqlDbType.Bit, satir.KolonBit);
		builder.parameterEkle("@KolonChar",SqlDbType.Char, satir.KolonChar,10);
		builder.parameterEkle("@KolonDateTime",SqlDbType.DateTime, satir.KolonDateTime);
		builder.parameterEkle("@KolonDecimal",SqlDbType.Decimal, satir.KolonDecimal);
		builder.parameterEkle("@KolonFloat",SqlDbType.Float, satir.KolonFloat);
		builder.parameterEkle("@KolonImage",SqlDbType.Image, satir.KolonImage);
		builder.parameterEkle("@KolonInt",SqlDbType.Int, satir.KolonInt);
		builder.parameterEkle("@KolonMoney",SqlDbType.Money, satir.KolonMoney);
		builder.parameterEkle("@KolonNChar",SqlDbType.NChar, satir.KolonNchar,10);
		builder.parameterEkle("@KolonNText",SqlDbType.NText, satir.KolonNtext);
		builder.parameterEkle("@KolonNumeric",SqlDbType.Decimal, satir.KolonNumeric);
		builder.parameterEkle("@KolonNVarchar",SqlDbType.NVarChar, satir.KolonNvarchar,50);
		builder.parameterEkle("@KolonNVarcharMax",SqlDbType.NVarChar, satir.KolonNvarcharMax,-1);
		builder.parameterEkle("@KolonReal",SqlDbType.Real, satir.KolonReal);
		builder.parameterEkle("@KolonSmallDateTime",SqlDbType.SmallDateTime, satir.KolonSmallDateTime);
		builder.parameterEkle("@KolonSmallInt",SqlDbType.SmallInt, satir.KolonSmallInt);
		builder.parameterEkle("@KolonSmallMoney",SqlDbType.SmallMoney, satir.KolonSmallMoney);
		builder.parameterEkle("@KolonSqlVariant",SqlDbType.Variant, satir.KolonSqlVariant);
		builder.parameterEkle("@KolonText",SqlDbType.Text, satir.KolonText);
		builder.parameterEkle("@KolonTinyInt",SqlDbType.TinyInt, satir.KolonTinyInt);
		builder.parameterEkle("@KolonUniqueIdentifier",SqlDbType.UniqueIdentifier, satir.KolonUniqueIdentifier);
		builder.parameterEkle("@KolonVarBinary",SqlDbType.VarBinary, satir.KolonVarBinary);
		builder.parameterEkle("@KolonVarBinaryMax",SqlDbType.VarBinary, satir.KolonVarBinaryMax);
		builder.parameterEkle("@KolonVarchar",SqlDbType.VarChar, satir.KolonVarchar,50);
		builder.parameterEkle("@KolonVarcharMax",SqlDbType.VarChar, satir.KolonVarcharMax,-1);
		builder.parameterEkle("@KolonXml",SqlDbType.Xml, satir.KolonXml);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	OrnekTablo	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@OrnekTabloKey",SqlDbType.UniqueIdentifier, satir.OrnekTabloKey);
		builder.parameterEkle("@KolonBigInt",SqlDbType.BigInt, satir.KolonBigInt);
		builder.parameterEkle("@KolonBinary",SqlDbType.Binary, satir.KolonBinary);
		builder.parameterEkle("@KolonBit",SqlDbType.Bit, satir.KolonBit);
		builder.parameterEkle("@KolonChar",SqlDbType.Char, satir.KolonChar,10);
		builder.parameterEkle("@KolonDateTime",SqlDbType.DateTime, satir.KolonDateTime);
		builder.parameterEkle("@KolonDecimal",SqlDbType.Decimal, satir.KolonDecimal);
		builder.parameterEkle("@KolonFloat",SqlDbType.Float, satir.KolonFloat);
		builder.parameterEkle("@KolonImage",SqlDbType.Image, satir.KolonImage);
		builder.parameterEkle("@KolonInt",SqlDbType.Int, satir.KolonInt);
		builder.parameterEkle("@KolonMoney",SqlDbType.Money, satir.KolonMoney);
		builder.parameterEkle("@KolonNChar",SqlDbType.NChar, satir.KolonNchar,10);
		builder.parameterEkle("@KolonNText",SqlDbType.NText, satir.KolonNtext);
		builder.parameterEkle("@KolonNumeric",SqlDbType.Decimal, satir.KolonNumeric);
		builder.parameterEkle("@KolonNVarchar",SqlDbType.NVarChar, satir.KolonNvarchar,50);
		builder.parameterEkle("@KolonNVarcharMax",SqlDbType.NVarChar, satir.KolonNvarcharMax,-1);
		builder.parameterEkle("@KolonReal",SqlDbType.Real, satir.KolonReal);
		builder.parameterEkle("@KolonSmallDateTime",SqlDbType.SmallDateTime, satir.KolonSmallDateTime);
		builder.parameterEkle("@KolonSmallInt",SqlDbType.SmallInt, satir.KolonSmallInt);
		builder.parameterEkle("@KolonSmallMoney",SqlDbType.SmallMoney, satir.KolonSmallMoney);
		builder.parameterEkle("@KolonSqlVariant",SqlDbType.Variant, satir.KolonSqlVariant);
		builder.parameterEkle("@KolonText",SqlDbType.Text, satir.KolonText);
		builder.parameterEkle("@KolonTinyInt",SqlDbType.TinyInt, satir.KolonTinyInt);
		builder.parameterEkle("@KolonUniqueIdentifier",SqlDbType.UniqueIdentifier, satir.KolonUniqueIdentifier);
		builder.parameterEkle("@KolonVarBinary",SqlDbType.VarBinary, satir.KolonVarBinary);
		builder.parameterEkle("@KolonVarBinaryMax",SqlDbType.VarBinary, satir.KolonVarBinaryMax);
		builder.parameterEkle("@KolonVarchar",SqlDbType.VarChar, satir.KolonVarchar,50);
		builder.parameterEkle("@KolonVarcharMax",SqlDbType.VarChar, satir.KolonVarcharMax,-1);
		builder.parameterEkle("@KolonXml",SqlDbType.Xml, satir.KolonXml);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	OrnekTablo	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@OrnekTabloKey",SqlDbType.UniqueIdentifier, satir.OrnekTabloKey);
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
