using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutor_modul4
{
	internal class DataGeneric<T>
	{
		private T data;

		public DataGeneric(T data)
		{
			this.data = data;
		}

		public void PrintInfo()
		{
			Console.WriteLine("Data yang disimpan adalah: " + this.data);
		}

	}
}
