using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapStorageVirtualMachine
{
    [JsiiByValue(fqn: "aws.fsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineActiveDirectoryConfiguration")]
    public class FsxOntapStorageVirtualMachineActiveDirectoryConfiguration : aws.FsxOntapStorageVirtualMachine.IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#netbios_name FsxOntapStorageVirtualMachine#netbios_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netbiosName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetbiosName
        {
            get;
            set;
        }

        /// <summary>self_managed_active_directory_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#self_managed_active_directory_configuration FsxOntapStorageVirtualMachine#self_managed_active_directory_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selfManagedActiveDirectoryConfiguration", typeJson: "{\"fqn\":\"aws.fsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration\"}", isOptional: true)]
        public aws.FsxOntapStorageVirtualMachine.IFsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration? SelfManagedActiveDirectoryConfiguration
        {
            get;
            set;
        }
    }
}
