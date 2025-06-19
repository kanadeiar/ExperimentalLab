#include <iostream>
#include <windows.h>

using namespace std;

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    cout << "Привет!" << endl;

    cout << "Нажать любую кнопку для завершения ..." << endl;
    cin.get();
    return 0;
}

