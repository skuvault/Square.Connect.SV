/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Square.Connect.Client;
using Square.Connect.Api;
using Square.Connect.Model;

namespace Square.Connect.Test
{
    /// <summary>
    ///  Class for testing LocationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LocationsApiTests
    {
        private LocationsApi instance;
        private TestAccounts testAccounts;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocationsApi();
            testAccounts = new TestAccounts();
            var sandboxAccount = testAccounts["Sandbox"];
            Configuration.Default.AccessToken = sandboxAccount.AccessToken;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<LocationsApi>(instance, "instance is not type of LocationApi");
        }

        
        /// <summary>
        /// Test ListLocations
        /// </summary>
        [Test]
        public void ListLocationsTest()
        {
            var response = instance.ListLocations();
            var firstLocation = response.Locations.First();

            Assert.IsInstanceOf<ListLocationsResponse> (response, "response type is not ListLocationsResponse.");
            Assert.IsInstanceOf<Location> (firstLocation, "response element type is not Location.");
            Assert.AreEqual(testAccounts["Sandbox"].LocationId, firstLocation.Id, "first location id doesn't match.");
        }
        
    }

}
