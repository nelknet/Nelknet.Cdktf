using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiInterface(nativeType: typeof(IKendraIndexCapacityUnits), fullyQualifiedName: "aws.kendraIndex.KendraIndexCapacityUnits")]
    public interface IKendraIndexCapacityUnits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#query_capacity_units KendraIndex#query_capacity_units}.</summary>
        [JsiiProperty(name: "queryCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QueryCapacityUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#storage_capacity_units KendraIndex#storage_capacity_units}.</summary>
        [JsiiProperty(name: "storageCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StorageCapacityUnits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraIndexCapacityUnits), fullyQualifiedName: "aws.kendraIndex.KendraIndexCapacityUnits")]
        internal sealed class _Proxy : DeputyBase, aws.KendraIndex.IKendraIndexCapacityUnits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#query_capacity_units KendraIndex#query_capacity_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QueryCapacityUnits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#storage_capacity_units KendraIndex#storage_capacity_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StorageCapacityUnits
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
