void f(int *a, size_t n)
{
	for (size_t i = 0; i < n; ++i) {
		//*(a + i) *= 10;
		a[i] *= 10;
	}
}
void f2(int* a, size_t n)
{
	for (; n;--n)
		*a++ *= 10;
}


#include <algorithm>
int main()
{
	int a[]{10, 20, 30};
	f(a, std::size(a));
}
