#include <string>
void f(std::string& s)
{
}
int main()
{
	std::string s{ "TEST" };
	f(s);
}
