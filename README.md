# Word Counter

#### _Code Review for Week 9 - 3/6/2020_

#### _By Jonathan Carlos_

## **Description**

_This application will build a C# codebase for a word counter. A user will be prompted to enter a word, followed by a sentence, and then be told how many times the given word appears in the given sentence._

## Preview
<p align="center">
  
</p>  

## **Behavior Driven Development**

| Behavior | Input | Output |
|----------|:-----:|--------|
| User enters a word. | "the" | **Word**: the |
| User enters a sentence. | "The duck swims on the lake." | **Sentence**: "The duck swims on the lake." |
| User enters a word and a sentence, showing what the count is. | "the", "The duck swims on the lake." | **Word**: the <br> **Sentence**: The duck swims on the lake. <br> **Word Count**: 2 |
| User enters a word and a sentence, ignoring the words in the sentence that contain the same letters in the same order, as the word given. | "The duck sang in the theater." | **Word**: the <br> **Sentence**: The duck swims on the lake. <br> **Word Count**: 2 |

## **Minimum Viable Product (MVP)**

The minimum viable product is an application that a user will interact with on a command line in their terminal. After typing and entering a word and a sentence, both the word and the sentence will be displayed in the terminal, as well as the word count for that sentence.

Stretch Goals Include:

* Allow users to enter multiple words.
* Allow users to enter multiple sentences.
* Allow users to run through the Word Count as many times as they would like without having to run it every time for a new word or sentence.

## **Setup/Installation**

*Cloning this repository:*
1. Open up your terminal.
2. Navigate to the desired directory in which you want to clone this repository.
3. Use the command `git clone https://github.com/jonathancarlos21/WordCounter.Solution` to clone this repository.
4. Open this repository from within your terminal.
5. Use `dotnet run` to start the application.

*Downloading this repository:*
1. On the top right of this page, click the "Clone or download" button.
2. Click on "Download ZIP."
3. Click the downloaded file to unzip and extract this repository to your desired directory.
4. Within your terminal, navigate to the directory where you saved this repository.
5. Open the repository within your terminal.
6. Use `dotnet run` to start the application.

## **Known Bugs**

There are no known bugs at this time.

## **Support and contact details**

If you have any questions, comments, or concerns, please feel free to contact the content creator at examplemail@company.net 

## **Technologies used**

* MSTest

* C#

* .Net Core

* Visual Studio Code

* GitBash

## **License**

Copyright (c) 2020 **_Word Counter_**

This software is licensed under the MIT license.