using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.batchAccount.BatchAccountNetworkProfileAccountAccessIpRule")]
    public class BatchAccountNetworkProfileAccountAccessIpRule : azurerm.BatchAccount.IBatchAccountNetworkProfileAccountAccessIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#ip_range BatchAccount#ip_range}.</summary>
        [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}")]
        public string IpRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#action BatchAccount#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }
    }
}
