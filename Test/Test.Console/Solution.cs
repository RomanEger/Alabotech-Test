namespace Test.Console;

public static class Solution
{
    public static int GetMinSteps(int[] chips)
    {
        if (chips.Sum() % chips.Length != 0)
            throw new ArgumentException("Фишки нельзя поделить поровну между игроками!");

        int average = chips.Sum() / chips.Length;

        if (chips.Any(x => x != average))
        {
            int length = chips.Length;

            int moves = 0;

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < length; i++)
                dict.Add(i, chips[i]);

            for (int i = 0; i < length; i++)
            {
                int maxValue = dict.Values.Max();

                var max  = dict.First(x => x.Value == maxValue);
                
                if (max.Value == average)
                    break;

                if (max.Key == 0)
                {
                    if (chips[max.Key + 1] < average)
                    {
                        AddMoves(max.Key + 1, max.Key);
                    }
                    else if (chips[length - 1] < average)
                    {
                        AddMoves(length - 1, max.Key);
                    }
                }
                else if (max.Key == chips.Length - 1)
                {
                    if (chips[max.Key - 1] < average)
                    {
                        AddMoves(max.Key - 1, max.Key);
                    }
                    else if (chips[0] < average)
                    {
                        AddMoves(0, max.Key);
                    }
                }
                else
                {
                    if (chips[max.Key - 1] < average)
                    {
                        AddMoves(max.Key - 1, max.Key);
                    }
                    else if (chips[max.Key + 1] < average)
                    {
                        AddMoves(max.Key + 1, max.Key);
                    }
                }
            }

            return moves;

            void AddMoves(int keyForInc, int keyForDec)
            {
                while (chips[keyForDec] > average || chips[keyForInc] < average)
                {
                    dict[keyForInc] = ++chips[keyForInc];
                    dict[keyForDec] = --chips[keyForDec];
                    moves++;
                }
            }
        }

        return 0;
    }
}