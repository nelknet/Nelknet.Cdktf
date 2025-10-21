using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiClass(nativeType: typeof(aws.CognitoUserPool.CognitoUserPoolAccountRecoverySettingOutputReference), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolAccountRecoverySettingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CognitoUserPoolAccountRecoverySettingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CognitoUserPoolAccountRecoverySettingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CognitoUserPoolAccountRecoverySettingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolAccountRecoverySettingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRecoveryMechanism", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySettingRecoveryMechanism\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRecoveryMechanism(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySettingRecoveryMechanism[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySettingRecoveryMechanism).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySettingRecoveryMechanism).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRecoveryMechanism")]
        public virtual void ResetRecoveryMechanism()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "recoveryMechanism", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySettingRecoveryMechanismList\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolAccountRecoverySettingRecoveryMechanismList RecoveryMechanism
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolAccountRecoverySettingRecoveryMechanismList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "recoveryMechanismInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySettingRecoveryMechanism\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RecoveryMechanismInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySetting\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySetting? InternalValue
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySetting?>();
            set => SetInstanceProperty(value);
        }
    }
}
