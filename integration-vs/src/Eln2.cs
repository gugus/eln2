using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;
using System;

[assembly: ModInfo( "Eln2",
	Description = "Electricity in your base!",
	Website     = "https://eln2.org",
	Authors     = new []{ "jrddunbr" } )]

namespace org.Eln2 {
	public class Eln2 : ModSystem {
		public override void Start(ICoreAPI api) {
			base.Start(api);
			Console.WriteLine("Hello World! This is Regular Start!");
			api.RegisterBlockClass("flubber", typeof(Flubber));
		}
		
		public override void StartClientSide(ICoreClientAPI api) {
			Console.WriteLine("Hello World! This is Client Start!");
		}
		
		public override void StartServerSide(ICoreServerAPI api) {
			Console.WriteLine("Hello World! This is Server Start!");
		}
	}
}
