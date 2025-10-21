using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecordsExclusive
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordsExclusiveResourceRecordSetCidrRoutingConfig), fullyQualifiedName: "aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetCidrRoutingConfig")]
    public interface IRoute53RecordsExclusiveResourceRecordSetCidrRoutingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#collection_id Route53RecordsExclusive#collection_id}.</summary>
        [JsiiProperty(name: "collectionId", typeJson: "{\"primitive\":\"string\"}")]
        string CollectionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#location_name Route53RecordsExclusive#location_name}.</summary>
        [JsiiProperty(name: "locationName", typeJson: "{\"primitive\":\"string\"}")]
        string LocationName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordsExclusiveResourceRecordSetCidrRoutingConfig), fullyQualifiedName: "aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetCidrRoutingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetCidrRoutingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#collection_id Route53RecordsExclusive#collection_id}.</summary>
            [JsiiProperty(name: "collectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string CollectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#location_name Route53RecordsExclusive#location_name}.</summary>
            [JsiiProperty(name: "locationName", typeJson: "{\"primitive\":\"string\"}")]
            public string LocationName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
