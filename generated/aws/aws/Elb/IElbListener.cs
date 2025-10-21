using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(IElbListener), fullyQualifiedName: "aws.elb.ElbListener")]
    public interface IElbListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#instance_port Elb#instance_port}.</summary>
        [JsiiProperty(name: "instancePort", typeJson: "{\"primitive\":\"number\"}")]
        double InstancePort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#instance_protocol Elb#instance_protocol}.</summary>
        [JsiiProperty(name: "instanceProtocol", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceProtocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#lb_port Elb#lb_port}.</summary>
        [JsiiProperty(name: "lbPort", typeJson: "{\"primitive\":\"number\"}")]
        double LbPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#lb_protocol Elb#lb_protocol}.</summary>
        [JsiiProperty(name: "lbProtocol", typeJson: "{\"primitive\":\"string\"}")]
        string LbProtocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#ssl_certificate_id Elb#ssl_certificate_id}.</summary>
        [JsiiProperty(name: "sslCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslCertificateId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElbListener), fullyQualifiedName: "aws.elb.ElbListener")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.IElbListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#instance_port Elb#instance_port}.</summary>
            [JsiiProperty(name: "instancePort", typeJson: "{\"primitive\":\"number\"}")]
            public double InstancePort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#instance_protocol Elb#instance_protocol}.</summary>
            [JsiiProperty(name: "instanceProtocol", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceProtocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#lb_port Elb#lb_port}.</summary>
            [JsiiProperty(name: "lbPort", typeJson: "{\"primitive\":\"number\"}")]
            public double LbPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#lb_protocol Elb#lb_protocol}.</summary>
            [JsiiProperty(name: "lbProtocol", typeJson: "{\"primitive\":\"string\"}")]
            public string LbProtocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#ssl_certificate_id Elb#ssl_certificate_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslCertificateId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
