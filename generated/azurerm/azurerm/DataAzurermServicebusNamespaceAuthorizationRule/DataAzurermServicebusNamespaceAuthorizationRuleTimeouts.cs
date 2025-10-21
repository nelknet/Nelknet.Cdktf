using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermServicebusNamespaceAuthorizationRule
{
    [JsiiByValue(fqn: "azurerm.dataAzurermServicebusNamespaceAuthorizationRule.DataAzurermServicebusNamespaceAuthorizationRuleTimeouts")]
    public class DataAzurermServicebusNamespaceAuthorizationRuleTimeouts : azurerm.DataAzurermServicebusNamespaceAuthorizationRule.IDataAzurermServicebusNamespaceAuthorizationRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_authorization_rule#read DataAzurermServicebusNamespaceAuthorizationRule#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
