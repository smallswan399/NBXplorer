using NBitcoin;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitBGold(NetworkType networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.BGold.Instance, networkType)
			{
				MinRPCVersion = 140200,
				CoinType = networkType == NetworkType.Mainnet ? new KeyPath("156'") : new KeyPath("1'")
			});
		}

		public NBXplorerNetwork GetBTG()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.BGold.Instance.CryptoCode);
		}
	}
}
