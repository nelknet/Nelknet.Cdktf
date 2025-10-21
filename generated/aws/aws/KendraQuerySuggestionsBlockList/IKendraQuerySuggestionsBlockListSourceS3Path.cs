using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraQuerySuggestionsBlockList
{
    [JsiiInterface(nativeType: typeof(IKendraQuerySuggestionsBlockListSourceS3Path), fullyQualifiedName: "aws.kendraQuerySuggestionsBlockList.KendraQuerySuggestionsBlockListSourceS3Path")]
    public interface IKendraQuerySuggestionsBlockListSourceS3Path
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#bucket KendraQuerySuggestionsBlockList#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#key KendraQuerySuggestionsBlockList#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraQuerySuggestionsBlockListSourceS3Path), fullyQualifiedName: "aws.kendraQuerySuggestionsBlockList.KendraQuerySuggestionsBlockListSourceS3Path")]
        internal sealed class _Proxy : DeputyBase, aws.KendraQuerySuggestionsBlockList.IKendraQuerySuggestionsBlockListSourceS3Path
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#bucket KendraQuerySuggestionsBlockList#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#key KendraQuerySuggestionsBlockList#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
