using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.M2Environment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.m2Environment.M2EnvironmentStorageConfigurationEfs")]
    public class M2EnvironmentStorageConfigurationEfs : aws.M2Environment.IM2EnvironmentStorageConfigurationEfs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#file_system_id M2Environment#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#mount_point M2Environment#mount_point}.</summary>
        [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}")]
        public string MountPoint
        {
            get;
            set;
        }
    }
}
