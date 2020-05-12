# _Anagram_

#### _Epicodus Project May 12, 2020_

#### By _**Matt Stroud**_

## Description

_An Epicodus individual project using C# and MSTest. This project prioritizes unit testing to validate code and logic before writing code._
_The application will take a given word, and return a list of possible anagrams._

## Specs
| Behavior                                                                       | Input                     | Output                     |
|:-------------------------------------------------------------------------------|:--------------------------|---------------------------:|
| Program will create new object and store the passed word in memory.            | ... = new Anagram("Test") | Word = "Test"              |
| Program will return a string result.                                           | Word = "Dear"             | "Dear"                     |
| Program will store a list of comparison words in memory.                       | "Dear", "Test", "Cake"    | { "Dear", "Test", "Cake" } |
| Program will sort the user's word alphabetically.                              | "dear"                    | "aedr"                     |
| Program will sort the list of comparison words alphabetically.                 | "dear", "test", "cake"    | { "aedr", "estt", "acek" } |
| Program will return a word from the sorted list if it matches the sorted word. | "dear" { "read", "cake" } | "read"                     |
| Program will return words that are a partial match.                            | "hat" { "path, "cake" }   | "path"                     |

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the command dotnet build.

## Known Bugs

There are no known bugs at the time of this update.
 
## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/mlstroud/anagram/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core
* MSTest
* Git

### License

This software is licensed under the MIT license.

Copyright © 2020 **_Matt Stroud_**