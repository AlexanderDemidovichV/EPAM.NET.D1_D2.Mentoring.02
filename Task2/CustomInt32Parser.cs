using System;
using System.Linq;

namespace Task2
{
    public sealed class CustomInt32Parser : IParser<int>
    {
        public int Parse(string value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            ValidateArgument(value);

            int result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                result = checked(10 * result + (value[i] - 48));
            }
            return result;
        }

        private void ValidateArgument(string value)
        {
            if (value.Any(symbol => symbol < 48 && symbol > 57))
            {
                throw new ArgumentOutOfRangeException("Argument has wrong symbols");
            }
        }
    }
}
