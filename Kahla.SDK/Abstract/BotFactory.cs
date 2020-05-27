﻿using Aiursoft.Scanner.Interfaces;
using Kahla.SDK.Data;
using Kahla.SDK.Services;

namespace Kahla.SDK.Abstract
{
    public class BotFactory : ITransientDependency
    {
        private readonly ConversationService _conversationService;
        private readonly GroupsService _groupsService;
        private readonly FriendshipService _friendshipService;
        private readonly AuthService _authService;
        private readonly HomeService _homeService;
        private readonly KahlaLocation _kahlaLocation;
        private readonly BotLogger _botLogger;
        private readonly VersionService _versionService;
        private readonly SettingsService _settingsService;
        private readonly BotCommander _botCommander;
        private readonly EventSyncer _eventSyncer;
        private readonly StorageService _storageService;
        private readonly AES _aes;

        public BotFactory(
            ConversationService conversationService,
            GroupsService groupsService,
            FriendshipService friendshipService,
            AuthService authService,
            HomeService homeService,
            KahlaLocation kahlaLocation,
            BotLogger botLogger,
            VersionService versionService,
            SettingsService settingsService,
            BotCommander botCommander,
            EventSyncer eventSyncer,
            StorageService storageService,
            AES aes)
        {
            _conversationService = conversationService;
            _groupsService = groupsService;
            _friendshipService = friendshipService;
            _authService = authService;
            _homeService = homeService;
            _kahlaLocation = kahlaLocation;
            _botLogger = botLogger;
            _versionService = versionService;
            _settingsService = settingsService;
            _botCommander = botCommander;
            _eventSyncer = eventSyncer;
            _storageService = storageService;
            _aes = aes;
        }
    }
}
