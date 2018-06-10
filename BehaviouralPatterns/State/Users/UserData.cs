﻿using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using State.Contracts;

namespace State.Users
{
    public class UserData : IUserData
    {
        private UserData(string name, IEnumerable<string> posts, int pinnedPost)
        {
            Name = name;
            Posts = posts;
            PinnedPost = pinnedPost;
        }

        public static UserData Create(string name)
        {
            return new UserData(name, new List<string>(), 0);
        }

        public IUserData SetName(string newName)
        {
            return new UserData(newName, Posts, PinnedPost);
        }

        public IUserData AddPost(string newPost)
        {
            var list = Posts.ToList();
            list.Add(newPost);
            return new UserData(Name, list, PinnedPost);
        }

        public IUserData PinPost(int id)
        {
            return new UserData(Name, Posts, id);
        }

        public IEnumerable<string> Posts { get; }
        public int PinnedPost { get; }
        public string Name { get; }
    }
}