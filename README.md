# CommandQuerySeparationDemo

*Command–query separation (CQS) is a principle of imperative computer programming. It was devised by Bertrand Meyer as part of his pioneering work on the Eiffel programming language.*

*It states that every method should either be a command that performs an action, or a query that returns data to the caller, but not both. In other words, Asking a question should not change the answer.[1] More formally, methods should return a value only if they are referentially transparent and hence possess no side effects.*

https://en.wikipedia.org/wiki/Command%E2%80%93query_separation

This demonstration attempts to follow the command/query separation principle using the c sharp programming language. I've come across this principle in projects before and find it useful for separating action models from their implementations. This can be helpful for mocking and abstracting access-layers.
