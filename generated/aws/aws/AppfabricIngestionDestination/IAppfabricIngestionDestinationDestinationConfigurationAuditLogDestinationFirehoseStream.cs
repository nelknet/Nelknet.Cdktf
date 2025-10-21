using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricIngestionDestination
{
    [JsiiInterface(nativeType: typeof(IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream), fullyQualifiedName: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream")]
    public interface IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#stream_name AppfabricIngestionDestination#stream_name}.</summary>
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
        string StreamName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream), fullyQualifiedName: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream")]
        internal sealed class _Proxy : DeputyBase, aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#stream_name AppfabricIngestionDestination#stream_name}.</summary>
            [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
