using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    [JsiiClass(nativeType: typeof(aws.SagemakerWorkteam.SagemakerWorkteamMemberDefinitionOutputReference), fullyQualifiedName: "aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerWorkteamMemberDefinitionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SagemakerWorkteamMemberDefinitionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerWorkteamMemberDefinitionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerWorkteamMemberDefinitionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCognitoMemberDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionCognitoMemberDefinition\"}}]")]
        public virtual void PutCognitoMemberDefinition(aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOidcMemberDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionOidcMemberDefinition\"}}]")]
        public virtual void PutOidcMemberDefinition(aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCognitoMemberDefinition")]
        public virtual void ResetCognitoMemberDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidcMemberDefinition")]
        public virtual void ResetOidcMemberDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cognitoMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionCognitoMemberDefinitionOutputReference\"}")]
        public virtual aws.SagemakerWorkteam.SagemakerWorkteamMemberDefinitionCognitoMemberDefinitionOutputReference CognitoMemberDefinition
        {
            get => GetInstanceProperty<aws.SagemakerWorkteam.SagemakerWorkteamMemberDefinitionCognitoMemberDefinitionOutputReference>()!;
        }

        [JsiiProperty(name: "oidcMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionOidcMemberDefinitionOutputReference\"}")]
        public virtual aws.SagemakerWorkteam.SagemakerWorkteamMemberDefinitionOidcMemberDefinitionOutputReference OidcMemberDefinition
        {
            get => GetInstanceProperty<aws.SagemakerWorkteam.SagemakerWorkteamMemberDefinitionOidcMemberDefinitionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cognitoMemberDefinitionInput", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionCognitoMemberDefinition\"}", isOptional: true)]
        public virtual aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinitionInput
        {
            get => GetInstanceProperty<aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcMemberDefinitionInput", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionOidcMemberDefinition\"}", isOptional: true)]
        public virtual aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition? OidcMemberDefinitionInput
        {
            get => GetInstanceProperty<aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinition\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinition cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinition).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
