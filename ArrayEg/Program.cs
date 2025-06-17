string[] trainees = new string[]
{
 "Akhil", "Madhav", "Allen"
};

Console.WriteLine(trainees[0]);
for (int i = 0; i < trainees.Length; i++)
{
    Console.WriteLine(trainees[i]);
}
Console.WriteLine();

Console.WriteLine("For each");
foreach (string trainee in trainees)
{
    Console.WriteLine(trainee);
}