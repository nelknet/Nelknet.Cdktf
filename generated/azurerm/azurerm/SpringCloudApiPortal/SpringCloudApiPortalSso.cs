using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudApiPortal
{
    [JsiiByValue(fqn: "azurerm.springCloudApiPortal.SpringCloudApiPortalSso")]
    public class SpringCloudApiPortalSso : azurerm.SpringCloudApiPortal.ISpringCloudApiPortalSso
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#client_id SpringCloudApiPortal#client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#client_secret SpringCloudApiPortal#client_secret}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecret
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#issuer_uri SpringCloudApiPortal#issuer_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "issuerUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IssuerUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#scope SpringCloudApiPortal#scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Scope
        {
            get;
            set;
        }
    }
}
