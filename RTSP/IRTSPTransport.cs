﻿using System;

namespace RTSP
{
    /// <summary>
    /// Interface for Transport of RTSP (TCP, TCP+SSL,..)
    /// </summary>
    public interface IRTSPTransport
    {
        /// <summary>
        /// Gets the stream of the transport.
        /// </summary>
        /// <returns>A stream</returns>
        System.IO.Stream GetStream();

        /// <summary>
        /// Gets the remote address.
        /// </summary>
        /// <value>The remote address.</value>
        string RemoteAddress
        {
            get;
        }

        /// <summary>
        /// Closes this instance.
        /// </summary>
        void Close();

        /// <summary>
        /// Gets a value indicating whether this <see cref="IRTSPTransport"/> is connected.
        /// </summary>
        /// <value><c>true</c> if connected; otherwise, <c>false</c>.</value>
        bool Connected { get; }

        /// <summary>
        /// Reconnect this instance.
        /// <remarks>Must do nothing if already connected.</remarks>
        /// </summary>
        void ReConnect();
    }
}