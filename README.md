# 📊 Sort Visualizer
#### A simple visualizer for sorting algorithms.
- So far I implemented Bubble Sort, Insertion Sort, Stalin Sort, and Gnome Sort.

From old me:
> I recently got my wisdom teeth removed and I have a lot of time in my hands. This was pretty fun.  

From current me:
> This was very fun indeed.

## ✅ Possible Improvements
- Come up with a better framework
- Implement Quick Sort
- Change the color of the two values being compared/worked on

## 🧰 Tech Stack
- [Raylib-cs](https://github.com/raylib-cs/raylib-cs)
- .NET 6

## 🚀 Getting Started
```bash
git clone git@github.com:holypeachy/sort-visualizer.git
cd sort-visualizer
dotnet run
```
If raylib is missing add the package using:
```bash
dotnet add package Raylib-cs
```
To change the algorithm to be visualized:
1. Close program
2. Change the function in line 32 to the desired algorithm (one of these):
```csharp
Task.Run(() => GnomeSort());
Task.Run(() => BubbleSort());
Task.Run(() => StalinSort());
Task.Run(() => InsertionSort());
```

## 📤 Output Example:
<img width="1002" height="333" alt="image" src="https://github.com/user-attachments/assets/405b7b18-a3b5-4756-88e2-d298ff0e6cf5" />
