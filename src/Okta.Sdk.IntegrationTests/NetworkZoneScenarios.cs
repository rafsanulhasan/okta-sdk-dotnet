﻿// <copyright file="NetworkZoneScenarios.cs" company="Okta, Inc">
// Copyright (c) 2020 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Okta.Sdk.IntegrationTests
{
    public class NetworkZoneScenarios
    {
        [Fact]
        public async Task CreateUpdateDeleteNetworkZone()
        {
            var oktaClient = TestClient.Create();
            var zonesClient = oktaClient.NetworkZones;
            NetworkZone newZone = BuildNetworkZoneObject();
            var createZoneResponse = await zonesClient.CreateNetworkZoneAsync(newZone);
            try
            {
                createZoneResponse.Id.Should().NotBeNullOrEmpty();
                createZoneResponse.Name.Should().Be(newZone.Name);
                createZoneResponse.Type.Should().Be(newZone.Type);
                createZoneResponse.Status.Should().Be(newZone.Status);
                createZoneResponse.Gateways.Should().HaveCount(2);
                createZoneResponse.Proxies.Should().HaveCount(2);

                createZoneResponse.Name = "Another Name";
                createZoneResponse.Gateways.Add(new NetworkZoneAddress
                {
                    Type = NetworkZoneAddressType.Cidr,
                    Value = "1.1.1.1/24",
                });

                var updateZoneResponse = await zonesClient.UpdateNetworkZoneAsync(createZoneResponse, createZoneResponse.Id);
                updateZoneResponse.Name.Should().Be(createZoneResponse.Name);
                updateZoneResponse.Gateways.Count.Should().Be(3);
            }
            finally
            {
                await zonesClient.DeleteNetworkZoneAsync(createZoneResponse.Id);
            }
        }

        [Fact]
        public async Task DeactivateAndActivateNetworkZone()
        {
            var oktaClient = TestClient.Create();
            var zonesClient = oktaClient.NetworkZones;
            NetworkZone newZone = BuildNetworkZoneObject();
            var createZoneResponse = await zonesClient.CreateNetworkZoneAsync(newZone);
            try
            {
                var deactivateZoneResponse = await zonesClient.DeactivateNetworkZoneAsync(createZoneResponse.Id);
                deactivateZoneResponse.Status.Should().Be(NetworkZoneStatus.Inactive);
                var activateZoneResponse = await zonesClient.ActivateNetworkZoneAsync(deactivateZoneResponse.Id);
                activateZoneResponse.Status.Should().Be(NetworkZoneStatus.Active);
            }
            finally
            {
                await zonesClient.DeleteNetworkZoneAsync(createZoneResponse.Id);
            }
        }

        [Fact]
        public async Task ListAndGetNetworkZones()
        {
            var oktaClient = TestClient.Create();
            var zonesClient = oktaClient.NetworkZones;
            NetworkZone newZone = BuildNetworkZoneObject();
            var createZoneResponse = await zonesClient.CreateNetworkZoneAsync(newZone);
            try
            {
                var allNetworkZones = zonesClient.ListNetworkZones();
                var createdZone = await allNetworkZones.FirstOrDefaultAsync(z => z.Id == createZoneResponse.Id);

                createdZone.Should().NotBeNull();

                var getResponse = await zonesClient.GetNetworkZoneAsync(createZoneResponse.Id);

                getResponse.Id.Should().NotBeNullOrEmpty();
                getResponse.Name.Should().Be(newZone.Name);
                getResponse.Type.Should().Be(newZone.Type);
                getResponse.Status.Should().Be(newZone.Status);
                getResponse.Gateways.Should().HaveCount(2);
                getResponse.Proxies.Should().HaveCount(2);
            }
            finally
            {
                await zonesClient.DeleteNetworkZoneAsync(createZoneResponse.Id);
            }
        }

        #region private functions
        private static NetworkZone BuildNetworkZoneObject()
        {
            return new NetworkZone
            {
                Type = NetworkZoneType.Ip,
                Name = "newNetworkZone",
                Status = NetworkZoneStatus.Active,
                Gateways = new List<INetworkZoneAddress> {
                    new NetworkZoneAddress
                    {
                        Type = NetworkZoneAddressType.Cidr,
                        Value = "1.2.3.4/24",
                    },
                    new NetworkZoneAddress
                    {
                        Type = NetworkZoneAddressType.Cidr,
                        Value = "2.3.4.5/24",
                    },
                },
                Proxies = new List<INetworkZoneAddress> {
                    new NetworkZoneAddress
                    {
                        Type = NetworkZoneAddressType.Cidr,
                        Value = "2.2.3.4/24",
                    },
                    new NetworkZoneAddress
                    {
                        Type = NetworkZoneAddressType.Cidr,
                        Value = "3.3.4.5/24",
                    },
                },
            };
        }
        #endregion private functions
    }
}
