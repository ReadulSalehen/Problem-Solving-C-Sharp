

int[] arr = new int[] {2,4,9,8,10,-1};
InsertionSort(arr);
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"{arr[i]}");
}

static void InsertionSort(int[] arr)
{
    int count = arr.Length;
    int key;
    for (int i = 1; i < count; i++)
    {
        key = arr[i];
        int j = i - 1;
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
}

