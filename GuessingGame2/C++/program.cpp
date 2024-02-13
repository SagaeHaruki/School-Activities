#include <iostream>
#include <cstdlib>
#include <ctime> 

using namespace std;

int main() {
    
    srand(time(nullptr));
    int number = rand() % 100 + 1;
    int Count = 5;
    int input;
    
    for(int i = 0; i < Count;)
    {
        cout << "Enter a number: ";
        cin >> input;
        if(input < number)
        {
            cout << "Higher! " << endl;
            i++;
        }
        else if(input > number)
        {
            cout << "Lower! " << endl;
            i++;       
        }
        else
        {
            cout << "You guessed the right answer! " << number << endl;
            return 0;
        }
        
        if(i == Count)
        {
            cout << "You ran out of tries! \nThe correct number is: " << number << endl;
            return 0;
        }
    }
    return 0;
}
