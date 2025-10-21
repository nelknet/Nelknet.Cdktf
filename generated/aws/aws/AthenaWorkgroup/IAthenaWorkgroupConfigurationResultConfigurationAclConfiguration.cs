using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfigurationResultConfigurationAclConfiguration), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationResultConfigurationAclConfiguration")]
    public interface IAthenaWorkgroupConfigurationResultConfigurationAclConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#s3_acl_option AthenaWorkgroup#s3_acl_option}.</summary>
        [JsiiProperty(name: "s3AclOption", typeJson: "{\"primitive\":\"string\"}")]
        string S3AclOption
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfigurationResultConfigurationAclConfiguration), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationResultConfigurationAclConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationResultConfigurationAclConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#s3_acl_option AthenaWorkgroup#s3_acl_option}.</summary>
            [JsiiProperty(name: "s3AclOption", typeJson: "{\"primitive\":\"string\"}")]
            public string S3AclOption
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
