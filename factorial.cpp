#include <iostream>
using namespace std;

// Function to calculate the factorial of a number
unsigned long long factorial(int n) {
    unsigned long long result = 1; // Initialize result to 1

    // Check if the input is valid (non-negative)
    if (n < 0) {
        cout << "Factorial is not defined for negative numbers." << endl;
        return 0;
    }

    // Calculate factorial using a loop
    for (int i = 1; i <= n; i++) {
        result *= i; // Multiply result by the current number
    }

    return result;
}

int main() {
    int n;

    // Input: Number to calculate factorial
    cout << "Enter a non-negative integer: ";
    cin >> n;

    // Call the factorial function and display the result
    cout << "Factorial of " << n << " is: " << factorial(n) << endl;

    return 0;
}
