class Program
{
	unsafe static void Test(int* p)
	{
		*p = 123;//新規に値をセットする
	}
	unsafe static void Test2(int* p)
	{
		*p *= 10;//現在の値を改変する
	}

	unsafe static void Main()
	{
		int n;
		Test(&n);
		Test2(&n);
		System.Diagnostics.Debug.WriteLine($"n = {n}");
	}
}
