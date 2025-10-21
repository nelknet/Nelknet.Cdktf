using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ActiveDirectoryDomainService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceInitialReplicaSet")]
    public class ActiveDirectoryDomainServiceInitialReplicaSet : azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceInitialReplicaSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#subnet_id ActiveDirectoryDomainService#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }
    }
}
