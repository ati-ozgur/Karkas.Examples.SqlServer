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
	[DebuggerDisplay("IdentityBigIntKey = {IdentityBigIntKey}")]
	public partial class 	IdentityBigInt: BaseTypeLibrary
	{
		private long identityBigIntKey;
		private string adi;

		[Key]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public long IdentityBigIntKey
		{
			[DebuggerStepThrough]
			get
			{
				return identityBigIntKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (identityBigIntKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				identityBigIntKey = value;
			}
		}

		[StringLength(50)]
		[Required]
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
		public string IdentityBigIntKeyAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return identityBigIntKey.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					long _a = Convert.ToInt64(value);
				IdentityBigIntKey = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"IdentityBigIntKey",string.Format(CEVIRI_YAZISI,"IdentityBigIntKey","long")));
				}
			}
		}

		public IdentityBigInt ShallowCopy()
		{
			IdentityBigInt obj = new IdentityBigInt();
			obj.identityBigIntKey = identityBigIntKey;
			obj.adi = adi;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
		}
		public class PropertyIsimleri
		{
			public const string IdentityBigIntKey = "IdentityBigIntKey";
			public const string Adi = "Adi";
		}

	}
}
