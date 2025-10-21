using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkforce
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerWorkforce.SagemakerWorkforceSourceIpConfig")]
    public class SagemakerWorkforceSourceIpConfig : aws.SagemakerWorkforce.ISagemakerWorkforceSourceIpConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#cidrs SagemakerWorkforce#cidrs}.</summary>
        [JsiiProperty(name: "cidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Cidrs
        {
            get;
            set;
        }
    }
}
