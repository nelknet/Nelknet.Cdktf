using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDeviceFleet
{
    [JsiiInterface(nativeType: typeof(ISagemakerDeviceFleetOutputConfig), fullyQualifiedName: "aws.sagemakerDeviceFleet.SagemakerDeviceFleetOutputConfig")]
    public interface ISagemakerDeviceFleetOutputConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#s3_output_location SagemakerDeviceFleet#s3_output_location}.</summary>
        [JsiiProperty(name: "s3OutputLocation", typeJson: "{\"primitive\":\"string\"}")]
        string S3OutputLocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#kms_key_id SagemakerDeviceFleet#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDeviceFleetOutputConfig), fullyQualifiedName: "aws.sagemakerDeviceFleet.SagemakerDeviceFleetOutputConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDeviceFleet.ISagemakerDeviceFleetOutputConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#s3_output_location SagemakerDeviceFleet#s3_output_location}.</summary>
            [JsiiProperty(name: "s3OutputLocation", typeJson: "{\"primitive\":\"string\"}")]
            public string S3OutputLocation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#kms_key_id SagemakerDeviceFleet#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
