// Copyright (c) Microsoft Corporation. All rights reserved. Licensed under
// the MIT License. See LICENSE in the project root for license information.
// <autogenerated> This file was generated using AutoRest. </autogenerated>

namespace SocialPlus.Client
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Hashtags.
    /// </summary>
    public static partial class HashtagsExtensions
    {
            /// <summary>
            /// Get trending hashtags
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='authorization'>
            /// Format is: "Scheme CredentialsList". Possible values are:
            /// 
            /// - Anon AK=AppKey
            /// 
            /// - SocialPlus TK=SessionToken
            /// 
            /// - Facebook AK=AppKey|TK=AccessToken
            /// 
            /// - Google AK=AppKey|TK=AccessToken
            /// 
            /// - Twitter AK=AppKey|RT=RequestToken|TK=AccessToken
            /// 
            /// - Microsoft AK=AppKey|TK=AccessToken
            /// 
            /// - AADS2S AK=AppKey|[UH=UserHandle]|TK=AADToken
            /// </param>
            public static IList<string> GetTrendingHashtags(this IHashtags operations, string authorization)
            {
                return Task.Factory.StartNew(s => ((IHashtags)s).GetTrendingHashtagsAsync(authorization), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get trending hashtags
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='authorization'>
            /// Format is: "Scheme CredentialsList". Possible values are:
            /// 
            /// - Anon AK=AppKey
            /// 
            /// - SocialPlus TK=SessionToken
            /// 
            /// - Facebook AK=AppKey|TK=AccessToken
            /// 
            /// - Google AK=AppKey|TK=AccessToken
            /// 
            /// - Twitter AK=AppKey|RT=RequestToken|TK=AccessToken
            /// 
            /// - Microsoft AK=AppKey|TK=AccessToken
            /// 
            /// - AADS2S AK=AppKey|[UH=UserHandle]|TK=AADToken
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetTrendingHashtagsAsync(this IHashtags operations, string authorization, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTrendingHashtagsWithHttpMessagesAsync(authorization, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get autocompleted hashtags
            /// </summary>
            /// The query string must be at least 3 characters long, and no more than 25
            /// characters long.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='query'>
            /// Search query
            /// </param>
            /// <param name='authorization'>
            /// Format is: "Scheme CredentialsList". Possible values are:
            /// 
            /// - Anon AK=AppKey
            /// 
            /// - SocialPlus TK=SessionToken
            /// 
            /// - Facebook AK=AppKey|TK=AccessToken
            /// 
            /// - Google AK=AppKey|TK=AccessToken
            /// 
            /// - Twitter AK=AppKey|RT=RequestToken|TK=AccessToken
            /// 
            /// - Microsoft AK=AppKey|TK=AccessToken
            /// 
            /// - AADS2S AK=AppKey|[UH=UserHandle]|TK=AADToken
            /// </param>
            public static IList<string> GetAutocompletedHashtags(this IHashtags operations, string query, string authorization)
            {
                return Task.Factory.StartNew(s => ((IHashtags)s).GetAutocompletedHashtagsAsync(query, authorization), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get autocompleted hashtags
            /// </summary>
            /// The query string must be at least 3 characters long, and no more than 25
            /// characters long.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='query'>
            /// Search query
            /// </param>
            /// <param name='authorization'>
            /// Format is: "Scheme CredentialsList". Possible values are:
            /// 
            /// - Anon AK=AppKey
            /// 
            /// - SocialPlus TK=SessionToken
            /// 
            /// - Facebook AK=AppKey|TK=AccessToken
            /// 
            /// - Google AK=AppKey|TK=AccessToken
            /// 
            /// - Twitter AK=AppKey|RT=RequestToken|TK=AccessToken
            /// 
            /// - Microsoft AK=AppKey|TK=AccessToken
            /// 
            /// - AADS2S AK=AppKey|[UH=UserHandle]|TK=AADToken
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetAutocompletedHashtagsAsync(this IHashtags operations, string query, string authorization, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAutocompletedHashtagsWithHttpMessagesAsync(query, authorization, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}