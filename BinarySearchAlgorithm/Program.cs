int BinarySearch(int[] arr, int seachItem)
{
    int start = 0;
    int end = arr.Length -1;
    while (start <= end)
    {
        int mid = (start + end) / 2;
        if (seachItem == arr[mid])
        {
            return mid;
        }
        else if(seachItem < arr[mid])
        {
            end = mid - 1;
        }
        else
        {
            start = mid + 1;
        }
    }
    return -1;
}





Console.Write("Please provaid input search item :");
int searchItem = int.Parse(Console.ReadLine());
int[] arr = { 5, 11, 20, 25, 33, 49, 50, 62, 67, 73 };
int result = BinarySearch(arr, searchItem);
if(result < 0)
{
    Console.WriteLine($"{searchItem} is not found");
}
else
{
    Console.WriteLine($"{searchItem} is found at index: {result}" );
}
