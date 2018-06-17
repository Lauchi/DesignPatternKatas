﻿using System.Collections.Generic;
using State.Contracts;

namespace State.Users
{
    public class BannedUser : IUser
    {
        private readonly UserData _userData;

        public BannedUser(UserData userData)
        {
            _userData = userData;
        }

        public IUser Publish(string postToPublish)
        {
            throw new UserCanNotPublishException();
        }

        public IUser Ban()
        {
            return new BannedUser(_userData);
        }

        public IUser Downgrade()
        {
            return new ReadOnlyUser(_userData);
        }

        public IUser Upgrade()
        {
            return new Administrator(_userData);
        }

        public IUser PinPost(int id)
        {
            throw new UserCanNotPinPostsException();
        }

        public IEnumerable<string> Posts => new List<string>();
        public int PinnedPost  => 0;
        public string Name => "BannedUser";
    }
}