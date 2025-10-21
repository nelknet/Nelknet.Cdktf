using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrInstanceFleet
{
    [JsiiInterface(nativeType: typeof(IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification), fullyQualifiedName: "aws.emrInstanceFleet.EmrInstanceFleetLaunchSpecificationsOnDemandSpecification")]
    public interface IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#allocation_strategy EmrInstanceFleet#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string AllocationStrategy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification), fullyQualifiedName: "aws.emrInstanceFleet.EmrInstanceFleetLaunchSpecificationsOnDemandSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.EmrInstanceFleet.IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#allocation_strategy EmrInstanceFleet#allocation_strategy}.</summary>
            [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string AllocationStrategy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
