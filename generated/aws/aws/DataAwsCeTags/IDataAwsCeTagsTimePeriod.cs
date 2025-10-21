using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    [JsiiInterface(nativeType: typeof(IDataAwsCeTagsTimePeriod), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTagsTimePeriod")]
    public interface IDataAwsCeTagsTimePeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#end DataAwsCeTags#end}.</summary>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
        string End
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#start DataAwsCeTags#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        string Start
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsCeTagsTimePeriod), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTagsTimePeriod")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsCeTags.IDataAwsCeTagsTimePeriod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#end DataAwsCeTags#end}.</summary>
            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
            public string End
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#start DataAwsCeTags#start}.</summary>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
            public string Start
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
