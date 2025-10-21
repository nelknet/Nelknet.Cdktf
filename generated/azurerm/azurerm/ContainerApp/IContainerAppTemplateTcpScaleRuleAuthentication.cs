using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    [JsiiInterface(nativeType: typeof(IContainerAppTemplateTcpScaleRuleAuthentication), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplateTcpScaleRuleAuthentication")]
    public interface IContainerAppTemplateTcpScaleRuleAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#secret_name ContainerApp#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        string SecretName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#trigger_parameter ContainerApp#trigger_parameter}.</summary>
        [JsiiProperty(name: "triggerParameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TriggerParameter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppTemplateTcpScaleRuleAuthentication), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplateTcpScaleRuleAuthentication")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerApp.IContainerAppTemplateTcpScaleRuleAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#secret_name ContainerApp#secret_name}.</summary>
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#trigger_parameter ContainerApp#trigger_parameter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "triggerParameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TriggerParameter
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
