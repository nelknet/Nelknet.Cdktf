using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.athenaDatabase.AthenaDatabaseAclConfiguration")]
    public class AthenaDatabaseAclConfiguration : aws.AthenaDatabase.IAthenaDatabaseAclConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#s3_acl_option AthenaDatabase#s3_acl_option}.</summary>
        [JsiiProperty(name: "s3AclOption", typeJson: "{\"primitive\":\"string\"}")]
        public string S3AclOption
        {
            get;
            set;
        }
    }
}
