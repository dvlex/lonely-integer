# Hacker Rank - 1 Month Preparation Kit
## Sparse Arrays

### Introduction

This is a series of exercises included in the "1 Month Preparation Kit" within HackerRank preparation kits. I am developing these solutions inside devcontainers to solve the different challenges in various programming languages that I know, such as:
- C#
- Python
- TypeScript
- Ruby

Additionally, I will assign different difficulty levels to each challenge, starting with console applications. Once the entire series is completed, I will display the results in a web application.

### Prerequisites

To run this devcontainer, you need:
- Linux, Mac, or Windows with WSL
- Docker
- Visual Studio Code
- Git

### Usage

Open this repository in VSCode (in CLI, open the repo folder and type `code .`). Press Ctrl + Shift + P, and type "Reopen in Container" to enter the devcontainer. Once inside the devcontainer, navigate to the file `Program.cs` and run it using the play button above.
![image](https://github.com/user-attachments/assets/be3f28fa-b04f-4515-b8b9-5c9be0158cd6)


### Challenge

There is a collection of input strings and a collection of query strings. For each query string, determine how many times it occurs in the list of input strings. Return an array of the results.

**Example**

There are instances of 'aba', 1 of 'xzxb', and 0 of 'ab'. For each query, add an element to the return array.

**Function Description**

Complete the function `matchingStrings` in the editor below. The function must return an array of integers representing the frequency of occurrence of each query string in strings.

`matchingStrings` has the following parameters:
- `string strings[n]`: an array of strings to search
- `string queries[q]`: an array of query strings

**Returns**
- `int[q]`: an array of results for each query

**Input Format**

- The first line contains an integer `n`, the size of `strings`.
- Each of the next `n` lines contains a string.
- The next line contains `q`, the size of `queries`.
- Each of the next `q` lines contains a string.

**Constraints**
- 1 ≤ n ≤ 1000
- 1 ≤ q ≤ 1000
- 1 ≤ |strings[i]|, |queries[i]| ≤ 20

**Sample Input 1**

```
4
aba
baba
aba
xzxb
3
aba
xzxb
ab
```

**Sample Output 1**

```
2
1
0
```

**Sample Input 2**

```
3
def
de
fgh
3
de
lmn
fgh
```

**Sample Output 2**

```
1
0
1
```

**Sample Input 3**

```
13
abcde
sdaklfj
asdjf
na
basdn
sdaklfj
asdjf
na
asdjf
na
basdn
sdaklfj
asdjf
5
abcde
sdaklfj
asdjf
na
basdn
```

**Sample Output 3**

```
1
3
4
3
2
```

### Solution


### Evidence

