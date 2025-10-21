using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontDistribution.CloudfrontDistributionOriginOutputReference), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionOriginOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontDistributionOriginOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CloudfrontDistributionOriginOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CloudfrontDistributionOriginOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionOriginOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomHeader\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomHeader(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomHeader[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomHeader).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomHeader).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomOriginConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomOriginConfig\"}}]")]
        public virtual void PutCustomOriginConfig(aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomOriginConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomOriginConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOriginShield", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginOriginShield\"}}]")]
        public virtual void PutOriginShield(aws.CloudfrontDistribution.ICloudfrontDistributionOriginOriginShield @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginOriginShield)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3OriginConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginS3OriginConfig\"}}]")]
        public virtual void PutS3OriginConfig(aws.CloudfrontDistribution.ICloudfrontDistributionOriginS3OriginConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginS3OriginConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcOriginConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginVpcOriginConfig\"}}]")]
        public virtual void PutVpcOriginConfig(aws.CloudfrontDistribution.ICloudfrontDistributionOriginVpcOriginConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginVpcOriginConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectionAttempts")]
        public virtual void ResetConnectionAttempts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionTimeout")]
        public virtual void ResetConnectionTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomHeader")]
        public virtual void ResetCustomHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomOriginConfig")]
        public virtual void ResetCustomOriginConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginAccessControlId")]
        public virtual void ResetOriginAccessControlId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginPath")]
        public virtual void ResetOriginPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginShield")]
        public virtual void ResetOriginShield()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3OriginConfig")]
        public virtual void ResetS3OriginConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcOriginConfig")]
        public virtual void ResetVpcOriginConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customHeader", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomHeaderList\"}")]
        public virtual aws.CloudfrontDistribution.CloudfrontDistributionOriginCustomHeaderList CustomHeader
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.CloudfrontDistributionOriginCustomHeaderList>()!;
        }

        [JsiiProperty(name: "customOriginConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomOriginConfigOutputReference\"}")]
        public virtual aws.CloudfrontDistribution.CloudfrontDistributionOriginCustomOriginConfigOutputReference CustomOriginConfig
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.CloudfrontDistributionOriginCustomOriginConfigOutputReference>()!;
        }

        [JsiiProperty(name: "originShield", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginOriginShieldOutputReference\"}")]
        public virtual aws.CloudfrontDistribution.CloudfrontDistributionOriginOriginShieldOutputReference OriginShield
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.CloudfrontDistributionOriginOriginShieldOutputReference>()!;
        }

        [JsiiProperty(name: "s3OriginConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginS3OriginConfigOutputReference\"}")]
        public virtual aws.CloudfrontDistribution.CloudfrontDistributionOriginS3OriginConfigOutputReference S3OriginConfig
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.CloudfrontDistributionOriginS3OriginConfigOutputReference>()!;
        }

        [JsiiProperty(name: "vpcOriginConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginVpcOriginConfigOutputReference\"}")]
        public virtual aws.CloudfrontDistribution.CloudfrontDistributionOriginVpcOriginConfigOutputReference VpcOriginConfig
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.CloudfrontDistributionOriginVpcOriginConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionAttemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConnectionAttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConnectionTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customHeaderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomHeaderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customOriginConfigInput", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomOriginConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomOriginConfig? CustomOriginConfigInput
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomOriginConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originAccessControlIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginAccessControlIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originShieldInput", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginOriginShield\"}", isOptional: true)]
        public virtual aws.CloudfrontDistribution.ICloudfrontDistributionOriginOriginShield? OriginShieldInput
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionOriginOriginShield?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3OriginConfigInput", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginS3OriginConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontDistribution.ICloudfrontDistributionOriginS3OriginConfig? S3OriginConfigInput
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionOriginS3OriginConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcOriginConfigInput", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginVpcOriginConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontDistribution.ICloudfrontDistributionOriginVpcOriginConfig? VpcOriginConfigInput
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionOriginVpcOriginConfig?>();
        }

        [JsiiProperty(name: "connectionAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectionAttempts
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectionTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originAccessControlId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAccessControlId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOrigin\"}]}}", isOptional: true)]
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
                        case aws.CloudfrontDistribution.ICloudfrontDistributionOrigin cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOrigin).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
