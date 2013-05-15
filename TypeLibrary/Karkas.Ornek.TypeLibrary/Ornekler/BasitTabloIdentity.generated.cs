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
	[DebuggerDisplay("BasitTabloIdentityKey = {BasitTabloIdentityKey}")]
	public partial class 	BasitTabloIdentity: BaseTypeLibrary
	{
		private int basitTabloIdentityKey;
		private string adi;
		private string soyadi;

		[Key]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int BasitTabloIdentityKey
		{
			[DebuggerStepThrough]
			get
			{
				return basitTabloIdentityKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (basitTabloIdentityKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				basitTabloIdentityKey = value;
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
		public string BasitTabloIdentityKeyAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return basitTabloIdentityKey.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				BasitTabloIdentityKey = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"BasitTabloIdentityKey",string.Format(CEVIRI_YAZISI,"BasitTabloIdentityKey","int")));
				}
			}
		}

		public BasitTabloIdentity ShallowCopy()
		{
			BasitTabloIdentity obj = new BasitTabloIdentity();
			obj.basitTabloIdentityKey = basitTabloIdentityKey;
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
			public const string BasitTabloIdentityKey = "BasitTabloIdentityKey";
			public const string Adi = "Adi";
			public const string Soyadi = "Soyadi";
		}

	}
}
