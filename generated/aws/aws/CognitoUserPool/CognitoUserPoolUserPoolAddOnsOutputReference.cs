using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiClass(nativeType: typeof(aws.CognitoUserPool.CognitoUserPoolUserPoolAddOnsOutputReference), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolUserPoolAddOnsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CognitoUserPoolUserPoolAddOnsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CognitoUserPoolUserPoolAddOnsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CognitoUserPoolUserPoolAddOnsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolUserPoolAddOnsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdvancedSecurityAdditionalFlows", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows\"}}]")]
        public virtual void PutAdvancedSecurityAdditionalFlows(aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdvancedSecurityAdditionalFlows")]
        public virtual void ResetAdvancedSecurityAdditionalFlows()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "advancedSecurityAdditionalFlows", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlowsOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlowsOutputReference AdvancedSecurityAdditionalFlows
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlowsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedSecurityAdditionalFlowsInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows? AdvancedSecurityAdditionalFlowsInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedSecurityModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdvancedSecurityModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "advancedSecurityMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdvancedSecurityMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOns\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOns? InternalValue
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOns?>();
            set => SetInstanceProperty(value);
        }
    }
}
