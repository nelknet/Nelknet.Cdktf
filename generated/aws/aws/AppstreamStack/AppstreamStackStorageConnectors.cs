using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appstreamStack.AppstreamStackStorageConnectors")]
    public class AppstreamStackStorageConnectors : aws.AppstreamStack.IAppstreamStackStorageConnectors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#connector_type AppstreamStack#connector_type}.</summary>
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectorType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#domains AppstreamStack#domains}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Domains
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#resource_identifier AppstreamStack#resource_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceIdentifier
        {
            get;
            set;
        }
    }
}
