using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappVolumeQuotaRule
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetappVolumeQuotaRule.DataAzurermNetappVolumeQuotaRuleTimeouts")]
    public class DataAzurermNetappVolumeQuotaRuleTimeouts : azurerm.DataAzurermNetappVolumeQuotaRule.IDataAzurermNetappVolumeQuotaRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_quota_rule#read DataAzurermNetappVolumeQuotaRule#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
