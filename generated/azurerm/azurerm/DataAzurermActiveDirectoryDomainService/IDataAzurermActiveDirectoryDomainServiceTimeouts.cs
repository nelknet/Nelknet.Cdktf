using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermActiveDirectoryDomainService
{
    [JsiiInterface(nativeType: typeof(IDataAzurermActiveDirectoryDomainServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermActiveDirectoryDomainService.DataAzurermActiveDirectoryDomainServiceTimeouts")]
    public interface IDataAzurermActiveDirectoryDomainServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/active_directory_domain_service#read DataAzurermActiveDirectoryDomainService#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermActiveDirectoryDomainServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermActiveDirectoryDomainService.DataAzurermActiveDirectoryDomainServiceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermActiveDirectoryDomainService.IDataAzurermActiveDirectoryDomainServiceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/active_directory_domain_service#read DataAzurermActiveDirectoryDomainService#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
