using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CapacityReservation
{
    [JsiiInterface(nativeType: typeof(ICapacityReservationSku), fullyQualifiedName: "azurerm.capacityReservation.CapacityReservationSku")]
    public interface ICapacityReservationSku
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation#capacity CapacityReservation#capacity}.</summary>
        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}")]
        double Capacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation#name CapacityReservation#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICapacityReservationSku), fullyQualifiedName: "azurerm.capacityReservation.CapacityReservationSku")]
        internal sealed class _Proxy : DeputyBase, azurerm.CapacityReservation.ICapacityReservationSku
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation#capacity CapacityReservation#capacity}.</summary>
            [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}")]
            public double Capacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation#name CapacityReservation#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
