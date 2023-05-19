
public static class TimeComplexity
{
	public static void Main(string[] args)
	{
		Console.WriteLine(BinarySearch(234));
	}
	public static int BinarySearch(int val, int[] array = new int[] {23, 1423, 4332, 1213, 432, 212})
	{
		Array.Sort(array);
		int sA = 0, eA = array.Length - 1;
		int mA = (sA + eA) / 2;
		
		while (sA < eA)
		{
			if (array[mA] == val) return mA;
			(sA, eA) = (array[mA] < val ? mA + 1 : sA, array[mA] > val ? mA - 1 : eA);
		}
		return -1; 
	}
}

public static class TimeComplexity2
{
	public static void Main(string[] args)
	{
		Console.WriteLine(BubbleSort(234));
	}
	public static int BubbleSort(int val, int[] array = new int[] {23, 1423, 4332, 1213, 432, 212})
	{
		int temp = 0;
		for (int pointer = 0; pointer < array.Length; pointer++)
		{
			for (int sort = 0; sort < array.Length - 1; sort++)
			{
				if (array[sort] > array[sort + 1])
				{
					temp = array[sort + 1];
					array[sort + 1] = array[sort];
					array[sort] = temp;
				}
			}
		}
	}
