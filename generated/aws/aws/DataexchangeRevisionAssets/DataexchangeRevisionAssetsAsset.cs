using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeRevisionAssets
{
    [JsiiByValue(fqn: "aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAsset")]
    public class DataexchangeRevisionAssetsAsset : aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAsset
    {
        private object? _createS3DataAccessFromS3Bucket;

        /// <summary>create_s3_data_access_from_s3_bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#create_s3_data_access_from_s3_bucket DataexchangeRevisionAssets#create_s3_data_access_from_s3_bucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createS3DataAccessFromS3Bucket", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetCreateS3DataAccessFromS3Bucket\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreateS3DataAccessFromS3Bucket
        {
            get => _createS3DataAccessFromS3Bucket;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAssetCreateS3DataAccessFromS3Bucket[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAssetCreateS3DataAccessFromS3Bucket).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createS3DataAccessFromS3Bucket = value;
            }
        }

        private object? _importAssetsFromS3;

        /// <summary>import_assets_from_s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#import_assets_from_s3 DataexchangeRevisionAssets#import_assets_from_s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "importAssetsFromS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ImportAssetsFromS3
        {
            get => _importAssetsFromS3;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAssetImportAssetsFromS3[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAssetImportAssetsFromS3).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _importAssetsFromS3 = value;
            }
        }

        private object? _importAssetsFromSignedUrl;

        /// <summary>import_assets_from_signed_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#import_assets_from_signed_url DataexchangeRevisionAssets#import_assets_from_signed_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "importAssetsFromSignedUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromSignedUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ImportAssetsFromSignedUrl
        {
            get => _importAssetsFromSignedUrl;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAssetImportAssetsFromSignedUrl[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAssetImportAssetsFromSignedUrl).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _importAssetsFromSignedUrl = value;
            }
        }
    }
}
