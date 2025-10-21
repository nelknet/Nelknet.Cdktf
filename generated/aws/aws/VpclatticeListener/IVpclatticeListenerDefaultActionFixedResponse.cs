using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListener
{
    [JsiiInterface(nativeType: typeof(IVpclatticeListenerDefaultActionFixedResponse), fullyQualifiedName: "aws.vpclatticeListener.VpclatticeListenerDefaultActionFixedResponse")]
    public interface IVpclatticeListenerDefaultActionFixedResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#status_code VpclatticeListener#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
        double StatusCode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeListenerDefaultActionFixedResponse), fullyQualifiedName: "aws.vpclatticeListener.VpclatticeListenerDefaultActionFixedResponse")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeListener.IVpclatticeListenerDefaultActionFixedResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#status_code VpclatticeListener#status_code}.</summary>
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
            public double StatusCode
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
