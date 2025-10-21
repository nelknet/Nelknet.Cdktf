using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermHealthcareWorkspace
{
    [JsiiInterface(nativeType: typeof(IDataAzurermHealthcareWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermHealthcareWorkspace.DataAzurermHealthcareWorkspaceTimeouts")]
    public interface IDataAzurermHealthcareWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_workspace#read DataAzurermHealthcareWorkspace#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermHealthcareWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermHealthcareWorkspace.DataAzurermHealthcareWorkspaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermHealthcareWorkspace.IDataAzurermHealthcareWorkspaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_workspace#read DataAzurermHealthcareWorkspace#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
