using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListener
{
    [JsiiByValue(fqn: "aws.dataAwsLbListener.DataAwsLbListenerTimeouts")]
    public class DataAwsLbListenerTimeouts : aws.DataAwsLbListener.IDataAwsLbListenerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener#read DataAwsLbListener#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
