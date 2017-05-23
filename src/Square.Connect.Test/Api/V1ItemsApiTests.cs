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
    ///  Class for testing V1ItemsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class V1ItemsApiTests
    {
        private V1ItemsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new V1ItemsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of V1ItemsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' V1ItemsApi
            //Assert.IsInstanceOfType(typeof(V1ItemsApi), instance, "instance is a V1ItemsApi");
        }

        
        /// <summary>
        /// Test AdjustInventory
        /// </summary>
        [Test]
        public void AdjustInventoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string variationId = null;
            //V1AdjustInventoryRequest body = null;
            //var response = instance.AdjustInventory(locationId, variationId, body);
            //Assert.IsInstanceOf<V1InventoryEntry> (response, "response is V1InventoryEntry");
        }
        
        /// <summary>
        /// Test ApplyFee
        /// </summary>
        [Test]
        public void ApplyFeeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string itemId = null;
            //string feeId = null;
            //var response = instance.ApplyFee(locationId, itemId, feeId);
            //Assert.IsInstanceOf<V1Item> (response, "response is V1Item");
        }
        
        /// <summary>
        /// Test ApplyModifierList
        /// </summary>
        [Test]
        public void ApplyModifierListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string modifierListId = null;
            //string itemId = null;
            //var response = instance.ApplyModifierList(locationId, modifierListId, itemId);
            //Assert.IsInstanceOf<V1Item> (response, "response is V1Item");
        }
        
        /// <summary>
        /// Test CreateCategory
        /// </summary>
        [Test]
        public void CreateCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //V1Category body = null;
            //var response = instance.CreateCategory(locationId, body);
            //Assert.IsInstanceOf<V1Category> (response, "response is V1Category");
        }
        
        /// <summary>
        /// Test CreateDiscount
        /// </summary>
        [Test]
        public void CreateDiscountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //V1Discount body = null;
            //var response = instance.CreateDiscount(locationId, body);
            //Assert.IsInstanceOf<V1Discount> (response, "response is V1Discount");
        }
        
        /// <summary>
        /// Test CreateFee
        /// </summary>
        [Test]
        public void CreateFeeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //V1Fee body = null;
            //var response = instance.CreateFee(locationId, body);
            //Assert.IsInstanceOf<V1Fee> (response, "response is V1Fee");
        }
        
        /// <summary>
        /// Test CreateItem
        /// </summary>
        [Test]
        public void CreateItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //V1Item body = null;
            //var response = instance.CreateItem(locationId, body);
            //Assert.IsInstanceOf<V1Item> (response, "response is V1Item");
        }
        
        /// <summary>
        /// Test CreateModifierList
        /// </summary>
        [Test]
        public void CreateModifierListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //V1ModifierList body = null;
            //var response = instance.CreateModifierList(locationId, body);
            //Assert.IsInstanceOf<V1ModifierList> (response, "response is V1ModifierList");
        }
        
        /// <summary>
        /// Test CreateModifierOption
        /// </summary>
        [Test]
        public void CreateModifierOptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string modifierListId = null;
            //V1ModifierOption body = null;
            //var response = instance.CreateModifierOption(locationId, modifierListId, body);
            //Assert.IsInstanceOf<V1ModifierOption> (response, "response is V1ModifierOption");
        }
        
        /// <summary>
        /// Test CreatePage
        /// </summary>
        [Test]
        public void CreatePageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //V1Page body = null;
            //var response = instance.CreatePage(locationId, body);
            //Assert.IsInstanceOf<V1Page> (response, "response is V1Page");
        }
        
        /// <summary>
        /// Test CreateVariation
        /// </summary>
        [Test]
        public void CreateVariationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string itemId = null;
            //V1Variation body = null;
            //var response = instance.CreateVariation(locationId, itemId, body);
            //Assert.IsInstanceOf<V1Variation> (response, "response is V1Variation");
        }
        
        /// <summary>
        /// Test DeleteCategory
        /// </summary>
        [Test]
        public void DeleteCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string categoryId = null;
            //var response = instance.DeleteCategory(locationId, categoryId);
            //Assert.IsInstanceOf<V1Category> (response, "response is V1Category");
        }
        
        /// <summary>
        /// Test DeleteDiscount
        /// </summary>
        [Test]
        public void DeleteDiscountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string discountId = null;
            //var response = instance.DeleteDiscount(locationId, discountId);
            //Assert.IsInstanceOf<V1Discount> (response, "response is V1Discount");
        }
        
        /// <summary>
        /// Test DeleteFee
        /// </summary>
        [Test]
        public void DeleteFeeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string feeId = null;
            //var response = instance.DeleteFee(locationId, feeId);
            //Assert.IsInstanceOf<V1Fee> (response, "response is V1Fee");
        }
        
        /// <summary>
        /// Test DeleteItem
        /// </summary>
        [Test]
        public void DeleteItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string itemId = null;
            //var response = instance.DeleteItem(locationId, itemId);
            //Assert.IsInstanceOf<V1Item> (response, "response is V1Item");
        }
        
        /// <summary>
        /// Test DeleteModifierList
        /// </summary>
        [Test]
        public void DeleteModifierListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string modifierListId = null;
            //var response = instance.DeleteModifierList(locationId, modifierListId);
            //Assert.IsInstanceOf<V1ModifierList> (response, "response is V1ModifierList");
        }
        
        /// <summary>
        /// Test DeleteModifierOption
        /// </summary>
        [Test]
        public void DeleteModifierOptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string modifierListId = null;
            //string modifierOptionId = null;
            //var response = instance.DeleteModifierOption(locationId, modifierListId, modifierOptionId);
            //Assert.IsInstanceOf<V1ModifierOption> (response, "response is V1ModifierOption");
        }
        
        /// <summary>
        /// Test DeletePage
        /// </summary>
        [Test]
        public void DeletePageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string pageId = null;
            //var response = instance.DeletePage(locationId, pageId);
            //Assert.IsInstanceOf<V1Page> (response, "response is V1Page");
        }
        
        /// <summary>
        /// Test DeletePageCell
        /// </summary>
        [Test]
        public void DeletePageCellTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string pageId = null;
            //string row = null;
            //string column = null;
            //var response = instance.DeletePageCell(locationId, pageId, row, column);
            //Assert.IsInstanceOf<V1Page> (response, "response is V1Page");
        }
        
        /// <summary>
        /// Test DeleteVariation
        /// </summary>
        [Test]
        public void DeleteVariationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string itemId = null;
            //string variationId = null;
            //var response = instance.DeleteVariation(locationId, itemId, variationId);
            //Assert.IsInstanceOf<V1Variation> (response, "response is V1Variation");
        }
        
        /// <summary>
        /// Test ListCategories
        /// </summary>
        [Test]
        public void ListCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //var response = instance.ListCategories(locationId);
            //Assert.IsInstanceOf<List<V1Category>> (response, "response is List<V1Category>");
        }
        
        /// <summary>
        /// Test ListDiscounts
        /// </summary>
        [Test]
        public void ListDiscountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //var response = instance.ListDiscounts(locationId);
            //Assert.IsInstanceOf<List<V1Discount>> (response, "response is List<V1Discount>");
        }
        
        /// <summary>
        /// Test ListFees
        /// </summary>
        [Test]
        public void ListFeesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //var response = instance.ListFees(locationId);
            //Assert.IsInstanceOf<List<V1Fee>> (response, "response is List<V1Fee>");
        }
        
        /// <summary>
        /// Test ListInventory
        /// </summary>
        [Test]
        public void ListInventoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //int? limit = null;
            //var response = instance.ListInventory(locationId, limit);
            //Assert.IsInstanceOf<List<V1InventoryEntry>> (response, "response is List<V1InventoryEntry>");
        }
        
        /// <summary>
        /// Test ListItems
        /// </summary>
        [Test]
        public void ListItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //var response = instance.ListItems(locationId);
            //Assert.IsInstanceOf<List<V1Item>> (response, "response is List<V1Item>");
        }
        
        /// <summary>
        /// Test ListModifierLists
        /// </summary>
        [Test]
        public void ListModifierListsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //var response = instance.ListModifierLists(locationId);
            //Assert.IsInstanceOf<List<V1ModifierList>> (response, "response is List<V1ModifierList>");
        }
        
        /// <summary>
        /// Test ListPages
        /// </summary>
        [Test]
        public void ListPagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //var response = instance.ListPages(locationId);
            //Assert.IsInstanceOf<List<V1Page>> (response, "response is List<V1Page>");
        }
        
        /// <summary>
        /// Test RemoveFee
        /// </summary>
        [Test]
        public void RemoveFeeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string itemId = null;
            //string feeId = null;
            //var response = instance.RemoveFee(locationId, itemId, feeId);
            //Assert.IsInstanceOf<V1Item> (response, "response is V1Item");
        }
        
        /// <summary>
        /// Test RemoveModifierList
        /// </summary>
        [Test]
        public void RemoveModifierListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string modifierListId = null;
            //string itemId = null;
            //var response = instance.RemoveModifierList(locationId, modifierListId, itemId);
            //Assert.IsInstanceOf<V1Item> (response, "response is V1Item");
        }
        
        /// <summary>
        /// Test RetrieveItem
        /// </summary>
        [Test]
        public void RetrieveItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string itemId = null;
            //var response = instance.RetrieveItem(locationId, itemId);
            //Assert.IsInstanceOf<V1Item> (response, "response is V1Item");
        }
        
        /// <summary>
        /// Test RetrieveModifierList
        /// </summary>
        [Test]
        public void RetrieveModifierListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string modifierListId = null;
            //var response = instance.RetrieveModifierList(locationId, modifierListId);
            //Assert.IsInstanceOf<V1ModifierList> (response, "response is V1ModifierList");
        }
        
        /// <summary>
        /// Test UpdateCategory
        /// </summary>
        [Test]
        public void UpdateCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string categoryId = null;
            //V1Category body = null;
            //var response = instance.UpdateCategory(locationId, categoryId, body);
            //Assert.IsInstanceOf<V1Category> (response, "response is V1Category");
        }
        
        /// <summary>
        /// Test UpdateDiscount
        /// </summary>
        [Test]
        public void UpdateDiscountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string discountId = null;
            //V1Discount body = null;
            //var response = instance.UpdateDiscount(locationId, discountId, body);
            //Assert.IsInstanceOf<V1Discount> (response, "response is V1Discount");
        }
        
        /// <summary>
        /// Test UpdateFee
        /// </summary>
        [Test]
        public void UpdateFeeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string feeId = null;
            //V1Fee body = null;
            //var response = instance.UpdateFee(locationId, feeId, body);
            //Assert.IsInstanceOf<V1Fee> (response, "response is V1Fee");
        }
        
        /// <summary>
        /// Test UpdateItem
        /// </summary>
        [Test]
        public void UpdateItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string itemId = null;
            //V1Item body = null;
            //var response = instance.UpdateItem(locationId, itemId, body);
            //Assert.IsInstanceOf<V1Item> (response, "response is V1Item");
        }
        
        /// <summary>
        /// Test UpdateModifierList
        /// </summary>
        [Test]
        public void UpdateModifierListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string modifierListId = null;
            //V1UpdateModifierListRequest body = null;
            //var response = instance.UpdateModifierList(locationId, modifierListId, body);
            //Assert.IsInstanceOf<V1ModifierList> (response, "response is V1ModifierList");
        }
        
        /// <summary>
        /// Test UpdateModifierOption
        /// </summary>
        [Test]
        public void UpdateModifierOptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string modifierListId = null;
            //string modifierOptionId = null;
            //V1ModifierOption body = null;
            //var response = instance.UpdateModifierOption(locationId, modifierListId, modifierOptionId, body);
            //Assert.IsInstanceOf<V1ModifierOption> (response, "response is V1ModifierOption");
        }
        
        /// <summary>
        /// Test UpdatePage
        /// </summary>
        [Test]
        public void UpdatePageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string pageId = null;
            //V1Page body = null;
            //var response = instance.UpdatePage(locationId, pageId, body);
            //Assert.IsInstanceOf<V1Page> (response, "response is V1Page");
        }
        
        /// <summary>
        /// Test UpdatePageCell
        /// </summary>
        [Test]
        public void UpdatePageCellTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string pageId = null;
            //V1PageCell body = null;
            //var response = instance.UpdatePageCell(locationId, pageId, body);
            //Assert.IsInstanceOf<V1Page> (response, "response is V1Page");
        }
        
        /// <summary>
        /// Test UpdateVariation
        /// </summary>
        [Test]
        public void UpdateVariationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //string itemId = null;
            //string variationId = null;
            //V1Variation body = null;
            //var response = instance.UpdateVariation(locationId, itemId, variationId, body);
            //Assert.IsInstanceOf<V1Variation> (response, "response is V1Variation");
        }
        
    }

}
