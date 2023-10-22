using System.Text.Json.Serialization;

namespace Usda.Response;
public class RootObject
{
    [JsonPropertyName("totalHits")]
    public int TotalHits { get; set; }

    [JsonPropertyName("currentPage")]
    public int CurrentPage { get; set; }

    [JsonPropertyName("totalPages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("pageList")]
    public int[] PageList { get; set; }

    [JsonPropertyName("foodSearchCriteria")]
    public FoodSearchCriteria FoodSearchCriteria { get; set; }

    [JsonPropertyName("foods")]
    public Food[] Foods { get; set; }

    [JsonPropertyName("aggregations")]
    public Aggregations Aggregations { get; set; }
}


public class FoodSearchCriteria
{
    [JsonPropertyName("query")]
    public string Query { get; set; }

    [JsonPropertyName("generalSearchInput")]
    public string GeneralSearchInput { get; set; }

    [JsonPropertyName("pageNumber")]
    public int PageNumber { get; set; }

    [JsonPropertyName("numberOfResultsPerPage")]
    public int NumberOfResultsPerPage { get; set; }

    [JsonPropertyName("pageSize")]
    public int PageSize { get; set; }

    [JsonPropertyName("requireAllWords")]
    public bool RequireAllWords { get; set; }
}

public class Aggregations
{
    [JsonPropertyName("dataType")]
    public DataType DataType { get; set; }

    [JsonPropertyName("nutrients")]
    public Nutrients Nutrients { get; set; }
}

public class DataType
{
    [JsonPropertyName("Branded")]
    public int Branded { get; set; }

    [JsonPropertyName("SurveyFNDDS")]
    public int SurveyFNDDS { get; set; }

    [JsonPropertyName("SRLegacy")]
    public int SRLegacy { get; set; }

    [JsonPropertyName("Foundation")]
    public int Foundation { get; set; }
}

public class Nutrients
{
}

public class Food
{
    [JsonPropertyName("fdcId")]
    public int FdcId { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("dataType")]
    public string DataType { get; set; }

    [JsonPropertyName("gtinUpc")]
    public string GtinUpc { get; set; }

    [JsonPropertyName("publishedDate")]
    public string PublishedDate { get; set; }

    [JsonPropertyName("brandOwner")]
    public string BrandOwner { get; set; }

    [JsonPropertyName("brandName")]
    public string BrandName { get; set; }

    [JsonPropertyName("ingredients")]
    public string Ingredients { get; set; } 

    [JsonPropertyName("marketCountry")]
    public string MarketCountry { get; set; }

    [JsonPropertyName("foodCategory")]
    public string FoodCategory { get; set; }

    [JsonPropertyName("modifiedDate")]
    public string ModifiedDate { get; set; }

    [JsonPropertyName("dataSource")]
    public string DataSource { get; set; }

    [JsonPropertyName("packageWeight")]
    public string PackageWeight { get; set; }

    [JsonPropertyName("servingSizeUnit")]
    public string ServingSizeUnit { get; set; }

    [JsonPropertyName("servingSize")]
    public float ServingSize { get; set; }

    [JsonPropertyName("tradeChannels")]
    public string[] TradeChannels { get; set; }

    [JsonPropertyName("allHighlightFields")]
    public string AllHighlightFields { get; set; }

    [JsonPropertyName("score")]
    public float Score { get; set; }

    [JsonPropertyName("microbes")]
    public object[] Microbes { get; set; }
    [JsonPropertyName("foodNutrients")]
    public FoodNutrient[] FoodNutrients { get; set; }

    [JsonPropertyName("finalFoodInputFoods")]
    public FinalFoodInputFood[] FinalFoodInputFoods { get; set; }

    [JsonPropertyName("foodMeasures")]
    public FoodMeasure[] FoodMeasures { get; set; }

    [JsonPropertyName("foodAttributes")]
    public object[] FoodAttributes { get; set; }

    [JsonPropertyName("foodAttributeTypes")]
    public FoodAttributeType[] FoodAttributeTypes { get; set; }

    [JsonPropertyName("foodVersionIds")]
    public object[] FoodVersionIds { get; set; }

    [JsonPropertyName("householdServingFullText")]
    public string HouseholdServingFullText { get; set; }

    [JsonPropertyName("shortDescription")]
    public string ShortDescription { get; set; }

    [JsonPropertyName("subbrandName")]
    public string SubbrandName { get; set; }

    [JsonPropertyName("commonNames")]
    public string CommonNames { get; set; }

    [JsonPropertyName("additionalDescriptions")]
    public string AdditionalDescriptions { get; set; }

    [JsonPropertyName("foodCode")]
    public int FoodCode { get; set; }

    [JsonPropertyName("foodCategoryId")]
    public int FoodCategoryId { get; set; }

    [JsonPropertyName("ndbNumber")]
    public int NdbNumber { get; set; }
}

public class FoodNutrient
{
    [JsonPropertyName("nutrientId")]
    public int NutrientId { get; set; }

    [JsonPropertyName("nutrientName")]
    public string NutrientName { get; set; }

    [JsonPropertyName("nutrientNumber")]
    public string NutrientNumber { get; set; }

    [JsonPropertyName("unitName")]
    public string UnitName { get; set; }

    [JsonPropertyName("derivationCode")]
    public string DerivationCode { get; set; }

    [JsonPropertyName("derivationDescription")]
    public string DerivationDescription { get; set; }

    [JsonPropertyName("derivationId")]
    public int DerivationId { get; set; }

    [JsonPropertyName("value")]
    public float Value { get; set; }

    [JsonPropertyName("foodNutrientSourceId")]
    public int FoodNutrientSourceId { get; set; }

    [JsonPropertyName("foodNutrientSourceCode")]
    public string FoodNutrientSourceCode { get; set; }

    [JsonPropertyName("foodNutrientSourceDescription")]
    public string FoodNutrientSourceDescription { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("indentLevel")]
    public int IndentLevel { get; set; }

    [JsonPropertyName("foodNutrientId")]
    public int FoodNutrientId { get; set; }

    [JsonPropertyName("percentDailyValue")]
    public int PercentDailyValue { get; set; }

    [JsonPropertyName("dataPoints")]
    public int DataPoints { get; set; }
}

public class FinalFoodInputFood
{
    [JsonPropertyName("foodDescription")]
    public string FoodDescription { get; set; }

    [JsonPropertyName("gramWeight")]
    public float GramWeight { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("portionCode")]
    public string PortionCode { get; set; }

    [JsonPropertyName("portionDescription")]
    public string PortionDescription { get; set; }

    [JsonPropertyName("unit")]
    public string Unit { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("srCode")]
    public int SrCode { get; set; }

    [JsonPropertyName("value")]
    public float Value { get; set; }
}

public class FoodMeasure
{
    public string DisseminationText { get; set; }

    [JsonPropertyName("gramWeight")]
    public float GramWeight { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("modifier")]
    public string Modifier { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("measureUnitAbbreviation")]
    public string MeasureUnitAbbreviation { get; set; }

    [JsonPropertyName("measureUnitName")]
    public string MeasureUnitName { get; set; }

    [JsonPropertyName("measureUnitId")]
    public int MeasureUnitId { get; set; }
}

public class FoodAttributeType
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("foodAttributes")]
    public FoodAttribute[] FoodAttributes { get; set; }
}

public class FoodAttribute
{
    [JsonPropertyName("value")]
    public string Value { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("sequenceNumber")]
    public int SequenceNumber { get; set; }
}
