using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LocationMap
{
    [JsiiInterface(nativeType: typeof(ILocationMapConfiguration), fullyQualifiedName: "aws.locationMap.LocationMapConfiguration")]
    public interface ILocationMapConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_map#style LocationMap#style}.</summary>
        [JsiiProperty(name: "style", typeJson: "{\"primitive\":\"string\"}")]
        string Style
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILocationMapConfiguration), fullyQualifiedName: "aws.locationMap.LocationMapConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.LocationMap.ILocationMapConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_map#style LocationMap#style}.</summary>
            [JsiiProperty(name: "style", typeJson: "{\"primitive\":\"string\"}")]
            public string Style
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
