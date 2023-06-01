/*
 * Storage API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
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

using storageapi.Client;
using storageapi.Api;

namespace storageapi.Test.Api
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DefaultApiTests : IDisposable
    {
        private DefaultApi instance;

        public DefaultApiTests()
        {
            instance = new DefaultApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DefaultApi
            //Assert.IsType<DefaultApi>(instance);
        }

        /// <summary>
        /// Test DeleteVersion
        /// </summary>
        [Fact]
        public void DeleteVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string versionId = null;
            //instance.DeleteVersion(versionId);
        }

        /// <summary>
        /// Test StorageVersionIdPost
        /// </summary>
        [Fact]
        public void StorageVersionIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAzionStaticPath = null;
            //string versionId = null;
            //System.IO.Stream body = null;
            //var response = instance.StorageVersionIdPost(xAzionStaticPath, versionId, body);
            //Assert.IsType<Object>(response);
        }
    }
}
