#include <iostream>
#include <chrono>
using namespace std;
using namespace chrono;

// Function to generate Fibonacci series up to n terms
void fibonacci(int n) {
    int t1 = 0, t2 = 1, nextTerm = 0;

    // Check if the number of terms is valid
    if (n <= 0) {
        cout << "Please enter a positive integer.";
    } else if (n == 1) {
        // If only one term is required, print the first term
        cout << "Fibonacci Series: " << t1;
    } else {
        // Print the first two terms
        cout << "Fibonacci Series: " << t1 << ", " << t2;

        // Generate the rest of the terms
        for (int i = 3; i <= n; i++) {
            nextTerm = t1 + t2; // Calculate the next term
            cout << ", " << nextTerm;

            // Update the values of t1 and t2 for the next iteration
            t1 = t2;
            t2 = nextTerm;
        }
    }
    cout << endl;
}

int main() {
    int n;

    // Input: Number of terms in the Fibonacci series
    cout << "Enter the number of terms: ";
    cin >> n;

    // Measure runtime
    auto start = high_resolution_clock::now();
    fibonacci(n);
    auto stop = high_resolution_clock::now();

    // Display runtime
    cout << "Time taken: " << duration_cast<microseconds>(stop - start).count() << " microseconds\n";

    return 0;
}
