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

Code Explanation 

Fibonacci Series 

The Fibonacci sequence is generated using iteration. Given n terms, it prints the series using two variables that store previous values.  

Explanation of Fibonacci Program  

What is the Fibonacci Series? The Fibonacci series is a sequence where each number is the sum of the previous two numbers. The first two terms are always 0 and 1. Mathematically: 𝐹 ( 𝑛 ) = 𝐹 ( 𝑛 − 1 ) + 𝐹 ( 𝑛 − 2 ) F(n)=F(n−1)+F(n−2) where: 𝐹 ( 0 ) = 0 F(0)=0 𝐹 ( 1 ) = 1 F(1)=1 𝐹 ( 2 ) = 0 + 1 = 1 F(2)=0+1=1 𝐹 ( 3 ) = 1 + 1 = 2 F(3)=1+1=2 𝐹 ( 4 ) = 1 + 2 = 3 F(4)=1+2=3, and so on.  

Code Breakdown Input Handling The user enters how many terms they want. Loop Execution A for loop runs n times, printing each Fibonacci number. We use two variables, first and second, to keep track of the previous two numbers. Efficient Calculation Each Fibonacci number is calculated without recursion, making it efficient. 

How to Compile & Run: ``sh g++ fibonacci.cpp -o fibonacci ./fibonacci 

Factorial Calculation 

The factorial of a number n is computed iteratively. The factorial of n is given by: n! = n × (n-1) × (n-2) × ... × 1 

How to Compile & Run:  

``sh g++ factorial.cpp -o factorial ./factorial 

Explanation of Factorial Program 

What is Factorial? 

The factorial of a number nnn is the product of all numbers from 111 to nnn: n!=n×(n−1)×(n−2)×...×1n! = n \times (n-1) \times (n-2) \times ... \times 1n!=n×(n−1)×(n−2)×...×1 

Example: 

5!=5×4×3×2×1=1205! = 5 \times 4 \times 3 \times 2 \times 1 = 1205!=5×4×3×2×1=120 

Code Breakdown 

Input Handling 

The user is prompted to enter a number. 

Factorial Calculation 

If the number is 0 or 1, the function immediately returns 1. 

Otherwise, a for loop runs from 2 to n, multiplying all numbers. 

Efficiency Considerations 

Uses an iterative approach (instead of recursion) to avoid stack overflow for large numbers. 

Uses a long long variable to handle large factorial values. 

 
