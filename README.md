# Everybody Edits - Report Tool (2017)

This is a portfolio piece from a project I built in 2017 when I was 17. The game it was for is no longer active, and this code isn't maintained.

## The Problem

I used to be a volunteer moderator for the online Flash game "Everybody Edits." The existing moderation tool was inefficient and made it difficult to review player reports, check their history, and take action efficiently.

## The Solution

To make the job easier for myself and the other moderators, I decided to build a new standalone tool in C# and WinForms. It connected directly to the game's backend (PlayerIO) and provided a much more streamlined way to handle the report queue.

## Features & Technical Details

This was one of my first big projects and a great way to learn. I focused on building features that I knew we needed:

*   **Direct API Integration:** Connected to the PlayerIO backend for authentication, real-time messaging, and submitting moderation actions.
*   **Efficient UI:** A multi-tabbed interface to manage the report list, view individual report details, and look up player information without switching windows.
*   **Flicker-Free Chat Log:** To prevent the `RichTextBox` from flickering during rapid updates, I utilized a custom control (`ExtendedRichTextBox.cs`) that would temporarily freeze UI redraws.
*   **Useful Tools:**
    *   Client-side filtering for the report list.
    *   Desktop notifications for new, unhandled reports.
    *   Syntax highlighting in chat logs to easily distinguish the accuser and accusee.
    *   A context menu "Copy" function that could identify the exact text under the cursor.
*   **Easy Distribution:** Used `Costura.Fody` to package all dependencies into a single, portable `.exe`, so other moderators could use it without needing to install anything.

## Retrospective

This project taught me a lot about C#, WinForms, and working with APIs. It was a practical lesson in the value of building your own tools to solve direct, real-world workflow problems.

## Screenshots

<img width="786" height="593" alt="report-tool-1" src="https://github.com/user-attachments/assets/5cc8f1a6-c1da-476f-b620-ca487628377a" />
<img width="786" height="593" alt="report-tool-2" src="https://github.com/user-attachments/assets/f3f5d3a0-de2c-4859-be4e-f9c6cc902a11" />
<img width="786" height="593" alt="report-tool-3" src="https://github.com/user-attachments/assets/d30764dc-7022-4b4a-9141-5c0022583804" />
