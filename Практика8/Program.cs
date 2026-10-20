using System;
using System.Globalization;

int[] room = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

double[] size = { room[0], room[1], room[2] };

double[] spider = Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);
double[] fly = Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);

double answer = double.MaxValue;

for (int spiderAxis = 0; spiderAxis < 3; spiderAxis++)
{
    for (int spiderSide = 0; spiderSide < 2; spiderSide++)
    {
        double spiderBoundary = spiderSide == 0 ? 0 : size[spiderAxis];

        if (spider[spiderAxis] != spiderBoundary)
            continue;

        for (int flyAxis = 0; flyAxis < 3; flyAxis++)
        {
            for (int flySide = 0; flySide < 2; flySide++)
            {
                double flyBoundary = flySide == 0 ? 0 : size[flyAxis];

                if (fly[flyAxis] != flyBoundary)
                    continue;

                double distance = 0;

                if (spiderAxis == flyAxis)
                {
                    if (spiderSide == flySide)
                    {
                        int first = (spiderAxis + 1) % 3;
                        int second = (spiderAxis + 2) % 3;

                        double dx = spider[first] - fly[first];
                        double dy = spider[second] - fly[second];

                        distance = Math.Sqrt(dx * dx + dy * dy);
                    }
                    else
                    {
                        for (int otherAxis = 0; otherAxis < 3; otherAxis++)
                        {
                            if (otherAxis == spiderAxis)
                                continue;

                            int remainingAxis = 3 - spiderAxis - otherAxis;

                            for (int side = 0; side < 2; side++)
                            {
                                double edge = side == 0 ? 0 : size[otherAxis];

                                double spiderOffset = Math.Abs(spider[otherAxis] - edge);
                                double flyOffset = Math.Abs(fly[otherAxis] - edge);

                                double unfolded = size[spiderAxis]
                                    + spiderOffset + flyOffset;

                                double otherDistance =
                                    spider[remainingAxis] - fly[remainingAxis];

                                distance = Math.Sqrt(
                                    unfolded * unfolded
                                    + otherDistance * otherDistance);

                                if (distance < answer)
                                    answer = distance;
                            }
                        }

                        continue;
                    }
                }
                else
                {
                    int remainingAxis = 3 - spiderAxis - flyAxis;

                    double spiderOffset = Math.Abs(
                        spider[flyAxis] - flyBoundary);

                    double flyOffset = Math.Abs(
                        fly[spiderAxis] - spiderBoundary);

                    double alongEdge =
                        spider[remainingAxis] - fly[remainingAxis];

                    distance = Math.Sqrt(
                        alongEdge * alongEdge
                        + (spiderOffset + flyOffset)
                        * (spiderOffset + flyOffset));
                }

                if (distance < answer)
                    answer = distance;
            }
        }
    }
}

Console.WriteLine(answer.ToString("F3", CultureInfo.InvariantCulture));