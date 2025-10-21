using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricIngestionDestination
{
    [JsiiByValue(fqn: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationProcessingConfiguration")]
    public class AppfabricIngestionDestinationProcessingConfiguration : aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationProcessingConfiguration
    {
        private object? _auditLog;

        /// <summary>audit_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#audit_log AppfabricIngestionDestination#audit_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auditLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricIngestionDestination.AppfabricIngestionDestinationProcessingConfigurationAuditLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AuditLog
        {
            get => _auditLog;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationProcessingConfigurationAuditLog[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationProcessingConfigurationAuditLog).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _auditLog = value;
            }
        }
    }
}
