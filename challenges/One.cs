static int One()
{
    List<int> nums = [2, 1, 3, 5, 3, 2];
    HashSet<int> alreadyPresent = [];

    int result = -1;
    foreach (int num in nums)
    {
        if (!alreadyPresent.Add(num))
        {
            result = num;
            break;
        }
    }
    return result;
}

Console.WriteLine(One());