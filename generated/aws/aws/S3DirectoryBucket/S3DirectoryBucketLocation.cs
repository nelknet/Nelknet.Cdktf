using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3DirectoryBucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3DirectoryBucket.S3DirectoryBucketLocation")]
    public class S3DirectoryBucketLocation : aws.S3DirectoryBucket.IS3DirectoryBucketLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_directory_bucket#name S3DirectoryBucket#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_directory_bucket#type S3DirectoryBucket#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
