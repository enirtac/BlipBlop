using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlipBlopTests
{
	[TestClass]
	public class BlipBlopTests
	{		
		[TestMethod]
		public void ReturnsBlipTest()
		{
			int value = 3;
			var text = BlipBlop.BlipBlop.TextToPrint(value);
			Assert.AreEqual("Blip", text);
		}

		[TestMethod]
		public void ReturnsBlopTest()
		{
			int value = 5;
			var text = BlipBlop.BlipBlop.TextToPrint(value);
			Assert.AreEqual("Blop", text);
		}

		[TestMethod]
		public void ReturnsBlipBlopTest()
		{
			int value = 15;
			var text = BlipBlop.BlipBlop.TextToPrint(value);
			Assert.AreEqual("BlipBlop", text);
		}

		[TestMethod]
		public void ReturnsValueTest()
		{
			int value = 14;
			var text = BlipBlop.BlipBlop.TextToPrint(value);
			Assert.AreEqual(value.ToString(), text);
		}
	}
}
