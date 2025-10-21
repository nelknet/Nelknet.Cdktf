using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolStartTaskUserIdentity")]
    public class BatchPoolStartTaskUserIdentity : azurerm.BatchPool.IBatchPoolStartTaskUserIdentity
    {
        /// <summary>auto_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#auto_user BatchPool#auto_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoUser", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskUserIdentityAutoUser\"}", isOptional: true)]
        public azurerm.BatchPool.IBatchPoolStartTaskUserIdentityAutoUser? AutoUser
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#user_name BatchPool#user_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserName
        {
            get;
            set;
        }
    }
}
