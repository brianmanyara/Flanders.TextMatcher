using System.Collections.Generic;
using Flanders.TextMatcher.Model;

namespace Flanders.TextMatcher.Business
{
    public interface ITextMatcherService   
    {   
        IEnumerable<MatchResult> Match(string text, string subText);
    }
}
