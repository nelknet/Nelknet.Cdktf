using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53Record
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordGeoproximityRoutingPolicyCoordinates), fullyQualifiedName: "aws.route53Record.Route53RecordGeoproximityRoutingPolicyCoordinates")]
    public interface IRoute53RecordGeoproximityRoutingPolicyCoordinates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#latitude Route53Record#latitude}.</summary>
        [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"string\"}")]
        string Latitude
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#longitude Route53Record#longitude}.</summary>
        [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"string\"}")]
        string Longitude
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordGeoproximityRoutingPolicyCoordinates), fullyQualifiedName: "aws.route53Record.Route53RecordGeoproximityRoutingPolicyCoordinates")]
        internal sealed class _Proxy : DeputyBase, aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicyCoordinates
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#latitude Route53Record#latitude}.</summary>
            [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"string\"}")]
            public string Latitude
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#longitude Route53Record#longitude}.</summary>
            [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"string\"}")]
            public string Longitude
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
