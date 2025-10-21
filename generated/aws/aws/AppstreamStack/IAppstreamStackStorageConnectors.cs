using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamStack
{
    [JsiiInterface(nativeType: typeof(IAppstreamStackStorageConnectors), fullyQualifiedName: "aws.appstreamStack.AppstreamStackStorageConnectors")]
    public interface IAppstreamStackStorageConnectors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#connector_type AppstreamStack#connector_type}.</summary>
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectorType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#domains AppstreamStack#domains}.</summary>
        [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Domains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#resource_identifier AppstreamStack#resource_identifier}.</summary>
        [JsiiProperty(name: "resourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppstreamStackStorageConnectors), fullyQualifiedName: "aws.appstreamStack.AppstreamStackStorageConnectors")]
        internal sealed class _Proxy : DeputyBase, aws.AppstreamStack.IAppstreamStackStorageConnectors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#connector_type AppstreamStack#connector_type}.</summary>
            [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectorType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#domains AppstreamStack#domains}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Domains
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#resource_identifier AppstreamStack#resource_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceIdentifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
