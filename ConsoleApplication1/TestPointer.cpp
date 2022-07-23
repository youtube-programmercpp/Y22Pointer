#include <sal.h> //マイクロソフト社独自
void f(_Out_ int* p)
{
	*p = 123;
}
void f2(_Inout_ int* p)
{
	*p *= 10;
}
// Intellisense
#include <Windows.h>
#include <sstream>
int main()
{
	int n;
	f(&n);
	f2(&n);
	OutputDebugStringA((std::ostringstream() << "n = " << n << '\n').str().c_str());
}
