using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeRevisionAssets
{
    [JsiiByValue(fqn: "aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromS3")]
    public class DataexchangeRevisionAssetsAssetImportAssetsFromS3 : aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAssetImportAssetsFromS3
    {
        private object? _assetSource;

        /// <summary>asset_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#asset_source DataexchangeRevisionAssets#asset_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "assetSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromS3AssetSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AssetSource
        {
            get => _assetSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAssetImportAssetsFromS3AssetSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAssetImportAssetsFromS3AssetSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _assetSource = value;
            }
        }
    }
}
