using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOpenzfsFileSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports")]
    public class FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports : aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports
    {
        private object _clientConfigurations;

        /// <summary>client_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#client_configurations FsxOpenzfsFileSystem#client_configurations}
        /// </remarks>
        [JsiiProperty(name: "clientConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations\"},\"kind\":\"array\"}}]}}")]
        public object ClientConfigurations
        {
            get => _clientConfigurations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _clientConfigurations = value;
            }
        }
    }
}
