class Program {
	static void Test(out int n)
	{
		n = 123;//新規に値をセットする
	}
	static void Test2(ref int n)
	{
		n *= 10;//現在の値を改変する
	}

	static void Main()
	{
		Test(out int n);
		Test2(ref n);
		System.Diagnostics.Debug.WriteLine($"n = {n}");
	}
}
