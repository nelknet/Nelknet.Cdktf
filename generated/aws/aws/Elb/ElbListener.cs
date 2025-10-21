using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.ElbListener")]
    public class ElbListener : aws.Elb.IElbListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#instance_port Elb#instance_port}.</summary>
        [JsiiProperty(name: "instancePort", typeJson: "{\"primitive\":\"number\"}")]
        public double InstancePort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#instance_protocol Elb#instance_protocol}.</summary>
        [JsiiProperty(name: "instanceProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#lb_port Elb#lb_port}.</summary>
        [JsiiProperty(name: "lbPort", typeJson: "{\"primitive\":\"number\"}")]
        public double LbPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#lb_protocol Elb#lb_protocol}.</summary>
        [JsiiProperty(name: "lbProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public string LbProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#ssl_certificate_id Elb#ssl_certificate_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslCertificateId
        {
            get;
            set;
        }
    }
}
