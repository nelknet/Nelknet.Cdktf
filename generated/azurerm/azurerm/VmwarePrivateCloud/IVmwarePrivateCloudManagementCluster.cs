using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VmwarePrivateCloud
{
    [JsiiInterface(nativeType: typeof(IVmwarePrivateCloudManagementCluster), fullyQualifiedName: "azurerm.vmwarePrivateCloud.VmwarePrivateCloudManagementCluster")]
    public interface IVmwarePrivateCloudManagementCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#size VmwarePrivateCloud#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVmwarePrivateCloudManagementCluster), fullyQualifiedName: "azurerm.vmwarePrivateCloud.VmwarePrivateCloudManagementCluster")]
        internal sealed class _Proxy : DeputyBase, azurerm.VmwarePrivateCloud.IVmwarePrivateCloudManagementCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#size VmwarePrivateCloud#size}.</summary>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
