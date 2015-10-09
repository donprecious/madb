﻿// <copyright file="IPacketConsumer.cs" company="The Android Open Source Project, Ryan Conrad, Quamotion">
// Copyright (c) The Android Open Source Project, Ryan Conrad, Quamotion. All rights reserved.
// </copyright>

namespace Managed.Adb
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    ///
    /// </summary>
    public interface IPacketConsumer
    {
        /// <summary>
        /// Reads this instance.
        /// </summary>
        void Read();

        // TODO: JdwpPacket
        /*JdwpPacket*/ object GetJdwpPacket();

        /// <summary>
        /// Forwards the packet to client.
        /// </summary>
        /// <param name="packet">The packet.</param>
        void ForwardPacketToClient(/*JdwpPacket*/ object packet);

        /// <summary>
        /// Sends the handshake.
        /// </summary>
        bool SendHandshake();

        /// <summary>
        /// Sends the and consume.
        /// </summary>
        /// <param name="packet">The packet.</param>
        void SendAndConsume(/*JdwpPacket*/ object packet);
    }
}