using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsBot
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsBotDataPrivacy), fullyQualifiedName: "aws.lexv2ModelsBot.Lexv2ModelsBotDataPrivacy")]
    public interface ILexv2ModelsBotDataPrivacy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot#child_directed Lexv2ModelsBot#child_directed}.</summary>
        [JsiiProperty(name: "childDirected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object ChildDirected
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsBotDataPrivacy), fullyQualifiedName: "aws.lexv2ModelsBot.Lexv2ModelsBotDataPrivacy")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsBot.ILexv2ModelsBotDataPrivacy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot#child_directed Lexv2ModelsBot#child_directed}.</summary>
            [JsiiProperty(name: "childDirected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object ChildDirected
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
