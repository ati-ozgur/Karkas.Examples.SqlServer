using System;
using System.Data;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections.Generic;
using Karkas.Core.TypeLibrary;
using Karkas.Core.Onaylama;
using Karkas.Core.Onaylama.ForPonos;
using System.ComponentModel.DataAnnotations;

namespace Karkas.Ornek.TypeLibrary.Ornekler
{
	[Serializable]
	[DebuggerDisplay("")]
	public partial class 	ButunVeriYapilari2008r2: BaseTypeLibrary
	{
		private Nullable<long> bigIntColumn;
		private byte[] binaryColumn;
		private Nullable<bool> bitColumn;
		private string charColumn;
		private Unknown dateColumn;
		private Nullable<DateTime> dateTimeColumn;
		private Unknown dateTime2column;
		private Unknown dateTimeOffsetColumn;
		private Nullable<decimal> decimalColumn;
		private Nullable<double> floatColumn;
		private Unknown geopgraphyColummn;
		private Unknown geometryColumn;
		private Unknown hierarchyIdColumn;
		private byte[] imageColumn;
		private Nullable<int> intColumn;
		private Nullable<decimal> moneyColumn;
		private string ncharColumn;
		private string ntextColumn;
		private Nullable<decimal> numericColumn;
		private string nvarcharColumn;
		private string nvarcharMaxColumn;
		private Nullable<float> realColumn;
		private Nullable<DateTime> smallDateTimeColumn;
		private Nullable<short> smallIntColumn;
		private Nullable<decimal> smallMoneyColumn;
		private object sqlVariantColumn;
		private string textColumn;
		private Unknown timeColumn;
		private byte[] timestampColumn;
		private Nullable<byte> tinyIntColumn;
		private Nullable<Guid> uniqueIdentifierColumn;
		private byte[] varBinaryColumn;
		private byte[] varBinaryMaxColumn;
		private string varCharColumn;
		private string varCharMaxColumn;
		private string xmlColumn;

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<long> BigIntColumn
		{
			[DebuggerStepThrough]
			get
			{
				return bigIntColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (bigIntColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				bigIntColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public byte[] BinaryColumn
		{
			[DebuggerStepThrough]
			get
			{
				return binaryColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (binaryColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				binaryColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<bool> BitColumn
		{
			[DebuggerStepThrough]
			get
			{
				return bitColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (bitColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				bitColumn = value;
			}
		}

		[StringLength(10)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string CharColumn
		{
			[DebuggerStepThrough]
			get
			{
				return charColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (charColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				charColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Unknown DateColumn
		{
			[DebuggerStepThrough]
			get
			{
				return dateColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (dateColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				dateColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<DateTime> DateTimeColumn
		{
			[DebuggerStepThrough]
			get
			{
				return dateTimeColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (dateTimeColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				dateTimeColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Unknown DateTime2column
		{
			[DebuggerStepThrough]
			get
			{
				return dateTime2column;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (dateTime2column!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				dateTime2column = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Unknown DateTimeOffsetColumn
		{
			[DebuggerStepThrough]
			get
			{
				return dateTimeOffsetColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (dateTimeOffsetColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				dateTimeOffsetColumn = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> DecimalColumn
		{
			[DebuggerStepThrough]
			get
			{
				return decimalColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (decimalColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				decimalColumn = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<double> FloatColumn
		{
			[DebuggerStepThrough]
			get
			{
				return floatColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (floatColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				floatColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Unknown GeopgraphyColummn
		{
			[DebuggerStepThrough]
			get
			{
				return geopgraphyColummn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (geopgraphyColummn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				geopgraphyColummn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Unknown GeometryColumn
		{
			[DebuggerStepThrough]
			get
			{
				return geometryColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (geometryColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				geometryColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Unknown HierarchyIdColumn
		{
			[DebuggerStepThrough]
			get
			{
				return hierarchyIdColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (hierarchyIdColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				hierarchyIdColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public byte[] ImageColumn
		{
			[DebuggerStepThrough]
			get
			{
				return imageColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (imageColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				imageColumn = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<int> IntColumn
		{
			[DebuggerStepThrough]
			get
			{
				return intColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (intColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				intColumn = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> MoneyColumn
		{
			[DebuggerStepThrough]
			get
			{
				return moneyColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (moneyColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				moneyColumn = value;
			}
		}

		[StringLength(10)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string NcharColumn
		{
			[DebuggerStepThrough]
			get
			{
				return ncharColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (ncharColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				ncharColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string NtextColumn
		{
			[DebuggerStepThrough]
			get
			{
				return ntextColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (ntextColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				ntextColumn = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> NumericColumn
		{
			[DebuggerStepThrough]
			get
			{
				return numericColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (numericColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				numericColumn = value;
			}
		}

		[StringLength(50)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string NvarcharColumn
		{
			[DebuggerStepThrough]
			get
			{
				return nvarcharColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (nvarcharColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				nvarcharColumn = value;
			}
		}

		[StringLength(-1)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string NvarcharMaxColumn
		{
			[DebuggerStepThrough]
			get
			{
				return nvarcharMaxColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (nvarcharMaxColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				nvarcharMaxColumn = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<float> RealColumn
		{
			[DebuggerStepThrough]
			get
			{
				return realColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (realColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				realColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<DateTime> SmallDateTimeColumn
		{
			[DebuggerStepThrough]
			get
			{
				return smallDateTimeColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (smallDateTimeColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				smallDateTimeColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<short> SmallIntColumn
		{
			[DebuggerStepThrough]
			get
			{
				return smallIntColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (smallIntColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				smallIntColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> SmallMoneyColumn
		{
			[DebuggerStepThrough]
			get
			{
				return smallMoneyColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (smallMoneyColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				smallMoneyColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public object SqlVariantColumn
		{
			[DebuggerStepThrough]
			get
			{
				return sqlVariantColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (sqlVariantColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				sqlVariantColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string TextColumn
		{
			[DebuggerStepThrough]
			get
			{
				return textColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (textColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				textColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Unknown TimeColumn
		{
			[DebuggerStepThrough]
			get
			{
				return timeColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (timeColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				timeColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public byte[] TimestampColumn
		{
			[DebuggerStepThrough]
			get
			{
				return timestampColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (timestampColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				timestampColumn = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<byte> TinyIntColumn
		{
			[DebuggerStepThrough]
			get
			{
				return tinyIntColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (tinyIntColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				tinyIntColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<Guid> UniqueIdentifierColumn
		{
			[DebuggerStepThrough]
			get
			{
				return uniqueIdentifierColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (uniqueIdentifierColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				uniqueIdentifierColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public byte[] VarBinaryColumn
		{
			[DebuggerStepThrough]
			get
			{
				return varBinaryColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (varBinaryColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				varBinaryColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public byte[] VarBinaryMaxColumn
		{
			[DebuggerStepThrough]
			get
			{
				return varBinaryMaxColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (varBinaryMaxColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				varBinaryMaxColumn = value;
			}
		}

		[StringLength(50)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string VarCharColumn
		{
			[DebuggerStepThrough]
			get
			{
				return varCharColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (varCharColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				varCharColumn = value;
			}
		}

		[StringLength(-1)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string VarCharMaxColumn
		{
			[DebuggerStepThrough]
			get
			{
				return varCharMaxColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (varCharMaxColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				varCharMaxColumn = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string XmlColumn
		{
			[DebuggerStepThrough]
			get
			{
				return xmlColumn;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (xmlColumn!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				xmlColumn = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string BigIntColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return bigIntColumn != null ? bigIntColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					long _a = Convert.ToInt64(value);
				BigIntColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"BigIntColumn",string.Format(CEVIRI_YAZISI,"BigIntColumn","long")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string BinaryColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return binaryColumn != null ? binaryColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("String'ten byte[] array'e cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string BitColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return bitColumn != null ? bitColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					bool _a = Convert.ToBoolean(value);
				BitColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"BitColumn",string.Format(CEVIRI_YAZISI,"BitColumn","bool")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DateColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return dateColumn != null ? dateColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("string'ten degisken tipine cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DateTimeColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return dateTimeColumn != null ? dateTimeColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					DateTime _a = Convert.ToDateTime(value);
				DateTimeColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"DateTimeColumn",string.Format(CEVIRI_YAZISI,"DateTimeColumn","DateTime")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DateTime2columnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return dateTime2column != null ? dateTime2column.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("string'ten degisken tipine cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DateTimeOffsetColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return dateTimeOffsetColumn != null ? dateTimeOffsetColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("string'ten degisken tipine cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DecimalColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return decimalColumn != null ? decimalColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				DecimalColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"DecimalColumn",string.Format(CEVIRI_YAZISI,"DecimalColumn","decimal")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string FloatColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return floatColumn != null ? floatColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					double _a = Convert.ToDouble(value);
				FloatColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"FloatColumn",string.Format(CEVIRI_YAZISI,"FloatColumn","double")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string GeopgraphyColummnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return geopgraphyColummn != null ? geopgraphyColummn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("string'ten degisken tipine cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string GeometryColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return geometryColumn != null ? geometryColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("string'ten degisken tipine cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string HierarchyIdColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return hierarchyIdColumn != null ? hierarchyIdColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("string'ten degisken tipine cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string ImageColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return imageColumn != null ? imageColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("String'ten byte[] array'e cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string IntColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return intColumn != null ? intColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				IntColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"IntColumn",string.Format(CEVIRI_YAZISI,"IntColumn","int")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string MoneyColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return moneyColumn != null ? moneyColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				MoneyColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"MoneyColumn",string.Format(CEVIRI_YAZISI,"MoneyColumn","decimal")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string NumericColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return numericColumn != null ? numericColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				NumericColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"NumericColumn",string.Format(CEVIRI_YAZISI,"NumericColumn","decimal")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string RealColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return realColumn != null ? realColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					float _a = Convert.ToSingle(value);
				RealColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"RealColumn",string.Format(CEVIRI_YAZISI,"RealColumn","float")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string SmallDateTimeColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return smallDateTimeColumn != null ? smallDateTimeColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					DateTime _a = Convert.ToDateTime(value);
				SmallDateTimeColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"SmallDateTimeColumn",string.Format(CEVIRI_YAZISI,"SmallDateTimeColumn","DateTime")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string SmallIntColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return smallIntColumn != null ? smallIntColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					short _a = Convert.ToInt16(value);
				SmallIntColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"SmallIntColumn",string.Format(CEVIRI_YAZISI,"SmallIntColumn","short")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string SmallMoneyColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return smallMoneyColumn != null ? smallMoneyColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				SmallMoneyColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"SmallMoneyColumn",string.Format(CEVIRI_YAZISI,"SmallMoneyColumn","decimal")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string SqlVariantColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return sqlVariantColumn != null ? sqlVariantColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
				object _a =(object) value;
				SqlVariantColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"SqlVariantColumn",string.Format(CEVIRI_YAZISI,"SqlVariantColumn","object")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string TimeColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return timeColumn != null ? timeColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("string'ten degisken tipine cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string TimestampColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return timestampColumn != null ? timestampColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("String'ten byte[] array'e cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string TinyIntColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return tinyIntColumn != null ? tinyIntColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					byte _a = Convert.ToByte(value);
				TinyIntColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"TinyIntColumn",string.Format(CEVIRI_YAZISI,"TinyIntColumn","byte")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string UniqueIdentifierColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return uniqueIdentifierColumn != null ? uniqueIdentifierColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					Guid _a = new Guid(value);
				UniqueIdentifierColumn = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"UniqueIdentifierColumn",string.Format(CEVIRI_YAZISI,"UniqueIdentifierColumn","Guid")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string VarBinaryColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return varBinaryColumn != null ? varBinaryColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("String'ten byte[] array'e cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string VarBinaryMaxColumnAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return varBinaryMaxColumn != null ? varBinaryMaxColumn.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("String'ten byte[] array'e cevirim desteklenmemektedir");
			}
		}

		public ButunVeriYapilari2008r2 ShallowCopy()
		{
			ButunVeriYapilari2008r2 obj = new ButunVeriYapilari2008r2();
			obj.bigIntColumn = bigIntColumn;
			obj.binaryColumn = binaryColumn;
			obj.bitColumn = bitColumn;
			obj.charColumn = charColumn;
			obj.dateColumn = dateColumn;
			obj.dateTimeColumn = dateTimeColumn;
			obj.dateTime2column = dateTime2column;
			obj.dateTimeOffsetColumn = dateTimeOffsetColumn;
			obj.decimalColumn = decimalColumn;
			obj.floatColumn = floatColumn;
			obj.geopgraphyColummn = geopgraphyColummn;
			obj.geometryColumn = geometryColumn;
			obj.hierarchyIdColumn = hierarchyIdColumn;
			obj.imageColumn = imageColumn;
			obj.intColumn = intColumn;
			obj.moneyColumn = moneyColumn;
			obj.ncharColumn = ncharColumn;
			obj.ntextColumn = ntextColumn;
			obj.numericColumn = numericColumn;
			obj.nvarcharColumn = nvarcharColumn;
			obj.nvarcharMaxColumn = nvarcharMaxColumn;
			obj.realColumn = realColumn;
			obj.smallDateTimeColumn = smallDateTimeColumn;
			obj.smallIntColumn = smallIntColumn;
			obj.smallMoneyColumn = smallMoneyColumn;
			obj.sqlVariantColumn = sqlVariantColumn;
			obj.textColumn = textColumn;
			obj.timeColumn = timeColumn;
			obj.timestampColumn = timestampColumn;
			obj.tinyIntColumn = tinyIntColumn;
			obj.uniqueIdentifierColumn = uniqueIdentifierColumn;
			obj.varBinaryColumn = varBinaryColumn;
			obj.varBinaryMaxColumn = varBinaryMaxColumn;
			obj.varCharColumn = varCharColumn;
			obj.varCharMaxColumn = varCharMaxColumn;
			obj.xmlColumn = xmlColumn;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
		}
		public class PropertyIsimleri
		{
			public const string BigIntColumn = "BigIntColumn";
			public const string BinaryColumn = "BinaryColumn";
			public const string BitColumn = "BitColumn";
			public const string CharColumn = "CharColumn";
			public const string DateColumn = "DateColumn";
			public const string DateTimeColumn = "DateTimeColumn";
			public const string DateTime2column = "DateTime2Column";
			public const string DateTimeOffsetColumn = "DateTimeOffsetColumn";
			public const string DecimalColumn = "DecimalColumn";
			public const string FloatColumn = "FloatColumn";
			public const string GeopgraphyColummn = "GeopgraphyColummn";
			public const string GeometryColumn = "GeometryColumn";
			public const string HierarchyIdColumn = "HierarchyIdColumn";
			public const string ImageColumn = "ImageColumn";
			public const string IntColumn = "IntColumn";
			public const string MoneyColumn = "MoneyColumn";
			public const string NcharColumn = "NCharColumn";
			public const string NtextColumn = "NTextColumn";
			public const string NumericColumn = "NumericColumn";
			public const string NvarcharColumn = "NVarcharColumn";
			public const string NvarcharMaxColumn = "NVarcharMaxColumn";
			public const string RealColumn = "RealColumn";
			public const string SmallDateTimeColumn = "smallDateTimeColumn";
			public const string SmallIntColumn = "smallIntColumn";
			public const string SmallMoneyColumn = "SmallMoneyColumn";
			public const string SqlVariantColumn = "SqlVariantColumn";
			public const string TextColumn = "TextColumn";
			public const string TimeColumn = "TimeColumn";
			public const string TimestampColumn = "TimestampColumn";
			public const string TinyIntColumn = "TinyIntColumn";
			public const string UniqueIdentifierColumn = "UniqueIdentifierColumn";
			public const string VarBinaryColumn = "VarBinaryColumn";
			public const string VarBinaryMaxColumn = "VarBinaryMaxColumn";
			public const string VarCharColumn = "VarCharColumn";
			public const string VarCharMaxColumn = "VarCharMaxColumn";
			public const string XmlColumn = "XmlColumn";
		}

	}
}
