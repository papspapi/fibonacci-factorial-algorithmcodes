# MergeSortDescending - C# Implementation

## Student Details
**REG NO:** EB3/61541/22  
**NAME:** Denis Njiru  

---

## 💌 Project Overview
This project implements the **Merge Sort algorithm** in C#, sorting numbers in **descending order**. The program generates a random dataset, sorts it using Merge Sort, and logs execution details.

---

## 🚀 How to Run the Program

### **1️⃣ Prerequisites**
Ensure you have the following installed:
- **.NET SDK (Version 8.0 or later)**  
  Check if .NET is installed by running:
  ```sh
  dotnet --version
  ```
  If not installed, download it from [dotnet.microsoft.com](https://dotnet.microsoft.com/download)

- **C# Dev Kit (VS Code Extension)** (Optional but recommended)

### **2️⃣ Clone the Repository**
```sh
git clone https://github.com/yourusername/MergeSortDescending.git
cd MergeSortDescending
```

### **3️⃣ Build and Run the Program**
```sh
dotnet run
```

### **Alternative Method**
If you don't want to clone the repository, you can manually copy the raw contents of `Program.cs`, create a new file in your local machine, and then run it:
1. **Create a new file** named `Program.cs`.
2. **Paste the copied code** from `Program.cs`.
3. **Run the program** using the command:
   ```sh
   dotnet run Program.cs
   ```

### **4️⃣ Expected Output**
The program sorts **1,000,000 random numbers** and displays execution time:
```
Sorted 1,000,000 elements in 500 ms
Log saved to MergeSortLog.txt
```

---

## ⚙️ Implementation Details
- Uses **Merge Sort** for efficient sorting (**O(n log n) complexity**)
- Implements sorting with **C# Span<T>** for performance
- Saves execution time to a log file (`MergeSortLog.txt`)

---

## 📊 Performance & Optimization

### **Baseline Performance**
- Sorting **1 million elements** takes **~500ms** on an average machine
- Uses **Span<T> for memory efficiency**

### **Optimizations Considered**
- **Parallel Sorting** using `Parallel.Invoke()` (not included in this version to keep things simple)
- **Memory Tracking** using `GC.GetTotalMemory()`
- **Logging System** to track execution over time

---

## 🐝 License
This project is open-source. Feel free to modify and use it as needed!

---

## 💍 Contact
For questions or contributions, reach out via GitHub or email!

---

