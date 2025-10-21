using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BcmdataexportsExport
{
    [JsiiInterface(nativeType: typeof(IBcmdataexportsExportExportDataQuery), fullyQualifiedName: "aws.bcmdataexportsExport.BcmdataexportsExportExportDataQuery")]
    public interface IBcmdataexportsExportExportDataQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#query_statement BcmdataexportsExport#query_statement}.</summary>
        [JsiiProperty(name: "queryStatement", typeJson: "{\"primitive\":\"string\"}")]
        string QueryStatement
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#table_configurations BcmdataexportsExport#table_configurations}.</summary>
        [JsiiProperty(name: "tableConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TableConfigurations
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBcmdataexportsExportExportDataQuery), fullyQualifiedName: "aws.bcmdataexportsExport.BcmdataexportsExportExportDataQuery")]
        internal sealed class _Proxy : DeputyBase, aws.BcmdataexportsExport.IBcmdataexportsExportExportDataQuery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#query_statement BcmdataexportsExport#query_statement}.</summary>
            [JsiiProperty(name: "queryStatement", typeJson: "{\"primitive\":\"string\"}")]
            public string QueryStatement
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#table_configurations BcmdataexportsExport#table_configurations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tableConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? TableConfigurations
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
