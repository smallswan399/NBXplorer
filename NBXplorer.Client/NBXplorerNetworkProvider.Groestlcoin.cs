﻿using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
	public partial class NBXplorerNetworkProvider
    {
		private void InitGroestlcoin(NetworkType networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.Groestlcoin.Instance, networkType)
			{
				MinRPCVersion = 2160000,
				CoinType = NetworkType == NetworkType.Mainnet ? new KeyPath("17'") : new KeyPath("1'")
			});
		}
	}
}
