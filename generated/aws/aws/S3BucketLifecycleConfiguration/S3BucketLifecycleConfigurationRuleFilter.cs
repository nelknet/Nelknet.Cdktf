using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLifecycleConfiguration
{
    [JsiiByValue(fqn: "aws.s3BucketLifecycleConfiguration.S3BucketLifecycleConfigurationRuleFilter")]
    public class S3BucketLifecycleConfigurationRuleFilter : aws.S3BucketLifecycleConfiguration.IS3BucketLifecycleConfigurationRuleFilter
    {
        private object? _and;

        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#and S3BucketLifecycleConfiguration#and}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketLifecycleConfiguration.S3BucketLifecycleConfigurationRuleFilterAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? And
        {
            get => _and;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.S3BucketLifecycleConfiguration.IS3BucketLifecycleConfigurationRuleFilterAnd[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3BucketLifecycleConfiguration.IS3BucketLifecycleConfigurationRuleFilterAnd).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _and = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#object_size_greater_than S3BucketLifecycleConfiguration#object_size_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectSizeGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ObjectSizeGreaterThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#object_size_less_than S3BucketLifecycleConfiguration#object_size_less_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectSizeLessThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ObjectSizeLessThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#prefix S3BucketLifecycleConfiguration#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        private object? _tag;

        /// <summary>tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#tag S3BucketLifecycleConfiguration#tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketLifecycleConfiguration.S3BucketLifecycleConfigurationRuleFilterTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tag
        {
            get => _tag;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.S3BucketLifecycleConfiguration.IS3BucketLifecycleConfigurationRuleFilterTag[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3BucketLifecycleConfiguration.IS3BucketLifecycleConfigurationRuleFilterTag).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tag = value;
            }
        }
    }
}
