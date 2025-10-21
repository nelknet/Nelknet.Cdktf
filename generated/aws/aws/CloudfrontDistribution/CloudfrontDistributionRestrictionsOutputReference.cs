using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontDistribution.CloudfrontDistributionRestrictionsOutputReference), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionRestrictionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontDistributionRestrictionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontDistributionRestrictionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudfrontDistributionRestrictionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionRestrictionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGeoRestriction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionRestrictionsGeoRestriction\"}}]")]
        public virtual void PutGeoRestriction(aws.CloudfrontDistribution.ICloudfrontDistributionRestrictionsGeoRestriction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontDistribution.ICloudfrontDistributionRestrictionsGeoRestriction)}, new object[]{@value});
        }

        [JsiiProperty(name: "geoRestriction", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionRestrictionsGeoRestrictionOutputReference\"}")]
        public virtual aws.CloudfrontDistribution.CloudfrontDistributionRestrictionsGeoRestrictionOutputReference GeoRestriction
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.CloudfrontDistributionRestrictionsGeoRestrictionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoRestrictionInput", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionRestrictionsGeoRestriction\"}", isOptional: true)]
        public virtual aws.CloudfrontDistribution.ICloudfrontDistributionRestrictionsGeoRestriction? GeoRestrictionInput
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionRestrictionsGeoRestriction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionRestrictions\"}", isOptional: true)]
        public virtual aws.CloudfrontDistribution.ICloudfrontDistributionRestrictions? InternalValue
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionRestrictions?>();
            set => SetInstanceProperty(value);
        }
    }
}
