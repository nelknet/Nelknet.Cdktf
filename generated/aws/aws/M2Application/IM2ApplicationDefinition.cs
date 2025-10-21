using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.M2Application
{
    [JsiiInterface(nativeType: typeof(IM2ApplicationDefinition), fullyQualifiedName: "aws.m2Application.M2ApplicationDefinition")]
    public interface IM2ApplicationDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#content M2Application#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Content
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#s3_location M2Application#s3_location}.</summary>
        [JsiiProperty(name: "s3Location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3Location
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IM2ApplicationDefinition), fullyQualifiedName: "aws.m2Application.M2ApplicationDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.M2Application.IM2ApplicationDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#content M2Application#content}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Content
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#s3_location M2Application#s3_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3Location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3Location
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
