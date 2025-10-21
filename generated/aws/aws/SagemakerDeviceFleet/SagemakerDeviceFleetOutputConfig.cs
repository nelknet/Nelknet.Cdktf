using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDeviceFleet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerDeviceFleet.SagemakerDeviceFleetOutputConfig")]
    public class SagemakerDeviceFleetOutputConfig : aws.SagemakerDeviceFleet.ISagemakerDeviceFleetOutputConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#s3_output_location SagemakerDeviceFleet#s3_output_location}.</summary>
        [JsiiProperty(name: "s3OutputLocation", typeJson: "{\"primitive\":\"string\"}")]
        public string S3OutputLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#kms_key_id SagemakerDeviceFleet#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }
    }
}
