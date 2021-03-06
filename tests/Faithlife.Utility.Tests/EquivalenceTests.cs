using System.Collections.Generic;
using NUnit.Framework;

namespace Faithlife.Utility.Tests
{
	[TestFixture]
	class EquivalenceTests
	{
		[Test]
		public void SimpleTest()
		{
			HasEquivalence one = new HasEquivalence { Value = 1 };
			HasEquivalence oneClone = new HasEquivalence { Value = 1 };
			HasEquivalence two = new HasEquivalence { Value = 2 };

			Assert.IsFalse(one.IsEquivalentTo(null));

			Assert.AreEqual(one.IsEquivalentTo(one), true);
			Assert.AreEqual(one.IsEquivalentTo(oneClone), true);
			Assert.AreEqual(one.IsEquivalentTo(two), false);

			Assert.AreEqual(oneClone.IsEquivalentTo(one), true);
			Assert.AreEqual(oneClone.IsEquivalentTo(oneClone), true);
			Assert.AreEqual(oneClone.IsEquivalentTo(two), false);

			Assert.AreEqual(two.IsEquivalentTo(one), false);
			Assert.AreEqual(two.IsEquivalentTo(oneClone), false);
			Assert.AreEqual(two.IsEquivalentTo(two), true);
		}

		[Test]
		public void AreEquivalentTests()
		{
			HasEquivalence one = new HasEquivalence { Value = 1 };
			HasEquivalence oneClone = new HasEquivalence { Value = 1 };
			HasEquivalence two = new HasEquivalence { Value = 2 };

			Assert.AreEqual(Equivalence.AreEquivalent<HasEquivalence>(null, null), true);
			Assert.AreEqual(Equivalence.AreEquivalent(one, null), false);
			Assert.AreEqual(Equivalence.AreEquivalent(null, one), false);

			Assert.AreEqual(Equivalence.AreEquivalent(one, one), true);
			Assert.AreEqual(Equivalence.AreEquivalent(one, oneClone), true);
			Assert.AreEqual(Equivalence.AreEquivalent(one, two), false);

			Assert.AreEqual(Equivalence.AreEquivalent(oneClone, one), true);
			Assert.AreEqual(Equivalence.AreEquivalent(oneClone, oneClone), true);
			Assert.AreEqual(Equivalence.AreEquivalent(oneClone, two), false);

			Assert.AreEqual(two.IsEquivalentTo(one), false);
			Assert.AreEqual(two.IsEquivalentTo(oneClone), false);
			Assert.AreEqual(two.IsEquivalentTo(two), true);
		}

		[Test]
		public void AreSequencesEquivalentTests()
		{
			HasEquivalence one = new HasEquivalence { Value = 1 };
			HasEquivalence oneClone = new HasEquivalence { Value = 1 };
			HasEquivalence two = new HasEquivalence { Value = 2 };

			Assert.AreEqual(Equivalence.AreSequencesEquivalent<HasEquivalence>(null, null), true);
			Assert.AreEqual(Equivalence.AreSequencesEquivalent(new HasEquivalence[0], null), false);
			Assert.AreEqual(Equivalence.AreSequencesEquivalent(null, new HasEquivalence[0]), false);
			Assert.AreEqual(Equivalence.AreSequencesEquivalent(new HasEquivalence[0], new HasEquivalence[0]), true);
			Assert.AreEqual(Equivalence.AreSequencesEquivalent(new[] { one }, null), false);
			Assert.AreEqual(Equivalence.AreSequencesEquivalent(null, new[] { one }), false);
			Assert.AreEqual(Equivalence.AreSequencesEquivalent(new[] { one }, new[] { oneClone }), true);
			Assert.AreEqual(Equivalence.AreSequencesEquivalent(new[] { one, two }, new[] { one, two }), true);
			Assert.AreEqual(Equivalence.AreSequencesEquivalent(new[] { one, two }, new[] { one, two, one }), false);
			Assert.AreEqual(Equivalence.AreSequencesEquivalent(new[] { one, two }, new[] { two, one }), false);
		}

		[Test]
		public void UseEqualityComparer()
		{
			IEqualityComparer<HasEquivalence> ec = Equivalence.GetEqualityComparer<HasEquivalence>();

			HasEquivalence one = new HasEquivalence { Value = 1 };
			HasEquivalence oneClone = new HasEquivalence { Value = 1 };
			HasEquivalence two = new HasEquivalence { Value = 2 };

			Assert.AreEqual(ec.Equals(null, null), true);
			Assert.AreEqual(ec.Equals(one, null), false);
			Assert.AreEqual(ec.Equals(null, one), false);

			Assert.AreEqual(ec.Equals(one, one), true);
			Assert.AreEqual(ec.Equals(one, oneClone), true);
			Assert.AreEqual(ec.Equals(one, two), false);

			Assert.AreEqual(ec.Equals(oneClone, one), true);
			Assert.AreEqual(ec.Equals(oneClone, oneClone), true);
			Assert.AreEqual(ec.Equals(oneClone, two), false);

			Assert.AreEqual(ec.Equals(two, one), false);
			Assert.AreEqual(ec.Equals(two, oneClone), false);
			Assert.AreEqual(ec.Equals(two, two), true);
		}

		[Test]
		public void UseEqualityComparerWithFallback()
		{
			IEqualityComparer<HasEquivalence> ec = Equivalence.GetEqualityComparerOrFallback<HasEquivalence>();

			HasEquivalence one = new HasEquivalence { Value = 1 };
			HasEquivalence oneClone = new HasEquivalence { Value = 1 };
			HasEquivalence two = new HasEquivalence { Value = 2 };

			Assert.AreEqual(ec.Equals(null, null), true);
			Assert.AreEqual(ec.Equals(one, null), false);
			Assert.AreEqual(ec.Equals(null, one), false);

			Assert.AreEqual(ec.Equals(one, one), true);
			Assert.AreEqual(ec.Equals(one, oneClone), true);
			Assert.AreEqual(ec.Equals(one, two), false);

			Assert.AreEqual(ec.Equals(oneClone, one), true);
			Assert.AreEqual(ec.Equals(oneClone, oneClone), true);
			Assert.AreEqual(ec.Equals(oneClone, two), false);

			Assert.AreEqual(ec.Equals(two, one), false);
			Assert.AreEqual(ec.Equals(two, oneClone), false);
			Assert.AreEqual(ec.Equals(two, two), true);
		}

		[Test]
		public void UseEqualityComparerWithoutEquivalence()
		{
			IEqualityComparer<HasNotEquivalence> ec = Equivalence.GetEqualityComparerOrFallback<HasNotEquivalence>();

			HasNotEquivalence one = new HasNotEquivalence { Value = 1 };
			HasNotEquivalence oneClone = new HasNotEquivalence { Value = 1 };
			HasNotEquivalence two = new HasNotEquivalence { Value = 2 };

			Assert.AreEqual(ec.Equals(null, null), true);
			Assert.AreEqual(ec.Equals(one, null), false);
			Assert.AreEqual(ec.Equals(null, one), false);

			Assert.AreEqual(ec.Equals(one, one), true);
			Assert.AreEqual(ec.Equals(one, oneClone), false);
			Assert.AreEqual(ec.Equals(one, two), false);

			Assert.AreEqual(ec.Equals(oneClone, one), false);
			Assert.AreEqual(ec.Equals(oneClone, oneClone), true);
			Assert.AreEqual(ec.Equals(oneClone, two), false);

			Assert.AreEqual(ec.Equals(two, one), false);
			Assert.AreEqual(ec.Equals(two, oneClone), false);
			Assert.AreEqual(ec.Equals(two, two), true);
		}

		private sealed class HasEquivalence : IHasEquivalence<HasEquivalence>
		{
			public int Value { get; set; }

			public bool IsEquivalentTo(HasEquivalence other)
			{
				return other != null && other.Value == Value;
			}
		}

		private sealed class HasNotEquivalence
		{
			public int Value { get; set; }
		}
	}
}
