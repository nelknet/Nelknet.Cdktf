using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BcmdataexportsExport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bcmdataexportsExport.BcmdataexportsExportExport")]
    public class BcmdataexportsExportExport : aws.BcmdataexportsExport.IBcmdataexportsExportExport
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#name BcmdataexportsExport#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _dataQuery;

        /// <summary>data_query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#data_query BcmdataexportsExport#data_query}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportDataQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataQuery
        {
            get => _dataQuery;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BcmdataexportsExport.IBcmdataexportsExportExportDataQuery[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BcmdataexportsExport.IBcmdataexportsExportExportDataQuery).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataQuery = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#description BcmdataexportsExport#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _destinationConfigurations;

        /// <summary>destination_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#destination_configurations BcmdataexportsExport#destination_configurations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DestinationConfigurations
        {
            get => _destinationConfigurations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BcmdataexportsExport.IBcmdataexportsExportExportDestinationConfigurations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BcmdataexportsExport.IBcmdataexportsExportExportDestinationConfigurations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _destinationConfigurations = value;
            }
        }

        private object? _refreshCadence;

        /// <summary>refresh_cadence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#refresh_cadence BcmdataexportsExport#refresh_cadence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "refreshCadence", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportRefreshCadence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RefreshCadence
        {
            get => _refreshCadence;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BcmdataexportsExport.IBcmdataexportsExportExportRefreshCadence[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BcmdataexportsExport.IBcmdataexportsExportExportRefreshCadence).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _refreshCadence = value;
            }
        }
    }
}
