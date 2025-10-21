using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerGroup
{
    [JsiiInterface(nativeType: typeof(IContainerGroupDiagnostics), fullyQualifiedName: "azurerm.containerGroup.ContainerGroupDiagnostics")]
    public interface IContainerGroupDiagnostics
    {
        /// <summary>log_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#log_analytics ContainerGroup#log_analytics}
        /// </remarks>
        [JsiiProperty(name: "logAnalytics", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupDiagnosticsLogAnalytics\"}")]
        azurerm.ContainerGroup.IContainerGroupDiagnosticsLogAnalytics LogAnalytics
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerGroupDiagnostics), fullyQualifiedName: "azurerm.containerGroup.ContainerGroupDiagnostics")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerGroup.IContainerGroupDiagnostics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>log_analytics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#log_analytics ContainerGroup#log_analytics}
            /// </remarks>
            [JsiiProperty(name: "logAnalytics", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupDiagnosticsLogAnalytics\"}")]
            public azurerm.ContainerGroup.IContainerGroupDiagnosticsLogAnalytics LogAnalytics
            {
                get => GetInstanceProperty<azurerm.ContainerGroup.IContainerGroupDiagnosticsLogAnalytics>()!;
            }
        }
    }
}
