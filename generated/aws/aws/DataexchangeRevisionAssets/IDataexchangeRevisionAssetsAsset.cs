using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeRevisionAssets
{
    [JsiiInterface(nativeType: typeof(IDataexchangeRevisionAssetsAsset), fullyQualifiedName: "aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAsset")]
    public interface IDataexchangeRevisionAssetsAsset
    {
        /// <summary>create_s3_data_access_from_s3_bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#create_s3_data_access_from_s3_bucket DataexchangeRevisionAssets#create_s3_data_access_from_s3_bucket}
        /// </remarks>
        [JsiiProperty(name: "createS3DataAccessFromS3Bucket", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetCreateS3DataAccessFromS3Bucket\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CreateS3DataAccessFromS3Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>import_assets_from_s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#import_assets_from_s3 DataexchangeRevisionAssets#import_assets_from_s3}
        /// </remarks>
        [JsiiProperty(name: "importAssetsFromS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ImportAssetsFromS3
        {
            get
            {
                return null;
            }
        }

        /// <summary>import_assets_from_signed_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#import_assets_from_signed_url DataexchangeRevisionAssets#import_assets_from_signed_url}
        /// </remarks>
        [JsiiProperty(name: "importAssetsFromSignedUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromSignedUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ImportAssetsFromSignedUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataexchangeRevisionAssetsAsset), fullyQualifiedName: "aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAsset")]
        internal sealed class _Proxy : DeputyBase, aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAsset
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>create_s3_data_access_from_s3_bucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#create_s3_data_access_from_s3_bucket DataexchangeRevisionAssets#create_s3_data_access_from_s3_bucket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createS3DataAccessFromS3Bucket", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetCreateS3DataAccessFromS3Bucket\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CreateS3DataAccessFromS3Bucket
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>import_assets_from_s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#import_assets_from_s3 DataexchangeRevisionAssets#import_assets_from_s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "importAssetsFromS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ImportAssetsFromS3
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>import_assets_from_signed_url block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#import_assets_from_signed_url DataexchangeRevisionAssets#import_assets_from_signed_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "importAssetsFromSignedUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromSignedUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ImportAssetsFromSignedUrl
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
