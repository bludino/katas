namespace StringCalculator
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            int result = 0;

            if (string.IsNullOrEmpty(numbers))
                return result;

            string[] array;

            if (numbers.StartsWith("//"))
            {
                char delimiter = char.Parse(numbers.Substring(2, 1));
                numbers = numbers.Substring(numbers.IndexOf('\n') + 1);

                array = numbers.Split(delimiter);
            }
            else
            {
                array = numbers.Split(new char[] { ',', '\n' });
            }


            foreach (string item in array)
            {
                result += int.Parse(item);
            }

            return result;
        }
    }
}