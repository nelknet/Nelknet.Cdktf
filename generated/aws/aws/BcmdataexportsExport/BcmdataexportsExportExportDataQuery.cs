using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BcmdataexportsExport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bcmdataexportsExport.BcmdataexportsExportExportDataQuery")]
    public class BcmdataexportsExportExportDataQuery : aws.BcmdataexportsExport.IBcmdataexportsExportExportDataQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#query_statement BcmdataexportsExport#query_statement}.</summary>
        [JsiiProperty(name: "queryStatement", typeJson: "{\"primitive\":\"string\"}")]
        public string QueryStatement
        {
            get;
            set;
        }

        private object? _tableConfigurations;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#table_configurations BcmdataexportsExport#table_configurations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tableConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? TableConfigurations
        {
            get => _tableConfigurations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tableConfigurations = value;
            }
        }
    }
}
