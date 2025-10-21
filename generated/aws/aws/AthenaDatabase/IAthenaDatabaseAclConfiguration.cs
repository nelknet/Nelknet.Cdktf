using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaDatabase
{
    [JsiiInterface(nativeType: typeof(IAthenaDatabaseAclConfiguration), fullyQualifiedName: "aws.athenaDatabase.AthenaDatabaseAclConfiguration")]
    public interface IAthenaDatabaseAclConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#s3_acl_option AthenaDatabase#s3_acl_option}.</summary>
        [JsiiProperty(name: "s3AclOption", typeJson: "{\"primitive\":\"string\"}")]
        string S3AclOption
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaDatabaseAclConfiguration), fullyQualifiedName: "aws.athenaDatabase.AthenaDatabaseAclConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AthenaDatabase.IAthenaDatabaseAclConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#s3_acl_option AthenaDatabase#s3_acl_option}.</summary>
            [JsiiProperty(name: "s3AclOption", typeJson: "{\"primitive\":\"string\"}")]
            public string S3AclOption
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
