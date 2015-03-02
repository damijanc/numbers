This is a simple solution to the problem of detecting numbers written with -_/\

Here is an example:

```
---   ---    |  |   |   -----
 /     _|    |  |___|   |___
 \    |      |      |       |
--    ---    |      |   ____|
|  |   |   -----
|  |___|   |___
|      |       |
|      |   ____|
```

Usage:

Numbers.App.exe  [path]

Here are the assumptions for this problem: 
I do not support large files since I use ReadLines and it would kill the RAM.
I assumed that the all the numbers are 4 lines high and that they are all the same as in example.
I did not complicate with factories, dependency injection etc. since this is a simple program.
I used interfaces :) but the solution would be just as good without them.
I did not implement the unit tests (that I should)
I did a very basic error handling.
