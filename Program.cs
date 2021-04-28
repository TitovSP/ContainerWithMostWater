using System;
using System.Linq;

int[] height = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
int area = MaxArea(height);
Console.WriteLine(area);
Console.ReadKey();

int MaxArea(int[] height)
{
    int area = 0;
    int first = 0;
    int last = height.Count() - 1;

    while(first < last)
    {
        area = Math.Max(area, (last - first) * Math.Min(height[first], height[last]));

        if (height[first] > height[last])
            last -= 1;
        else
            first += 1;
    }

    return area;
}
