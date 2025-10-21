using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricIngestionDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationProcessingConfigurationAuditLog")]
    public class AppfabricIngestionDestinationProcessingConfigurationAuditLog : aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationProcessingConfigurationAuditLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#format AppfabricIngestionDestination#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public string Format
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#schema AppfabricIngestionDestination#schema}.</summary>
        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}")]
        public string Schema
        {
            get;
            set;
        }
    }
}
