using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermTemplateSpecVersion
{
    [JsiiInterface(nativeType: typeof(IDataAzurermTemplateSpecVersionTimeouts), fullyQualifiedName: "azurerm.dataAzurermTemplateSpecVersion.DataAzurermTemplateSpecVersionTimeouts")]
    public interface IDataAzurermTemplateSpecVersionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/template_spec_version#read DataAzurermTemplateSpecVersion#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermTemplateSpecVersionTimeouts), fullyQualifiedName: "azurerm.dataAzurermTemplateSpecVersion.DataAzurermTemplateSpecVersionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermTemplateSpecVersion.IDataAzurermTemplateSpecVersionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/template_spec_version#read DataAzurermTemplateSpecVersion#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
