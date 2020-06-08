using System.Linq;
using Flanders.TextMatcher.Business.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flanders.TextMatcher.Business.Test
{
    [TestClass]
    public class TextMatcherServiceTests    
    {
        private ITextMatcherService _iTextMatcherService;

        [TestInitialize]
        public void Setup() 
        {
            _iTextMatcherService = new TextMatcherService();
        }

        [TestMethod]
        public void Two_Matches_Found() 
        {
            var results = _iTextMatcherService.Match("table football, foosball", "foo").ToArray();
            Assert.AreEqual(2, results.Length);
            Assert.AreEqual(6, results[0].Position);
            Assert.AreEqual(16, results[1].Position);
        }

        [TestMethod]
        public void No_Matches_Found()  
        {
            var results = _iTextMatcherService.Match("table football, foosball", "fool").ToArray();
            Assert.AreEqual(0, results.Length);
        }

    }
}
