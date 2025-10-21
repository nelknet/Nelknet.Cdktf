using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazoneFormType
{
    [JsiiInterface(nativeType: typeof(IDatazoneFormTypeModel), fullyQualifiedName: "aws.datazoneFormType.DatazoneFormTypeModel")]
    public interface IDatazoneFormTypeModel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_form_type#smithy DatazoneFormType#smithy}.</summary>
        [JsiiProperty(name: "smithy", typeJson: "{\"primitive\":\"string\"}")]
        string Smithy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazoneFormTypeModel), fullyQualifiedName: "aws.datazoneFormType.DatazoneFormTypeModel")]
        internal sealed class _Proxy : DeputyBase, aws.DatazoneFormType.IDatazoneFormTypeModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_form_type#smithy DatazoneFormType#smithy}.</summary>
            [JsiiProperty(name: "smithy", typeJson: "{\"primitive\":\"string\"}")]
            public string Smithy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
