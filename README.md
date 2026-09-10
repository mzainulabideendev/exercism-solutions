# Exercism Solutions

[![Language](https://img.shields.io/badge/Language-C%23-512BD4?style=flat-square\&logo=csharp\&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Exercism-009CAB?style=flat-square)](https://exercism.org/)
[![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)](LICENSE)
[![Repository](https://img.shields.io/badge/GitHub-mzainulabideendev-181717?style=flat-square\&logo=github)](https://github.com/mzainulabideendev)

A structured collection of my solutions to programming exercises from [Exercism](https://exercism.org/), focused primarily on **C# and .NET**.

This repository documents my continuous journey of improving problem-solving skills, strengthening programming fundamentals, learning clean coding practices, and developing a deeper understanding of software engineering concepts through practical exercises.

---

## Overview

Exercism provides programming exercises designed to help developers practice language fundamentals, problem solving, algorithms, data structures, and software design.

This repository contains my completed solutions and serves as a personal technical archive of my progress.

The main objectives are:

* Strengthen C# programming fundamentals
* Improve logical and analytical thinking
* Practice algorithms and data structures
* Understand object-oriented programming concepts
* Write clean, readable, and maintainable code
* Improve familiarity with the .NET ecosystem
* Develop consistent problem-solving techniques
* Track progress through practical programming exercises

---

## Repository Architecture

The repository is organized by programming language and then by individual Exercism exercises.

```text
exercism-solutions/
│
├── solutions/
│   └── csharp/
│       │
│       ├── exercise-1/
│       │   ├── Exercise.cs
│       │   └── ...
│       │
│       ├── exercise-2/
│       │   ├── Exercise.cs
│       │   └── ...
│       │
│       ├── exercise-3/
│       │   ├── Exercise.cs
│       │   └── ...
│       │
│       └── ...
│
├── LICENSE
└── README.md
```

### Structure

| Directory            | Purpose                           |
| -------------------- | --------------------------------- |
| `solutions/`         | Contains programming solutions    |
| `solutions/csharp/`  | C# Exercism track solutions       |
| Exercise directories | Individual programming challenges |
| `LICENSE`            | MIT License                       |
| `README.md`          | Repository documentation          |

---

## Learning Workflow

The repository follows a practical problem-solving workflow:

```text
                    ┌──────────────────────┐
                    │      Exercism        │
                    │   Programming Task   │
                    └──────────┬───────────┘
                               │
                               ▼
                    ┌──────────────────────┐
                    │ Understand Problem   │
                    │ Requirements & Rules │
                    └──────────┬───────────┘
                               │
                               ▼
                    ┌──────────────────────┐
                    │ Analyze the Logic    │
                    │ Cases & Constraints  │
                    └──────────┬───────────┘
                               │
                               ▼
                    ┌──────────────────────┐
                    │ Implement in C#      │
                    │ Clean & Readable     │
                    └──────────┬───────────┘
                               │
                               ▼
                    ┌──────────────────────┐
                    │ Run Exercism Tests   │
                    │ Validate Solution    │
                    └──────────┬───────────┘
                               │
                         ┌─────┴─────┐
                         │           │
                       Failed      Passed
                         │           │
                         ▼           ▼
                  ┌────────────┐  ┌──────────────┐
                  │ Debug &    │  │ Review Code  │
                  │ Improve    │  │ & Refactor   │
                  └─────┬──────┘  └──────┬───────┘
                        │                │
                        └───────┬────────┘
                                ▼
                       ┌──────────────────┐
                       │ Commit Solution  │
                       │ & Track Progress │
                       └──────────────────┘
```

This process emphasizes understanding the problem before writing code rather than simply producing a working answer.

---

## C# Focus

The primary language in this repository is **C#**.

The exercises provide an opportunity to practice different areas of the language, including:

### Core C#

* Variables and data types
* Operators
* Conditional statements
* Loops
* Methods
* Classes
* Interfaces
* Properties
* Collections
* Exception handling
* String manipulation
* Pattern matching

### Object-Oriented Programming

* Encapsulation
* Abstraction
* Inheritance
* Polymorphism
* Interfaces
* Classes and objects

### Problem Solving

* Logical conditions
* Mathematical problems
* String processing
* Collection manipulation
* Searching
* Sorting
* Counting
* Data transformation
* Algorithmic reasoning

### .NET

The exercises also provide practical experience with the C#/.NET development environment and its standard programming conventions.

---

## Example: Leap Year

One of the exercises in the repository focuses on determining whether a year is a leap year.

The basic rule can be represented as:

```text
                    Is year divisible by 400?
                              │
                    ┌─────────┴─────────┐
                   YES                   NO
                    │                    │
                    ▼                    ▼
              Leap Year          Is year divisible by 100?
                                         │
                                ┌────────┴────────┐
                               YES               NO
                                │                 │
                                ▼                 ▼
                         Not Leap Year     Is year divisible by 4?
                                                   │
                                          ┌────────┴────────┐
                                         YES               NO
                                          │                 │
                                          ▼                 ▼
                                   Leap Year         Not Leap Year
```

This type of exercise demonstrates how multiple logical conditions can be combined to implement a precise set of rules.

---

## Problem-Solving Principles

The solutions in this repository are developed around several principles.

### 1. Understand Before Implementing

The problem requirements should be understood before writing the solution.

### 2. Break Problems Into Smaller Conditions

Complex problems can usually be simplified by identifying smaller logical conditions.

### 3. Prefer Readable Code

Code should be easy to understand rather than unnecessarily complicated.

### 4. Use Appropriate Language Features

C# features should be used when they improve clarity, maintainability, or correctness.

### 5. Test Against Edge Cases

Solutions should consider normal cases as well as boundary and exceptional cases.

### 6. Refactor When Appropriate

A solution that works is not necessarily the final solution. Code can often be improved after the initial implementation.

---

## Repository Workflow

The general development workflow is:

```text
Exercise
   │
   ▼
Understand Requirements
   │
   ▼
Design Logic
   │
   ▼
Implement Solution
   │
   ▼
Run Tests
   │
   ▼
Fix Failures
   │
   ▼
Review & Refactor
   │
   ▼
Commit
   │
   ▼
Push to GitHub
```

This creates a consistent cycle for learning and improving programming skills.

---

## Technologies

| Technology     | Purpose                                |
| -------------- | -------------------------------------- |
| C#             | Primary programming language           |
| .NET           | Runtime and development platform       |
| Exercism       | Programming practice platform          |
| Git            | Version control                        |
| GitHub         | Source-code hosting                    |
| GitHub Actions | Repository automation where applicable |

---

## Repository Goals

The long-term goals of this repository are to:

* Complete more Exercism exercises
* Improve C# proficiency
* Develop stronger algorithmic thinking
* Build better debugging skills
* Learn different approaches to solving programming problems
* Practice writing production-quality code
* Maintain a searchable archive of solved problems
* Use the exercises as preparation for real-world software development

---

## How to Explore

Browse the C# solutions directory:

```text
solutions/csharp/
```

Each exercise can be opened independently and reviewed as a small programming problem.

For the original exercises, visit the official Exercism platform:

[Exercism](https://exercism.org/)

For the C# track:

[C# Track](https://exercism.org/tracks/csharp)

---

## Running the Solutions

Clone the repository:

```bash
git clone https://github.com/mzainulabideendev/exercism-solutions.git
```

Move into the repository:

```bash
cd exercism-solutions
```

Open the project in your preferred C# development environment.

For example:

```bash
code .
```

If an individual exercise contains its own project or test configuration, run it using the appropriate .NET commands:

```bash
dotnet restore
dotnet build
dotnet test
```

---

## Learning Philosophy

This repository is not intended to be a collection of copied answers.

The purpose is to document the process of learning through practice.

Each exercise provides an opportunity to:

```text
Problem
   │
   ▼
Understanding
   │
   ▼
Reasoning
   │
   ▼
Implementation
   │
   ▼
Testing
   │
   ▼
Debugging
   │
   ▼
Improvement
   │
   ▼
Knowledge
```

The goal is to gradually transform individual programming exercises into stronger problem-solving abilities that can be applied to larger software projects.

---

## Exercism

Exercism is a programming practice platform that provides exercises across many programming languages and emphasizes learning through practice and feedback.

The official Exercism organization describes the platform as focused on code mentorship and thoughtful conversations about code.

This repository is maintained as a personal learning archive based on exercises completed through the platform.

---

## License

This repository is licensed under the MIT License.

See the [LICENSE](LICENSE) file for the complete license text.

---

## Author

**M Zain Ul Abideen**

Full-Stack .NET Developer | C# Developer | Software Developer

GitHub: [@mzainulabideendev](https://github.com/mzainulabideendev)

Repository: [exercism-solutions](https://github.com/mzainulabideendev/exercism-solutions)

---

## Disclaimer

These solutions represent my personal learning process and implementation approaches.

If you are also working through Exercism, I recommend attempting each exercise yourself before reviewing other solutions. The primary purpose of Exercism is to develop problem-solving ability through practice.

---

## Progress

This repository is continuously updated as new exercises are completed.

```text
Learning → Practicing → Solving → Reviewing → Improving
```

The journey continues with every exercise.
