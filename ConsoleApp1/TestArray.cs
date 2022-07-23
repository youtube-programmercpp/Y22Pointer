class Program {
	static void f(int[] a)
	{
		for (int i = 0; i < a.Length; ++i)
		{
			a[i] *= 10;
		}
	}
	unsafe static void f2(int* p, int n)
	{
		for (int i = 0; i < n; ++i)
		{
			p[i] *= 10;
		}
	}
	unsafe static void Main()
	{
		var a = new int[] { 10, 20, 30 };
		fixed (int* p = a)
		{
			f2(p, a.Length);
		}
	}
}
