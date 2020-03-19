﻿using Kahla.SDK.Models;

namespace Kahla.SDK.Events
{
    public enum EventType
    {
        /// <summary>
        /// When some one sent you a new message.
        /// </summary>
        NewMessage = 0,
        /// <summary>
        /// When a friend request related to you was created.
        /// </summary>
        NewFriendRequestEvent = 1,
        /// <summary>
        /// When you was deleted by a friend or you deleted a friend.
        /// </summary>
        WereDeletedEvent = 2,
        FriendsChangedEvent = 3,
        TimerUpdatedEvent = 4,
        NewMemberEvent = 5,
        SomeoneLeftEvent = 6,
        DissolveEvent = 7,
    }
    public class KahlaEvent
    {
        public EventType Type { get; set; }
        public string TypeDescription => Type.ToString();
    }

    public class NewMessageEvent : KahlaEvent
    {
        public NewMessageEvent()
        {
            Type = EventType.NewMessage;
        }
        public string AESKey { get; set; }
        public bool Muted { get; set; }
        public bool Mentioned { get; set; }
        public int ConversationId => Message.ConversationId;
        public Message Message { get; set; }
        public string PreviousMessageId { get; set; }
    }

    public class NewFriendRequestEvent : KahlaEvent
    {
        public NewFriendRequestEvent()
        {
            Type = EventType.NewFriendRequestEvent;
        }

        public Request Request { get; set; }
    }

    public class FriendsChangedEvent : KahlaEvent
    {
        public FriendsChangedEvent()
        {
            Type = EventType.FriendsChangedEvent;
        }
        public Request Request { get; set; }
        public bool Result { get; set; }
        public PrivateConversation CreatedConversation { get; set; }
    }

    public class WereDeletedEvent : KahlaEvent
    {
        public WereDeletedEvent()
        {
            Type = EventType.WereDeletedEvent;
        }

        public KahlaUser Trigger { get; set; }
        public int ConversationId { get; set; }
    }

    public class TimerUpdatedEvent : KahlaEvent
    {
        public TimerUpdatedEvent()
        {
            Type = EventType.TimerUpdatedEvent;
        }
        public int ConversationId { get; set; }
        public int NewTimer { get; set; }
    }

    public class NewMemberEvent : KahlaEvent
    {
        public NewMemberEvent()
        {
            Type = EventType.NewMemberEvent;
        }
        public int ConversationId { get; set; }
        public KahlaUser NewMember { get; set; }
    }

    public class SomeoneLeftEvent : KahlaEvent
    {
        public SomeoneLeftEvent()
        {
            Type = EventType.SomeoneLeftEvent;
        }
        public int ConversationId { get; set; }
        public KahlaUser LeftUser { get; set; }
    }

    public class DissolveEvent : KahlaEvent
    {
        public DissolveEvent()
        {
            Type = EventType.DissolveEvent;
        }

        public int ConversationId { get; set; }
    }
}
