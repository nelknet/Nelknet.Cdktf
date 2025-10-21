using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiInterface(nativeType: typeof(IKendraIndexDocumentMetadataConfigurationUpdates), fullyQualifiedName: "aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdates")]
    public interface IKendraIndexDocumentMetadataConfigurationUpdates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#name KendraIndex#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#type KendraIndex#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>relevance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#relevance KendraIndex#relevance}
        /// </remarks>
        [JsiiProperty(name: "relevance", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesRelevance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesRelevance? Relevance
        {
            get
            {
                return null;
            }
        }

        /// <summary>search block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#search KendraIndex#search}
        /// </remarks>
        [JsiiProperty(name: "search", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesSearch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesSearch? Search
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraIndexDocumentMetadataConfigurationUpdates), fullyQualifiedName: "aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdates")]
        internal sealed class _Proxy : DeputyBase, aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdates
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#name KendraIndex#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#type KendraIndex#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>relevance block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#relevance KendraIndex#relevance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relevance", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesRelevance\"}", isOptional: true)]
            public aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesRelevance? Relevance
            {
                get => GetInstanceProperty<aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesRelevance?>();
            }

            /// <summary>search block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#search KendraIndex#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesSearch\"}", isOptional: true)]
            public aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesSearch? Search
            {
                get => GetInstanceProperty<aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesSearch?>();
            }
        }
    }
}
