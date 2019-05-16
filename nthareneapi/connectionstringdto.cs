/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 09/27/2018
 * Time: 07:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace nthareneapi
{
	/// <summary>
	/// Description of connectionstringdto.
	/// </summary>
	public abstract class connectionstringdto
	{ 
		public string datasource { get; set; }
		public string database { get; set; }
		public string userid { get; set; }
		public string password { get; set; }
		public string port { get; set; }
		public string new_database_name { get; set; }
		public string update_schema_temp_db { get; set; }
		public string update_schema_current_db { get; set; }
	}
	
}
