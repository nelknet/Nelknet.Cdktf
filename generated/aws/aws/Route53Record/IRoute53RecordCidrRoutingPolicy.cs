using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53Record
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordCidrRoutingPolicy), fullyQualifiedName: "aws.route53Record.Route53RecordCidrRoutingPolicy")]
    public interface IRoute53RecordCidrRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#collection_id Route53Record#collection_id}.</summary>
        [JsiiProperty(name: "collectionId", typeJson: "{\"primitive\":\"string\"}")]
        string CollectionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#location_name Route53Record#location_name}.</summary>
        [JsiiProperty(name: "locationName", typeJson: "{\"primitive\":\"string\"}")]
        string LocationName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordCidrRoutingPolicy), fullyQualifiedName: "aws.route53Record.Route53RecordCidrRoutingPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Route53Record.IRoute53RecordCidrRoutingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#collection_id Route53Record#collection_id}.</summary>
            [JsiiProperty(name: "collectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string CollectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#location_name Route53Record#location_name}.</summary>
            [JsiiProperty(name: "locationName", typeJson: "{\"primitive\":\"string\"}")]
            public string LocationName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
