using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAdvisorRecommendations
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAdvisorRecommendationsTimeouts), fullyQualifiedName: "azurerm.dataAzurermAdvisorRecommendations.DataAzurermAdvisorRecommendationsTimeouts")]
    public interface IDataAzurermAdvisorRecommendationsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/advisor_recommendations#read DataAzurermAdvisorRecommendations#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAdvisorRecommendationsTimeouts), fullyQualifiedName: "azurerm.dataAzurermAdvisorRecommendations.DataAzurermAdvisorRecommendationsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAdvisorRecommendations.IDataAzurermAdvisorRecommendationsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/advisor_recommendations#read DataAzurermAdvisorRecommendations#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
