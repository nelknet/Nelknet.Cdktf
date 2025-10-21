using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationDataCaptureConfig")]
    public class SagemakerEndpointConfigurationDataCaptureConfig : aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationDataCaptureConfig
    {
        private object _captureOptions;

        /// <summary>capture_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#capture_options SagemakerEndpointConfiguration#capture_options}
        /// </remarks>
        [JsiiProperty(name: "captureOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationDataCaptureConfigCaptureOptions\"},\"kind\":\"array\"}}]}}")]
        public object CaptureOptions
        {
            get => _captureOptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _captureOptions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#destination_s3_uri SagemakerEndpointConfiguration#destination_s3_uri}.</summary>
        [JsiiProperty(name: "destinationS3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationS3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#initial_sampling_percentage SagemakerEndpointConfiguration#initial_sampling_percentage}.</summary>
        [JsiiProperty(name: "initialSamplingPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public double InitialSamplingPercentage
        {
            get;
            set;
        }

        /// <summary>capture_content_type_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#capture_content_type_header SagemakerEndpointConfiguration#capture_content_type_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captureContentTypeHeader", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader\"}", isOptional: true)]
        public aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader? CaptureContentTypeHeader
        {
            get;
            set;
        }

        private object? _enableCapture;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#enable_capture SagemakerEndpointConfiguration#enable_capture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableCapture", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableCapture
        {
            get => _enableCapture;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableCapture = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#kms_key_id SagemakerEndpointConfiguration#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }
    }
}
