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

namespace Karkas.Ornek.TypeLibrary.Dbo
{
	[Serializable]
	[DebuggerDisplay("DiagramId = {DiagramId}")]
	public partial class 	Sysdiagrams: BaseTypeLibrary
	{
		private string name;
		private int principalId;
		private int diagramId;
		private Nullable<int> version;
		private byte[] definition;

		[StringLength(128)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Name
		{
			[DebuggerStepThrough]
			get
			{
				return name;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (name!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				name = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int PrincipalId
		{
			[DebuggerStepThrough]
			get
			{
				return principalId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (principalId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				principalId = value;
			}
		}

		[Key]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int DiagramId
		{
			[DebuggerStepThrough]
			get
			{
				return diagramId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (diagramId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				diagramId = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<int> Version
		{
			[DebuggerStepThrough]
			get
			{
				return version;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (version!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				version = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public byte[] Definition
		{
			[DebuggerStepThrough]
			get
			{
				return definition;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (definition!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				definition = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string PrincipalIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return principalId.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				PrincipalId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"PrincipalId",string.Format(CEVIRI_YAZISI,"PrincipalId","int")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DiagramIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return diagramId.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				DiagramId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"DiagramId",string.Format(CEVIRI_YAZISI,"DiagramId","int")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string VersionAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return version != null ? version.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				Version = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"Version",string.Format(CEVIRI_YAZISI,"Version","int")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DefinitionAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return definition != null ? definition.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("String'ten byte[] array'e cevirim desteklenmemektedir");
			}
		}

		public Sysdiagrams ShallowCopy()
		{
			Sysdiagrams obj = new Sysdiagrams();
			obj.name = name;
			obj.principalId = principalId;
			obj.diagramId = diagramId;
			obj.version = version;
			obj.definition = definition;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Name"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "PrincipalId"));		}
		public class PropertyIsimleri
		{
			public const string Name = "name";
			public const string PrincipalId = "principal_id";
			public const string DiagramId = "diagram_id";
			public const string Version = "version";
			public const string Definition = "definition";
		}

	}
}
