using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutor_modul4
{
	internal class HaloGeneric<T>
	{

		public void SapaUser(T user)
		{
			Console.WriteLine("Halo user " + user);
		}

	}
}
