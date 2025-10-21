using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiClass(nativeType: typeof(aws.KendraDataSource.KendraDataSourceConfigurationOutputReference), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KendraDataSourceConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KendraDataSourceConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraDataSourceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraDataSourceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Configuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationS3Configuration\"}}]")]
        public virtual void PutS3Configuration(aws.KendraDataSource.IKendraDataSourceConfigurationS3Configuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraDataSource.IKendraDataSourceConfigurationS3Configuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTemplateConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationTemplateConfiguration\"}}]")]
        public virtual void PutTemplateConfiguration(aws.KendraDataSource.IKendraDataSourceConfigurationTemplateConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraDataSource.IKendraDataSourceConfigurationTemplateConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebCrawlerConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfiguration\"}}]")]
        public virtual void PutWebCrawlerConfiguration(aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetS3Configuration")]
        public virtual void ResetS3Configuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTemplateConfiguration")]
        public virtual void ResetTemplateConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebCrawlerConfiguration")]
        public virtual void ResetWebCrawlerConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationS3ConfigurationOutputReference\"}")]
        public virtual aws.KendraDataSource.KendraDataSourceConfigurationS3ConfigurationOutputReference S3Configuration
        {
            get => GetInstanceProperty<aws.KendraDataSource.KendraDataSourceConfigurationS3ConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "templateConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationTemplateConfigurationOutputReference\"}")]
        public virtual aws.KendraDataSource.KendraDataSourceConfigurationTemplateConfigurationOutputReference TemplateConfiguration
        {
            get => GetInstanceProperty<aws.KendraDataSource.KendraDataSourceConfigurationTemplateConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "webCrawlerConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationOutputReference\"}")]
        public virtual aws.KendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationOutputReference WebCrawlerConfiguration
        {
            get => GetInstanceProperty<aws.KendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationS3Configuration\"}", isOptional: true)]
        public virtual aws.KendraDataSource.IKendraDataSourceConfigurationS3Configuration? S3ConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationS3Configuration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "templateConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationTemplateConfiguration\"}", isOptional: true)]
        public virtual aws.KendraDataSource.IKendraDataSourceConfigurationTemplateConfiguration? TemplateConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationTemplateConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webCrawlerConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfiguration\"}", isOptional: true)]
        public virtual aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfiguration? WebCrawlerConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfiguration\"}", isOptional: true)]
        public virtual aws.KendraDataSource.IKendraDataSourceConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
