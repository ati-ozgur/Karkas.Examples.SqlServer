
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Ornek.TypeLibrary;
using Karkas.Ornek.TypeLibrary.Dbo;


namespace Karkas.Ornek.Dal.Dbo
{
public partial class SysdiagramsDal : BaseDal<Sysdiagrams>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Ornek";
		}
	}
	protected override void identityKolonDegeriniSetle(Sysdiagrams pTypeLibrary,long pIdentityKolonValue)
	{
		pTypeLibrary.DiagramId = (int )pIdentityKolonValue;
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.sysdiagrams";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT name,principal_id,diagram_id,version,definition FROM dbo.sysdiagrams";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.sysdiagrams WHERE diagram_id = @diagram_id ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.sysdiagrams
			 SET 
			name = @name
,principal_id = @principal_id
,version = @version
,definition = @definition
			
			WHERE 
			 diagram_id = @diagram_id
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.sysdiagrams 
			 (name,principal_id,version,definition) 
			 VALUES 
						(@name,@principal_id,@version,@definition);SELECT scope_identity();";
		}
	}
	public Sysdiagrams SorgulaDiagramIdIle(int p1)
	{
		List<Sysdiagrams> liste = new List<Sysdiagrams>();
		SorguCalistir(liste,String.Format(" diagram_id = '{0}'", p1));		
		if (liste.Count > 0)
		{
			return liste[0];
		}
		else
		{
			return null;
		}
	}
	
	protected override bool IdentityVarMi
	{
		get
		{
			return true;
		}
	}
	
	protected override bool PkGuidMi
	{
		get
		{
			return false;
		}
	}
	
	
	public override string PrimaryKey
	{
		get
		{
			return "diagram_id";
		}
	}
	
	public virtual void Sil(int DiagramId)
	{
		Sysdiagrams satir = new Sysdiagrams();
		satir.DiagramId = DiagramId;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, Sysdiagrams satir)
	{
		satir.Name = dr.GetString(0);
		satir.PrincipalId = dr.GetInt32(1);
		satir.DiagramId = dr.GetInt32(2);
		if (!dr.IsDBNull(3))
		{
			satir.Version = dr.GetInt32(3);
		}
		if (!dr.IsDBNull(4))
		{
			satir.Definition = (Byte[])dr.GetValue(4);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Sysdiagrams satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@name",SqlDbType.NVarChar, satir.Name,128);
		builder.parameterEkle("@principal_id",SqlDbType.Int, satir.PrincipalId);
		builder.parameterEkle("@version",SqlDbType.Int, satir.Version);
		builder.parameterEkle("@definition",SqlDbType.VarBinary, satir.Definition);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Sysdiagrams	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@name",SqlDbType.NVarChar, satir.Name,128);
		builder.parameterEkle("@principal_id",SqlDbType.Int, satir.PrincipalId);
		builder.parameterEkle("@diagram_id",SqlDbType.Int, satir.DiagramId);
		builder.parameterEkle("@version",SqlDbType.Int, satir.Version);
		builder.parameterEkle("@definition",SqlDbType.VarBinary, satir.Definition);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Sysdiagrams	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@diagram_id",SqlDbType.Int, satir.DiagramId);
	}
	public override string DbProviderName
	{
		get
		{
			return "System.Data.SqlClient";
		}
	}
}
}
