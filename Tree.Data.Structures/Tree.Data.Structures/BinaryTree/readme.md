# 🌳 Binary Tree — A Genius Twist to a Messy Jungle

## 🧠 Concept: From Chaos to Clarity

In regular trees, each node can have many children. This sounds flexible, but it makes the structure messy and hard to navigate.  
Imagine trying to find your friend in a huge forest without a map... exhausting, right?

---

## 🌟 The Genius Idea: Binary Trees

**Binary Trees** solved this problem by introducing a simple but powerful rule:

> 🎯 Every node has **at most two children** — called `Left` and `Right`.

This idea turns the chaotic jungle into a clean, organized maze. Now we can explore the tree with clear rules and write code that just works.

---

## 🧱 Structure

```
    A
   / \
  B   C
 / \   \
D   E   F
```



- Each node has **only two options**: go left or go right.
- This makes insertion and reading **much easier**.

---

## 💻 C# Code Example

Below is a simple C# program that:
- Defines a binary tree
- Inserts nodes level by level (left to right)
- Prints out the tree in level order

### 🧩 TreeNode and BinaryTree Classes

```csharp
using System;
using System.Collections.Generic;

public class Node(string value)
{
    public string Value { get; set; } = value;

    public Node? Left { get; set; }

    public Node? Right { get; set; }
}

public class AnimalGuesser
{
    private readonly Node _root;

    public AnimalGuesser()
    {
        _root = new Node("Is it a mammal?");
        _root.Left = new Node("Is it bigger than a cat?");
        _root.Right = new Node("Is it a bird?");

        var leftNode = _root.Left;

        leftNode.Left = new Node("Dog");
        leftNode.Right = new Node("Elephant");

        var rightNode = _root.Right;
        rightNode.Left = new Node("Eagle");
        rightNode.Right = new Node("Lizard");
    }

    public void Play()
    {
        var current = _root;

        while (current.Left is not null && current.Right is not null)
        {
            Console.WriteLine(current.Value + " (yes/no)");
            var input = Console.ReadLine()?.Trim().ToLower();

            if (input?.Equals("yes", StringComparison.OrdinalIgnoreCase) ?? false)
            {
                current = current.Left!;
            }
            else if (input?.Equals("no", StringComparison.OrdinalIgnoreCase) ?? false)
            {
                current = current.Right!;
            }
            else
            {
                Console.WriteLine("Please answer only with 'yes' or 'no'.");
            }
        }

        Console.WriteLine($"🎉 I think it's a {current.Value}!");
    }
}
```