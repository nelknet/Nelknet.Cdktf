using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyOutputReference), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclAssociationConfigRequestBodyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Wafv2WebAclAssociationConfigRequestBodyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected Wafv2WebAclAssociationConfigRequestBodyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclAssociationConfigRequestBodyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApiGateway", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyApiGateway\"}}]")]
        public virtual void PutApiGateway(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyApiGateway @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyApiGateway)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAppRunnerService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyAppRunnerService\"}}]")]
        public virtual void PutAppRunnerService(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyAppRunnerService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyAppRunnerService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCloudfront", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCloudfront\"}}]")]
        public virtual void PutCloudfront(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCloudfront @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCloudfront)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCognitoUserPool", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCognitoUserPool\"}}]")]
        public virtual void PutCognitoUserPool(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCognitoUserPool @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCognitoUserPool)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerifiedAccessInstance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance\"}}]")]
        public virtual void PutVerifiedAccessInstance(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiGateway")]
        public virtual void ResetApiGateway()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppRunnerService")]
        public virtual void ResetAppRunnerService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudfront")]
        public virtual void ResetCloudfront()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCognitoUserPool")]
        public virtual void ResetCognitoUserPool()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifiedAccessInstance")]
        public virtual void ResetVerifiedAccessInstance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "apiGateway", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyApiGatewayOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyApiGatewayOutputReference ApiGateway
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyApiGatewayOutputReference>()!;
        }

        [JsiiProperty(name: "appRunnerService", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyAppRunnerServiceOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyAppRunnerServiceOutputReference AppRunnerService
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyAppRunnerServiceOutputReference>()!;
        }

        [JsiiProperty(name: "cloudfront", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCloudfrontOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCloudfrontOutputReference Cloudfront
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCloudfrontOutputReference>()!;
        }

        [JsiiProperty(name: "cognitoUserPool", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCognitoUserPoolOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCognitoUserPoolOutputReference CognitoUserPool
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCognitoUserPoolOutputReference>()!;
        }

        [JsiiProperty(name: "verifiedAccessInstance", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstanceOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstanceOutputReference VerifiedAccessInstance
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstanceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiGatewayInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyApiGateway\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyApiGateway? ApiGatewayInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyApiGateway?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appRunnerServiceInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyAppRunnerService\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyAppRunnerService? AppRunnerServiceInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyAppRunnerService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudfrontInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCloudfront\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCloudfront? CloudfrontInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCloudfront?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cognitoUserPoolInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCognitoUserPool\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCognitoUserPool? CognitoUserPoolInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCognitoUserPool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verifiedAccessInstanceInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance? VerifiedAccessInstanceInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBody\"}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBody cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBody).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
