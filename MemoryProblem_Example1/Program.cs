using Leak;

internal class Program
{
	private static void Main()
	{
		Console.Write("Running example 1 of memory problem app... Press ENTER to start.");
		Console.ReadLine();

		var list = new List<string>();
		var stringGenerator = new StringGenerator();

		const int length = 10000;
		const int repeatCnt = 1000;
		var index = 0;
		while (index < repeatCnt)
		{
			list.Add(
				stringGenerator.GenRandomStr(length));

			index++;

			Thread.Sleep(1);
		}

		Console.Write("Press ENTER to force clean.");
		Console.ReadLine();

		list.Clear();
		GC.Collect();

		Console.Write("Press ENTER to stop.");
		Console.ReadLine();
	}
}
