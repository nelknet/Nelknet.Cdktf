using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazoneAssetType
{
    [JsiiInterface(nativeType: typeof(IDatazoneAssetTypeFormsInput), fullyQualifiedName: "aws.datazoneAssetType.DatazoneAssetTypeFormsInput")]
    public interface IDatazoneAssetTypeFormsInput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#map_block_key DatazoneAssetType#map_block_key}.</summary>
        [JsiiProperty(name: "mapBlockKey", typeJson: "{\"primitive\":\"string\"}")]
        string MapBlockKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#type_identifier DatazoneAssetType#type_identifier}.</summary>
        [JsiiProperty(name: "typeIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string TypeIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#type_revision DatazoneAssetType#type_revision}.</summary>
        [JsiiProperty(name: "typeRevision", typeJson: "{\"primitive\":\"string\"}")]
        string TypeRevision
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#required DatazoneAssetType#required}.</summary>
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Required
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazoneAssetTypeFormsInput), fullyQualifiedName: "aws.datazoneAssetType.DatazoneAssetTypeFormsInput")]
        internal sealed class _Proxy : DeputyBase, aws.DatazoneAssetType.IDatazoneAssetTypeFormsInput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#map_block_key DatazoneAssetType#map_block_key}.</summary>
            [JsiiProperty(name: "mapBlockKey", typeJson: "{\"primitive\":\"string\"}")]
            public string MapBlockKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#type_identifier DatazoneAssetType#type_identifier}.</summary>
            [JsiiProperty(name: "typeIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string TypeIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#type_revision DatazoneAssetType#type_revision}.</summary>
            [JsiiProperty(name: "typeRevision", typeJson: "{\"primitive\":\"string\"}")]
            public string TypeRevision
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#required DatazoneAssetType#required}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Required
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
