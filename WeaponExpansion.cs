using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace WeaponExpansion
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class WeaponExpansion : Mod
	{
		public static void Log(String msg)
		{
			Main.NewText(msg, 255, 120, 10);
		}
	}
}
