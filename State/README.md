# State Pattern
The state pattern aims to put the state of an object inside the object so you need less if else when using the object.

## Pick this Kata if code like this bothers you
```
if (user.IsDisabled | user.IsBanned) throw new UserIsDisabledOrBannedException();
else user.Name = newName;

...

if (user.IsBanned) throw new AccesNotGrantedException();
else OpenWebpage();
```

## The Kata
You will implement a blogsystem with basic user role administration.

### Sprint 1
- a blogpost has a title and a body
- a user has a name and a list of posts that he published
- a user can publish posts

### Sprint 2
- a user can be banned
- if a user is banned, his published posts are hidden

### Sprint 3
- a user can be a read only user or a redakteur
- a read only user can not publish posts
- a redakteur can publish posts
- redakteur can be made a readonly user
- a readonly user can be made a redakteur

### Sprint 4
- posts are sorted by date
- a redakteur can pin a post. This pinned post is always the first post in the list of posts he published
- if a user pins a post, an error occurs

### Sprint 5
- users and redakteurs can be disabled, if they are disabled, they can no longer publish posts or pin posts
- users and redakteurs can be enabled, if they are enabled again, they can do what they were able to do before

### Sprint 6
- there will be a administrator role
- the administrator can disable, enable or ban a user/redakteur
- the administrator can promote or demote a user/redakteur
- if an user/redakteur trys to disable/ban a user/redakteur, there will be an error

### Sprint 7
- there is a temporary Redakteur role
- a temporary redakteur role means a user can publish 3 posts like a redakteur
- only an administrator can grant temporary redakteur roles

### Sprint 8
- an administrator can delete a user/redakteur
- there will be no more access to a deleted user/redakteur

### Sprint 9
- an administrator can undelete a user
- an undeleted user works as if he was never deleted

### Sprint 10
- the read only user role is no longer needed, all users are treated like redakteurs

## The Problem

## The Explanation

## The Solution