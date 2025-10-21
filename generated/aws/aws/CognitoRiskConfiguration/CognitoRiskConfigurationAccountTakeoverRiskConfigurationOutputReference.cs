using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    [JsiiClass(nativeType: typeof(aws.CognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationOutputReference), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CognitoRiskConfigurationAccountTakeoverRiskConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CognitoRiskConfigurationAccountTakeoverRiskConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CognitoRiskConfigurationAccountTakeoverRiskConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoRiskConfigurationAccountTakeoverRiskConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActions\"}}]")]
        public virtual void PutActions(aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotifyConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfiguration\"}}]")]
        public virtual void PutNotifyConfiguration(aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfiguration)}, new object[]{@value});
        }

        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsOutputReference\"}")]
        public virtual aws.CognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsOutputReference Actions
        {
            get => GetInstanceProperty<aws.CognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsOutputReference>()!;
        }

        [JsiiProperty(name: "notifyConfiguration", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationOutputReference\"}")]
        public virtual aws.CognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationOutputReference NotifyConfiguration
        {
            get => GetInstanceProperty<aws.CognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionsInput", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActions\"}", isOptional: true)]
        public virtual aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActions? ActionsInput
        {
            get => GetInstanceProperty<aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notifyConfigurationInput", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfiguration\"}", isOptional: true)]
        public virtual aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfiguration? NotifyConfigurationInput
        {
            get => GetInstanceProperty<aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfiguration\"}", isOptional: true)]
        public virtual aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
