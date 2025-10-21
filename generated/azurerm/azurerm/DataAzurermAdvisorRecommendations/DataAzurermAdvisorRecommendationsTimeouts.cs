using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAdvisorRecommendations
{
    [JsiiByValue(fqn: "azurerm.dataAzurermAdvisorRecommendations.DataAzurermAdvisorRecommendationsTimeouts")]
    public class DataAzurermAdvisorRecommendationsTimeouts : azurerm.DataAzurermAdvisorRecommendations.IDataAzurermAdvisorRecommendationsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/advisor_recommendations#read DataAzurermAdvisorRecommendations#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
