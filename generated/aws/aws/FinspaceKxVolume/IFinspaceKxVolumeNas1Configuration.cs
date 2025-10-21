using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxVolume
{
    [JsiiInterface(nativeType: typeof(IFinspaceKxVolumeNas1Configuration), fullyQualifiedName: "aws.finspaceKxVolume.FinspaceKxVolumeNas1Configuration")]
    public interface IFinspaceKxVolumeNas1Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#size FinspaceKxVolume#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#type FinspaceKxVolume#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFinspaceKxVolumeNas1Configuration), fullyQualifiedName: "aws.finspaceKxVolume.FinspaceKxVolumeNas1Configuration")]
        internal sealed class _Proxy : DeputyBase, aws.FinspaceKxVolume.IFinspaceKxVolumeNas1Configuration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#size FinspaceKxVolume#size}.</summary>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#type FinspaceKxVolume#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
