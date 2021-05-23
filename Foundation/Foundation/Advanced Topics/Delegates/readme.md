<h1>Delegates</h1>

- "Action" is a used as part of the .net framework to create deletate methods. 
- We do not need to create our own as in my example. <br>

<h2>What is it</h2>

- An object that knows how to call a method (or a group of methods)
- A reference to a function


<h2>Why do we need it?</h2>

- For designing extensible and flexible applications (eg frameworks)
- Alternative: Interfaces

<h2>Interface or Delegates?</h2>

Use a delegate when
- An eventing design pattern is used
- The caller doesn't need to access outher properties or methods on the object implementing the method