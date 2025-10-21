using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapStorageVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration), fullyQualifiedName: "aws.fsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineActiveDirectoryConfiguration")]
    public interface IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#netbios_name FsxOntapStorageVirtualMachine#netbios_name}.</summary>
        [JsiiProperty(name: "netbiosName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetbiosName
        {
            get
            {
                return null;
            }
        }

        /// <summary>self_managed_active_directory_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#self_managed_active_directory_configuration FsxOntapStorageVirtualMachine#self_managed_active_directory_configuration}
        /// </remarks>
        [JsiiProperty(name: "selfManagedActiveDirectoryConfiguration", typeJson: "{\"fqn\":\"aws.fsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FsxOntapStorageVirtualMachine.IFsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration? SelfManagedActiveDirectoryConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration), fullyQualifiedName: "aws.fsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineActiveDirectoryConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FsxOntapStorageVirtualMachine.IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#netbios_name FsxOntapStorageVirtualMachine#netbios_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "netbiosName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetbiosName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>self_managed_active_directory_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#self_managed_active_directory_configuration FsxOntapStorageVirtualMachine#self_managed_active_directory_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selfManagedActiveDirectoryConfiguration", typeJson: "{\"fqn\":\"aws.fsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration\"}", isOptional: true)]
            public aws.FsxOntapStorageVirtualMachine.IFsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration? SelfManagedActiveDirectoryConfiguration
            {
                get => GetInstanceProperty<aws.FsxOntapStorageVirtualMachine.IFsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration?>();
            }
        }
    }
}
