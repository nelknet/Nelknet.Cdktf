using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlMultiRegionAccessPoint
{
    [JsiiClass(nativeType: typeof(aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsOutputReference), fullyQualifiedName: "aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3ControlMultiRegionAccessPointDetailsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3ControlMultiRegionAccessPointDetailsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3ControlMultiRegionAccessPointDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlMultiRegionAccessPointDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPublicAccessBlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsPublicAccessBlock\"}}]")]
        public virtual void PutPublicAccessBlock(aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegion", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsRegion\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRegion(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsRegion[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsRegion).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsRegion).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPublicAccessBlock")]
        public virtual void ResetPublicAccessBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "publicAccessBlock", typeJson: "{\"fqn\":\"aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsPublicAccessBlockOutputReference\"}")]
        public virtual aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsPublicAccessBlockOutputReference PublicAccessBlock
        {
            get => GetInstanceProperty<aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsPublicAccessBlockOutputReference>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"fqn\":\"aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsRegionList\"}")]
        public virtual aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsRegionList Region
        {
            get => GetInstanceProperty<aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsRegionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicAccessBlockInput", typeJson: "{\"fqn\":\"aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsPublicAccessBlock\"}", isOptional: true)]
        public virtual aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock? PublicAccessBlockInput
        {
            get => GetInstanceProperty<aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RegionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetails\"}", isOptional: true)]
        public virtual aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetails? InternalValue
        {
            get => GetInstanceProperty<aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
