﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using CroussoutDBPlus;
//
//    var empty = Empty.FromJson(jsonString);

// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using CroussoutDBPlus;
//
//    var crossoutDb = CrossoutDb.FromJson(jsonString);

namespace CroussoutDBPlus
{


    public partial class CrossoutDb
    {
        [JsonProperty("recipe")]
        public Recipe Recipe { get; set; }
    }

    public partial class Recipe
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("uniqueId")]
        public long UniqueId { get; set; }

        [JsonProperty("rootNumber")]
        public long RootNumber { get; set; }

        [JsonProperty("factionNumber")]
        public long FactionNumber { get; set; }

        [JsonProperty("depth")]
        public long Depth { get; set; }

        [JsonProperty("maxDepth")]
        public long MaxDepth { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("sumBuy")]
        public long SumBuy { get; set; }

        [JsonProperty("sumSell")]
        public long SumSell { get; set; }

        [JsonProperty("sumBuyFormat")]
        public string SumBuyFormat { get; set; }

        [JsonProperty("sumSellFormat")]
        public string SumSellFormat { get; set; }

        [JsonProperty("buyPriceTimesNumber")]
        public long BuyPriceTimesNumber { get; set; }

        [JsonProperty("sellPriceTimesNumber")]
        public long SellPriceTimesNumber { get; set; }

        [JsonProperty("formatBuyPriceTimesNumber")]
        public string FormatBuyPriceTimesNumber { get; set; }

        [JsonProperty("formatSellPriceTimesNumber")]
        public string FormatSellPriceTimesNumber { get; set; }

        [JsonProperty("isSumRow")]
        public bool IsSumRow { get; set; }

        [JsonProperty("parentId")]
        public long ParentId { get; set; }

        [JsonProperty("parentUniqueId")]
        public long ParentUniqueId { get; set; }

        [JsonProperty("parentRecipe")]
        public long ParentRecipe { get; set; }

        [JsonProperty("superParentRecipe")]
        public long SuperParentRecipe { get; set; }

        [JsonProperty("ingredientSum")]
        public Recipe IngredientSum { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("ingredients")]
        public List<Recipe> Ingredients { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("localizedName")]
        public string LocalizedName { get; set; }

        [JsonProperty("availableName")]
        public string AvailableName { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("sellOffers")]
        public long SellOffers { get; set; }

        [JsonProperty("sellPrice")]
        public long SellPrice { get; set; }

        [JsonProperty("buyOrders")]
        public long BuyOrders { get; set; }

        [JsonProperty("buyPrice")]
        public long BuyPrice { get; set; }

        [JsonProperty("meta")]
        public long Meta { get; set; }

        [JsonProperty("removed")]
        public long Removed { get; set; }

        [JsonProperty("craftable")]
        public long Craftable { get; set; }

        [JsonProperty("popularity")]
        public long Popularity { get; set; }

        [JsonProperty("workbenchRarity")]
        public long WorkbenchRarity { get; set; }

        [JsonProperty("craftingSellSum")]
        public long CraftingSellSum { get; set; }

        [JsonProperty("craftingBuySum")]
        public long CraftingBuySum { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("demandSupplyRatio")]
        public double DemandSupplyRatio { get; set; }

        [JsonProperty("margin")]
        public double Margin { get; set; }

        [JsonProperty("roi")]
        public double Roi { get; set; }

        [JsonProperty("craftingMargin")]
        public double CraftingMargin { get; set; }

        [JsonProperty("formatDemandSupplyRatio")]
        public string FormatDemandSupplyRatio { get; set; }

        [JsonProperty("formatMargin")]
        public string FormatMargin { get; set; }

        [JsonProperty("formatRoi")]
        public string FormatRoi { get; set; }

        [JsonProperty("formatCraftingMargin")]
        public string FormatCraftingMargin { get; set; }

        [JsonProperty("craftVsBuy")]
        public string CraftVsBuy { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("lastUpdateTime")]
        public DateTimeOffset LastUpdateTime { get; set; }

        [JsonProperty("rarityId")]
        public long RarityId { get; set; }

        [JsonProperty("rarityName")]
        public string RarityName { get; set; }

        [JsonProperty("categoryId")]
        public long CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("typeId")]
        public long TypeId { get; set; }

        [JsonProperty("recipeId")]
        public long RecipeId { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("factionNumber")]
        public long FactionNumber { get; set; }

        [JsonProperty("faction")]
        public string Faction { get; set; }

        [JsonProperty("formatBuyPrice")]
        public string FormatBuyPrice { get; set; }

        [JsonProperty("formatSellPrice")]
        public string FormatSellPrice { get; set; }

        [JsonProperty("formatCraftingSellSum")]
        public string FormatCraftingSellSum { get; set; }

        [JsonProperty("formatCraftingBuySum")]
        public string FormatCraftingBuySum { get; set; }

        [JsonProperty("craftingResultAmount")]
        public long CraftingResultAmount { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }

    }


    public partial class CrossoutDb
    {
        public static CrossoutDb FromJson(string json) => JsonConvert.DeserializeObject<CrossoutDb>(json, CroussoutDBPlus.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this CrossoutDb self) => JsonConvert.SerializeObject(self, CroussoutDBPlus.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
