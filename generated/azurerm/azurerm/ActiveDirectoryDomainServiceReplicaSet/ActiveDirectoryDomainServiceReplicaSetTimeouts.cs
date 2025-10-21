using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ActiveDirectoryDomainServiceReplicaSet
{
    [JsiiByValue(fqn: "azurerm.activeDirectoryDomainServiceReplicaSet.ActiveDirectoryDomainServiceReplicaSetTimeouts")]
    public class ActiveDirectoryDomainServiceReplicaSetTimeouts : azurerm.ActiveDirectoryDomainServiceReplicaSet.IActiveDirectoryDomainServiceReplicaSetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#create ActiveDirectoryDomainServiceReplicaSet#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#delete ActiveDirectoryDomainServiceReplicaSet#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#read ActiveDirectoryDomainServiceReplicaSet#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
