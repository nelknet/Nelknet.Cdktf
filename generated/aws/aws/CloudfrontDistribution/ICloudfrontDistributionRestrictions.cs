using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionRestrictions), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionRestrictions")]
    public interface ICloudfrontDistributionRestrictions
    {
        /// <summary>geo_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#geo_restriction CloudfrontDistribution#geo_restriction}
        /// </remarks>
        [JsiiProperty(name: "geoRestriction", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionRestrictionsGeoRestriction\"}")]
        aws.CloudfrontDistribution.ICloudfrontDistributionRestrictionsGeoRestriction GeoRestriction
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionRestrictions), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionRestrictions")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistribution.ICloudfrontDistributionRestrictions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>geo_restriction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#geo_restriction CloudfrontDistribution#geo_restriction}
            /// </remarks>
            [JsiiProperty(name: "geoRestriction", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionRestrictionsGeoRestriction\"}")]
            public aws.CloudfrontDistribution.ICloudfrontDistributionRestrictionsGeoRestriction GeoRestriction
            {
                get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionRestrictionsGeoRestriction>()!;
            }
        }
    }
}
