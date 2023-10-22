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
    public int nutrientId { get; set; }
    public string nutrientName { get; set; }
    public string nutrientNumber { get; set; }
    public string unitName { get; set; }
    public string derivationCode { get; set; }
    public string derivationDescription { get; set; }
    public int derivationId { get; set; }
    public float value { get; set; }
    public int foodNutrientSourceId { get; set; }
    public string foodNutrientSourceCode { get; set; }
    public string foodNutrientSourceDescription { get; set; }
    public int rank { get; set; }
    public int indentLevel { get; set; }
    public int foodNutrientId { get; set; }
    public int percentDailyValue { get; set; }
    public int dataPoints { get; set; }
}

public class FinalFoodInputFood
{
    public string foodDescription { get; set; }
    public float gramWeight { get; set; }
    public int id { get; set; }
    public string portionCode { get; set; }
    public string portionDescription { get; set; }
    public string unit { get; set; }
    public int rank { get; set; }
    public int srCode { get; set; }
    public float value { get; set; }
}

public class FoodMeasure
{
    public string disseminationText { get; set; }
    public float gramWeight { get; set; }
    public int id { get; set; }
    public string modifier { get; set; }
    public int rank { get; set; }
    public string measureUnitAbbreviation { get; set; }
    public string measureUnitName { get; set; }
    public int measureUnitId { get; set; }
}

public class FoodAttributeType
{
    public string name { get; set; }
    public string description { get; set; }
    public int id { get; set; }
    public Foodattribute[] foodAttributes { get; set; }
}

public class Foodattribute
{
    public string value { get; set; }
    public string name { get; set; }
    public int id { get; set; }
    public int sequenceNumber { get; set; }
}
