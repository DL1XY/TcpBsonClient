
using System;
using System.IO;
using UnityEngine;

namespace TcpBsonClient
{

	public class ByteStreamParser
	{

		public static byte[] parseStream(Stream s)
		{

			var header = new byte[4];
			// TODO: You need to make sure that 4 bytes have been read.
			s.Read(header, 0, 4);

			var length = BitConverter.ToInt32(header,0);
			var readbuffer= new byte[1024 * 1024];
			var bytesLeft = length-4;
			var messageStream = new MemoryStream();
			messageStream.Write(header,0,4);
			//Debug.Log("length:" + length + " bytesLeft:" + bytesLeft);
			while (bytesLeft > 0)
			{
				var read = s.Read(readbuffer, 0, bytesLeft);
				//Console.WriteLine(" - Try to read read:{0}",read);
				messageStream.Write(readbuffer, 0, read);
				bytesLeft -= read;
			}
			//Console.WriteLine(" - Reading done!");
			messageStream.Seek(0, SeekOrigin.Begin);
			
			byte[] data = new byte[length];
			messageStream.Read(data, 0, length);//messageStream.ToArray();
			messageStream.Close ();
			return data;
		}

		static byte[] GetBytes(string str)
		{
			byte[] bytes = new byte[str.Length * sizeof(char)];
			System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
			return bytes;
		}
	}
}

