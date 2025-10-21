using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LocationPlaceIndex
{
    [JsiiInterface(nativeType: typeof(ILocationPlaceIndexDataSourceConfiguration), fullyQualifiedName: "aws.locationPlaceIndex.LocationPlaceIndexDataSourceConfiguration")]
    public interface ILocationPlaceIndexDataSourceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_place_index#intended_use LocationPlaceIndex#intended_use}.</summary>
        [JsiiProperty(name: "intendedUse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IntendedUse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILocationPlaceIndexDataSourceConfiguration), fullyQualifiedName: "aws.locationPlaceIndex.LocationPlaceIndexDataSourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.LocationPlaceIndex.ILocationPlaceIndexDataSourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_place_index#intended_use LocationPlaceIndex#intended_use}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "intendedUse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IntendedUse
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
