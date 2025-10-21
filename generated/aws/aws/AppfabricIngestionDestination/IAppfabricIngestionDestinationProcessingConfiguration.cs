using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricIngestionDestination
{
    [JsiiInterface(nativeType: typeof(IAppfabricIngestionDestinationProcessingConfiguration), fullyQualifiedName: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationProcessingConfiguration")]
    public interface IAppfabricIngestionDestinationProcessingConfiguration
    {
        /// <summary>audit_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#audit_log AppfabricIngestionDestination#audit_log}
        /// </remarks>
        [JsiiProperty(name: "auditLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricIngestionDestination.AppfabricIngestionDestinationProcessingConfigurationAuditLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuditLog
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppfabricIngestionDestinationProcessingConfiguration), fullyQualifiedName: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationProcessingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationProcessingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>audit_log block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#audit_log AppfabricIngestionDestination#audit_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auditLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricIngestionDestination.AppfabricIngestionDestinationProcessingConfigurationAuditLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AuditLog
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
