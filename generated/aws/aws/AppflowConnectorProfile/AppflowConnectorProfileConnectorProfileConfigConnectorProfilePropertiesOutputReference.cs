using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    [JsiiClass(nativeType: typeof(aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesOutputReference), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAmplitude", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesAmplitude\"}}]")]
        public virtual void PutAmplitude(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesAmplitude @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesAmplitude)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomConnector", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesCustomConnector\"}}]")]
        public virtual void PutCustomConnector(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesCustomConnector @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesCustomConnector)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatadog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDatadog\"}}]")]
        public virtual void PutDatadog(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDatadog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDatadog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDynatrace", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDynatrace\"}}]")]
        public virtual void PutDynatrace(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDynatrace @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDynatrace)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGoogleAnalytics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesGoogleAnalytics\"}}]")]
        public virtual void PutGoogleAnalytics(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesGoogleAnalytics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesGoogleAnalytics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHoneycode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesHoneycode\"}}]")]
        public virtual void PutHoneycode(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesHoneycode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesHoneycode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInforNexus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesInforNexus\"}}]")]
        public virtual void PutInforNexus(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesInforNexus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesInforNexus)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMarketo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesMarketo\"}}]")]
        public virtual void PutMarketo(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesMarketo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesMarketo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedshift", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesRedshift\"}}]")]
        public virtual void PutRedshift(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesRedshift @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesRedshift)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSalesforce", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSalesforce\"}}]")]
        public virtual void PutSalesforce(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSalesforce @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSalesforce)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSapoData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData\"}}]")]
        public virtual void PutSapoData(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceNow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNow\"}}]")]
        public virtual void PutServiceNow(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSingular", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSingular\"}}]")]
        public virtual void PutSingular(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSingular @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSingular)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlack", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSlack\"}}]")]
        public virtual void PutSlack(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSlack @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSlack)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnowflake", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSnowflake\"}}]")]
        public virtual void PutSnowflake(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSnowflake @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSnowflake)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrendmicro", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesTrendmicro\"}}]")]
        public virtual void PutTrendmicro(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesTrendmicro @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesTrendmicro)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVeeva", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesVeeva\"}}]")]
        public virtual void PutVeeva(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesVeeva @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesVeeva)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZendesk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesZendesk\"}}]")]
        public virtual void PutZendesk(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesZendesk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesZendesk)}, new object[]{@value});
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

        [JsiiMethod(name: "resetHoneycode")]
        public virtual void ResetHoneycode()
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

        [JsiiMethod(name: "resetRedshift")]
        public virtual void ResetRedshift()
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

        [JsiiMethod(name: "resetSnowflake")]
        public virtual void ResetSnowflake()
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

        [JsiiProperty(name: "amplitude", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesAmplitudeOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesAmplitudeOutputReference Amplitude
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesAmplitudeOutputReference>()!;
        }

        [JsiiProperty(name: "customConnector", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesCustomConnectorOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesCustomConnectorOutputReference CustomConnector
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesCustomConnectorOutputReference>()!;
        }

        [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDatadogOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDatadogOutputReference Datadog
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDatadogOutputReference>()!;
        }

        [JsiiProperty(name: "dynatrace", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDynatraceOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDynatraceOutputReference Dynatrace
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDynatraceOutputReference>()!;
        }

        [JsiiProperty(name: "googleAnalytics", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesGoogleAnalyticsOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesGoogleAnalyticsOutputReference GoogleAnalytics
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesGoogleAnalyticsOutputReference>()!;
        }

        [JsiiProperty(name: "honeycode", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesHoneycodeOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesHoneycodeOutputReference Honeycode
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesHoneycodeOutputReference>()!;
        }

        [JsiiProperty(name: "inforNexus", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesInforNexusOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesInforNexusOutputReference InforNexus
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesInforNexusOutputReference>()!;
        }

        [JsiiProperty(name: "marketo", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesMarketoOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesMarketoOutputReference Marketo
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesMarketoOutputReference>()!;
        }

        [JsiiProperty(name: "redshift", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesRedshiftOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesRedshiftOutputReference Redshift
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesRedshiftOutputReference>()!;
        }

        [JsiiProperty(name: "salesforce", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSalesforceOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSalesforceOutputReference Salesforce
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSalesforceOutputReference>()!;
        }

        [JsiiProperty(name: "sapoData", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOutputReference SapoData
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOutputReference>()!;
        }

        [JsiiProperty(name: "serviceNow", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNowOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNowOutputReference ServiceNow
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNowOutputReference>()!;
        }

        [JsiiProperty(name: "singular", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSingularOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSingularOutputReference Singular
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSingularOutputReference>()!;
        }

        [JsiiProperty(name: "slack", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSlackOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSlackOutputReference Slack
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSlackOutputReference>()!;
        }

        [JsiiProperty(name: "snowflake", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSnowflakeOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSnowflakeOutputReference Snowflake
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSnowflakeOutputReference>()!;
        }

        [JsiiProperty(name: "trendmicro", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesTrendmicroOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesTrendmicroOutputReference Trendmicro
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesTrendmicroOutputReference>()!;
        }

        [JsiiProperty(name: "veeva", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesVeevaOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesVeevaOutputReference Veeva
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesVeevaOutputReference>()!;
        }

        [JsiiProperty(name: "zendesk", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesZendeskOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesZendeskOutputReference Zendesk
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesZendeskOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amplitudeInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesAmplitude\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesAmplitude? AmplitudeInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesAmplitude?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customConnectorInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesCustomConnector\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesCustomConnector? CustomConnectorInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesCustomConnector?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "datadogInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDatadog\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDatadog? DatadogInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDatadog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynatraceInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDynatrace\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDynatrace? DynatraceInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesDynatrace?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "googleAnalyticsInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesGoogleAnalytics\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesGoogleAnalytics? GoogleAnalyticsInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesGoogleAnalytics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "honeycodeInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesHoneycode\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesHoneycode? HoneycodeInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesHoneycode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inforNexusInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesInforNexus\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesInforNexus? InforNexusInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesInforNexus?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "marketoInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesMarketo\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesMarketo? MarketoInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesMarketo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redshiftInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesRedshift\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesRedshift? RedshiftInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesRedshift?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "salesforceInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSalesforce\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSalesforce? SalesforceInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSalesforce?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sapoDataInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData? SapoDataInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNowInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNow\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNow? ServiceNowInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singularInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSingular\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSingular? SingularInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSingular?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slackInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSlack\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSlack? SlackInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSlack?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snowflakeInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSnowflake\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSnowflake? SnowflakeInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSnowflake?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trendmicroInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesTrendmicro\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesTrendmicro? TrendmicroInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesTrendmicro?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "veevaInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesVeeva\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesVeeva? VeevaInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesVeeva?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zendeskInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesZendesk\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesZendesk? ZendeskInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesZendesk?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileProperties\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileProperties? InternalValue
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
