using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LighthouseDefinition
{
    [JsiiClass(nativeType: typeof(azurerm.LighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyOutputReference), fullyQualifiedName: "azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApprover", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutApprover(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApprover")]
        public virtual void ResetApprover()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumActivationDuration")]
        public virtual void ResetMaximumActivationDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMultiFactorAuthProvider")]
        public virtual void ResetMultiFactorAuthProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "approver", typeJson: "{\"fqn\":\"azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApproverList\"}")]
        public virtual azurerm.LighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApproverList Approver
        {
            get => GetInstanceProperty<azurerm.LighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApproverList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "approverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ApproverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumActivationDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaximumActivationDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "multiFactorAuthProviderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MultiFactorAuthProviderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maximumActivationDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaximumActivationDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "multiFactorAuthProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MultiFactorAuthProvider
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy\"}", isOptional: true)]
        public virtual azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
