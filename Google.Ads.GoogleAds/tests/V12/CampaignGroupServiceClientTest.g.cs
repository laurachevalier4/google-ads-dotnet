// Copyright 2022 Google LLC
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

#pragma warning disable CS8981
using gagve = Google.Ads.GoogleAds.V12.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V12.Services;

namespace Google.Ads.GoogleAds.Tests.V12.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignGroupServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateCampaignGroupsRequestObject()
        {
            moq::Mock<CampaignGroupService.CampaignGroupServiceClient> mockGrpcClient = new moq::Mock<CampaignGroupService.CampaignGroupServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignGroupsRequest request = new MutateCampaignGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignGroupOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignGroupsResponse expectedResponse = new MutateCampaignGroupsResponse
            {
                Results =
                {
                    new MutateCampaignGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignGroups(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignGroupServiceClient client = new CampaignGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCampaignGroupsResponse response = client.MutateCampaignGroups(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCampaignGroupsRequestObjectAsync()
        {
            moq::Mock<CampaignGroupService.CampaignGroupServiceClient> mockGrpcClient = new moq::Mock<CampaignGroupService.CampaignGroupServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignGroupsRequest request = new MutateCampaignGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignGroupOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignGroupsResponse expectedResponse = new MutateCampaignGroupsResponse
            {
                Results =
                {
                    new MutateCampaignGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignGroupsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignGroupsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignGroupServiceClient client = new CampaignGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCampaignGroupsResponse responseCallSettings = await client.MutateCampaignGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignGroupsResponse responseCancellationToken = await client.MutateCampaignGroupsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateCampaignGroups()
        {
            moq::Mock<CampaignGroupService.CampaignGroupServiceClient> mockGrpcClient = new moq::Mock<CampaignGroupService.CampaignGroupServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignGroupsRequest request = new MutateCampaignGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignGroupOperation(),
                },
            };
            MutateCampaignGroupsResponse expectedResponse = new MutateCampaignGroupsResponse
            {
                Results =
                {
                    new MutateCampaignGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignGroups(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignGroupServiceClient client = new CampaignGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCampaignGroupsResponse response = client.MutateCampaignGroups(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCampaignGroupsAsync()
        {
            moq::Mock<CampaignGroupService.CampaignGroupServiceClient> mockGrpcClient = new moq::Mock<CampaignGroupService.CampaignGroupServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignGroupsRequest request = new MutateCampaignGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignGroupOperation(),
                },
            };
            MutateCampaignGroupsResponse expectedResponse = new MutateCampaignGroupsResponse
            {
                Results =
                {
                    new MutateCampaignGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignGroupsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignGroupsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignGroupServiceClient client = new CampaignGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCampaignGroupsResponse responseCallSettings = await client.MutateCampaignGroupsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignGroupsResponse responseCancellationToken = await client.MutateCampaignGroupsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
