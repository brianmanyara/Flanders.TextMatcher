using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Flanders.TextMatcher.Model;

namespace Flanders.TextMatcher.Business.Impl
{
    public class TextMatcherService : ITextMatcherService
    {
        public IEnumerable<MatchResult> Match(string text, string subText)
        {
            const RegexOptions options = RegexOptions.IgnoreCase;
            return (from Match match in Regex.Matches(text, subText, options)
                    select new MatchResult
                    {
                        Position = match.Index, 
                        Value = match.Value
                    }).ToList(); 
        }
    }
}
