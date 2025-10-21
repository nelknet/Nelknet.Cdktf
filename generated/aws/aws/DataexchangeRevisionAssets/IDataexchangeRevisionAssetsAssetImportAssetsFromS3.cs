using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeRevisionAssets
{
    [JsiiInterface(nativeType: typeof(IDataexchangeRevisionAssetsAssetImportAssetsFromS3), fullyQualifiedName: "aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromS3")]
    public interface IDataexchangeRevisionAssetsAssetImportAssetsFromS3
    {
        /// <summary>asset_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#asset_source DataexchangeRevisionAssets#asset_source}
        /// </remarks>
        [JsiiProperty(name: "assetSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromS3AssetSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AssetSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataexchangeRevisionAssetsAssetImportAssetsFromS3), fullyQualifiedName: "aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromS3")]
        internal sealed class _Proxy : DeputyBase, aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAssetImportAssetsFromS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>asset_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#asset_source DataexchangeRevisionAssets#asset_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assetSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromS3AssetSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AssetSource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
