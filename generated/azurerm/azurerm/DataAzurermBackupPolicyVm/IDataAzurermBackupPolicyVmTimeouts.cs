using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBackupPolicyVm
{
    [JsiiInterface(nativeType: typeof(IDataAzurermBackupPolicyVmTimeouts), fullyQualifiedName: "azurerm.dataAzurermBackupPolicyVm.DataAzurermBackupPolicyVmTimeouts")]
    public interface IDataAzurermBackupPolicyVmTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_vm#read DataAzurermBackupPolicyVm#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermBackupPolicyVmTimeouts), fullyQualifiedName: "azurerm.dataAzurermBackupPolicyVm.DataAzurermBackupPolicyVmTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermBackupPolicyVm.IDataAzurermBackupPolicyVmTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_vm#read DataAzurermBackupPolicyVm#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
