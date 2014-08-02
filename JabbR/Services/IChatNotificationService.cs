﻿using System;
using JabbR.Models;

namespace JabbR.Services
{
    public interface IChatNotificationService
    {
        void OnUserNameChanged(ChatUser targetUser, ChatUser callingUser, string oldUserName, string newUserName);
        void UpdateUnreadMentions(ChatUser mentionedUser, int unread);
    }
}