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
	[DebuggerDisplay("MusteriKey = {MusteriKey}")]
	public partial class 	Musteri: BaseTypeLibrary
	{
		private Guid musteriKey;
		private string adi;
		private string soyadi;
		private string ikinciAdi;
		private Nullable<DateTime> dogumTarihi;
		private bool aktifMi;
		private Nullable<int> onemi;
		private Nullable<decimal> kredisi;
		private string tamAdi;

		[Key]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Guid MusteriKey
		{
			[DebuggerStepThrough]
			get
			{
				return musteriKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (musteriKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				musteriKey = value;
			}
		}

		[StringLength(50)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Adi
		{
			[DebuggerStepThrough]
			get
			{
				return adi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (adi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				adi = value;
			}
		}

		[StringLength(50)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Soyadi
		{
			[DebuggerStepThrough]
			get
			{
				return soyadi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (soyadi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				soyadi = value;
			}
		}

		[StringLength(50)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string IkinciAdi
		{
			[DebuggerStepThrough]
			get
			{
				return ikinciAdi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (ikinciAdi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				ikinciAdi = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<DateTime> DogumTarihi
		{
			[DebuggerStepThrough]
			get
			{
				return dogumTarihi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (dogumTarihi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				dogumTarihi = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool AktifMi
		{
			[DebuggerStepThrough]
			get
			{
				return aktifMi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (aktifMi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				aktifMi = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<int> Onemi
		{
			[DebuggerStepThrough]
			get
			{
				return onemi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (onemi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				onemi = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> Kredisi
		{
			[DebuggerStepThrough]
			get
			{
				return kredisi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (kredisi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				kredisi = value;
			}
		}

		[StringLength(152)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string TamAdi
		{
			[DebuggerStepThrough]
			get
			{
				return tamAdi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (tamAdi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				tamAdi = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string MusteriKeyAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return musteriKey.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					Guid _a = new Guid(value);
				MusteriKey = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"MusteriKey",string.Format(CEVIRI_YAZISI,"MusteriKey","Guid")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DogumTarihiAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return dogumTarihi != null ? dogumTarihi.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					DateTime _a = Convert.ToDateTime(value);
				DogumTarihi = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"DogumTarihi",string.Format(CEVIRI_YAZISI,"DogumTarihi","DateTime")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string AktifMiAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return aktifMi.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					bool _a = Convert.ToBoolean(value);
				AktifMi = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"AktifMi",string.Format(CEVIRI_YAZISI,"AktifMi","bool")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string OnemiAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return onemi != null ? onemi.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				Onemi = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"Onemi",string.Format(CEVIRI_YAZISI,"Onemi","int")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string KredisiAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return kredisi != null ? kredisi.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				Kredisi = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"Kredisi",string.Format(CEVIRI_YAZISI,"Kredisi","decimal")));
				}
			}
		}

		public Musteri ShallowCopy()
		{
			Musteri obj = new Musteri();
			obj.musteriKey = musteriKey;
			obj.adi = adi;
			obj.soyadi = soyadi;
			obj.ikinciAdi = ikinciAdi;
			obj.dogumTarihi = dogumTarihi;
			obj.aktifMi = aktifMi;
			obj.onemi = onemi;
			obj.kredisi = kredisi;
			obj.tamAdi = tamAdi;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Adi"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Soyadi"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "AktifMi"));		}
		public class PropertyIsimleri
		{
			public const string MusteriKey = "MusteriKey";
			public const string Adi = "Adi";
			public const string Soyadi = "Soyadi";
			public const string IkinciAdi = "IkinciAdi";
			public const string DogumTarihi = "DogumTarihi";
			public const string AktifMi = "AktifMi";
			public const string Onemi = "Onemi";
			public const string Kredisi = "Kredisi";
			public const string TamAdi = "TamAdi";
		}

	}
}
