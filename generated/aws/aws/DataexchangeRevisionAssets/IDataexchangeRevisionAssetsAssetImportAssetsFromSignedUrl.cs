using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeRevisionAssets
{
    [JsiiInterface(nativeType: typeof(IDataexchangeRevisionAssetsAssetImportAssetsFromSignedUrl), fullyQualifiedName: "aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromSignedUrl")]
    public interface IDataexchangeRevisionAssetsAssetImportAssetsFromSignedUrl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#filename DataexchangeRevisionAssets#filename}.</summary>
        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}")]
        string Filename
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataexchangeRevisionAssetsAssetImportAssetsFromSignedUrl), fullyQualifiedName: "aws.dataexchangeRevisionAssets.DataexchangeRevisionAssetsAssetImportAssetsFromSignedUrl")]
        internal sealed class _Proxy : DeputyBase, aws.DataexchangeRevisionAssets.IDataexchangeRevisionAssetsAssetImportAssetsFromSignedUrl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#filename DataexchangeRevisionAssets#filename}.</summary>
            [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}")]
            public string Filename
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
