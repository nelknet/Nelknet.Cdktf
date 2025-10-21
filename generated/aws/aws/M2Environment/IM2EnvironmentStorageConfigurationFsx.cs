using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.M2Environment
{
    [JsiiInterface(nativeType: typeof(IM2EnvironmentStorageConfigurationFsx), fullyQualifiedName: "aws.m2Environment.M2EnvironmentStorageConfigurationFsx")]
    public interface IM2EnvironmentStorageConfigurationFsx
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#file_system_id M2Environment#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#mount_point M2Environment#mount_point}.</summary>
        [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}")]
        string MountPoint
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IM2EnvironmentStorageConfigurationFsx), fullyQualifiedName: "aws.m2Environment.M2EnvironmentStorageConfigurationFsx")]
        internal sealed class _Proxy : DeputyBase, aws.M2Environment.IM2EnvironmentStorageConfigurationFsx
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#file_system_id M2Environment#file_system_id}.</summary>
            [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#mount_point M2Environment#mount_point}.</summary>
            [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}")]
            public string MountPoint
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
