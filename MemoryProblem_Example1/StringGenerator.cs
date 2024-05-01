namespace Leak
{
	internal sealed class StringGenerator
	{
		private readonly Random rnd = new();

		public string GenRandomStr(int length)
		{
			var chars = new List<char>();

			for (var i = 0; i < length; i++)
			{
				var a = (char)rnd.Next(0, 100);
				chars.Add(a);
			}

			return string.Concat(chars);
		}
	}
}
