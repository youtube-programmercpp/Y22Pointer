internal class Program
{
	static void 引き数に値を設定する関数(out int n)
	{
		n = 123;
	}
	static void 引き数を１０倍する関数(ref int n)
	{
		n *= 10;
	}
	static void Main(string[] args)
	{
		int n;
		引き数に値を設定する関数(out n);
		引き数を１０倍する関数(ref n);
	}
}
