using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VmwarePrivateCloud
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vmwarePrivateCloud.VmwarePrivateCloudManagementCluster")]
    public class VmwarePrivateCloudManagementCluster : azurerm.VmwarePrivateCloud.IVmwarePrivateCloudManagementCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#size VmwarePrivateCloud#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public double Size
        {
            get;
            set;
        }
    }
}
