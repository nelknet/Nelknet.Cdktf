using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolStartTaskUserIdentityAutoUser")]
    public class BatchPoolStartTaskUserIdentityAutoUser : azurerm.BatchPool.IBatchPoolStartTaskUserIdentityAutoUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#elevation_level BatchPool#elevation_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elevationLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ElevationLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#scope BatchPool#scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Scope
        {
            get;
            set;
        }
    }
}
