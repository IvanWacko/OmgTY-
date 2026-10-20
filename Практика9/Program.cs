using System;
using System.Linq;
using System.Collections.Generic;

int[] ReadNumbers()
{
    return Console.ReadLine()!
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
}

int CountReal(int number, HashSet<int> unlucky)
{
    int skipped = 0;

    foreach (int value in unlucky)
    {
        if (value <= number)
            skipped++;
    }

    return number - skipped;
}

int CountDisplayed(int real, HashSet<int> unlucky)
{
    if (real == 0)
        return 0;

    int left = real;
    int right = real + unlucky.Count;

    while (left < right)
    {
        int middle = left + (right - left) / 2;

        if (CountReal(middle, unlucky) >= real)
            right = middle;
        else
            left = middle + 1;
    }

    return left;
}

int[] source = ReadNumbers();
int sourceCount = source[0];
int[] sourceRatios = source.Skip(1).ToArray();

int[] sourceUnluckyInput = ReadNumbers();
HashSet<int> sourceUnlucky = sourceUnluckyInput
    .Skip(1)
    .ToHashSet();

int[] target = ReadNumbers();
int targetCount = target[0];
int[] targetRatios = target.Skip(1).ToArray();

int[] targetUnluckyInput = ReadNumbers();
HashSet<int> targetUnlucky = targetUnluckyInput
    .Skip(1)
    .ToHashSet();

int[] amount = ReadNumbers();

long total = 0;
long multiplier = 1;

for (int i = sourceCount - 1; i >= 0; i--)
{
    int realAmount = CountReal(amount[i], sourceUnlucky);
    total += realAmount * multiplier;

    if (i > 0)
        multiplier *= sourceRatios[i - 1];
}

int[] result = new int[targetCount];
long remaining = total;

for (int i = 0; i < targetCount; i++)
{
    long unitValue = 1;

    for (int j = i; j < targetCount - 1; j++)
        unitValue *= targetRatios[j];

    long realAmount = remaining / unitValue;
    remaining %= unitValue;

    result[i] = CountDisplayed((int)realAmount, targetUnlucky);
}

Console.WriteLine(string.Join(" ", result));