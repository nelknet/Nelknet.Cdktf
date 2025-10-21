using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermServicebusTopicAuthorizationRule
{
    [JsiiInterface(nativeType: typeof(IDataAzurermServicebusTopicAuthorizationRuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermServicebusTopicAuthorizationRule.DataAzurermServicebusTopicAuthorizationRuleTimeouts")]
    public interface IDataAzurermServicebusTopicAuthorizationRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic_authorization_rule#read DataAzurermServicebusTopicAuthorizationRule#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermServicebusTopicAuthorizationRuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermServicebusTopicAuthorizationRule.DataAzurermServicebusTopicAuthorizationRuleTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermServicebusTopicAuthorizationRule.IDataAzurermServicebusTopicAuthorizationRuleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic_authorization_rule#read DataAzurermServicebusTopicAuthorizationRule#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
