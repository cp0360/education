int getMax(int[] array)
{
    int maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > maxValue)
            maxValue = array[i];

    return maxValue;
}


int[] array = {18, 21, 37, 42, 159, 64, 75, 81, 92};
int result = getMax(array);
Console.WriteLine(result);
