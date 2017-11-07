# CommandQuerySeparationDemo

*Command–query separation (CQS) is a principle of imperative computer programming. It was devised by Bertrand Meyer as part of his pioneering work on the Eiffel programming language.*

*It states that every method should either be a command that performs an action, or a query that returns data to the caller, but not both. In other words, Asking a question should not change the answer.[1] More formally, methods should return a value only if they are referentially transparent and hence possess no side effects.*

https://en.wikipedia.org/wiki/Command%E2%80%93query_separation

This demonstration attempts to follow the command/query separation principle using the c sharp programming language. I've come across this principle in projects before and find it useful for separating action models from their implementations. This can be helpful for mocking and abstracting access-layers.

While the idea has been started by myself I must also give credit to Steven van Deursen as his blog on the principle (ironically separated into two posts) were a great help and inspiration to me.

Command: https://cuttingedge.it/blogs/steven/pivot/entry.php?id=91
Query: https://cuttingedge.it/blogs/steven/pivot/entry.php?id=92
