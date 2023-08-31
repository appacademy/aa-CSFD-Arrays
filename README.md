# Exercise: Arrays NUnit

## Introduction

In this exercise, you will be given a series of challenges to check your ability to use arrays.

## Instructions

* Open [ExercisesArrays.sln.](activities/11e-ExercisesArray.zip)
* Click Test > Run all Test, and this will produce red results

    ![Array fail](https://aa-online.s3.us-west-1.amazonaws.com/htd-assets/csfd/csharp-lang-fundamentals/array_fail.png)
* Open ArrayExercises.cs
* Complete the following methods

### Automated Testing

When you click Test > Run all Tests, you are telling your IDE to find and run all of the automated tests associated with the project.

Automated testing is a valuable tool for keeping bugs out of your code. Briefly, they are a way of codifying the expectation that given a certain input, the program will produce an expected output. We will dive into how they work (and how to write your own!) later in the course, but for now they're a useful way of letting you get immediate feedback on whether or not you've correctly completed the exercises below.

### CreateNewArray

Given a size greater than zero, return a new array of ints

### GetLastElement

Given an array larger than 0, return the last element in the array

### FillArray

Given an empty array, fill each element with the index + 1

### GrowArray

Given an array, and n. Add more slots to an array. eg. An array with 5 elements, and n = 2, return an array with 7 elements.

### HalfArray

Given an array length greater than 1, reduce the array size in half rounded down.
