# 2. Articles

Create a **class Article**with the following properties:

- **Title** – a string
- **Content** – a string
- **Author** – a string

The class should have a constructor and the following methods:

- **Edit (new content**) – change the old content with the new one
- **ChangeAuthor (new author)** – change the author
- **Rename (new title)** – change the title of the article
- Override the **ToString** method – print the article in the following format:

**"\{title} - \{content}:\ {author}"**

Create a program that reads an article in the following format **"\{title}, \{content}, \{author}"**. On the next line, you will receive a number **n,** representing the number of commands, which will follow after it. On the next **n**  **lines,** you will be receiving the following commands:

- **"Edit: \{new content}"**
- **"ChangeAuthor: \{new author}"**
- **"Rename: \{new title}"**

In the end, print the final state of the article.

## Example

| **Input** | **Output** |
| --- | --- |
| some title, some content, some author<br>3<br>Edit: better content<br>ChangeAuthor: better author<br>Rename: better title | better title - better content: better author |
| Fight club, love story, Martin Scorsese<br>2<br>Edit: underground fight club that evolves into much more<br>ChangeAuthor: Chuck Palahniuk | Fight club - underground fight club that evolves into much more: Chuck Palahniuk | 