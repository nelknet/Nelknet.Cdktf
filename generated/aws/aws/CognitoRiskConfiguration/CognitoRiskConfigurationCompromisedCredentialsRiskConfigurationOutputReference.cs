using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    [JsiiClass(nativeType: typeof(aws.CognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationOutputReference), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions\"}}]")]
        public virtual void PutActions(aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEventFilter")]
        public virtual void ResetEventFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActionsOutputReference\"}")]
        public virtual aws.CognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActionsOutputReference Actions
        {
            get => GetInstanceProperty<aws.CognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionsInput", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions\"}", isOptional: true)]
        public virtual aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions? ActionsInput
        {
            get => GetInstanceProperty<aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventFilterInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EventFilterInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "eventFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EventFilter
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfiguration\"}", isOptional: true)]
        public virtual aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
