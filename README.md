# fibonacci-factorial-algorithmcodes
fibonacci and factorial c++ codes to show algoritms design
fibonacci-factorial-repository 

the codes are written in c++ to describe the algorithm design using fibonacci and factorial series 

Fibonacci Series & Factorial Program 

This project contains a c++ implementation of: 

Fibonacci Series 

Factorial Calculation 

Author 

Name: Denis Njiru 

Reg Number: EB3/61541/22 


1. Fibonacci Series in C++
The Fibonacci series is a sequence where each number is the sum of the two preceding ones, starting from 0 and 1. The sequence looks like this: 0, 1, 1, 2, 3, 5, 8, 13, ...

Explanation of the Algorithm:
Initialization: Start with the first two terms of the series, t1 = 0 and t2 = 1.

Input Validation: Check if the input n is valid (positive integer).

Base Cases:

If n == 1, print only the first term (0).

If n == 2, print the first two terms (0, 1).

Iteration:

For n > 2, calculate the next term as the sum of the previous two terms (nextTerm = t1 + t2).

Print the next term and update t1 and t2 for the next iteration.

Output: Print the Fibonacci series up to n terms.

Runtime Measurement:
We measure the time taken to compute the Fibonacci series using the chrono library. The execution time is calculated by capturing the start and end times and computing the difference in microseconds.


2. Factorial Calculation in C++
The factorial of a non-negative integer n is the product of all positive integers less than or equal to n. For example, 5! = 5 × 4 × 3 × 2 × 1 = 120.

Explanation of the Algorithm:
Initialization: Start with result = 1 to store the factorial value.

Input Validation: Check if the input n is valid (non-negative integer).

Iteration:

Use a loop to multiply result by each integer from 1 to n.

This accumulates the product of all integers in the range [1, n].

Output: Return the computed factorial value.

Runtime Measurement:
The time taken to compute the factorial is measured using the chrono library, capturing the execution time in microseconds.

Key Differences in Algorithms:
Fibonacci Series: Relies on iterative addition of the last two terms to generate the sequence.

Factorial: Relies on iterative multiplication of integers from 1 to n.

