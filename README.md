# BlazorServerSample

This is an example solution of how you might build a N-Tier application with a Blazor UI.

This is a work in progress.

Project: BlazorServerSample

This is a simple component based approach to building a UI. On the Posts page it lists messages that a user might post on something like a social network. If you view the post you will see the full post with comments. You will also be allowed to comment. The components implemented are:

- PostComponent - Lists all the posts
- AddPostComponent - Create a new post
- ViewPostComponent - View a specific post
-   ViewCommentsComponent - View the comments for a post
-   AddCommentComponent - Add a comment to a post.

Some things I might change and/or add later
- Create services for each component - This might be overkill for a blazor application but I was found of this pattern in my Angular days.
- Implement the Blazor EditForm component - At the moment I use use standard HTML for my forms. I will probably want to experiement with Blazor specific controls
- Add Authentication - Might be out of scope for this sample app

Project: BlazorServerSample.Data

Project: BlazorServerSample.Exentions

Project: BlazorServerSample.Services

Project: BlazorServerSample.Shared


