using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeSubscriber
{
    [JsiiInterface(nativeType: typeof(ISecuritylakeSubscriberSourceCustomLogSourceResource), fullyQualifiedName: "aws.securitylakeSubscriber.SecuritylakeSubscriberSourceCustomLogSourceResource")]
    public interface ISecuritylakeSubscriberSourceCustomLogSourceResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#source_name SecuritylakeSubscriber#source_name}.</summary>
        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}")]
        string SourceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#source_version SecuritylakeSubscriber#source_version}.</summary>
        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecuritylakeSubscriberSourceCustomLogSourceResource), fullyQualifiedName: "aws.securitylakeSubscriber.SecuritylakeSubscriberSourceCustomLogSourceResource")]
        internal sealed class _Proxy : DeputyBase, aws.SecuritylakeSubscriber.ISecuritylakeSubscriberSourceCustomLogSourceResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#source_name SecuritylakeSubscriber#source_name}.</summary>
            [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#source_version SecuritylakeSubscriber#source_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
