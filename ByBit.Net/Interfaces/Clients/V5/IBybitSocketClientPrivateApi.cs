﻿using Bybit.Net.Enums;
using Bybit.Net.Objects.Models.V5;
using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Objects.Sockets;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Bybit.Net.Interfaces.Clients.V5
{
    /// <summary>
    /// Bybit user data streams
    /// </summary>
    public interface IBybitSocketClientPrivateApi : ISocketApiClient
    {
        /// <summary>
        /// Subscribe to Greek updates
        /// <para><a href="https://bybit-exchange.github.io/docs/v5/websocket/private/greek" /></para>
        /// </summary>
        /// <param name="handler">Data handler</param>
        /// <param name="ct">Cancellation token. Cancelling will cancel the subscription</param>
        /// <returns></returns>
        Task<CallResult<UpdateSubscription>> SubscribeToGreekUpdatesAsync(Action<DataEvent<IEnumerable<BybitGreeks>>> handler, CancellationToken ct = default);

        /// <summary>
        /// Subscribe to order updates
        /// <para><a href="https://bybit-exchange.github.io/docs/v5/websocket/private/order" /></para>
        /// </summary>
        /// <param name="handler">Data handler</param>
        /// <param name="ct">Cancellation token. Cancelling will cancel the subscription</param>
        /// <returns></returns>
        Task<CallResult<UpdateSubscription>> SubscribeToOrderUpdatesAsync(Action<DataEvent<IEnumerable<BybitOrderUpdate>>> handler, CancellationToken ct = default);

        /// <summary>
        /// Subscribe to position updates
        /// <para><a href="https://bybit-exchange.github.io/docs/v5/websocket/private/position" /></para>
        /// </summary>
        /// <param name="handler">Data handler</param>
        /// <param name="ct">Cancellation token. Cancelling will cancel the subscription</param>
        /// <returns></returns>
        Task<CallResult<UpdateSubscription>> SubscribeToPositionUpdatesAsync(Action<DataEvent<IEnumerable<BybitPositionUpdate>>> handler, CancellationToken ct = default);

        /// <summary>
        /// Subscribe to trade updates
        /// <para><a href="https://bybit-exchange.github.io/docs/v5/websocket/private/execution" /></para>
        /// </summary>
        /// <param name="handler">Data handler</param>
        /// <param name="ct">Cancellation token. Cancelling will cancel the subscription</param>
        /// <returns></returns>
        Task<CallResult<UpdateSubscription>> SubscribeToUserTradeUpdatesAsync(Action<DataEvent<IEnumerable<BybitUserTradeUpdate>>> handler, CancellationToken ct = default);

        /// <summary>
        /// Subscribe to minimal trade updates. There is less data available, but updates are pushed significantly faster
        /// <para><a href="https://bybit-exchange.github.io/docs/v5/websocket/private/fast-execution" /></para>
        /// </summary>
        /// <param name="handler">Data handler</param>
        /// <param name="ct">Cancellation token. Cancelling will cancel the subscription</param>
        /// <returns></returns>
        Task<CallResult<UpdateSubscription>> SubscribeToMinimalUserTradeUpdatesAsync(Action<DataEvent<IEnumerable<BybitMinimalUserTradeUpdate>>> handler, CancellationToken ct = default);

        /// <summary>
        /// Subscribe to wallet balance updates
        /// <para><a href="https://bybit-exchange.github.io/docs/v5/websocket/private/wallet" /></para>
        /// </summary>
        /// <param name="handler">Data handler</param>
        /// <param name="ct">Cancellation token. Cancelling will cancel the subscription</param>
        /// <returns></returns>
        Task<CallResult<UpdateSubscription>> SubscribeToWalletUpdatesAsync(Action<DataEvent<IEnumerable<BybitBalance>>> handler, CancellationToken ct = default);

        /// <summary>
        /// Subscribe to disconnect cancel all topics. It doesn't provide updates, but works with the <see href="https://bybit-exchange.github.io/docs/v5/order/dcp">DisconnectCancelAll</see> configuration
        /// <para><a href="https://bybit-exchange.github.io/docs/v5/websocket/private/dcp" /></para>
        /// </summary>
        /// <param name="productType">Product type</param>
        /// <param name="ct">Cancellation token. Cancelling will cancel the subscription</param>
        /// <returns></returns>
        Task<CallResult<UpdateSubscription>> SubscribeToDisconnectCancelAllTopicAsync(ProductType productType, CancellationToken ct = default);
    }
}