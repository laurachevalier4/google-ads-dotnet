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
    public sealed class GeneratedCampaignAssetServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateCampaignAssetsRequestObject()
        {
            moq::Mock<CampaignAssetService.CampaignAssetServiceClient> mockGrpcClient = new moq::Mock<CampaignAssetService.CampaignAssetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignAssetsRequest request = new MutateCampaignAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignAssetsResponse expectedResponse = new MutateCampaignAssetsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateCampaignAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCampaignAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignAssetServiceClient client = new CampaignAssetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCampaignAssetsResponse response = client.MutateCampaignAssets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCampaignAssetsRequestObjectAsync()
        {
            moq::Mock<CampaignAssetService.CampaignAssetServiceClient> mockGrpcClient = new moq::Mock<CampaignAssetService.CampaignAssetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignAssetsRequest request = new MutateCampaignAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignAssetsResponse expectedResponse = new MutateCampaignAssetsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateCampaignAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCampaignAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignAssetServiceClient client = new CampaignAssetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCampaignAssetsResponse responseCallSettings = await client.MutateCampaignAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignAssetsResponse responseCancellationToken = await client.MutateCampaignAssetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateCampaignAssets()
        {
            moq::Mock<CampaignAssetService.CampaignAssetServiceClient> mockGrpcClient = new moq::Mock<CampaignAssetService.CampaignAssetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignAssetsRequest request = new MutateCampaignAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignAssetOperation(),
                },
            };
            MutateCampaignAssetsResponse expectedResponse = new MutateCampaignAssetsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateCampaignAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCampaignAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignAssetServiceClient client = new CampaignAssetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCampaignAssetsResponse response = client.MutateCampaignAssets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCampaignAssetsAsync()
        {
            moq::Mock<CampaignAssetService.CampaignAssetServiceClient> mockGrpcClient = new moq::Mock<CampaignAssetService.CampaignAssetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignAssetsRequest request = new MutateCampaignAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignAssetOperation(),
                },
            };
            MutateCampaignAssetsResponse expectedResponse = new MutateCampaignAssetsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateCampaignAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCampaignAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignAssetServiceClient client = new CampaignAssetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCampaignAssetsResponse responseCallSettings = await client.MutateCampaignAssetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignAssetsResponse responseCancellationToken = await client.MutateCampaignAssetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}