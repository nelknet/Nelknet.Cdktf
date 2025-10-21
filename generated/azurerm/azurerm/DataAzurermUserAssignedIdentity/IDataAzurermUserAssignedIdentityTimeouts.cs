using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermUserAssignedIdentity
{
    [JsiiInterface(nativeType: typeof(IDataAzurermUserAssignedIdentityTimeouts), fullyQualifiedName: "azurerm.dataAzurermUserAssignedIdentity.DataAzurermUserAssignedIdentityTimeouts")]
    public interface IDataAzurermUserAssignedIdentityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/user_assigned_identity#read DataAzurermUserAssignedIdentity#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermUserAssignedIdentityTimeouts), fullyQualifiedName: "azurerm.dataAzurermUserAssignedIdentity.DataAzurermUserAssignedIdentityTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermUserAssignedIdentity.IDataAzurermUserAssignedIdentityTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/user_assigned_identity#read DataAzurermUserAssignedIdentity#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
