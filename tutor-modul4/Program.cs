﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutor_modul4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataGeneric<String> data = new DataGeneric<string>("1302204090");
			data.PrintInfo();
			HaloGeneric<String> halo = new HaloGeneric<String>();
			halo.SapaUser("Bayu");
		}
	}
}
