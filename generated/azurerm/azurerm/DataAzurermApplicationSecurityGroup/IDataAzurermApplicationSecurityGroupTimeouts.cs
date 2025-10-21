using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApplicationSecurityGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermApplicationSecurityGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermApplicationSecurityGroup.DataAzurermApplicationSecurityGroupTimeouts")]
    public interface IDataAzurermApplicationSecurityGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_security_group#read DataAzurermApplicationSecurityGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermApplicationSecurityGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermApplicationSecurityGroup.DataAzurermApplicationSecurityGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermApplicationSecurityGroup.IDataAzurermApplicationSecurityGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_security_group#read DataAzurermApplicationSecurityGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
