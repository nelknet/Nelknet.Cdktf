using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderDistributionConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionS3ExportConfiguration")]
    public class ImagebuilderDistributionConfigurationDistributionS3ExportConfiguration : aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionS3ExportConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#disk_image_format ImagebuilderDistributionConfiguration#disk_image_format}.</summary>
        [JsiiProperty(name: "diskImageFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string DiskImageFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#role_name ImagebuilderDistributionConfiguration#role_name}.</summary>
        [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#s3_bucket ImagebuilderDistributionConfiguration#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#s3_prefix ImagebuilderDistributionConfiguration#s3_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Prefix
        {
            get;
            set;
        }
    }
}
