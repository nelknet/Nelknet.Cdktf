using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlObjectLambdaAccessPoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3ControlObjectLambdaAccessPoint.S3ControlObjectLambdaAccessPointConfiguration")]
    public class S3ControlObjectLambdaAccessPointConfiguration : aws.S3ControlObjectLambdaAccessPoint.IS3ControlObjectLambdaAccessPointConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point#supporting_access_point S3ControlObjectLambdaAccessPoint#supporting_access_point}.</summary>
        [JsiiProperty(name: "supportingAccessPoint", typeJson: "{\"primitive\":\"string\"}")]
        public string SupportingAccessPoint
        {
            get;
            set;
        }

        private object _transformationConfiguration;

        /// <summary>transformation_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point#transformation_configuration S3ControlObjectLambdaAccessPoint#transformation_configuration}
        /// </remarks>
        [JsiiProperty(name: "transformationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3ControlObjectLambdaAccessPoint.S3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration\"},\"kind\":\"array\"}}]}}")]
        public object TransformationConfiguration
        {
            get => _transformationConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.S3ControlObjectLambdaAccessPoint.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3ControlObjectLambdaAccessPoint.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3ControlObjectLambdaAccessPoint.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _transformationConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point#allowed_features S3ControlObjectLambdaAccessPoint#allowed_features}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedFeatures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedFeatures
        {
            get;
            set;
        }

        private object? _cloudWatchMetricsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point#cloud_watch_metrics_enabled S3ControlObjectLambdaAccessPoint#cloud_watch_metrics_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudWatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CloudWatchMetricsEnabled
        {
            get => _cloudWatchMetricsEnabled;
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
                _cloudWatchMetricsEnabled = value;
            }
        }
    }
}
