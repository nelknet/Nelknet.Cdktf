using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsEndpoint
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointMongodbSettings), fullyQualifiedName: "aws.dmsEndpoint.DmsEndpointMongodbSettings")]
    public interface IDmsEndpointMongodbSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#auth_mechanism DmsEndpoint#auth_mechanism}.</summary>
        [JsiiProperty(name: "authMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthMechanism
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#auth_source DmsEndpoint#auth_source}.</summary>
        [JsiiProperty(name: "authSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#auth_type DmsEndpoint#auth_type}.</summary>
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#docs_to_investigate DmsEndpoint#docs_to_investigate}.</summary>
        [JsiiProperty(name: "docsToInvestigate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DocsToInvestigate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#extract_doc_id DmsEndpoint#extract_doc_id}.</summary>
        [JsiiProperty(name: "extractDocId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExtractDocId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#nesting_level DmsEndpoint#nesting_level}.</summary>
        [JsiiProperty(name: "nestingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NestingLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointMongodbSettings), fullyQualifiedName: "aws.dmsEndpoint.DmsEndpointMongodbSettings")]
        internal sealed class _Proxy : DeputyBase, aws.DmsEndpoint.IDmsEndpointMongodbSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#auth_mechanism DmsEndpoint#auth_mechanism}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthMechanism
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#auth_source DmsEndpoint#auth_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthSource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#auth_type DmsEndpoint#auth_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#docs_to_investigate DmsEndpoint#docs_to_investigate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "docsToInvestigate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DocsToInvestigate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#extract_doc_id DmsEndpoint#extract_doc_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "extractDocId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExtractDocId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#nesting_level DmsEndpoint#nesting_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nestingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NestingLevel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
