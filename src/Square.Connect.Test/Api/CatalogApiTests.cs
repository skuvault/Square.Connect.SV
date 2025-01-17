﻿using NUnit.Framework;
using System;

using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;
using System.Collections.Generic;
using System.Linq;

using static Square.Connect.Model.CatalogObject;

namespace Square.Connect.Test
{
    /// <summary>
    ///  Class for testing CatalogApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CatalogApiTests
    {
        private CatalogApi instance;
        private TestAccounts testAccounts;

        private const string BEVERAGES_ID = "#Beverages";
        private const string MILKS_ID = "#Milks";
        private const string SYRUPS_ID = "#Syrups";
        private const string COFFEE_ID = "#Coffee";
        private const string SMALL_COFFEE_ID = "#SmallCoffee";
        private const string LARGE_COFFEE_ID = "#LargeCoffee";
        private const string TEA_ID = "#Tea";
        private const string SMALL_TEA_ID = "#SmallTea";
        private const string LARGE_TEA_ID = "#LargeTea";
        private const string SALES_TAX_ID = "#SalesTax";
        private const string ANOTHER_SALES_TAX_ID = "#AnotherSalesTax";
        private const int BATCH_NUMBER = 3;
        private const int CATALOG_PER_BATCH_NUMBER = 5;

        private static readonly CatalogObject beverages = new CatalogObject(
            Type: "CATEGORY",
            Id: BEVERAGES_ID,
            CategoryData: new CatalogCategory(Name: "Beverages")
        );

        private static readonly CatalogObject milks = new CatalogObject(
            Type: "MODIFIER_LIST",
            Id: MILKS_ID,
            ModifierListData: new CatalogModifierList(
                Name: "Milks",
                Modifiers: new List<CatalogObject>()
                {
                    new CatalogObject(
                        Type: "MODIFIER",
                        Id: "#WholeMilk",
                        ModifierData: new CatalogModifier(Name: "Whole Milk")
                    ),
                    new CatalogObject(
                        Type: "MODIFIER",
                        Id: "#SkimMilk",
                        ModifierData: new CatalogModifier(Name: "Skim Milk")
                    ),
                    new CatalogObject(
                        Type: "MODIFIER",
                        Id: "#SoyMilk",
                        ModifierData: new CatalogModifier(
                            Name: "Soy Milk",
                            PriceMoney: new Money(Amount: 50L, Currency: "USD")
                        )
                    )
                }
            )
        );

        private static readonly CatalogObject syrups = new CatalogObject(
            Type: "MODIFIER_LIST",
            Id: SYRUPS_ID,
            ModifierListData: new CatalogModifierList(
                Name: "Syrups",
                Modifiers: new List<CatalogObject>()
                {
                    new CatalogObject(
                        Type: "MODIFIER",
                        Id: "#Hazelnut",
                        ModifierData: new CatalogModifier(Name: "Hazelnut")
                    ),
                    new CatalogObject(
                        Type: "MODIFIER",
                        Id: "#Vanilla",
                        ModifierData: new CatalogModifier(Name: "Vanilla")
                    ),
                    new CatalogObject(
                        Type: "MODIFIER",
                        Id: "#Chocolate",
                        ModifierData: new CatalogModifier(Name: "Chocolate")
                    )
                }
            )
        );

        private static readonly CatalogObject coffee = new CatalogObject(
            Type: "ITEM",
            Id: COFFEE_ID,
            ItemData: new CatalogItem(
                Name: "Coffee",
                Description: "Hot bean juice",
                Abbreviation: "Co",
                CategoryId: BEVERAGES_ID,
                ModifierListInfo: new List<CatalogItemModifierListInfo>()
                {
                    new CatalogItemModifierListInfo(ModifierListId: "#Milks")
                },
                TaxIds: new List<string> { "#SalesTax" },
                Variations: new List<CatalogObject>()
                {
                    new CatalogObject(
                        Type: "ITEM_VARIATION",
                        Id: SMALL_COFFEE_ID,
                        ItemVariationData: new CatalogItemVariation(
							Name: "Small",
							ItemId: COFFEE_ID,
                            PricingType: "FIXED_PRICING",
                            PriceMoney: new Money(Amount: 195L, Currency: "USD")
                        )
                    ),
                    new CatalogObject(
                        Type: "ITEM_VARIATION",
                        Id: LARGE_COFFEE_ID,
                        ItemVariationData: new CatalogItemVariation(
                            Name: "Large",
                            ItemId: COFFEE_ID,
                            PricingType: "FIXED_PRICING",
                            PriceMoney: new Money(Amount: 250L, Currency: "USD")
                        )
                    )
                }
            )
        );

        private static readonly CatalogObject tea = new CatalogObject(
            Type: "ITEM",
            Id: TEA_ID,
            ItemData: new CatalogItem(
                Name: "Tea",
                Description: "Hot leaf juice",
                Abbreviation: "Te",
                CategoryId: BEVERAGES_ID,
                ModifierListInfo: new List<CatalogItemModifierListInfo>()
                {
                    new CatalogItemModifierListInfo(ModifierListId: "#Milks")
                },
                TaxIds: new List<string> { "#SalesTax" },
                Variations: new List<CatalogObject>()
                {
                    new CatalogObject(
                        Type: "ITEM_VARIATION",
                        Id: SMALL_TEA_ID,
                        ItemVariationData: new CatalogItemVariation(
                            Name: "Small",
                            ItemId: TEA_ID,
                            PricingType: "FIXED_PRICING",
                            PriceMoney: new Money(Amount: 150L, Currency: "USD")
                        )
                    ),
                    new CatalogObject(
                        Type: "ITEM_VARIATION",
                        Id: LARGE_TEA_ID,
                        ItemVariationData: new CatalogItemVariation(
                            Name: "Large",
                            ItemId: TEA_ID,
                            PricingType: "FIXED_PRICING",
                            PriceMoney: new Money(Amount: 150L, Currency: "USD")
                        )
                    )
                }
            )
        );

        private static readonly CatalogObject salesTax = new CatalogObject(
            Type: "TAX",
            Id: SALES_TAX_ID,
            TaxData: new CatalogTax(Name: "Sales Tax")
        );

        private static readonly CatalogObject anotherSalesTax = new CatalogObject(
            Type: "TAX",
            Id: ANOTHER_SALES_TAX_ID,
            TaxData: new CatalogTax(Name: "Another Sales Tax")
        );

        private static readonly List<CatalogObject> OBJECTS = new List<CatalogObject>()
        {
            beverages,
            milks,
            syrups,
            coffee,
            tea,
            salesTax,
            anotherSalesTax
        };

        // Mapping from client to server id, refreshed before each test.
        public Dictionary<String, String> idMap = new Dictionary<string, string>();

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CatalogApi();
            testAccounts = new TestAccounts();
            var testAccount = testAccounts["Sandbox"];
            Configuration.Default.AccessToken = testAccount.AccessToken;

            try
            {
                var request =
                    new BatchUpsertCatalogObjectsRequest(
                        IdempotencyKey: Guid.NewGuid().ToString(),
                        Batches: new List<CatalogObjectBatch>()
                    );
                request.Batches.Add(new CatalogObjectBatch(Objects: OBJECTS));
                var response = instance.BatchUpsertCatalogObjects(request);
                idMap = response.IdMappings.ToDictionary(
                    keySelector: m => m.ClientObjectId,
                    elementSelector: m => m.ObjectId
                );
            }
            catch (Exception ex)
            {
                Assert.Fail("Failed to build catalog objects. {0}", ex.ToString());
            }
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            var cursor = string.Empty;
            var objectsToDelete = new HashSet<String>();
            do
            {
                var response = instance.ListCatalog(cursor, null);
                objectsToDelete.UnionWith(response.Objects.Select(o => o.Id).ToList());
                cursor = response.Cursor;
            } while (!string.IsNullOrEmpty(cursor));

            objectsToDelete
                .Select((o, i) => new { Index = i, Value = o })
                .GroupBy(x => x.Index / 200)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList()
                .ForEach(ids =>
                {
                    var request = new BatchDeleteCatalogObjectsRequest(ObjectIds: ids);
                    instance.BatchDeleteCatalogObjects(request);
                });
        }

        /// <summary>
        /// Tests the batch delete catalog objects.
        /// </summary>
        [Test]
        public void TestBatchDeleteCatalogObjects()
        {
            var reqeust = new BatchDeleteCatalogObjectsRequest();
            reqeust.ObjectIds = new List<string>() { idMap[COFFEE_ID], idMap[SMALL_TEA_ID] };
            var response = instance.BatchDeleteCatalogObjects(reqeust);

            Assert.AreEqual(4, response.DeletedObjectIds.Count);
            Assert.Contains(idMap[COFFEE_ID], response.DeletedObjectIds);
            Assert.Contains(idMap[SMALL_COFFEE_ID], response.DeletedObjectIds);
            Assert.Contains(idMap[LARGE_COFFEE_ID], response.DeletedObjectIds);
            Assert.Contains(idMap[SMALL_TEA_ID], response.DeletedObjectIds);
        }

        /// <summary>
        /// Tests the batch retrieve catalog objects.
        /// </summary>
        [Test]
        public void TestBatchRetrieveCatalogObjects()
        {
            var request = new BatchRetrieveCatalogObjectsRequest(ObjectIds: new List<string>()
            {
                idMap[COFFEE_ID],
                idMap[SALES_TAX_ID]
            });
            var response = instance.BatchRetrieveCatalogObjects(request);

            Assert.AreEqual(2, response.Objects.Count);

            CatalogObject actualCoffee = response.Objects[0];
            Assert.AreEqual("ITEM", actualCoffee.Type);
            Assert.AreEqual(idMap[COFFEE_ID], actualCoffee.Id);

            CatalogObject actualTax = response.Objects[1];
            Assert.AreEqual("TAX", actualTax.Type);
            Assert.AreEqual(idMap[SALES_TAX_ID], actualTax.Id);
        }

        /// <summary>
        /// Tests the batch upsert catalog objects.
        /// </summary>
        [Test]
        public void TestBatchUpsertCatalogObjects()
        {
            var batches = new List<CatalogObjectBatch>();
            int numObjects = 0;

            for (int batchNum = 0; batchNum < BATCH_NUMBER; batchNum++)
            {
                var objects = new List<CatalogObject>();

                for (int i = 0; i < CATALOG_PER_BATCH_NUMBER; i++)
                {
                    var itemId = string.Format("#Item-{0}-{1}", batchNum, i);
                    var itemName = string.Format("Item Name {0}-{1}", batchNum, i);
                    var variationId = string.Format("#ItemVariation-{0}-{1}", batchNum, i);
                    objects.Add(new CatalogObject(
                        Type: "ITEM",
                        Id: itemId,
                        ItemData: new CatalogItem(
                            Name: itemName,
                            Variations: new List<CatalogObject>()
                            {
                                new CatalogObject(
                                    Type: "ITEM_VARIATION",
                                    Id: variationId,
                                    ItemVariationData: new CatalogItemVariation(
                                        ItemId: itemId,
                                        Name: "Regular",
                                        PricingType: "FIXED_PRICING",
                                        PriceMoney: new Money(Amount: 100L, Currency: "USD")
                                    )
                                )
                            }
                        )
                    ));
                    numObjects++;
                }

                var batch = new CatalogObjectBatch(objects);
                batches.Add(batch);
            }

            var request = new BatchUpsertCatalogObjectsRequest(
                IdempotencyKey: Guid.NewGuid().ToString(),
                Batches: batches
            );
            var response = instance.BatchUpsertCatalogObjects(request);

            Assert.AreEqual(numObjects, response.Objects.Count);

            response.IdMappings.ForEach(m => idMap.Add(m.ClientObjectId, m.ObjectId));
        }

        /// <summary>
        /// Tests the catalog info.
        /// </summary>
        [Test]
        public void TestCatalogInfo()
        {
            var response = instance.CatalogInfo();

            Assert.Greater(response.Limits.BatchRetrieveMaxObjectIds, 100);
            Assert.Greater(response.Limits.BatchUpsertMaxTotalObjects, 100);
            Assert.Greater(response.Limits.BatchDeleteMaxObjectIds, 100);
            Assert.Greater(response.Limits.BatchUpsertMaxObjectsPerBatch, 100);
            Assert.Greater(response.Limits.SearchMaxPageLimit, 100);
            Assert.Greater(response.Limits.BatchDeleteMaxObjectIds, 100);
            Assert.Greater(response.Limits.UpdateItemTaxesMaxItemIds, 100);
            Assert.Greater(response.Limits.UpdateItemTaxesMaxTaxesToEnable, 100);
            Assert.Greater(response.Limits.UpdateItemTaxesMaxTaxesToDisable, 100);
            Assert.Greater(response.Limits.UpdateItemModifierListsMaxItemIds, 100);
            Assert.Greater(response.Limits.UpdateItemModifierListsMaxModifierListsToEnable, 100);
            Assert.Greater(response.Limits.UpdateItemModifierListsMaxModifierListsToDisable, 100);
        }

        /// <summary>
        /// Tests the delete catalog object.
        /// </summary>
        [Test]
        public void TestDeleteCatalogObject()
        {
            var response = instance.DeleteCatalogObject(idMap[COFFEE_ID]);

            Assert.AreEqual(3, response.DeletedObjectIds.Count);
            Assert.Contains(idMap[COFFEE_ID], response.DeletedObjectIds);
            Assert.Contains(idMap[SMALL_COFFEE_ID], response.DeletedObjectIds);
            Assert.Contains(idMap[LARGE_COFFEE_ID], response.DeletedObjectIds);
        }

        /// <summary>
        /// Tests the retrieve item catalog object.
        /// </summary>
        [Test]
        public void TestRetrieveItemCatalogObject()
        {
            var resp = instance.RetrieveCatalogObject(idMap[COFFEE_ID], true);

            Assert.IsNotNull(resp);
            Assert.AreEqual(coffee.Type, resp._Object.Type);
            Assert.AreEqual(idMap[COFFEE_ID], resp._Object.Id);
            Assert.IsNotNull(resp._Object.UpdatedAt);
            Assert.IsNotEmpty(resp._Object.UpdatedAt);
            Assert.AreNotEqual(0, resp._Object.Version);
            Assert.IsFalse(resp._Object.IsDeleted.Value);
            Assert.AreEqual(coffee.ItemData.Name, resp._Object.ItemData.Name);
            Assert.AreEqual(coffee.ItemData.Variations.Count, resp._Object.ItemData.Variations.Count);
            Assert.IsNull(resp._Object.TaxData);
            Assert.IsNull(resp._Object.CategoryData);
            Assert.IsNull(resp._Object.DiscountData);
        }

        /// <summary>
        /// Tests the retrieve tax catalog object.
        /// </summary>
		[Test]
        public void TestRetrieveTaxCatalogObject()
        {
            var resp = instance.RetrieveCatalogObject(idMap[SALES_TAX_ID], true);

            Assert.IsNotNull(resp);
            Assert.AreEqual(salesTax.Type, resp._Object.Type);
            Assert.AreEqual(idMap[SALES_TAX_ID], resp._Object.Id);
            Assert.IsNotNull(resp._Object.UpdatedAt);
            Assert.IsNotEmpty(resp._Object.UpdatedAt);
            Assert.AreNotEqual(0, resp._Object.Version);
            Assert.IsFalse(resp._Object.IsDeleted.Value);
            Assert.AreEqual(salesTax.TaxData.Name, resp._Object.TaxData.Name);
            Assert.IsNull(resp._Object.ItemData);
            Assert.IsNull(resp._Object.CategoryData);
            Assert.IsNull(resp._Object.DiscountData);
        }

        /// <summary>
        /// Tests the search catalog objects.
        /// </summary>
        [Test]
        public void TestSearchCatalogObjects()
        {
            var request = new SearchCatalogObjectsRequest();
            request.Query = new CatalogQuery(
                PrefixQuery: new CatalogQueryPrefix(AttributeName: "name", AttributePrefix: "Sm")
            );
            request.IncludeDeletedObjects = false;
            request.IncludeRelatedObjects = true;
            var response = instance.SearchCatalogObjects(request);

            Assert.AreEqual(2, response.Objects.Count);
            var obj1 = response.Objects[0];
            Assert.AreEqual("ITEM_VARIATION", obj1.Type);
            Assert.AreEqual("Small", obj1.ItemVariationData.Name);
            Assert.IsFalse(obj1.IsDeleted.Value);
            var obj2 = response.Objects[1];
            Assert.AreEqual("ITEM_VARIATION", obj2.Type);
            Assert.AreEqual("Small", obj2.ItemVariationData.Name);
            Assert.IsFalse(obj2.IsDeleted.Value);

            Assert.Less(0, response.RelatedObjects.Count);
        }

        /// <summary>
        /// Tests the update item modifier lists.
        /// </summary>
        [Test]
        public void TestUpdateItemModifierLists()
        {
            var request = new UpdateItemModifierListsRequest(
                ItemIds: new List<string>() { idMap[COFFEE_ID] },
                ModifierListsToEnable: new List<string>() { idMap[SYRUPS_ID] },
                ModifierListsToDisable: new List<string>() { idMap[MILKS_ID] }
            );
            instance.UpdateItemModifierLists(request);

            var retrieveResp = instance.RetrieveCatalogObject(idMap[COFFEE_ID], false);

            var afterModifierList = retrieveResp._Object.ItemData.ModifierListInfo;
            Assert.AreEqual(1, afterModifierList.Count);
            Assert.AreEqual(idMap[SYRUPS_ID], afterModifierList[0].ModifierListId);
        }

        [Test]
        public void TestUpdateItemTax()
        {
            var request = new UpdateItemTaxesRequest(
                ItemIds: new List<string>() { idMap[COFFEE_ID] },
                TaxesToEnable: new List<string>() { idMap[ANOTHER_SALES_TAX_ID] },
                TaxesToDisable: new List<string>() { idMap[SALES_TAX_ID] }
            );
            instance.UpdateItemTaxes(request);

            var retrieveResp = instance.RetrieveCatalogObject(idMap[COFFEE_ID], false);
            var afterTaxList = retrieveResp._Object.ItemData.TaxIds;
            Assert.AreEqual(1, afterTaxList.Count);
            Assert.AreEqual(idMap[ANOTHER_SALES_TAX_ID], afterTaxList[0]);
        }
    }
}
