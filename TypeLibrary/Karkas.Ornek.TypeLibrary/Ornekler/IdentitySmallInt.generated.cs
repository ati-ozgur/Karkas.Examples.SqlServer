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
	[DebuggerDisplay("IdentitySmallIntKey = {IdentitySmallIntKey}")]
	public partial class 	IdentitySmallInt: BaseTypeLibrary
	{
		private short identitySmallIntKey;
		private string adi;

		[Key]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public short IdentitySmallIntKey
		{
			[DebuggerStepThrough]
			get
			{
				return identitySmallIntKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (identitySmallIntKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				identitySmallIntKey = value;
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

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string IdentitySmallIntKeyAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return identitySmallIntKey.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					short _a = Convert.ToInt16(value);
				IdentitySmallIntKey = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"IdentitySmallIntKey",string.Format(CEVIRI_YAZISI,"IdentitySmallIntKey","short")));
				}
			}
		}

		public IdentitySmallInt ShallowCopy()
		{
			IdentitySmallInt obj = new IdentitySmallInt();
			obj.identitySmallIntKey = identitySmallIntKey;
			obj.adi = adi;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Adi"));		}
		public class PropertyIsimleri
		{
			public const string IdentitySmallIntKey = "IdentitySmallIntKey";
			public const string Adi = "Adi";
		}

	}
}
