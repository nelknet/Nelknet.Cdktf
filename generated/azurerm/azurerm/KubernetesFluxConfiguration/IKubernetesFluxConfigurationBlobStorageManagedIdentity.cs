using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFluxConfiguration
{
    [JsiiInterface(nativeType: typeof(IKubernetesFluxConfigurationBlobStorageManagedIdentity), fullyQualifiedName: "azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationBlobStorageManagedIdentity")]
    public interface IKubernetesFluxConfigurationBlobStorageManagedIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#client_id KubernetesFluxConfiguration#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesFluxConfigurationBlobStorageManagedIdentity), fullyQualifiedName: "azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationBlobStorageManagedIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationBlobStorageManagedIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#client_id KubernetesFluxConfiguration#client_id}.</summary>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
