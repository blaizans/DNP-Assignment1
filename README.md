# DNP-Assignment1

## Minimum requirement
This assignment is open-ended, meaning that the minimum requirements are few, but there is plenty of
room to expand upon the assignment, if you wish to challenge yourself. See optional suggestions in the
next section.
As a minimum, you must be able to:
1. Register, log in, and out
2. Create a new post (when logged in), containing a title and a body (create a new page for this)
3. View all posts, i.e. just a Title (either use the front page or create a new page)
4. Click on a post in the post overview, to go to a new page, where you can view the entire post.

### Authentication
A User consists at least of some username (or similar unique property) and password. I.e. your standard
login information.
At the time of this assignment being handed out, you can implement the functionality of creating a new
User, i.e. signing up for the app. But the functionality of logging in will be taught later in the course. For the
Web API it is fairly easy to apply this later.

## Optional requirements
Below are ideas to expand upon the assignment. It is recommended to do them from the top down,
however, not strictly necessary. Also, feel free to come up with your own features.
• The option for users to create sub-forums.
o Each post must then belong to a sub-forum. A sub-forum could be owned by the creator, so
the creator could be able to delete the sub-forum again, or otherwise moderate it, by
deleting posts, etc.
• The feature to comment on posts
o Each user can create one or more comments to each post.
• The feature to upvote/downvote posts
• The feature to upvote/downvote comments
• A profile page, where you can see stuff like
o Overview of all your posts
o Overview of all your comments
o A total of points based on upvotes.
• The feature to comment on comments.
• Whatever you can imagine, be creative.

## Your Task
Your task in this assignment is to make the Web API, i.e. the server. It should store the data as JSON in a
file, as you have seen in the Todo tutorial.
You must model the domain classes, create the relevant associations, etc. This collection of domain classes
may become complicated, and can be difficult to store effectively in a JSON format. Don’t worry too much
about having duplicate data in the JSON file. In the Todo tutorial the same User existed in multiple places. It
will be cleaner when the database is added.
You must follow the three-layered architecture taught in the Todo tutorial. You are free to be inspired by
that tutorial as much as needed. I recommend re-using the File storage functionality as much as possible.

## Recommendations for approaching this assignment
Do vertical slices. That means one feature at a time, and do only what is needed for this feature.
You could for example start with the feature of registering a user.
Then create new post, and initially just verify the content of the json file, to see if the post was created.
Then a view all functionality.
Etc.
Remember to apply a good design.

## Formalities
You may work in groups on this assignment.
This assignment must be handed in to be allowed to attend the exam.
Deadline will be posted on itslearning.

## What to hand in
A link to GitHub where you have your code.
A detailed class diagram of the entire system, in .svg file format.
