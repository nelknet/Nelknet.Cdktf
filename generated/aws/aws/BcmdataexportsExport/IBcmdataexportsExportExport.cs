using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BcmdataexportsExport
{
    [JsiiInterface(nativeType: typeof(IBcmdataexportsExportExport), fullyQualifiedName: "aws.bcmdataexportsExport.BcmdataexportsExportExport")]
    public interface IBcmdataexportsExportExport
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#name BcmdataexportsExport#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>data_query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#data_query BcmdataexportsExport#data_query}
        /// </remarks>
        [JsiiProperty(name: "dataQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportDataQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataQuery
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#description BcmdataexportsExport#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>destination_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#destination_configurations BcmdataexportsExport#destination_configurations}
        /// </remarks>
        [JsiiProperty(name: "destinationConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DestinationConfigurations
        {
            get
            {
                return null;
            }
        }

        /// <summary>refresh_cadence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#refresh_cadence BcmdataexportsExport#refresh_cadence}
        /// </remarks>
        [JsiiProperty(name: "refreshCadence", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportRefreshCadence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RefreshCadence
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBcmdataexportsExportExport), fullyQualifiedName: "aws.bcmdataexportsExport.BcmdataexportsExportExport")]
        internal sealed class _Proxy : DeputyBase, aws.BcmdataexportsExport.IBcmdataexportsExportExport
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#name BcmdataexportsExport#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>data_query block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#data_query BcmdataexportsExport#data_query}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportDataQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataQuery
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#description BcmdataexportsExport#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>destination_configurations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#destination_configurations BcmdataexportsExport#destination_configurations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DestinationConfigurations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>refresh_cadence block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#refresh_cadence BcmdataexportsExport#refresh_cadence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "refreshCadence", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportRefreshCadence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RefreshCadence
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
