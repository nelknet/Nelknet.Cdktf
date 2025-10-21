using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventgridDomainTopic
{
    [JsiiInterface(nativeType: typeof(IDataAzurermEventgridDomainTopicTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventgridDomainTopic.DataAzurermEventgridDomainTopicTimeouts")]
    public interface IDataAzurermEventgridDomainTopicTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain_topic#read DataAzurermEventgridDomainTopic#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermEventgridDomainTopicTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventgridDomainTopic.DataAzurermEventgridDomainTopicTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermEventgridDomainTopic.IDataAzurermEventgridDomainTopicTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain_topic#read DataAzurermEventgridDomainTopic#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
