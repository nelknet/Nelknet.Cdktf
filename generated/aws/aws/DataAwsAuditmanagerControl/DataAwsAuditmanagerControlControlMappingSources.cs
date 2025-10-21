using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAuditmanagerControl
{
    [JsiiByValue(fqn: "aws.dataAwsAuditmanagerControl.DataAwsAuditmanagerControlControlMappingSources")]
    public class DataAwsAuditmanagerControlControlMappingSources : aws.DataAwsAuditmanagerControl.IDataAwsAuditmanagerControlControlMappingSources
    {
        private object? _sourceKeyword;

        /// <summary>source_keyword block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_control#source_keyword DataAwsAuditmanagerControl#source_keyword}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceKeyword", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsAuditmanagerControl.DataAwsAuditmanagerControlControlMappingSourcesSourceKeyword\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SourceKeyword
        {
            get => _sourceKeyword;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsAuditmanagerControl.IDataAwsAuditmanagerControlControlMappingSourcesSourceKeyword[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsAuditmanagerControl.IDataAwsAuditmanagerControlControlMappingSourcesSourceKeyword).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sourceKeyword = value;
            }
        }
    }
}
