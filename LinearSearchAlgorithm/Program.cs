
int[] arr = new int[5] {10,20,30,40,55};
Console.WriteLine("Enter your student id numder:");
int studentId = int.Parse(Console.ReadLine());
int index = LinerSearch (arr, studentId);
if(index == 0)
{
    Console.WriteLine($"Student id is not found");
}
else
{
    Console.WriteLine($"Student id is found at {index} indext");
}

 int LinerSearch(int[] arr, int x)
{
    for(int i=0; i<arr.Length; i++)
    {
        if (arr[i] == x)
        {
            return i;
        }
    }
    return -1;
}
