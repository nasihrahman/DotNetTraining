
List<int> points = new List<int> { 1, 2, 3 };
points.Add(50);

int sum = 0;
foreach (int point in points)
{
    //Console.WriteLine(point);
    sum += point;
}

Console.WriteLine(sum);