﻿using System;

namespace SignalR.Client.TypedHubProxy.Tests
{
    public interface ITestHub
    {
        /// <summary>
        /// Does nothing.
        /// </summary>
        void DoNothing();

        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="guid">Guid.</param>
        void DoNothingWithParam(Guid guid);

        /// <summary>
        /// Returns the given guid.
        /// </summary>
        /// <param name="guid">Guid.</param>
        Guid ReturnGuid(Guid guid);
    }
}
