using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ActiveDirectoryDomainServiceReplicaSet
{
    [JsiiInterface(nativeType: typeof(IActiveDirectoryDomainServiceReplicaSetTimeouts), fullyQualifiedName: "azurerm.activeDirectoryDomainServiceReplicaSet.ActiveDirectoryDomainServiceReplicaSetTimeouts")]
    public interface IActiveDirectoryDomainServiceReplicaSetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#create ActiveDirectoryDomainServiceReplicaSet#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#delete ActiveDirectoryDomainServiceReplicaSet#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#read ActiveDirectoryDomainServiceReplicaSet#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActiveDirectoryDomainServiceReplicaSetTimeouts), fullyQualifiedName: "azurerm.activeDirectoryDomainServiceReplicaSet.ActiveDirectoryDomainServiceReplicaSetTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.ActiveDirectoryDomainServiceReplicaSet.IActiveDirectoryDomainServiceReplicaSetTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#create ActiveDirectoryDomainServiceReplicaSet#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#delete ActiveDirectoryDomainServiceReplicaSet#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#read ActiveDirectoryDomainServiceReplicaSet#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
