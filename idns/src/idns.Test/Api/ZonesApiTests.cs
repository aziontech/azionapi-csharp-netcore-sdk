/*
 * Intelligent DNS
 *
 * Azion Intelligent DNS API
 *
 * The version of the OpenAPI document: 3.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using idns.Client;
using idns.Api;
// uncomment below to import models
//using idns.Model;

namespace idns.Test.Api
{
    /// <summary>
    ///  Class for testing ZonesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ZonesApiTests : IDisposable
    {
        private ZonesApi instance;

        public ZonesApiTests()
        {
            instance = new ZonesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ZonesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ZonesApi
            //Assert.IsType<ZonesApi>(instance);
        }

        /// <summary>
        /// Test DeleteZone
        /// </summary>
        [Fact]
        public void DeleteZoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int zoneId = null;
            //var response = instance.DeleteZone(zoneId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetZone
        /// </summary>
        [Fact]
        public void GetZoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int zoneId = null;
            //var response = instance.GetZone(zoneId);
            //Assert.IsType<GetZoneResponse>(response);
        }

        /// <summary>
        /// Test GetZones
        /// </summary>
        [Fact]
        public void GetZonesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetZones();
            //Assert.IsType<GetZonesResponse>(response);
        }

        /// <summary>
        /// Test PostZone
        /// </summary>
        [Fact]
        public void PostZoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Zone zone = null;
            //var response = instance.PostZone(zone);
            //Assert.IsType<PostOrPutZoneResponse>(response);
        }

        /// <summary>
        /// Test PutZone
        /// </summary>
        [Fact]
        public void PutZoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int zoneId = null;
            //Zone zone = null;
            //var response = instance.PutZone(zoneId, zone);
            //Assert.IsType<PostOrPutZoneResponse>(response);
        }
    }
}
