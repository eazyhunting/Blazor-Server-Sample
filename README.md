# BlazorServerSample

This is an example solution of how you might build a N-Tier application with a Blazor UI.

This is a work in progress.

## Project: BlazorServerSample

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

## Project: BlazorServerSample.Data

The .Data project defines the entities for Post & Comment along with the AppDbContext which uses EntityFrameworkCore, inherits from the DbContext and defines the DbSet<T>'s that I'll be working with.

The Repsoitories folder contains a folder for the interfaces IPostRepository & ICommentRepository. Directly in the Repositories folder I implemented the concrete repositories respectively. 

The DependencyInjectionExtensions.RegisterDataServices static method is responsible for registering all of the repositories. This is known as the ServiceCollection pattern which I prefer over having the consumer of the repositories deal with the specifics of registration.

One of the design decisions I made that I will note is that I impelmented a specific SaveChangesAsync() seperately from the Insert/Update/Delete. I did this because I might want to add a UnitOfWork pattern later that would use the same repositories. In that case the UnitOfWork would call SaveChangesAsync rather than the repostories.

Somethings I might change and/or add later
- UnitOfWork - Implement the unit of work design pattern
- Generics - Create a Generic Repository (e.g., IRepository<T>)

## Project: BlazorServerSample.Exentions

## Project: BlazorServerSample.Services

## Project: BlazorServerSample.Shared


