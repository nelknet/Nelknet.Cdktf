using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedhatOpenshiftCluster
{
    [JsiiInterface(nativeType: typeof(IRedhatOpenshiftClusterIngressProfile), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterIngressProfile")]
    public interface IRedhatOpenshiftClusterIngressProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#visibility RedhatOpenshiftCluster#visibility}.</summary>
        [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}")]
        string Visibility
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRedhatOpenshiftClusterIngressProfile), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterIngressProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIngressProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#visibility RedhatOpenshiftCluster#visibility}.</summary>
            [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}")]
            public string Visibility
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
