// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gagvr = Google.Ads.GoogleAds.V6.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V6.Services
{
    /// <summary>Settings for <see cref="ManagedPlacementViewServiceClient"/> instances.</summary>
    public sealed partial class ManagedPlacementViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ManagedPlacementViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ManagedPlacementViewServiceSettings"/>.</returns>
        public static ManagedPlacementViewServiceSettings GetDefault() => new ManagedPlacementViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ManagedPlacementViewServiceSettings"/> object with default settings.
        /// </summary>
        public ManagedPlacementViewServiceSettings()
        {
        }

        private ManagedPlacementViewServiceSettings(ManagedPlacementViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetManagedPlacementViewSettings = existing.GetManagedPlacementViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ManagedPlacementViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedPlacementViewServiceClient.GetManagedPlacementView</c> and
        /// <c>ManagedPlacementViewServiceClient.GetManagedPlacementViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetManagedPlacementViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ManagedPlacementViewServiceSettings"/> object.</returns>
        public ManagedPlacementViewServiceSettings Clone() => new ManagedPlacementViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ManagedPlacementViewServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class ManagedPlacementViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<ManagedPlacementViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ManagedPlacementViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ManagedPlacementViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ManagedPlacementViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ManagedPlacementViewServiceClient Build()
        {
            ManagedPlacementViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ManagedPlacementViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ManagedPlacementViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ManagedPlacementViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ManagedPlacementViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ManagedPlacementViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ManagedPlacementViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ManagedPlacementViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ManagedPlacementViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ManagedPlacementViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ManagedPlacementViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Managed Placement views.
    /// </remarks>
    public abstract partial class ManagedPlacementViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the ManagedPlacementViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ManagedPlacementViewService scopes.</summary>
        /// <remarks>
        /// The default ManagedPlacementViewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ManagedPlacementViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ManagedPlacementViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ManagedPlacementViewServiceClient"/>.</returns>
        public static stt::Task<ManagedPlacementViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ManagedPlacementViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ManagedPlacementViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ManagedPlacementViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ManagedPlacementViewServiceClient"/>.</returns>
        public static ManagedPlacementViewServiceClient Create() => new ManagedPlacementViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ManagedPlacementViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ManagedPlacementViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="ManagedPlacementViewServiceClient"/>.</returns>
        internal static ManagedPlacementViewServiceClient Create(grpccore::CallInvoker callInvoker, ManagedPlacementViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ManagedPlacementViewService.ManagedPlacementViewServiceClient grpcClient = new ManagedPlacementViewService.ManagedPlacementViewServiceClient(callInvoker);
            return new ManagedPlacementViewServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC ManagedPlacementViewService client</summary>
        public virtual ManagedPlacementViewService.ManagedPlacementViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Managed Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ManagedPlacementView GetManagedPlacementView(GetManagedPlacementViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Managed Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ManagedPlacementView> GetManagedPlacementViewAsync(GetManagedPlacementViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Managed Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ManagedPlacementView> GetManagedPlacementViewAsync(GetManagedPlacementViewRequest request, st::CancellationToken cancellationToken) =>
            GetManagedPlacementViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Managed Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Managed Placement View to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ManagedPlacementView GetManagedPlacementView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetManagedPlacementView(new GetManagedPlacementViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Managed Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Managed Placement View to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ManagedPlacementView> GetManagedPlacementViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetManagedPlacementViewAsync(new GetManagedPlacementViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Managed Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Managed Placement View to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ManagedPlacementView> GetManagedPlacementViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetManagedPlacementViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Managed Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Managed Placement View to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ManagedPlacementView GetManagedPlacementView(gagvr::ManagedPlacementViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetManagedPlacementView(new GetManagedPlacementViewRequest
            {
                ResourceNameAsManagedPlacementViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Managed Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Managed Placement View to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ManagedPlacementView> GetManagedPlacementViewAsync(gagvr::ManagedPlacementViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetManagedPlacementViewAsync(new GetManagedPlacementViewRequest
            {
                ResourceNameAsManagedPlacementViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Managed Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Managed Placement View to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ManagedPlacementView> GetManagedPlacementViewAsync(gagvr::ManagedPlacementViewName resourceName, st::CancellationToken cancellationToken) =>
            GetManagedPlacementViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ManagedPlacementViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Managed Placement views.
    /// </remarks>
    public sealed partial class ManagedPlacementViewServiceClientImpl : ManagedPlacementViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetManagedPlacementViewRequest, gagvr::ManagedPlacementView> _callGetManagedPlacementView;

        /// <summary>
        /// Constructs a client wrapper for the ManagedPlacementViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ManagedPlacementViewServiceSettings"/> used within this client.
        /// </param>
        public ManagedPlacementViewServiceClientImpl(ManagedPlacementViewService.ManagedPlacementViewServiceClient grpcClient, ManagedPlacementViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ManagedPlacementViewServiceSettings effectiveSettings = settings ?? ManagedPlacementViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetManagedPlacementView = clientHelper.BuildApiCall<GetManagedPlacementViewRequest, gagvr::ManagedPlacementView>(grpcClient.GetManagedPlacementViewAsync, grpcClient.GetManagedPlacementView, effectiveSettings.GetManagedPlacementViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetManagedPlacementView);
            Modify_GetManagedPlacementViewApiCall(ref _callGetManagedPlacementView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetManagedPlacementViewApiCall(ref gaxgrpc::ApiCall<GetManagedPlacementViewRequest, gagvr::ManagedPlacementView> call);

        partial void OnConstruction(ManagedPlacementViewService.ManagedPlacementViewServiceClient grpcClient, ManagedPlacementViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ManagedPlacementViewService client</summary>
        public override ManagedPlacementViewService.ManagedPlacementViewServiceClient GrpcClient { get; }

        partial void Modify_GetManagedPlacementViewRequest(ref GetManagedPlacementViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Managed Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::ManagedPlacementView GetManagedPlacementView(GetManagedPlacementViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetManagedPlacementViewRequest(ref request, ref callSettings);
            return _callGetManagedPlacementView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Managed Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::ManagedPlacementView> GetManagedPlacementViewAsync(GetManagedPlacementViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetManagedPlacementViewRequest(ref request, ref callSettings);
            return _callGetManagedPlacementView.Async(request, callSettings);
        }
    }
}
