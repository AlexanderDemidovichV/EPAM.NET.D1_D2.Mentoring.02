using System;

namespace Task2
{
    public sealed class Int32Parser : IParser<int>
    {
        private readonly IParser<int> _parser;

        public Int32Parser(IParser<int> parser)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        }

        public int Parse(string value)
        {
            int parsedValue;
            try
            {
                parsedValue = _parser.Parse(value);
            }
            catch (ArgumentNullException ex)
            {
                throw new Int32ParserException("Something went wrong... sorry(", ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new Int32ParserException("Something went wrong... sorry(", ex);
            }
            catch (OverflowException ex)
            {
                throw new Int32ParserException("Something went wrong... sorry(", ex);
            }
            return parsedValue;
        }
    }
}
