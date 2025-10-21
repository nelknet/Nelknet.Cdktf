using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkforce
{
    [JsiiInterface(nativeType: typeof(ISagemakerWorkforceSourceIpConfig), fullyQualifiedName: "aws.sagemakerWorkforce.SagemakerWorkforceSourceIpConfig")]
    public interface ISagemakerWorkforceSourceIpConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#cidrs SagemakerWorkforce#cidrs}.</summary>
        [JsiiProperty(name: "cidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Cidrs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkforceSourceIpConfig), fullyQualifiedName: "aws.sagemakerWorkforce.SagemakerWorkforceSourceIpConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerWorkforce.ISagemakerWorkforceSourceIpConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#cidrs SagemakerWorkforce#cidrs}.</summary>
            [JsiiProperty(name: "cidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Cidrs
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
