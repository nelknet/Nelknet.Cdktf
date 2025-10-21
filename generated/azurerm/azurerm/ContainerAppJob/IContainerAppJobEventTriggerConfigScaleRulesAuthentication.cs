using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiInterface(nativeType: typeof(IContainerAppJobEventTriggerConfigScaleRulesAuthentication), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScaleRulesAuthentication")]
    public interface IContainerAppJobEventTriggerConfigScaleRulesAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#secret_name ContainerAppJob#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        string SecretName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#trigger_parameter ContainerAppJob#trigger_parameter}.</summary>
        [JsiiProperty(name: "triggerParameter", typeJson: "{\"primitive\":\"string\"}")]
        string TriggerParameter
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppJobEventTriggerConfigScaleRulesAuthentication), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScaleRulesAuthentication")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScaleRulesAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#secret_name ContainerAppJob#secret_name}.</summary>
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#trigger_parameter ContainerAppJob#trigger_parameter}.</summary>
            [JsiiProperty(name: "triggerParameter", typeJson: "{\"primitive\":\"string\"}")]
            public string TriggerParameter
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
