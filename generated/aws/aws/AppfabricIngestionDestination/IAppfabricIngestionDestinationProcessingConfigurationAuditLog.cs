using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricIngestionDestination
{
    [JsiiInterface(nativeType: typeof(IAppfabricIngestionDestinationProcessingConfigurationAuditLog), fullyQualifiedName: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationProcessingConfigurationAuditLog")]
    public interface IAppfabricIngestionDestinationProcessingConfigurationAuditLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#format AppfabricIngestionDestination#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#schema AppfabricIngestionDestination#schema}.</summary>
        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}")]
        string Schema
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppfabricIngestionDestinationProcessingConfigurationAuditLog), fullyQualifiedName: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationProcessingConfigurationAuditLog")]
        internal sealed class _Proxy : DeputyBase, aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationProcessingConfigurationAuditLog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#format AppfabricIngestionDestination#format}.</summary>
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#schema AppfabricIngestionDestination#schema}.</summary>
            [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}")]
            public string Schema
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
