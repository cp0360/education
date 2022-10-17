int[] array = {18, 231, 37, 42, 159, 64, 75, 81, 92};
int n = array.Length;
int find = 75;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}