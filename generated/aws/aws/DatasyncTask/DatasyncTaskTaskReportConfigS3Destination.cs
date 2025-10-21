using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasyncTask.DatasyncTaskTaskReportConfigS3Destination")]
    public class DatasyncTaskTaskReportConfigS3Destination : aws.DatasyncTask.IDatasyncTaskTaskReportConfigS3Destination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#bucket_access_role_arn DatasyncTask#bucket_access_role_arn}.</summary>
        [JsiiProperty(name: "bucketAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketAccessRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#s3_bucket_arn DatasyncTask#s3_bucket_arn}.</summary>
        [JsiiProperty(name: "s3BucketArn", typeJson: "{\"primitive\":\"string\"}")]
        public string S3BucketArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#subdirectory DatasyncTask#subdirectory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Subdirectory
        {
            get;
            set;
        }
    }
}
