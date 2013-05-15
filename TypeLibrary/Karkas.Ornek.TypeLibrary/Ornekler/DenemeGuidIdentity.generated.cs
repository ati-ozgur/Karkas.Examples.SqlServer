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
	[DebuggerDisplay("DenemeKey = {DenemeKey}")]
	public partial class 	DenemeGuidIdentity: BaseTypeLibrary
	{
		private Guid denemeKey;
		private int denemeNo;
		private string denemeKolon;

		[Key]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Guid DenemeKey
		{
			[DebuggerStepThrough]
			get
			{
				return denemeKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (denemeKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				denemeKey = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int DenemeNo
		{
			[DebuggerStepThrough]
			get
			{
				return denemeNo;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (denemeNo!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				denemeNo = value;
			}
		}

		[StringLength(50)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string DenemeKolon
		{
			[DebuggerStepThrough]
			get
			{
				return denemeKolon;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (denemeKolon!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				denemeKolon = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DenemeKeyAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return denemeKey.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					Guid _a = new Guid(value);
				DenemeKey = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"DenemeKey",string.Format(CEVIRI_YAZISI,"DenemeKey","Guid")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DenemeNoAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return denemeNo.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				DenemeNo = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"DenemeNo",string.Format(CEVIRI_YAZISI,"DenemeNo","int")));
				}
			}
		}

		public DenemeGuidIdentity ShallowCopy()
		{
			DenemeGuidIdentity obj = new DenemeGuidIdentity();
			obj.denemeKey = denemeKey;
			obj.denemeNo = denemeNo;
			obj.denemeKolon = denemeKolon;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "DenemeNo"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "DenemeKolon"));		}
		public class PropertyIsimleri
		{
			public const string DenemeKey = "DenemeKey";
			public const string DenemeNo = "DenemeNo";
			public const string DenemeKolon = "DenemeKolon";
		}

	}
}
