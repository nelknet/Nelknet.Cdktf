using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVmwarePrivateCloud
{
    [JsiiByValue(fqn: "azurerm.dataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudTimeouts")]
    public class DataAzurermVmwarePrivateCloudTimeouts : azurerm.DataAzurermVmwarePrivateCloud.IDataAzurermVmwarePrivateCloudTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vmware_private_cloud#read DataAzurermVmwarePrivateCloud#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
