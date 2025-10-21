using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueClassifier
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierJsonClassifier), fullyQualifiedName: "aws.glueClassifier.GlueClassifierJsonClassifier")]
    public interface IGlueClassifierJsonClassifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#json_path GlueClassifier#json_path}.</summary>
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
        string JsonPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierJsonClassifier), fullyQualifiedName: "aws.glueClassifier.GlueClassifierJsonClassifier")]
        internal sealed class _Proxy : DeputyBase, aws.GlueClassifier.IGlueClassifierJsonClassifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#json_path GlueClassifier#json_path}.</summary>
            [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
            public string JsonPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
