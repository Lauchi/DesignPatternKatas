﻿using System.Collections.Generic;
using System.Linq;
using State.Contracts;

namespace State.Users
{
    public class Administrator : IUser
    {
        private readonly IUserData _userData;

        public Administrator(IUserData userData)
        {
            _userData = userData;
        }

        public IUser Publish(string postToPublish)
        {
            return new Administrator(_userData.AddPost(postToPublish));
        }

        public IUser Ban()
        {
            throw new AdministratorCanNotBeBannedException();
        }

        public IUser Degrade()
        {
            throw new AdministratorCanNotBeDisabledException();
        }

        public IUser Upgrade()
        {
            return new Administrator(_userData);
        }

        public IUser PinPost(int id)
        {
            return new Administrator(_userData.PinPost(id));
        }

        public IEnumerable<string> Posts => _userData.Posts;
        public string PinnedPost => _userData.Posts.ToList()[_userData.PinnedPost];
        public string Name => _userData.Name;
    }
}