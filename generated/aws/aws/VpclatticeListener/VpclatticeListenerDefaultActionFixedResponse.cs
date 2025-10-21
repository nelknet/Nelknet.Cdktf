using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListener
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpclatticeListener.VpclatticeListenerDefaultActionFixedResponse")]
    public class VpclatticeListenerDefaultActionFixedResponse : aws.VpclatticeListener.IVpclatticeListenerDefaultActionFixedResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#status_code VpclatticeListener#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
        public double StatusCode
        {
            get;
            set;
        }
    }
}
