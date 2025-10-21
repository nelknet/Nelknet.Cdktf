using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricIngestionDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream")]
    public class AppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream : aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#stream_name AppfabricIngestionDestination#stream_name}.</summary>
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
        public string StreamName
        {
            get;
            set;
        }
    }
}
