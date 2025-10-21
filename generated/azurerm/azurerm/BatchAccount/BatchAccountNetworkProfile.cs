using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchAccount
{
    [JsiiByValue(fqn: "azurerm.batchAccount.BatchAccountNetworkProfile")]
    public class BatchAccountNetworkProfile : azurerm.BatchAccount.IBatchAccountNetworkProfile
    {
        /// <summary>account_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#account_access BatchAccount#account_access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountAccess", typeJson: "{\"fqn\":\"azurerm.batchAccount.BatchAccountNetworkProfileAccountAccess\"}", isOptional: true)]
        public azurerm.BatchAccount.IBatchAccountNetworkProfileAccountAccess? AccountAccess
        {
            get;
            set;
        }

        /// <summary>node_management_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#node_management_access BatchAccount#node_management_access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeManagementAccess", typeJson: "{\"fqn\":\"azurerm.batchAccount.BatchAccountNetworkProfileNodeManagementAccess\"}", isOptional: true)]
        public azurerm.BatchAccount.IBatchAccountNetworkProfileNodeManagementAccess? NodeManagementAccess
        {
            get;
            set;
        }
    }
}
