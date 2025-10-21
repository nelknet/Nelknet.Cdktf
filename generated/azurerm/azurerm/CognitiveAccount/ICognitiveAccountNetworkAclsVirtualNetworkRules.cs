using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CognitiveAccount
{
    [JsiiInterface(nativeType: typeof(ICognitiveAccountNetworkAclsVirtualNetworkRules), fullyQualifiedName: "azurerm.cognitiveAccount.CognitiveAccountNetworkAclsVirtualNetworkRules")]
    public interface ICognitiveAccountNetworkAclsVirtualNetworkRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#subnet_id CognitiveAccount#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#ignore_missing_vnet_service_endpoint CognitiveAccount#ignore_missing_vnet_service_endpoint}.</summary>
        [JsiiProperty(name: "ignoreMissingVnetServiceEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreMissingVnetServiceEndpoint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitiveAccountNetworkAclsVirtualNetworkRules), fullyQualifiedName: "azurerm.cognitiveAccount.CognitiveAccountNetworkAclsVirtualNetworkRules")]
        internal sealed class _Proxy : DeputyBase, azurerm.CognitiveAccount.ICognitiveAccountNetworkAclsVirtualNetworkRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#subnet_id CognitiveAccount#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#ignore_missing_vnet_service_endpoint CognitiveAccount#ignore_missing_vnet_service_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreMissingVnetServiceEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IgnoreMissingVnetServiceEndpoint
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
