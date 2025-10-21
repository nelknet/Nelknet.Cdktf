using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiByValue(fqn: "aws.kendraIndex.KendraIndexCapacityUnits")]
    public class KendraIndexCapacityUnits : aws.KendraIndex.IKendraIndexCapacityUnits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#query_capacity_units KendraIndex#query_capacity_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? QueryCapacityUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#storage_capacity_units KendraIndex#storage_capacity_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StorageCapacityUnits
        {
            get;
            set;
        }
    }
}
