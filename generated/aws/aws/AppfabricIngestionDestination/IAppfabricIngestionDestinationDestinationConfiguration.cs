using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricIngestionDestination
{
    [JsiiInterface(nativeType: typeof(IAppfabricIngestionDestinationDestinationConfiguration), fullyQualifiedName: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfiguration")]
    public interface IAppfabricIngestionDestinationDestinationConfiguration
    {
        /// <summary>audit_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#audit_log AppfabricIngestionDestination#audit_log}
        /// </remarks>
        [JsiiProperty(name: "auditLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuditLog
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppfabricIngestionDestinationDestinationConfiguration), fullyQualifiedName: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>audit_log block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#audit_log AppfabricIngestionDestination#audit_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auditLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AuditLog
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
