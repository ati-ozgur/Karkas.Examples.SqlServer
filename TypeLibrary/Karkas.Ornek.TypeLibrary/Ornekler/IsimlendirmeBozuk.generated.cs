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
	[DebuggerDisplay("KisiOid = {KisiOid}")]
	public partial class 	IsimlendirmeBozuk: BaseTypeLibrary
	{
		private int kisiOid;
		private string adi;
		private string soyadi;

		[Key]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int KisiOid
		{
			[DebuggerStepThrough]
			get
			{
				return kisiOid;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (kisiOid!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				kisiOid = value;
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

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string KisiOidAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return kisiOid.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				KisiOid = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"KisiOid",string.Format(CEVIRI_YAZISI,"KisiOid","int")));
				}
			}
		}

		public IsimlendirmeBozuk ShallowCopy()
		{
			IsimlendirmeBozuk obj = new IsimlendirmeBozuk();
			obj.kisiOid = kisiOid;
			obj.adi = adi;
			obj.soyadi = soyadi;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Adi"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Soyadi"));		}
		public class PropertyIsimleri
		{
			public const string KisiOid = "KISI_OID";
			public const string Adi = "ADI";
			public const string Soyadi = "SOYADI";
		}

	}
}
