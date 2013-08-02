
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
public partial class ButunVeriYapilari2008r2Dal : BaseDal<ButunVeriYapilari2008r2>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Ornek";
		}
	}
	protected override void identityKolonDegeriniSetle(ButunVeriYapilari2008r2 pTypeLibrary,long pIdentityKolonValue)
	{
		pTypeLibrary.ButunVeriYapilari2008r2key = (int )pIdentityKolonValue;
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM ORNEKLER.BUTUN_VERI_YAPILARI_2008R2";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT ButunVeriYapilari2008R2Key,BigIntColumn,BinaryColumn,BitColumn,CharColumn,DateColumn,DateTimeColumn,DateTime2Column,DateTimeOffsetColumn,DecimalColumn,FloatColumn,GeopgraphyColummn,GeometryColumn,HierarchyIdColumn,ImageColumn,IntColumn,MoneyColumn,NCharColumn,NTextColumn,NumericColumn,NVarcharColumn,NVarcharMaxColumn,RealColumn,smallDateTimeColumn,smallIntColumn,SmallMoneyColumn,SqlVariantColumn,TextColumn,TimeColumn,TimestampColumn,TinyIntColumn,UniqueIdentifierColumn,VarBinaryColumn,VarBinaryMaxColumn,VarCharColumn,VarCharMaxColumn,XmlColumn FROM ORNEKLER.BUTUN_VERI_YAPILARI_2008R2";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM ORNEKLER.BUTUN_VERI_YAPILARI_2008R2 WHERE ButunVeriYapilari2008R2Key = @ButunVeriYapilari2008R2Key ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE ORNEKLER.BUTUN_VERI_YAPILARI_2008R2
			 SET 
			BigIntColumn = @BigIntColumn
,BinaryColumn = @BinaryColumn
,BitColumn = @BitColumn
,CharColumn = @CharColumn
,DateColumn = @DateColumn
,DateTimeColumn = @DateTimeColumn
,DateTime2Column = @DateTime2Column
,DateTimeOffsetColumn = @DateTimeOffsetColumn
,DecimalColumn = @DecimalColumn
,FloatColumn = @FloatColumn
,GeopgraphyColummn = @GeopgraphyColummn
,GeometryColumn = @GeometryColumn
,HierarchyIdColumn = @HierarchyIdColumn
,ImageColumn = @ImageColumn
,IntColumn = @IntColumn
,MoneyColumn = @MoneyColumn
,NCharColumn = @NCharColumn
,NTextColumn = @NTextColumn
,NumericColumn = @NumericColumn
,NVarcharColumn = @NVarcharColumn
,NVarcharMaxColumn = @NVarcharMaxColumn
,RealColumn = @RealColumn
,smallDateTimeColumn = @smallDateTimeColumn
,smallIntColumn = @smallIntColumn
,SmallMoneyColumn = @SmallMoneyColumn
,SqlVariantColumn = @SqlVariantColumn
,TextColumn = @TextColumn
,TimeColumn = @TimeColumn
,TinyIntColumn = @TinyIntColumn
,UniqueIdentifierColumn = @UniqueIdentifierColumn
,VarBinaryColumn = @VarBinaryColumn
,VarBinaryMaxColumn = @VarBinaryMaxColumn
,VarCharColumn = @VarCharColumn
,VarCharMaxColumn = @VarCharMaxColumn
,XmlColumn = @XmlColumn
			
			WHERE 
			 ButunVeriYapilari2008R2Key = @ButunVeriYapilari2008R2Key
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO ORNEKLER.BUTUN_VERI_YAPILARI_2008R2 
			 (BigIntColumn,BinaryColumn,BitColumn,CharColumn,DateColumn,DateTimeColumn,DateTime2Column,DateTimeOffsetColumn,DecimalColumn,FloatColumn,GeopgraphyColummn,GeometryColumn,HierarchyIdColumn,ImageColumn,IntColumn,MoneyColumn,NCharColumn,NTextColumn,NumericColumn,NVarcharColumn,NVarcharMaxColumn,RealColumn,smallDateTimeColumn,smallIntColumn,SmallMoneyColumn,SqlVariantColumn,TextColumn,TimeColumn,TinyIntColumn,UniqueIdentifierColumn,VarBinaryColumn,VarBinaryMaxColumn,VarCharColumn,VarCharMaxColumn,XmlColumn) 
			 VALUES 
						(@BigIntColumn,@BinaryColumn,@BitColumn,@CharColumn,@DateColumn,@DateTimeColumn,@DateTime2Column,@DateTimeOffsetColumn,@DecimalColumn,@FloatColumn,@GeopgraphyColummn,@GeometryColumn,@HierarchyIdColumn,@ImageColumn,@IntColumn,@MoneyColumn,@NCharColumn,@NTextColumn,@NumericColumn,@NVarcharColumn,@NVarcharMaxColumn,@RealColumn,@smallDateTimeColumn,@smallIntColumn,@SmallMoneyColumn,@SqlVariantColumn,@TextColumn,@TimeColumn,@TinyIntColumn,@UniqueIdentifierColumn,@VarBinaryColumn,@VarBinaryMaxColumn,@VarCharColumn,@VarCharMaxColumn,@XmlColumn);SELECT scope_identity();";
		}
	}
	public ButunVeriYapilari2008r2 SorgulaButunVeriYapilari2008r2keyIle(int p1)
	{
		List<ButunVeriYapilari2008r2> liste = new List<ButunVeriYapilari2008r2>();
		SorguCalistir(liste,String.Format(" ButunVeriYapilari2008R2Key = '{0}'", p1));		
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
			return true;
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
			return "ButunVeriYapilari2008R2Key";
		}
	}
	
	public virtual void Sil(int ButunVeriYapilari2008r2key)
	{
		ButunVeriYapilari2008r2 satir = new ButunVeriYapilari2008r2();
		satir.ButunVeriYapilari2008r2key = ButunVeriYapilari2008r2key;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, ButunVeriYapilari2008r2 satir)
	{
		satir.ButunVeriYapilari2008r2key = dr.GetInt32(0);
		if (!dr.IsDBNull(1))
		{
			satir.BigIntColumn = dr.GetInt64(1);
		}
		if (!dr.IsDBNull(2))
		{
			satir.BinaryColumn = (Byte[])dr.GetValue(2);
		}
		if (!dr.IsDBNull(3))
		{
			satir.BitColumn = dr.GetBoolean(3);
		}
		if (!dr.IsDBNull(4))
		{
			satir.CharColumn = dr.GetString(4);
		}
		if (!dr.IsDBNull(5))
		{
			satir.DateColumn = dr.GetDateTime(5);
		}
		if (!dr.IsDBNull(6))
		{
			satir.DateTimeColumn = dr.GetDateTime(6);
		}
		if (!dr.IsDBNull(7))
		{
			satir.DateTime2column = dr.GetDateTime(7);
		}
		if (!dr.IsDBNull(8))
		{
			satir.DateTimeOffsetColumn = DateTimeOffset(8);
		}
		if (!dr.IsDBNull(9))
		{
			satir.DecimalColumn = dr.GetDecimal(9);
		}
		if (!dr.IsDBNull(10))
		{
			satir.FloatColumn = dr.GetDouble(10);
		}
		if (!dr.IsDBNull(11))
		{
			satir.GeopgraphyColummn = SqlGeography(11);
		}
		if (!dr.IsDBNull(12))
		{
			satir.GeometryColumn = SqlGeometry(12);
		}
		if (!dr.IsDBNull(13))
		{
			satir.HierarchyIdColumn = SqlHierarchyId(13);
		}
		if (!dr.IsDBNull(14))
		{
			satir.ImageColumn = (Byte[])dr.GetValue(14);
		}
		if (!dr.IsDBNull(15))
		{
			satir.IntColumn = dr.GetInt32(15);
		}
		if (!dr.IsDBNull(16))
		{
			satir.MoneyColumn = dr.GetDecimal(16);
		}
		if (!dr.IsDBNull(17))
		{
			satir.NcharColumn = dr.GetString(17);
		}
		if (!dr.IsDBNull(18))
		{
			satir.NtextColumn = dr.GetString(18);
		}
		if (!dr.IsDBNull(19))
		{
			satir.NumericColumn = dr.GetDecimal(19);
		}
		if (!dr.IsDBNull(20))
		{
			satir.NvarcharColumn = dr.GetString(20);
		}
		if (!dr.IsDBNull(21))
		{
			satir.NvarcharMaxColumn = dr.GetString(21);
		}
		if (!dr.IsDBNull(22))
		{
			satir.RealColumn = dr.GetFloat(22);
		}
		if (!dr.IsDBNull(23))
		{
			satir.SmallDateTimeColumn = dr.GetDateTime(23);
		}
		if (!dr.IsDBNull(24))
		{
			satir.SmallIntColumn = dr.GetInt16(24);
		}
		if (!dr.IsDBNull(25))
		{
			satir.SmallMoneyColumn = dr.GetDecimal(25);
		}
		if (!dr.IsDBNull(26))
		{
			satir.SqlVariantColumn = dr.GetValue(26);
		}
		if (!dr.IsDBNull(27))
		{
			satir.TextColumn = dr.GetString(27);
		}
		if (!dr.IsDBNull(28))
		{
			satir.TimeColumn = TimeSpan(28);
		}
		if (!dr.IsDBNull(29))
		{
			satir.TimestampColumn = (Byte[])dr.GetValue(29);
		}
		if (!dr.IsDBNull(30))
		{
			satir.TinyIntColumn = dr.GetByte(30);
		}
		if (!dr.IsDBNull(31))
		{
			satir.UniqueIdentifierColumn = dr.GetGuid(31);
		}
		if (!dr.IsDBNull(32))
		{
			satir.VarBinaryColumn = (Byte[])dr.GetValue(32);
		}
		if (!dr.IsDBNull(33))
		{
			satir.VarBinaryMaxColumn = (Byte[])dr.GetValue(33);
		}
		if (!dr.IsDBNull(34))
		{
			satir.VarCharColumn = dr.GetString(34);
		}
		if (!dr.IsDBNull(35))
		{
			satir.VarCharMaxColumn = dr.GetString(35);
		}
		if (!dr.IsDBNull(36))
		{
			satir.XmlColumn = dr.GetString(36);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, ButunVeriYapilari2008r2 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@BigIntColumn",SqlDbType.BigInt, satir.BigIntColumn);
		builder.parameterEkle("@BinaryColumn",SqlDbType.Binary, satir.BinaryColumn);
		builder.parameterEkle("@BitColumn",SqlDbType.Bit, satir.BitColumn);
		builder.parameterEkle("@CharColumn",SqlDbType.Char, satir.CharColumn,10);
		builder.parameterEkle("@DateColumn",SqlDbType.date, satir.DateColumn);
		builder.parameterEkle("@DateTimeColumn",SqlDbType.DateTime, satir.DateTimeColumn);
		builder.parameterEkle("@DateTime2Column",SqlDbType.datetime2, satir.DateTime2column);
		builder.parameterEkle("@DateTimeOffsetColumn",SqlDbType.datetimeoffset, satir.DateTimeOffsetColumn);
		builder.parameterEkle("@DecimalColumn",SqlDbType.Decimal, satir.DecimalColumn);
		builder.parameterEkle("@FloatColumn",SqlDbType.Float, satir.FloatColumn);
		builder.parameterEkle("@GeopgraphyColummn",SqlDbType.geography, satir.GeopgraphyColummn);
		builder.parameterEkle("@GeometryColumn",SqlDbType.geometry, satir.GeometryColumn);
		builder.parameterEkle("@HierarchyIdColumn",SqlDbType.hierarchyid, satir.HierarchyIdColumn);
		builder.parameterEkle("@ImageColumn",SqlDbType.Image, satir.ImageColumn);
		builder.parameterEkle("@IntColumn",SqlDbType.Int, satir.IntColumn);
		builder.parameterEkle("@MoneyColumn",SqlDbType.Money, satir.MoneyColumn);
		builder.parameterEkle("@NCharColumn",SqlDbType.NChar, satir.NcharColumn,10);
		builder.parameterEkle("@NTextColumn",SqlDbType.NText, satir.NtextColumn);
		builder.parameterEkle("@NumericColumn",SqlDbType.Decimal, satir.NumericColumn);
		builder.parameterEkle("@NVarcharColumn",SqlDbType.NVarChar, satir.NvarcharColumn,50);
		builder.parameterEkle("@NVarcharMaxColumn",SqlDbType.NVarChar, satir.NvarcharMaxColumn,-1);
		builder.parameterEkle("@RealColumn",SqlDbType.Real, satir.RealColumn);
		builder.parameterEkle("@smallDateTimeColumn",SqlDbType.SmallDateTime, satir.SmallDateTimeColumn);
		builder.parameterEkle("@smallIntColumn",SqlDbType.SmallInt, satir.SmallIntColumn);
		builder.parameterEkle("@SmallMoneyColumn",SqlDbType.SmallMoney, satir.SmallMoneyColumn);
		builder.parameterEkle("@SqlVariantColumn",SqlDbType.Variant, satir.SqlVariantColumn);
		builder.parameterEkle("@TextColumn",SqlDbType.Text, satir.TextColumn);
		builder.parameterEkle("@TimeColumn",SqlDbType.time, satir.TimeColumn);
		builder.parameterEkle("@TinyIntColumn",SqlDbType.TinyInt, satir.TinyIntColumn);
		builder.parameterEkle("@UniqueIdentifierColumn",SqlDbType.UniqueIdentifier, satir.UniqueIdentifierColumn);
		builder.parameterEkle("@VarBinaryColumn",SqlDbType.VarBinary, satir.VarBinaryColumn);
		builder.parameterEkle("@VarBinaryMaxColumn",SqlDbType.VarBinary, satir.VarBinaryMaxColumn);
		builder.parameterEkle("@VarCharColumn",SqlDbType.VarChar, satir.VarCharColumn,50);
		builder.parameterEkle("@VarCharMaxColumn",SqlDbType.VarChar, satir.VarCharMaxColumn,-1);
		builder.parameterEkle("@XmlColumn",SqlDbType.Xml, satir.XmlColumn);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	ButunVeriYapilari2008r2	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@ButunVeriYapilari2008R2Key",SqlDbType.Int, satir.ButunVeriYapilari2008r2key);
		builder.parameterEkle("@BigIntColumn",SqlDbType.BigInt, satir.BigIntColumn);
		builder.parameterEkle("@BinaryColumn",SqlDbType.Binary, satir.BinaryColumn);
		builder.parameterEkle("@BitColumn",SqlDbType.Bit, satir.BitColumn);
		builder.parameterEkle("@CharColumn",SqlDbType.Char, satir.CharColumn,10);
		builder.parameterEkle("@DateColumn",SqlDbType.date, satir.DateColumn);
		builder.parameterEkle("@DateTimeColumn",SqlDbType.DateTime, satir.DateTimeColumn);
		builder.parameterEkle("@DateTime2Column",SqlDbType.datetime2, satir.DateTime2column);
		builder.parameterEkle("@DateTimeOffsetColumn",SqlDbType.datetimeoffset, satir.DateTimeOffsetColumn);
		builder.parameterEkle("@DecimalColumn",SqlDbType.Decimal, satir.DecimalColumn);
		builder.parameterEkle("@FloatColumn",SqlDbType.Float, satir.FloatColumn);
		builder.parameterEkle("@GeopgraphyColummn",SqlDbType.geography, satir.GeopgraphyColummn);
		builder.parameterEkle("@GeometryColumn",SqlDbType.geometry, satir.GeometryColumn);
		builder.parameterEkle("@HierarchyIdColumn",SqlDbType.hierarchyid, satir.HierarchyIdColumn);
		builder.parameterEkle("@ImageColumn",SqlDbType.Image, satir.ImageColumn);
		builder.parameterEkle("@IntColumn",SqlDbType.Int, satir.IntColumn);
		builder.parameterEkle("@MoneyColumn",SqlDbType.Money, satir.MoneyColumn);
		builder.parameterEkle("@NCharColumn",SqlDbType.NChar, satir.NcharColumn,10);
		builder.parameterEkle("@NTextColumn",SqlDbType.NText, satir.NtextColumn);
		builder.parameterEkle("@NumericColumn",SqlDbType.Decimal, satir.NumericColumn);
		builder.parameterEkle("@NVarcharColumn",SqlDbType.NVarChar, satir.NvarcharColumn,50);
		builder.parameterEkle("@NVarcharMaxColumn",SqlDbType.NVarChar, satir.NvarcharMaxColumn,-1);
		builder.parameterEkle("@RealColumn",SqlDbType.Real, satir.RealColumn);
		builder.parameterEkle("@smallDateTimeColumn",SqlDbType.SmallDateTime, satir.SmallDateTimeColumn);
		builder.parameterEkle("@smallIntColumn",SqlDbType.SmallInt, satir.SmallIntColumn);
		builder.parameterEkle("@SmallMoneyColumn",SqlDbType.SmallMoney, satir.SmallMoneyColumn);
		builder.parameterEkle("@SqlVariantColumn",SqlDbType.Variant, satir.SqlVariantColumn);
		builder.parameterEkle("@TextColumn",SqlDbType.Text, satir.TextColumn);
		builder.parameterEkle("@TimeColumn",SqlDbType.time, satir.TimeColumn);
		builder.parameterEkle("@TinyIntColumn",SqlDbType.TinyInt, satir.TinyIntColumn);
		builder.parameterEkle("@UniqueIdentifierColumn",SqlDbType.UniqueIdentifier, satir.UniqueIdentifierColumn);
		builder.parameterEkle("@VarBinaryColumn",SqlDbType.VarBinary, satir.VarBinaryColumn);
		builder.parameterEkle("@VarBinaryMaxColumn",SqlDbType.VarBinary, satir.VarBinaryMaxColumn);
		builder.parameterEkle("@VarCharColumn",SqlDbType.VarChar, satir.VarCharColumn,50);
		builder.parameterEkle("@VarCharMaxColumn",SqlDbType.VarChar, satir.VarCharMaxColumn,-1);
		builder.parameterEkle("@XmlColumn",SqlDbType.Xml, satir.XmlColumn);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	ButunVeriYapilari2008r2	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@ButunVeriYapilari2008R2Key",SqlDbType.Int, satir.ButunVeriYapilari2008r2key);
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
