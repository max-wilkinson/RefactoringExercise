# RefactoringExercise

## Credit
This exercise is copied from [Jeremy Miller's Composed Method Pattern](http://codebetter.com/jeremymiller/2006/12/03/composed-method-pattern/) blog post.

## Objective
The goal is to refactor the _MyExpandableList_ class such that it's _Add_ method can be fully understood in 3 seconds or less. For bonus points, you should use TDD to drive your refactorings.

## Tips
* Try to describe all the behaviors of the _Add_ method, in its unfactored state, to someone else in 3 seconds.
  * You will fail and that is okay! It means you've identified a code smell.
* Take a minute to gain a deeper understanding of a **single** behavior of the _Add_ method.
* Write a unit test(s) to characterize the behavior you studied in the above point.
* Refactor only the code relevant to this behavior, and run your test(s).
  * Hint: Extract Method, Rename, and Compose Method are 3 safe refactorings to start with.
