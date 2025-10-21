using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventgridDomain
{
    [JsiiInterface(nativeType: typeof(IDataAzurermEventgridDomainTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventgridDomain.DataAzurermEventgridDomainTimeouts")]
    public interface IDataAzurermEventgridDomainTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain#read DataAzurermEventgridDomain#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermEventgridDomainTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventgridDomain.DataAzurermEventgridDomainTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermEventgridDomain.IDataAzurermEventgridDomainTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain#read DataAzurermEventgridDomain#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
