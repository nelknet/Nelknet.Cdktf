using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOpenzfsVolume
{
    [JsiiInterface(nativeType: typeof(IFsxOpenzfsVolumeNfsExports), fullyQualifiedName: "aws.fsxOpenzfsVolume.FsxOpenzfsVolumeNfsExports")]
    public interface IFsxOpenzfsVolumeNfsExports
    {
        /// <summary>client_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#client_configurations FsxOpenzfsVolume#client_configurations}
        /// </remarks>
        [JsiiProperty(name: "clientConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxOpenzfsVolume.FsxOpenzfsVolumeNfsExportsClientConfigurations\"},\"kind\":\"array\"}}]}}")]
        object ClientConfigurations
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOpenzfsVolumeNfsExports), fullyQualifiedName: "aws.fsxOpenzfsVolume.FsxOpenzfsVolumeNfsExports")]
        internal sealed class _Proxy : DeputyBase, aws.FsxOpenzfsVolume.IFsxOpenzfsVolumeNfsExports
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_configurations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#client_configurations FsxOpenzfsVolume#client_configurations}
            /// </remarks>
            [JsiiProperty(name: "clientConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxOpenzfsVolume.FsxOpenzfsVolumeNfsExportsClientConfigurations\"},\"kind\":\"array\"}}]}}")]
            public object ClientConfigurations
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
