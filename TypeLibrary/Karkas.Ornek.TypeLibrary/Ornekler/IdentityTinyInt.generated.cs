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
	[DebuggerDisplay("IdentityTinyIntKey = {IdentityTinyIntKey}")]
	public partial class 	IdentityTinyInt: BaseTypeLibrary
	{
		private byte identityTinyIntKey;
		private string adi;

		[Key]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public byte IdentityTinyIntKey
		{
			[DebuggerStepThrough]
			get
			{
				return identityTinyIntKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (identityTinyIntKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				identityTinyIntKey = value;
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
		public string IdentityTinyIntKeyAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return identityTinyIntKey.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					byte _a = Convert.ToByte(value);
				IdentityTinyIntKey = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"IdentityTinyIntKey",string.Format(CEVIRI_YAZISI,"IdentityTinyIntKey","byte")));
				}
			}
		}

		public IdentityTinyInt ShallowCopy()
		{
			IdentityTinyInt obj = new IdentityTinyInt();
			obj.identityTinyIntKey = identityTinyIntKey;
			obj.adi = adi;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
		}
		public class PropertyIsimleri
		{
			public const string IdentityTinyIntKey = "IdentityTinyIntKey";
			public const string Adi = "Adi";
		}

	}
}
