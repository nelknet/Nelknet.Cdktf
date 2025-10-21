using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OsisPipeline
{
    [JsiiInterface(nativeType: typeof(IOsisPipelineEncryptionAtRestOptions), fullyQualifiedName: "aws.osisPipeline.OsisPipelineEncryptionAtRestOptions")]
    public interface IOsisPipelineEncryptionAtRestOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#kms_key_arn OsisPipeline#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        string KmsKeyArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOsisPipelineEncryptionAtRestOptions), fullyQualifiedName: "aws.osisPipeline.OsisPipelineEncryptionAtRestOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OsisPipeline.IOsisPipelineEncryptionAtRestOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#kms_key_arn OsisPipeline#kms_key_arn}.</summary>
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KmsKeyArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
