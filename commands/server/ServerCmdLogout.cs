//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Kernys.Bson;


namespace TcpBsonClient
{
	public class ServerCmdLogout : BaseServerCmd
	{

		public ServerCmdLogout()
		{
		}

		override public BSONObject encode()
		{
			BSONObject obj 	= new BSONObject ();
			obj ["id"] 		= this.id;
			obj ["meta"] 	= this.GetType ().Name;
			return obj; 
		}
	}
}
