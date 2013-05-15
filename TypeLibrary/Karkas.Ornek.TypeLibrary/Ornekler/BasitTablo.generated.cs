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
	[DebuggerDisplay("BasitTabloKey = {BasitTabloKey}")]
	public partial class 	BasitTablo: BaseTypeLibrary
	{
		private Guid basitTabloKey;
		private string adi;
		private string soyadi;
		private Nullable<Guid> gkullaniciKey;
		private Nullable<DateTime> utarihi;

		[Key]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Guid BasitTabloKey
		{
			[DebuggerStepThrough]
			get
			{
				return basitTabloKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (basitTabloKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				basitTabloKey = value;
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

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<Guid> GkullaniciKey
		{
			[DebuggerStepThrough]
			get
			{
				return gkullaniciKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (gkullaniciKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				gkullaniciKey = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<DateTime> Utarihi
		{
			[DebuggerStepThrough]
			get
			{
				return utarihi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (utarihi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				utarihi = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string BasitTabloKeyAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return basitTabloKey.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					Guid _a = new Guid(value);
				BasitTabloKey = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"BasitTabloKey",string.Format(CEVIRI_YAZISI,"BasitTabloKey","Guid")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string GkullaniciKeyAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return gkullaniciKey != null ? gkullaniciKey.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					Guid _a = new Guid(value);
				GkullaniciKey = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"GkullaniciKey",string.Format(CEVIRI_YAZISI,"GkullaniciKey","Guid")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string UtarihiAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return utarihi != null ? utarihi.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					DateTime _a = Convert.ToDateTime(value);
				Utarihi = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"Utarihi",string.Format(CEVIRI_YAZISI,"Utarihi","DateTime")));
				}
			}
		}

		public BasitTablo ShallowCopy()
		{
			BasitTablo obj = new BasitTablo();
			obj.basitTabloKey = basitTabloKey;
			obj.adi = adi;
			obj.soyadi = soyadi;
			obj.gkullaniciKey = gkullaniciKey;
			obj.utarihi = utarihi;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Adi"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Soyadi"));		}
		public class PropertyIsimleri
		{
			public const string BasitTabloKey = "BasitTabloKey";
			public const string Adi = "Adi";
			public const string Soyadi = "Soyadi";
			public const string GkullaniciKey = "GKullaniciKey";
			public const string Utarihi = "UTarihi";
		}

	}
}
