using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmPatchBaseline
{
    [JsiiInterface(nativeType: typeof(ISsmPatchBaselineSource), fullyQualifiedName: "aws.ssmPatchBaseline.SsmPatchBaselineSource")]
    public interface ISsmPatchBaselineSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#configuration SsmPatchBaseline#configuration}.</summary>
        [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}")]
        string Configuration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#name SsmPatchBaseline#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#products SsmPatchBaseline#products}.</summary>
        [JsiiProperty(name: "products", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Products
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmPatchBaselineSource), fullyQualifiedName: "aws.ssmPatchBaseline.SsmPatchBaselineSource")]
        internal sealed class _Proxy : DeputyBase, aws.SsmPatchBaseline.ISsmPatchBaselineSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#configuration SsmPatchBaseline#configuration}.</summary>
            [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}")]
            public string Configuration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#name SsmPatchBaseline#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#products SsmPatchBaseline#products}.</summary>
            [JsiiProperty(name: "products", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Products
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
