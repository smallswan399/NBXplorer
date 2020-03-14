﻿using NBXplorer.DerivationStrategy;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using NBitcoin;
using NBitcoin.Crypto;

namespace NBXplorer.DerivationStrategy
{
	public class P2WSHDerivationStrategy : DerivationStrategyBase
	{
		internal P2WSHDerivationStrategy(DerivationStrategyBase inner):base(inner.AdditionalOptions)
		{
			if(inner == null)
				throw new ArgumentNullException(nameof(inner));
			Inner = inner;
		}

		public DerivationStrategyBase Inner
		{
			get; set;
		}

		protected internal override string StringValueCore => Inner.ToString();

		public override Derivation GetDerivation()
		{
			var derivation = Inner.GetDerivation();
			return new Derivation()
			{
				ScriptPubKey = derivation.ScriptPubKey.WitHash.ScriptPubKey,
				Redeem = derivation.ScriptPubKey
			};
		}

		public override IEnumerable<ExtPubKey> GetExtPubKeys()
		{
			return Inner.GetExtPubKeys();
		}

		public override DerivationStrategyBase GetChild(KeyPath keyPath)
		{
			return new P2WSHDerivationStrategy(Inner.GetChild(keyPath));
		}
	}
}
