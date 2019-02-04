// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/bidding_strategy_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2018 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V0.Services {
  /// <summary>
  /// Service to manage bidding strategies.
  /// </summary>
  public static partial class BiddingStrategyService
  {
    static readonly string __ServiceName = "google.ads.googleads.v0.services.BiddingStrategyService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.GetBiddingStrategyRequest> __Marshaller_google_ads_googleads_v0_services_GetBiddingStrategyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.GetBiddingStrategyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Resources.BiddingStrategy> __Marshaller_google_ads_googleads_v0_resources_BiddingStrategy = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Resources.BiddingStrategy.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesRequest> __Marshaller_google_ads_googleads_v0_services_MutateBiddingStrategiesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesResponse> __Marshaller_google_ads_googleads_v0_services_MutateBiddingStrategiesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetBiddingStrategyRequest, global::Google.Ads.GoogleAds.V0.Resources.BiddingStrategy> __Method_GetBiddingStrategy = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetBiddingStrategyRequest, global::Google.Ads.GoogleAds.V0.Resources.BiddingStrategy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBiddingStrategy",
        __Marshaller_google_ads_googleads_v0_services_GetBiddingStrategyRequest,
        __Marshaller_google_ads_googleads_v0_resources_BiddingStrategy);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesRequest, global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesResponse> __Method_MutateBiddingStrategies = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesRequest, global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateBiddingStrategies",
        __Marshaller_google_ads_googleads_v0_services_MutateBiddingStrategiesRequest,
        __Marshaller_google_ads_googleads_v0_services_MutateBiddingStrategiesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V0.Services.BiddingStrategyServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BiddingStrategyService</summary>
    public abstract partial class BiddingStrategyServiceBase
    {
      /// <summary>
      /// Returns the requested bidding strategy in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Resources.BiddingStrategy> GetBiddingStrategy(global::Google.Ads.GoogleAds.V0.Services.GetBiddingStrategyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes bidding strategies. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesResponse> MutateBiddingStrategies(global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for BiddingStrategyService</summary>
    public partial class BiddingStrategyServiceClient : grpc::ClientBase<BiddingStrategyServiceClient>
    {
      /// <summary>Creates a new client for BiddingStrategyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BiddingStrategyServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BiddingStrategyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BiddingStrategyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BiddingStrategyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BiddingStrategyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested bidding strategy in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.BiddingStrategy GetBiddingStrategy(global::Google.Ads.GoogleAds.V0.Services.GetBiddingStrategyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBiddingStrategy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested bidding strategy in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.BiddingStrategy GetBiddingStrategy(global::Google.Ads.GoogleAds.V0.Services.GetBiddingStrategyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBiddingStrategy, null, options, request);
      }
      /// <summary>
      /// Returns the requested bidding strategy in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.BiddingStrategy> GetBiddingStrategyAsync(global::Google.Ads.GoogleAds.V0.Services.GetBiddingStrategyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBiddingStrategyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested bidding strategy in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.BiddingStrategy> GetBiddingStrategyAsync(global::Google.Ads.GoogleAds.V0.Services.GetBiddingStrategyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBiddingStrategy, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes bidding strategies. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesResponse MutateBiddingStrategies(global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateBiddingStrategies(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes bidding strategies. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesResponse MutateBiddingStrategies(global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateBiddingStrategies, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes bidding strategies. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateBiddingStrategiesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes bidding strategies. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(global::Google.Ads.GoogleAds.V0.Services.MutateBiddingStrategiesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateBiddingStrategies, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BiddingStrategyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BiddingStrategyServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BiddingStrategyServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetBiddingStrategy, serviceImpl.GetBiddingStrategy)
          .AddMethod(__Method_MutateBiddingStrategies, serviceImpl.MutateBiddingStrategies).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BiddingStrategyServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetBiddingStrategy, serviceImpl.GetBiddingStrategy);
      serviceBinder.AddMethod(__Method_MutateBiddingStrategies, serviceImpl.MutateBiddingStrategies);
    }

  }
}
#endregion
