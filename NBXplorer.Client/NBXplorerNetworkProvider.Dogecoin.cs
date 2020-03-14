﻿using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitDogecoin(NetworkType networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.Dogecoin.Instance, networkType)
			{
				MinRPCVersion = 140200,
				ChainLoadingTimeout = TimeSpan.FromHours(1),
				ChainCacheLoadingTimeout = TimeSpan.FromMinutes(2),
				SupportCookieAuthentication = false,
				CoinType = NetworkType == NetworkType.Mainnet ? new KeyPath("3'") : new KeyPath("1'")
			});
		}

		public NBXplorerNetwork GetDOGE()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.Dogecoin.Instance.CryptoCode);
		}
	}
}
