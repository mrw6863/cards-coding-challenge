# poker-coding-challenge
Coding Challenge from AMS Geek: Implement a Deck of Cards

--- 
# Coding Challenge Instructions
## Implement a Deck of Cards


> We would like you to create a C# or PHP implementation for a standard deck of poker-style playing cards. This deck is 52 cards with 4 suits (Hearts, Diamonds, Clubs and Spades) and 13 ranks (Ace, 2-10, Jack, Queen, and King).

> One of your classes should expose at least the following methods: 
- shuffle () - Shuffle returns no value but results in the cards in the deck being randomly permuted. Please
    - *do not* use a library-provided “shuffle” operation to implement this function. You may use library-provided random number generators in your solution.
- deal_one_card () - This function should return one card from the deck to the caller. If all cards have been dealt, no card is returned.
    - Specifically, a call to shuffle () followed by 52 calls to deal_one_card () should result in the caller being provided all 52 cards of the deck in a random order. If the caller then makes a 53rd call to deal_one_card (), no card is dealt.

> IMPORTANT: While this is a trivial assignment, pretend that this code will be the foundation for a new product. Take whatever measures you feel are required for your code to meet this bar. (Hint: TEST!)

> We have intentionally left many details of this assignment vague. Make reasonable assumptions that will result in the deck behaving as a real deck would. Feel free to use resources as you would when you typically implementing code but do not copy someone else's solution. We will discuss your solution during your interview.

> Please send in your solution via GitHub link at least one day (24 hours) in advance of your scheduled interview.


---
# Thought Process

## Setup
> As a Software Engineering major @RIT, I learned that documentation is critical. As such I'll be documenting my thought process as much as possible in addition to documenting the implementation itself
> I'm not familiar with the standard practices of coding in C# (such as naming conventions) so I've refrenced Microsoft's documentation below as guidelines
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
    - Upon reading this I've transitioned from snake_case to Pascal case
- [C# Unit Testing](https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022)
    - I've established my testing at the beginning of my implementation to be able to do test-driven development over the course of this coding challenge
- [C# Interfaces](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)
    - I'll be working with interfaces so I did some brief reading on what those should entail
- [C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments)
    - Implmented suggested coding comment conventions following the Microsoft documentation
- [Building and Running Tests](https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022#build-and-run-the-test)
    - These instructions are how I built and ran my tests


---
# Implementation

## Code
[CardDeck](https://github.com/mrw6863/cards-coding-challenge/blob/main/cards-coding-challenge/CardDeck.cs)

## Tests
[CardTests](https://github.com/mrw6863/cards-coding-challenge/blob/main/cards-test-coding-challenge/CardsTest.cs)
