﻿using System;
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
	public partial class 	PkOlmayan: BaseTypeLibrary
	{
		private int primaryKeyDegi;
		private string denemeKolon;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int PrimaryKeyDegi
		{
			[DebuggerStepThrough]
			get
			{
				return primaryKeyDegi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (primaryKeyDegi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				primaryKeyDegi = value;
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
		public string PrimaryKeyDegiAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return primaryKeyDegi.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				PrimaryKeyDegi = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"PrimaryKeyDegi",string.Format(CEVIRI_YAZISI,"PrimaryKeyDegi","int")));
				}
			}
		}

		public PkOlmayan ShallowCopy()
		{
			PkOlmayan obj = new PkOlmayan();
			obj.primaryKeyDegi = primaryKeyDegi;
			obj.denemeKolon = denemeKolon;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "PrimaryKeyDegi"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "DenemeKolon"));		}
		public class PropertyIsimleri
		{
			public const string PrimaryKeyDegi = "PrimaryKeyDegi";
			public const string DenemeKolon = "DenemeKolon";
		}

	}
}
