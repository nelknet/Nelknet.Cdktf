using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontResponseHeadersPolicy
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigOutputReference), fullyQualifiedName: "aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontResponseHeadersPolicyCorsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontResponseHeadersPolicyCorsConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudfrontResponseHeadersPolicyCorsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontResponseHeadersPolicyCorsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccessControlAllowHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders\"}}]")]
        public virtual void PutAccessControlAllowHeaders(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAccessControlAllowMethods", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods\"}}]")]
        public virtual void PutAccessControlAllowMethods(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAccessControlAllowOrigins", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins\"}}]")]
        public virtual void PutAccessControlAllowOrigins(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAccessControlExposeHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders\"}}]")]
        public virtual void PutAccessControlExposeHeaders(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessControlExposeHeaders")]
        public virtual void ResetAccessControlExposeHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccessControlMaxAgeSec")]
        public virtual void ResetAccessControlMaxAgeSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accessControlAllowHeaders", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeadersOutputReference\"}")]
        public virtual aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeadersOutputReference AccessControlAllowHeaders
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeadersOutputReference>()!;
        }

        [JsiiProperty(name: "accessControlAllowMethods", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethodsOutputReference\"}")]
        public virtual aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethodsOutputReference AccessControlAllowMethods
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethodsOutputReference>()!;
        }

        [JsiiProperty(name: "accessControlAllowOrigins", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOriginsOutputReference\"}")]
        public virtual aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOriginsOutputReference AccessControlAllowOrigins
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOriginsOutputReference>()!;
        }

        [JsiiProperty(name: "accessControlExposeHeaders", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeadersOutputReference\"}")]
        public virtual aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeadersOutputReference AccessControlExposeHeaders
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeadersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlAllowCredentialsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AccessControlAllowCredentialsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlAllowHeadersInput", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders\"}", isOptional: true)]
        public virtual aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders? AccessControlAllowHeadersInput
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlAllowMethodsInput", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods\"}", isOptional: true)]
        public virtual aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods? AccessControlAllowMethodsInput
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlAllowOriginsInput", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins\"}", isOptional: true)]
        public virtual aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins? AccessControlAllowOriginsInput
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlExposeHeadersInput", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders\"}", isOptional: true)]
        public virtual aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders? AccessControlExposeHeadersInput
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlMaxAgeSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AccessControlMaxAgeSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originOverrideInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OriginOverrideInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accessControlAllowCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AccessControlAllowCredentials
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "accessControlMaxAgeSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AccessControlMaxAgeSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object OriginOverride
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
