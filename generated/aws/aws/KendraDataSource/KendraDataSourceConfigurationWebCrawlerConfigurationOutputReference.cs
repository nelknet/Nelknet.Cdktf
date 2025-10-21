using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiClass(nativeType: typeof(aws.KendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationOutputReference), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KendraDataSourceConfigurationWebCrawlerConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KendraDataSourceConfigurationWebCrawlerConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KendraDataSourceConfigurationWebCrawlerConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraDataSourceConfigurationWebCrawlerConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthenticationConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration\"}}]")]
        public virtual void PutAuthenticationConfiguration(aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProxyConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration\"}}]")]
        public virtual void PutProxyConfiguration(aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrls\"}}]")]
        public virtual void PutUrls(aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthenticationConfiguration")]
        public virtual void ResetAuthenticationConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCrawlDepth")]
        public virtual void ResetCrawlDepth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxContentSizePerPageInMegaBytes")]
        public virtual void ResetMaxContentSizePerPageInMegaBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxLinksPerPage")]
        public virtual void ResetMaxLinksPerPage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxUrlsPerMinuteCrawlRate")]
        public virtual void ResetMaxUrlsPerMinuteCrawlRate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProxyConfiguration")]
        public virtual void ResetProxyConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlExclusionPatterns")]
        public virtual void ResetUrlExclusionPatterns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlInclusionPatterns")]
        public virtual void ResetUrlInclusionPatterns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfigurationOutputReference\"}")]
        public virtual aws.KendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfigurationOutputReference AuthenticationConfiguration
        {
            get => GetInstanceProperty<aws.KendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "proxyConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationProxyConfigurationOutputReference\"}")]
        public virtual aws.KendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationProxyConfigurationOutputReference ProxyConfiguration
        {
            get => GetInstanceProperty<aws.KendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationProxyConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "urls", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrlsOutputReference\"}")]
        public virtual aws.KendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrlsOutputReference Urls
        {
            get => GetInstanceProperty<aws.KendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration\"}", isOptional: true)]
        public virtual aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration? AuthenticationConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "crawlDepthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CrawlDepthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxContentSizePerPageInMegaBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxContentSizePerPageInMegaBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxLinksPerPageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxLinksPerPageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxUrlsPerMinuteCrawlRateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxUrlsPerMinuteCrawlRateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "proxyConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration\"}", isOptional: true)]
        public virtual aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration? ProxyConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlExclusionPatternsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? UrlExclusionPatternsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlInclusionPatternsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? UrlInclusionPatternsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlsInput", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrls\"}", isOptional: true)]
        public virtual aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrls? UrlsInput
        {
            get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrls?>();
        }

        [JsiiProperty(name: "crawlDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CrawlDepth
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxContentSizePerPageInMegaBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxContentSizePerPageInMegaBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxLinksPerPage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxLinksPerPage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxUrlsPerMinuteCrawlRate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxUrlsPerMinuteCrawlRate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "urlExclusionPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UrlExclusionPatterns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "urlInclusionPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UrlInclusionPatterns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfiguration\"}", isOptional: true)]
        public virtual aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
