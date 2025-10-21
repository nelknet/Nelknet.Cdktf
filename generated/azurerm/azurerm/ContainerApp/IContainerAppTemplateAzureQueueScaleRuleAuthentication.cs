using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    [JsiiInterface(nativeType: typeof(IContainerAppTemplateAzureQueueScaleRuleAuthentication), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplateAzureQueueScaleRuleAuthentication")]
    public interface IContainerAppTemplateAzureQueueScaleRuleAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#secret_name ContainerApp#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        string SecretName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#trigger_parameter ContainerApp#trigger_parameter}.</summary>
        [JsiiProperty(name: "triggerParameter", typeJson: "{\"primitive\":\"string\"}")]
        string TriggerParameter
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppTemplateAzureQueueScaleRuleAuthentication), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplateAzureQueueScaleRuleAuthentication")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerApp.IContainerAppTemplateAzureQueueScaleRuleAuthentication
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
            [JsiiProperty(name: "triggerParameter", typeJson: "{\"primitive\":\"string\"}")]
            public string TriggerParameter
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
