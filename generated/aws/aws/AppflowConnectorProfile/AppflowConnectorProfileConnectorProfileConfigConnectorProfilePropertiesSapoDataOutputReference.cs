using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    [JsiiClass(nativeType: typeof(aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOutputReference), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOauthProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties\"}}]")]
        public virtual void PutOauthProperties(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLogonLanguage")]
        public virtual void ResetLogonLanguage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauthProperties")]
        public virtual void ResetOauthProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateLinkServiceName")]
        public virtual void ResetPrivateLinkServiceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "oauthProperties", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthPropertiesOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthPropertiesOutputReference OauthProperties
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthPropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationHostUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationHostUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationServicePathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationServicePathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logonLanguageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogonLanguageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthPropertiesInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties? OauthPropertiesInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portNumberInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortNumberInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateLinkServiceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateLinkServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "applicationHostUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationHostUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applicationServicePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationServicePath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logonLanguage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogonLanguage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "portNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PortNumber
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateLinkServiceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateLinkServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData? InternalValue
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData?>();
            set => SetInstanceProperty(value);
        }
    }
}
