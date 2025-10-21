using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiClass(nativeType: typeof(aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesOutputReference), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppflowFlowSourceFlowConfigSourceConnectorPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppflowFlowSourceFlowConfigSourceConnectorPropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppflowFlowSourceFlowConfigSourceConnectorPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppflowFlowSourceFlowConfigSourceConnectorPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAmplitude", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesAmplitude\"}}]")]
        public virtual void PutAmplitude(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesAmplitude @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesAmplitude)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomConnector", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesCustomConnector\"}}]")]
        public virtual void PutCustomConnector(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesCustomConnector @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesCustomConnector)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatadog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadog\"}}]")]
        public virtual void PutDatadog(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDynatrace", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesDynatrace\"}}]")]
        public virtual void PutDynatrace(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesDynatrace @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesDynatrace)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGoogleAnalytics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics\"}}]")]
        public virtual void PutGoogleAnalytics(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInforNexus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesInforNexus\"}}]")]
        public virtual void PutInforNexus(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesInforNexus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesInforNexus)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMarketo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesMarketo\"}}]")]
        public virtual void PutMarketo(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesMarketo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesMarketo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3\"}}]")]
        public virtual void PutS3(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSalesforce", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSalesforce\"}}]")]
        public virtual void PutSalesforce(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSalesforce @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSalesforce)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSapoData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData\"}}]")]
        public virtual void PutSapoData(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceNow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesServiceNow\"}}]")]
        public virtual void PutServiceNow(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesServiceNow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesServiceNow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSingular", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSingular\"}}]")]
        public virtual void PutSingular(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSingular @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSingular)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlack", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSlack\"}}]")]
        public virtual void PutSlack(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSlack @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSlack)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrendmicro", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesTrendmicro\"}}]")]
        public virtual void PutTrendmicro(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesTrendmicro @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesTrendmicro)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVeeva", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesVeeva\"}}]")]
        public virtual void PutVeeva(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesVeeva @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesVeeva)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZendesk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesZendesk\"}}]")]
        public virtual void PutZendesk(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesZendesk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesZendesk)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmplitude")]
        public virtual void ResetAmplitude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomConnector")]
        public virtual void ResetCustomConnector()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatadog")]
        public virtual void ResetDatadog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynatrace")]
        public virtual void ResetDynatrace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGoogleAnalytics")]
        public virtual void ResetGoogleAnalytics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInforNexus")]
        public virtual void ResetInforNexus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMarketo")]
        public virtual void ResetMarketo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSalesforce")]
        public virtual void ResetSalesforce()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSapoData")]
        public virtual void ResetSapoData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceNow")]
        public virtual void ResetServiceNow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSingular")]
        public virtual void ResetSingular()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlack")]
        public virtual void ResetSlack()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrendmicro")]
        public virtual void ResetTrendmicro()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVeeva")]
        public virtual void ResetVeeva()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZendesk")]
        public virtual void ResetZendesk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "amplitude", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesAmplitudeOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesAmplitudeOutputReference Amplitude
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesAmplitudeOutputReference>()!;
        }

        [JsiiProperty(name: "customConnector", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesCustomConnectorOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesCustomConnectorOutputReference CustomConnector
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesCustomConnectorOutputReference>()!;
        }

        [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadogOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadogOutputReference Datadog
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadogOutputReference>()!;
        }

        [JsiiProperty(name: "dynatrace", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesDynatraceOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesDynatraceOutputReference Dynatrace
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesDynatraceOutputReference>()!;
        }

        [JsiiProperty(name: "googleAnalytics", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesGoogleAnalyticsOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesGoogleAnalyticsOutputReference GoogleAnalytics
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesGoogleAnalyticsOutputReference>()!;
        }

        [JsiiProperty(name: "inforNexus", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesInforNexusOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesInforNexusOutputReference InforNexus
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesInforNexusOutputReference>()!;
        }

        [JsiiProperty(name: "marketo", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesMarketoOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesMarketoOutputReference Marketo
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesMarketoOutputReference>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3OutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3OutputReference S3
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3OutputReference>()!;
        }

        [JsiiProperty(name: "salesforce", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSalesforceOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSalesforceOutputReference Salesforce
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSalesforceOutputReference>()!;
        }

        [JsiiProperty(name: "sapoData", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataOutputReference SapoData
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataOutputReference>()!;
        }

        [JsiiProperty(name: "serviceNow", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesServiceNowOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesServiceNowOutputReference ServiceNow
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesServiceNowOutputReference>()!;
        }

        [JsiiProperty(name: "singular", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSingularOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSingularOutputReference Singular
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSingularOutputReference>()!;
        }

        [JsiiProperty(name: "slack", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSlackOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSlackOutputReference Slack
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSlackOutputReference>()!;
        }

        [JsiiProperty(name: "trendmicro", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesTrendmicroOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesTrendmicroOutputReference Trendmicro
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesTrendmicroOutputReference>()!;
        }

        [JsiiProperty(name: "veeva", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesVeevaOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesVeevaOutputReference Veeva
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesVeevaOutputReference>()!;
        }

        [JsiiProperty(name: "zendesk", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesZendeskOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesZendeskOutputReference Zendesk
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesZendeskOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amplitudeInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesAmplitude\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesAmplitude? AmplitudeInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesAmplitude?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customConnectorInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesCustomConnector\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesCustomConnector? CustomConnectorInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesCustomConnector?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "datadogInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadog\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadog? DatadogInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesDatadog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynatraceInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesDynatrace\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesDynatrace? DynatraceInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesDynatrace?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "googleAnalyticsInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics? GoogleAnalyticsInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inforNexusInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesInforNexus\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesInforNexus? InforNexusInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesInforNexus?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "marketoInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesMarketo\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesMarketo? MarketoInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesMarketo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3? S3Input
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "salesforceInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSalesforce\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSalesforce? SalesforceInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSalesforce?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sapoDataInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData? SapoDataInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoData?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNowInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesServiceNow\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesServiceNow? ServiceNowInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesServiceNow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singularInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSingular\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSingular? SingularInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSingular?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slackInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSlack\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSlack? SlackInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSlack?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trendmicroInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesTrendmicro\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesTrendmicro? TrendmicroInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesTrendmicro?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "veevaInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesVeeva\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesVeeva? VeevaInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesVeeva?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zendeskInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesZendesk\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesZendesk? ZendeskInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesZendesk?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorProperties\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorProperties? InternalValue
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
