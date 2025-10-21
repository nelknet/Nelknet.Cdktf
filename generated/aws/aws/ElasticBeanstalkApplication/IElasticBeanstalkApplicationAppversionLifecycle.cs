using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticBeanstalkApplication
{
    [JsiiInterface(nativeType: typeof(IElasticBeanstalkApplicationAppversionLifecycle), fullyQualifiedName: "aws.elasticBeanstalkApplication.ElasticBeanstalkApplicationAppversionLifecycle")]
    public interface IElasticBeanstalkApplicationAppversionLifecycle
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#service_role ElasticBeanstalkApplication#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRole
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#delete_source_from_s3 ElasticBeanstalkApplication#delete_source_from_s3}.</summary>
        [JsiiProperty(name: "deleteSourceFromS3", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteSourceFromS3
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#max_age_in_days ElasticBeanstalkApplication#max_age_in_days}.</summary>
        [JsiiProperty(name: "maxAgeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAgeInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#max_count ElasticBeanstalkApplication#max_count}.</summary>
        [JsiiProperty(name: "maxCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticBeanstalkApplicationAppversionLifecycle), fullyQualifiedName: "aws.elasticBeanstalkApplication.ElasticBeanstalkApplicationAppversionLifecycle")]
        internal sealed class _Proxy : DeputyBase, aws.ElasticBeanstalkApplication.IElasticBeanstalkApplicationAppversionLifecycle
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#service_role ElasticBeanstalkApplication#service_role}.</summary>
            [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#delete_source_from_s3 ElasticBeanstalkApplication#delete_source_from_s3}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteSourceFromS3", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteSourceFromS3
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#max_age_in_days ElasticBeanstalkApplication#max_age_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxAgeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAgeInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#max_count ElasticBeanstalkApplication#max_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
