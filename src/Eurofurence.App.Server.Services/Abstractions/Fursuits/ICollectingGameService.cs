﻿using System;
using System.Threading.Tasks;
using Eurofurence.App.Common.Results;

namespace Eurofurence.App.Server.Services.Abstractions.Fursuits
{
    public interface ICollectingGameService
    {
        Task<FursuitParticipationInfo[]> GetFursuitParticipationInfoForOwnerAsync(string ownerUid);
        Task<PlayerParticipationInfo> GetPlayerParticipationInfoForPlayerAsync(string playerUid, string playerName);
        Task<IResult> RegisterTokenForFursuitBadgeForOwnerAsync(string ownerUid, Guid fursuitBadgeId, string tokenValue);
        Task<IResult<CollectTokenResponse>> CollectTokenForPlayerAsync(string playerUid, string tokenValue);
    }
}