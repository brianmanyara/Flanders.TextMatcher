using System;
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

    }
}
