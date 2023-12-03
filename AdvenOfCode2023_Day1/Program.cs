namespace AdvenOfCode2023_Day1
{
    public class Program
    {
        private readonly List<string> _calibrationList = [.. File.ReadLines("./input.txt")];

        private int totalSum = 0;
        private List<int> _digitList = [];

        private void Main(string[] args)
        {
            foreach (var value in _calibrationList)
            {
                _digitList.Add(int.Parse(
                    CheckForNumbers(
                        value
                        )
                    )
                );

                totalSum = _digitList.Sum();
            }

            Console.WriteLine(totalSum.ToString());
        }

        private string CheckForNumbers(string value)
        {
            var list = value.ToCharArray().Select(x => x.ToString()).ToList();

            var firstDigit = string.Empty;
            var lastDigit = string.Empty;

            for (var i = 0; i < list.Count; i++)
            {
                if (int.TryParse(list[i], out var digit)){
                    firstDigit = digit.ToString();
                    break;
                }
            }

            for (var i = list.Count - 1; i >= 0 ; i--)
            {
                if (int.TryParse(list[i], out var digit)){
                    lastDigit = digit.ToString();
                    break;
                }
            }

            return firstDigit + lastDigit;
        }
    }
}
