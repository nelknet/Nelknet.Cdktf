using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHumanTaskUi
{
    [JsiiInterface(nativeType: typeof(ISagemakerHumanTaskUiUiTemplate), fullyQualifiedName: "aws.sagemakerHumanTaskUi.SagemakerHumanTaskUiUiTemplate")]
    public interface ISagemakerHumanTaskUiUiTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_human_task_ui#content SagemakerHumanTaskUi#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Content
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHumanTaskUiUiTemplate), fullyQualifiedName: "aws.sagemakerHumanTaskUi.SagemakerHumanTaskUiUiTemplate")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHumanTaskUi.ISagemakerHumanTaskUiUiTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_human_task_ui#content SagemakerHumanTaskUi#content}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Content
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
