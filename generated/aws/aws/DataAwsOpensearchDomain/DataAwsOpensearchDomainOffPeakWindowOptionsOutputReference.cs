using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsOpensearchDomain
{
    [JsiiClass(nativeType: typeof(aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainOffPeakWindowOptionsOutputReference), fullyQualifiedName: "aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainOffPeakWindowOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsOpensearchDomainOffPeakWindowOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAwsOpensearchDomainOffPeakWindowOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataAwsOpensearchDomainOffPeakWindowOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOpensearchDomainOffPeakWindowOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Enabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "offPeakWindow", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainOffPeakWindowOptionsOffPeakWindowList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainOffPeakWindowOptionsOffPeakWindowList OffPeakWindow
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainOffPeakWindowOptionsOffPeakWindowList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainOffPeakWindowOptions\"}", isOptional: true)]
        public virtual aws.DataAwsOpensearchDomain.IDataAwsOpensearchDomainOffPeakWindowOptions? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.IDataAwsOpensearchDomainOffPeakWindowOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
