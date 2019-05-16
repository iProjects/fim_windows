/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 09/09/2018
 * Time: 21:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace nthareneapi
{
	public class responsedto
	{ 
		public string responsesuccessmessage { get; set; }
		public string responseerrormessage { get; set; }
		public string responsemethod { get; set; }
		public string responseclass { get; set; }
		public bool isresponseresultsuccessful { get; set; }
		public object responseresultobject { get; set; } 
	}
}
