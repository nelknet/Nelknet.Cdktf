using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectCustomPlugin
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskconnectCustomPlugin.MskconnectCustomPluginLocationS3")]
    public class MskconnectCustomPluginLocationS3 : aws.MskconnectCustomPlugin.IMskconnectCustomPluginLocationS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#bucket_arn MskconnectCustomPlugin#bucket_arn}.</summary>
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#file_key MskconnectCustomPlugin#file_key}.</summary>
        [JsiiProperty(name: "fileKey", typeJson: "{\"primitive\":\"string\"}")]
        public string FileKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#object_version MskconnectCustomPlugin#object_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectVersion
        {
            get;
            set;
        }
    }
}
